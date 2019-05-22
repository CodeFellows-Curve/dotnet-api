using GraphQL.Types;
using curve_api.Types.SubCategoryComment;
using curve_api.Models.Interfaces;

namespace curve_api.Types.SubCategory
{
    public class SubCategoryType : ObjectGraphType<Models.SubCategory>
    {

        public SubCategoryType(ISubCategoryCommentManager subCategoryComment)
        {
            Field(x => x.Id);
            Field(x => x.SubCategoryName);
            Field(x => x.Score);
            Field(x => x.CategoryId);
            
            Field<ListGraphType<SubCategoryCommentType>>("subcategorycomment",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "last" }),
                resolve: context => {
                    var lastItemsFilter = context.GetArgument<int?>("last");
                    return subCategoryComment.GetAllBySubCategoryId(context.Source.Id);
                });
            
        }
    }
}