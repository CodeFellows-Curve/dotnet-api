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
    public class CategoryCommentService : ICategoryCommentManager
    {
        private readonly CurveDBContext _context;

        public CategoryCommentService(CurveDBContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Creates a CategoryComment Entity in the database.
        /// </summary>
        /// <param name="categoryComment">The CategoryComment Entity being added</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task<CategoryComment> CreateCategoryComment(CategoryComment categoryComment)

        {
            _context.Add(categoryComment);
            await _context.SaveChangesAsync();
            return categoryComment;
        }

        /// <summary>
        /// Deletes a specific CategoryComment Entity from the database.
        /// </summary>
        /// <param name="id">The id of the CategoryComment being deleted.</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task DeleteCategoryComment(int id)
        {
            CategoryComment comment = await _context.CategoryComments.FirstOrDefaultAsync(i => i.Id == id);
            _context.CategoryComments.Remove(comment);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets a list of CategoryComment associated with a specific Review
        /// </summary>
        /// <param name="categoryId">The id of the category being referenced</param>
        /// <returns>A list of CategoryComment Entities</returns>
        public async Task<List<CategoryComment>> GetAllByCategoryId(int categoryId)
        {
            //var allComments =
                
                return await _context.CategoryComments.Where(i => i.Id == categoryId).ToListAsync();
            //return allComments;

        }

        /// <summary>
        /// Gets a specific CategoryComment Entity by Id
        /// </summary>
        /// <param name="id">The id of the specific CategoryComment</param>
        /// <returns>A CategoryComment Entity</returns>
        public async Task<CategoryComment> GetCategoryCommentById(int id)
        {
            var categoryComment = await _context.CategoryComments.FindAsync(id);
            return categoryComment;
        }


        /// <summary>
        /// Updates a specific CategoryComment Entity
        /// </summary>
        /// <param name="categoryComment">The CategoryComment being updated</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task<CategoryComment> UpdateCategoryComment(CategoryComment categoryComment)
        {
            _context.CategoryComments.Update(categoryComment);
            await _context.SaveChangesAsync();
            return categoryComment;
        }
    }
}
