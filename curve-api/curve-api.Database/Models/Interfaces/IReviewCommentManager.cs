using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Database.Models.Interfaces
{
    interface IReviewCommentManager
    {
        Task<ReviewComment> GetReviewCommentById(int id);

        Task<List<ReviewComment>> GetAllByReviewId(int reviewId);

        Task CreateReviewComment(ReviewComment reviewComment);

        Task UpdateReviewComment(ReviewComment reviewComment);

        Task DeleteReviewComment(int id);
    }
}
