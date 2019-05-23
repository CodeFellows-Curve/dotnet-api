using curve_api.Models;
using curve_api.Models.Interfaces;
using curve_api.Types.SubCategory;
using GraphQL.Types;

namespace curve_api.Mutations
{
    public class SubCategoryMutation : ObjectGraphType
    {
        public SubCategoryMutation(ISubcategoryManager subcategoryManager)
        {
            Field<SubCategoryType>(
                "addsubcategory",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<SubCategoryInputType>> { Name = "subcategory" }),
                resolve: context =>
                {
                    var subcategory = context.GetArgument<SubCategory>("subcategory");
                    return subcategoryManager.CreateSubCategory(subcategory);
                });

            Field<SubCategoryType>(
                "editsubcategory",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<SubCategoryInputType>> { Name = "subcategory" }),
                resolve: context =>
                {
                    var subcategory = context.GetArgument<SubCategory>("subcategory");
                    return subcategoryManager.UpdateSubCategory(subcategory);
                });

            Field<SubCategoryType>(
                "deletesubcategory",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return subcategoryManager.DeleteSubCategory(id);
                });
        }
    }
}
