using curve_api.Models;
using curve_api.Models.Interfaces;
using curve_api.Types.Category;
using GraphQL.Types;

namespace curve_api.Mutations
{
    public class CategoryMutation : ObjectGraphType
    {
        public CategoryMutation(ICategoryManager categoryManager)
        {
            Field<CategoryType>(
                "addCategory",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CategoryInputType>> { Name = "category" }),
                resolve: context =>
                {
                    var category = context.GetArgument<Category>("category");
                    return categoryManager.CreateCategory(category);
                });

            Field<CategoryType>(
                "editCategory",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CategoryInputType>> { Name = "category" }),
                resolve: context =>
                {
                    var category = context.GetArgument<Category>("category");
                    return categoryManager.UpdateCategory(category);
                });

            Field<CategoryType>(
                "deleteCategory",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return categoryManager.DeleteCategory(id);
                });
        }
    }
}
