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

        Task CreateCategory(Category category);

        Task UpdateCategory(Category category);

        Task DeleteCategory(int id);
    }
}
