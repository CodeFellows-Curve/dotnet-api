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

        public async Task CreateCategory(Category category)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(int id)
        {
            Category category = await _context.Categories.FirstOrDefaultAsync(i => i.Id == id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetAllByReviewId(int reviewId)
        {
            var reviews = await _context.Categories.Where(i => i.Id == reviewId).ToListAsync();
            return reviews;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            return category;
        }

        public async Task UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }
    }
}
