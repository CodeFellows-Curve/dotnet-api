using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Interfaces
{
    public interface IReviewManager
    {
        Task<Review> GetReviewById(int id);

        Task<List<Review>> GetAllByIndividualId(int individualId);

        Task<List<Review>> GetAllByIndividualId(int individualId, int lastReview);

        Task<List<Review>> GetAllByReviewDate(DateTime dateTime);

        Task<Review> CreateReview(Review review);

        Task<Review> UpdateReview(Review review);

        // TODO: Find out and impliment the return type that GraphQL needs for delete mutation
        Task DeleteReview(int id);
    }
}
