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

        /// <summary>
        /// Creates a Review Entity in the database.
        /// </summary>
        /// <param name="review">The Review being added</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task CreateReview(Review review)
        {
            _context.Add(review);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a Review Entity from the database.
        /// </summary>
        /// <param name="id">The id of the Review being deleted</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task DeleteReview(int id)
        {
            Review rv = await _context.Reviews.FindAsync(id);
            if (rv != null)
            {
                _context.Remove(rv);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Gets all Reviews for a given individual
        /// </summary>
        /// <param name="individualId">The id of the given individual</param>
        /// <returns>A list of Review Entities</returns>
        public async Task<List<Review>> GetAllByIndividualId(int individualId)
        {
            return await _context.Reviews.Where(rv => rv.IndividualId == individualId).ToListAsync();
        }

        /// <summary>
        /// Gets a number of most recent reviews for a given individual
        /// </summary>
        /// <param name="individualId">The id of the individual</param>
        /// <param name="lastReview">The number of recent reviews being retrieved</param>
        /// <returns>A list of Review Entities</returns>
        public async Task<List<Review>> GetAllByIndividualId(int individualId, int lastReview)
        {
            return await _context.Reviews.Where(rv => rv.IndividualId == individualId)
                .OrderByDescending(x => x.ReviewDate)
                .Take(lastReview)
                .ToListAsync();
        }

        /// <summary>
        /// Gets all reviews by a given date
        /// </summary>
        /// <param name="dateTime">The date being searched for</param>
        /// <returns>A list of Review Entities</returns>
        public async Task<List<Review>> GetAllByReviewDate(DateTime dateTime)
        {
            return await _context.Reviews.Where(rv => rv.ReviewDate == dateTime).ToListAsync();
        }

        /// <summary>
        /// Gets a specific Review Entity by Id
        /// </summary>
        /// <param name="id">The id of the Review Entity</param>
        /// <returns>A Review Entity</returns>
        public async Task<Review> GetReviewById(int id)
        {
            return await _context.Reviews.FindAsync(id);
        }

        /// <summary>
        /// Updates a specific Review Entity in the database
        /// </summary>
        /// <param name="review">The Review being updated</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task UpdateReview(Review review)
        {
            _context.Update(review);
            await _context.SaveChangesAsync();
        }
    }
}
