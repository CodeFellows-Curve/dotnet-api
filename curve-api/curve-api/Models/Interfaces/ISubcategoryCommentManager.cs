using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Interfaces
{
    interface ISubCategoryCommentManager
    {
        Task<SubCategoryComment> GetSubCategoryCommentById(int id);

        Task<List<SubCategoryComment>> GetAllBySubCategoryId(int subCategoryId);

        Task CreateSubCategoryComment(SubCategoryComment subCategoryComment);

        Task UpdateSubCategoryComment(SubCategoryComment subCategoryComment);

        Task DeleteSubCategoryComment(int id);
    }
}
