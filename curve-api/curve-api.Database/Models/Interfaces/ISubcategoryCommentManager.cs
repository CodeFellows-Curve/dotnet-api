using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Database.Models.Interfaces
{
    interface ISubcategoryCommentManager
    {
        Task<SubCategoryComment> GetSubCategoryCommentById(int id);

        Task<List<SubCategoryComment>> GetAllBySubCategoryId(int categoryId);

        Task CreateSubCategoryComment(SubCategoryComment subCategoryComment);

        Task UpdateSubCategoryComment(SubCategoryComment subCategoryComment);

        Task DeleteSubCategoryComment(int id);
    }
}
