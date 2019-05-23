using curve_api.Models;
using curve_api.Models.Interfaces;
using curve_api.Types.ReviewComment;
using GraphQL.Types;

namespace curve_api.Mutations
{
    public class ReviewCommentsMutation : ObjectGraphType
    {
        public ReviewCommentsMutation(IReviewCommentManager reviewComments)
        {
            Field<ReviewCommentType>(
                "addReviewComment",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ReviewCommentInputType>> { Name = "review" }),
                resolve: context =>
                {
                    var review = context.GetArgument<ReviewComment>("review");
                    return reviewComments.CreateReviewComment(review);
                });

            Field<ReviewCommentType>(
                "editReviewComment",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ReviewCommentInputType>> { Name = "review" }),
                resolve: context =>
                {
                    var review = context.GetArgument<ReviewComment>("review");
                    return reviewComments.UpdateReviewComment(review);
                });

            Field<ReviewCommentType>(
                "deleteReviewComment",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return reviewComments.DeleteReviewComment(id);
                });
        }
    }
}
