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
    public class SubCategoryService : ISubcategoryManager
    {
        private readonly CurveDBContext _context;

        public SubCategoryService(CurveDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a SubCategory Entity in the database.
        /// </summary>
        /// <param name="subCategory">The SubCategory being added</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task<SubCategory> CreateSubCategory(SubCategory subCategory)
        {
            _context.Add(subCategory);
            await _context.SaveChangesAsync();
            return subCategory;
        }

        /// <summary>
        /// Deletes a SubCategory Entity from the database.
        /// </summary>
        /// <param name="id">The Id of the SubCategory being deleted</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task DeleteSubCategory(int id)
        {
            SubCategory sc = await _context.Subcategories.FindAsync(id);
            if (sc != null)
            {
                _context.Remove(sc);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Gets all SubCategories that are related to a given Category.
        /// </summary>
        /// <param name="categoryId">The Category Id being looked for</param>
        /// <returns>A List of SubCategory Entities</returns>
        public async Task<List<SubCategory>> GetAllByCategoryId(int categoryId)
        {
            return await _context.Subcategories.Where(sc => sc.CategoryId == categoryId).ToListAsync();
        }

        /// <summary>
        /// Gets a specific SubCategory Entity by Id.
        /// </summary>
        /// <param name="id">The SubCategory Id being retrieved.</param>
        /// <returns>A SubCategory Entity</returns>
        public async Task<SubCategory> GetSubCategoryById(int id)
        {
            return await _context.Subcategories.FindAsync(id);
        }

        /// <summary>
        /// Updates a SubCategory Entity in the database.
        /// </summary>
        /// <param name="subCategory">The SubCategory being updated</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task<SubCategory> UpdateSubCategory(SubCategory subCategory)
        {
            _context.Update(subCategory);
            await _context.SaveChangesAsync();
            return subCategory;
        }
    }
}
