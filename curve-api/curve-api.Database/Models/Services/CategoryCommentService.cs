using curve_api.Database.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Database.Models.Services
{
    class CategoryCommentService : ICategoryCommentManager
    {
        private CurveDBContext _context;

        public CategoryCommentService(CurveDBContext context)
        {

        }


        public async Task CreateCategoryComment(CategoryComment categoryComment)
        {
            _context.
        }

        public Task DeleteCategoryComment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryComment>> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryComment> GetCategoryCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryComment(CategoryComment categoryComment)
        {
            throw new NotImplementedException();
        }
    }
}
