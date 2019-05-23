using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Interfaces
{
    public interface ICategoryManager
    {
        Task<Category> GetCategoryById(int id);

        Task<List<Category>> GetAllByReviewId(int reviewId);

        Task<Category> CreateCategory(Category category);

        Task<Category> UpdateCategory(Category category);

        // TODO: Find out and impliment the return type that GraphQL needs for delete mutation
        Task DeleteCategory(int id);
    }
}
