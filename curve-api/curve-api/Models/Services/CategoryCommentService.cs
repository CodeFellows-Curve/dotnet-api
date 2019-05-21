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
    class CategoryCommentService : ICategoryCommentManager
    {
        private readonly CurveDBContext _context;

        public CategoryCommentService(CurveDBContext context)
        {
            _context = context;
        }

        public async Task CreateCategoryComment(CategoryComment categoryComment)
        {
            _context.Add(categoryComment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryComment(int id)
        {
            CategoryComment comment = await _context.CategoryComments.FirstOrDefaultAsync(i => i.Id == id);
            _context.CategoryComments.Remove(comment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<CategoryComment>> GetAllByCategoryId(int categoryId)
        {
            var allComments = await _context.CategoryComments.Where(i => i.Id == categoryId).ToListAsync();
            return allComments;

        }

        public async Task<CategoryComment> GetCategoryCommentById(int id)
        {
            var categoryComment = await _context.CategoryComments.FindAsync(id);
            return categoryComment;
        }

        public async Task UpdateCategoryComment(CategoryComment categoryComment)
        {
            _context.CategoryComments.Update(categoryComment);
            await _context.SaveChangesAsync();
        }
    }
}
