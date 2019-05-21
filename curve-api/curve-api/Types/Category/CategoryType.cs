using curve_api.Models.Interfaces;
using curve_api.Types.CategoryComment;
using curve_api.Types.SubCategory;
using GraphQL.Types;

namespace curve_api.Types.Category
{
    public class CategoryType : ObjectGraphType<Models.Category>
    {
        public CategoryType(ICategoryCommentManager categoryComment, ISubCategoryManager subCategory)
        {
            Field(x => x.Id);
            Field(x => x.CategoryName);
            Field(x => x.OverallScore);
            Field(x => x.ReviewId);
            Field<ListGraphType<CategoryCommentType>>("categorycomment",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "last" }),
                resolve: context => {
                    var lastItemsFilter = context.GetArgument<int?>("last");
                    return categoryComment.GetAllByCategoryId(context.Source.Id);
                });

            Field<ListGraphType<SubCategoryType>>("subcategory",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "last" }),
                resolve: context => {
                    var lastItemsFilter = context.GetArgument<int?>("last");
                    return subCategory.GetAllByCategoryId(context.Source.Id);
                });
        }
    }
}