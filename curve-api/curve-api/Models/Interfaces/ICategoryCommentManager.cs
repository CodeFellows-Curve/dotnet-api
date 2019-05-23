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

        Task<CategoryComment> CreateCategoryComment(CategoryComment categoryComment);

        Task<CategoryComment> UpdateCategoryComment(CategoryComment categoryComment);

        // TODO: Find out and impliment the return type that GraphQL needs for delete mutation
        Task DeleteCategoryComment(int id);
    }
}
