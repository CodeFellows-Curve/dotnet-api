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
    public class SubCategoryCommentService : ISubCategoryCommentManager
    {
        private readonly CurveDBContext _context;

        public SubCategoryCommentService(CurveDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a SubCategoryComment Entity in the database.
        /// </summary>
        /// <param name="subCategoryComment">The SubCategoryComment being added</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task CreateSubCategoryComment(SubCategoryComment subCategoryComment)
        {
            _context.Add(subCategoryComment);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a SubCategoryComment Entity from the database.
        /// </summary>
        /// <param name="id">The Id of the SubCategoryComment being deleted</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task DeleteSubCategoryComment(int id)
        {
            SubCategoryComment scc = await _context.SubcategoryComments.FindAsync(id);
            if (scc != null)
            {
                _context.Remove(scc);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Gets all SubCategoryComments that are related to a given Category.
        /// </summary>
        /// <param name="subCategoryId">The SubCategory Id being looked for</param>
        /// <returns>A List of SubCategoryComment Entities</returns>
        public async Task<List<SubCategoryComment>> GetAllBySubCategoryId(int subCategoryId)
        {
            return await _context.SubcategoryComments.Where(sc => sc.SubCategoryId == subCategoryId).ToListAsync();
        }

        /// <summary>
        /// Gets a specific SubCategoryComment Entity by Id.
        /// </summary>
        /// <param name="id">The SubCategoryComment Id being retrieved.</param>
        /// <returns>A SubCategoryComment Entity</returns>
        public async Task<SubCategoryComment> GetSubCategoryCommentById(int id)
        {
            return await _context.SubcategoryComments.FindAsync(id);
        }

        /// <summary>
        /// Updates a SubCategoryComment Entity in the database.
        /// </summary>
        /// <param name="subCategoryComment">The SubCategoryComment being updated</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task UpdateSubCategoryComment(SubCategoryComment subCategoryComment)
        {
            _context.Update(subCategoryComment);
            await _context.SaveChangesAsync();
        }
    }
}
