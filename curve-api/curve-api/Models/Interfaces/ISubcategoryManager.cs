using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Interfaces
{
    interface ISubcategoryManager
    {
        Task<SubCategory> GetSubCategoryById(int id);

        Task<List<SubCategory>> GetAllByCategoryId(int categoryId);

        Task CreateSubCategory(SubCategory subCategory);

        Task UpdateSubCategory(SubCategory subCategory);

        Task DeleteSubCategory(int id);
    }
}
