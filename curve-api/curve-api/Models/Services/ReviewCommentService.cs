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

        /// <summary>
        /// Creates a ReviewComment Entity in the database.
        /// </summary>
        /// <param name="reviewComment">The ReviewComment Entity being added</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task CreateReviewComment(ReviewComment reviewComment)
        {
            _context.Add(reviewComment);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a specific ReviewComment Entity from the database.
        /// </summary>
        /// <param name="id">The id of the ReviewComment being deleted.</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task DeleteReviewComment(int id)
        {
            ReviewComment rc = await _context.ReviewComments.FindAsync(id);
            if (rc != null)
            {
                _context.Remove(rc);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Gets a list of ReviewComments associated with a specific Review
        /// </summary>
        /// <param name="reviewId">The id of the review being referenced</param>
        /// <returns>A list of ReviewComment Entities</returns>
        public async Task<List<ReviewComment>> GetAllByReviewId(int reviewId)
        {
            return await _context.ReviewComments.Where(rc => rc.ReviewId == reviewId).ToListAsync();
        }

        /// <summary>
        /// Gets a specific ReviewComment Entity by Id
        /// </summary>
        /// <param name="id">The id of the specific ReviewComment</param>
        /// <returns>A ReviewComment Entity</returns>
        public async Task<ReviewComment> GetReviewCommentById(int id)
        {
            return await _context.ReviewComments.FindAsync(id);
        }

        /// <summary>
        /// Updates a specific ReviewComment Entity
        /// </summary>
        /// <param name="reviewComment">The ReviewComment being updated</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task UpdateReviewComment(ReviewComment reviewComment)
        {
            _context.Update(reviewComment);
            await _context.SaveChangesAsync();
        }
    }
}
