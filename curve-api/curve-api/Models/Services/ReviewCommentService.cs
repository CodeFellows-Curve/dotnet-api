using curve_api.Data;
using curve_api.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Services
{
    public class ReviewCommentService : IReviewCommentManager
    {
        private readonly CurveDBContext _context;

        public ReviewCommentService(CurveDBContext context)
        {
            _context = context;
        }

        public async Task<ReviewComment> CreateReviewComment(ReviewComment reviewComment)
        {
            _context.Add(reviewComment);
            await _context.SaveChangesAsync();
            return reviewComment;
        }

        public async Task DeleteReviewComment(int id)
        {
            ReviewComment rc = await _context.ReviewComments.FindAsync(id);
            if (rc != null)
            {
                _context.Remove(rc);
                _context.SaveChanges();
            }
        }

        public async Task<List<ReviewComment>> GetAllByReviewId(int reviewId)
        {
            return await _context.ReviewComments.Where(rc => rc.ReviewId == reviewId).ToListAsync();
        }

        public async Task<ReviewComment> GetReviewCommentById(int id)
        {
            return await _context.ReviewComments.FindAsync(id);
        }

        public async Task<ReviewComment> UpdateReviewComment(ReviewComment reviewComment)
        {
            _context.Update(reviewComment);
            await _context.SaveChangesAsync();
            return reviewComment;
        }
    }
}
