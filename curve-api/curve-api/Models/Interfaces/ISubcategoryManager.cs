using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Interfaces
{
    public interface ISubcategoryManager
    {
        Task<SubCategory> GetSubCategoryById(int id);

        Task<List<SubCategory>> GetAllByCategoryId(int categoryId);

        Task<SubCategory> CreateSubCategory(SubCategory subCategory);

        Task<SubCategory> UpdateSubCategory(SubCategory subCategory);

        // TODO: Find out and impliment the return type that GraphQL needs for delete mutation
        Task DeleteSubCategory(int id);
    }
}
