using curve_api.Models;
using curve_api.Models.Interfaces;
using curve_api.Types.Category;
using curve_api.Types.Individual;
using curve_api.Types.Review;
using curve_api.Types.SubCategory;
using GraphQL.Types;
using System;

namespace curve_api.Mutations
{
    public class Mutation : ObjectGraphType
    {
        public Mutation(IIndividualManager individualManager, IReviewManager reviewManager, ICategoryManager categoryManager, ISubcategoryManager subcategoryManager)
        {
            Field<IndividualType>(
                "addIndividual",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IndividualInputType>> { Name = "individual" }),
                resolve: context =>
                {
                    var individual = context.GetArgument<Individual>("individual");
                    return individualManager.CreateIndividual(individual);
                });

            Field<IndividualType>(
                "editIndividual",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IndividualInputType>> { Name = "individual" }),
                resolve: context =>
                {
                    var individual = context.GetArgument<Individual>("individual");
                    return individualManager.UpdateIndividual(individual);
                });

            Field<IndividualType>(
                "deleteIndividual",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return individualManager.DeleteIndividual(id);
                });
            Field<ReviewType>(
                "addReview",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ReviewInputType>> { Name = "review" }),
                resolve: context =>
                {
                    var review = context.GetArgument<Review>("review");
                    return reviewManager.CreateReview(review);
                });

            Field<ReviewType>(
                "editReview",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ReviewInputType>> { Name = "review" }),
                resolve: context =>
                {
                    var review = context.GetArgument<Review>("review");
                    return reviewManager.UpdateReview(review);
                });

            Field<ReviewType>(
                "deleteReview",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return reviewManager.DeleteReview(id);
                });
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
