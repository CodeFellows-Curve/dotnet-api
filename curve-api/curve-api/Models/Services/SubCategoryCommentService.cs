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
    class SubCategoryCommentService : ISubCategoryCommentManager
    {
        private readonly CurveDBContext _context;

        public SubCategoryCommentService(CurveDBContext context)
        {
            _context = context;
        }

        public async Task CreateSubCategoryComment(SubCategoryComment subCategoryComment)
        {
            _context.Add(subCategoryComment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSubCategoryComment(int id)
        {
            SubCategoryComment scc = await _context.SubcategoryComments.FindAsync(id);
            if (scc != null)
            {
                _context.Remove(scc);
                _context.SaveChanges();
            }
        }

        public async Task<List<SubCategoryComment>> GetAllBySubCategoryId(int subCategoryId)
        {
            return await _context.SubcategoryComments.Where(sc => sc.SubCategoryId == subCategoryId).ToListAsync();
        }

        public async Task<SubCategoryComment> GetSubCategoryCommentById(int id)
        {
            return await _context.SubcategoryComments.FindAsync(id);
        }

        public async Task UpdateSubCategoryComment(SubCategoryComment subCategoryComment)
        {
            _context.Update(subCategoryComment);
            await _context.SaveChangesAsync();
        }
    }
}
