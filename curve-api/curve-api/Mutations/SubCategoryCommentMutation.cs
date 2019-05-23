using curve_api.Models;
using curve_api.Models.Interfaces;
using curve_api.Types.SubCategoryComment;
using GraphQL.Types;

namespace curve_api.Mutations
{
    public class SubCategoryCommentMutation : ObjectGraphType
    {
        public SubCategoryCommentMutation(ISubCategoryCommentManager subcategoryComment)
        {
            Field<SubCategoryCommentType>(
                "addSubCategoryComment",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<SubCategoryCommentInputType>> { Name = "subcategorycomment" }),
                resolve: context =>
                {
                    var subcategorycomment = context.GetArgument<SubCategoryComment>("subcategorycomment");
                    return subcategoryComment.CreateSubCategoryComment(subcategorycomment);
                });

            Field<SubCategoryCommentType>(
                "editSubCategoryCommentType",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<SubCategoryCommentInputType>> { Name = "subcategorycomment" }),
                resolve: context =>
                {
                    var subcategorycomment = context.GetArgument<SubCategoryComment>("subcategorycomment");
                    return subcategoryComment.UpdateSubCategoryComment(subcategorycomment);
                });

            Field<SubCategoryCommentType>(
                "deleteSubCategoryCommentType",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return subcategoryComment.DeleteSubCategoryComment(id);
                });
        }
    }
}
