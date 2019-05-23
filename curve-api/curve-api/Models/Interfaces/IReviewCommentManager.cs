using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Interfaces
{
    public interface IReviewCommentManager
    {
        Task<ReviewComment> GetReviewCommentById(int id);

        Task<List<ReviewComment>> GetAllByReviewId(int reviewId);

        Task<ReviewComment> CreateReviewComment(ReviewComment reviewComment);

        Task<ReviewComment> UpdateReviewComment(ReviewComment reviewComment);

        // TODO: Find out and impliment the return type that GraphQL needs for delete mutation
        Task DeleteReviewComment(int id);
    }
}
