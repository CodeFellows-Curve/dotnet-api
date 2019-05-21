using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Interfaces
{
    public interface ICategoryCommentManager
    {
        Task<CategoryComment> GetCategoryCommentById(int id);

        Task<List<CategoryComment>> GetAllByCategoryId(int categoryId);

        Task CreateCategoryComment(CategoryComment categoryComment);

        Task UpdateCategoryComment(CategoryComment categoryComment);

        Task DeleteCategoryComment(int id);
    }
}
