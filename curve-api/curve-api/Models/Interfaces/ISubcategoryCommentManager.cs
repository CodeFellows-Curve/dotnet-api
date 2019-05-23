using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Interfaces
{
    public interface ISubCategoryCommentManager
    {
        Task<SubCategoryComment> GetSubCategoryCommentById(int id);

        Task<List<SubCategoryComment>> GetAllBySubCategoryId(int subCategoryId);

        Task<SubCategoryComment> CreateSubCategoryComment(SubCategoryComment subCategoryComment);

        Task<SubCategoryComment> UpdateSubCategoryComment(SubCategoryComment subCategoryComment);

        // TODO: Find out and impliment the return type that GraphQL needs for delete mutation
        Task DeleteSubCategoryComment(int id);
    }
}
