using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Interfaces
{
    interface IReviewManager
    {
        Task<Review> GetReviewById(int id);

        Task<List<Review>> GetAllByIndividualId(int individualId);

        Task<List<Review>> GetAllByReviewDate(DateTime dateTime);

        Task CreateReview(Review review);

        Task UpdateReview(Review review);

        Task DeleteReview(int id);
    }
}
