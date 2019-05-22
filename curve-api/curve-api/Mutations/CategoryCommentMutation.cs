using curve_api.Models;
using curve_api.Models.Interfaces;
using curve_api.Types.CategoryComment;
using GraphQL.Types;

namespace curve_api.Mutations
{
    public class CategoryCommentMutation : ObjectGraphType
    {
        public CategoryCommentMutation(ICategoryCommentManager categoryComment)
        {
            Field<CategoryCommentType>(
                "addCategoryComment",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CategoryCommentInputType>> { Name = "categorycomment" }),
                resolve: context =>
                {
                    var categorycomment = context.GetArgument<CategoryComment>("categorycomment");
                    return categoryComment.CreateCategoryComment(categorycomment);
                });

            Field<CategoryCommentType>(
                "editCategoryComment",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CategoryCommentInputType>> { Name = "categorycomment" }),
                resolve: context =>
                {
                    var categorycomment = context.GetArgument<CategoryComment>("categorycomment");
                    return categoryComment.UpdateCategoryComment(categorycomment);
                });

            Field<CategoryCommentType>(
                "deleteCategoryComment",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return categoryComment.DeleteCategoryComment(id);
                });
        }
    }
}
