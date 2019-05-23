using curve_api.Models.Interfaces;
using curve_api.Types.Review;
using GraphQL.Types;
using curve_api.Models;

namespace curve_api.Mutations
{
    public class ReviewMutation : ObjectGraphType
    {
        public ReviewMutation(IReviewManager reveiwManager)
        {
            Field<ReviewType>(
                "addReview",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ReviewInputType>> { Name = "review" }),
                resolve: context =>
                {
                    var review = context.GetArgument<Review>("review");
                    return reveiwManager.CreateReview(review);
                });

            Field<ReviewType>(
                "editReview",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ReviewInputType>> { Name = "review" }),
                resolve: context =>
                {
                    var review = context.GetArgument<Review>("review");
                    return reveiwManager.UpdateReview(review);
                });

            Field<ReviewType>(
                "deleteReview",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return reveiwManager.DeleteReview(id);
                });
        }
    }
}
