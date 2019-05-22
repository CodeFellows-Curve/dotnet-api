using curve_api.Models.Interfaces;
using GraphQL.Types;
using curve_api.Types.ReviewComment;
using curve_api.Types.Category;

namespace curve_api.Types.Review
{
    public class ReviewType : ObjectGraphType<Models.Review>
    {
        public ReviewType(IReviewCommentManager reviewCommentManager, ICategoryManager categoryManager)
        {
            Field(x => x.Id);
            Field(x => x.ReviewDate);
            Field(x => x.IndividualId);
            Field(x => x.OverallScore);
            Field<ListGraphType<ReviewCommentType>>("reviewcomment",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "last" }),
                resolve: context => {
                    var lastItemsFilter = context.GetArgument<int?>("last");
                    return reviewCommentManager.GetAllByReviewId(context.Source.Id);
                });

            Field<ListGraphType<CategoryType>>("category",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "last" }),
                resolve: context => {
                    var lastItemsFilter = context.GetArgument<int?>("last");
                    return categoryManager.GetAllByReviewId(context.Source.Id);
                });
        }
    }
}
