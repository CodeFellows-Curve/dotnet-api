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
    public class ReviewService : IReviewManager
    {
        private readonly CurveDBContext _context;

        public ReviewService(CurveDBContext context)
        {
            _context = context;
        }

        public async Task<Review> CreateReview(Review review)
        {
            _context.Add(review);
            await _context.SaveChangesAsync();
            return review;
        }

        public async Task DeleteReview(int id)
        {
            Review rv = await _context.Reviews.FindAsync(id);
            if (rv != null)
            {
                _context.Remove(rv);
                _context.SaveChanges();
            }
        }

        public async Task<List<Review>> GetAllByIndividualId(int individualId)
        {
            return await _context.Reviews.Where(rv => rv.IndividualId == individualId).ToListAsync();
        }

        public async Task<List<Review>> GetAllByIndividualId(int individualId, int lastReview)
        {
            return await _context.Reviews.Where(rv => rv.IndividualId == individualId)
                .OrderByDescending(x => x.ReviewDate)
                .Take(lastReview)
                .ToListAsync();
        }

        public async Task<List<Review>> GetAllByReviewDate(DateTime dateTime)
        {
            return await _context.Reviews.Where(rv => rv.ReviewDate == dateTime).ToListAsync();
        }

        public async Task<Review> GetReviewById(int id)
        {
            return await _context.Reviews.FindAsync(id);
        }

        public async Task<Review> UpdateReview(Review review)
        {
            _context.Update(review);
            await _context.SaveChangesAsync();
            return review;
        }
    }
}
