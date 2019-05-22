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
    public class CategoryService : ICategoryManager
    {
        private readonly CurveDBContext _context;
        public CategoryService(CurveDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a Category Entity in the database.
        /// </summary>
        /// <param name="category">The Category being added</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task CreateCategory(Category category)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a Category Entity from the database.
        /// </summary>
        /// <param name="id">The id of the Category being deleted</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task DeleteCategory(int id)
        {
            Category category = await _context.Categories.FirstOrDefaultAsync(i => i.Id == id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets all Categories that are related to a given Review.
        /// </summary>
        /// <param name="reviewId">The Review Id being looked for</param>
        /// <returns>A List of Category Entities</returns>
        public async Task<List<Category>> GetAllByReviewId(int reviewId)
        {
            var reviews = await _context.Categories.Where(i => i.ReviewId == reviewId).ToListAsync();
            return reviews;
        }

        /// <summary>
        /// Gets a specific Category Entity by Id.
        /// </summary>
        /// <param name="id">The Category Id being retrieved.</param>
        /// <returns>A Category Entity</returns>
        public async Task<Category> GetCategoryById(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            return category;
        }

        /// <summary>
        /// Updates a Category Entity in the database.
        /// </summary>
        /// <param name="category">The Category being updated</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }
    }
}
