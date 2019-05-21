using Microsoft.EntityFrameworkCore.Internal;
using curve_api.Models;
using System;
using System.Collections.Generic;

namespace curve_api.Data
{
    public static class CurveSeedData
    {
        public static void EnsureSeedData(this CurveDBContext db)
        {
            if (!db.Individuals.Any() || !db.Reviews.Any() || !db.Categories.Any() || !db.Subcategories.Any() || !db.ReviewComments.Any() || !db.CategoryComments.Any() || !db.SubcategoryComments.Any())
            {
                var individuals = new List<Individual>
                {
                    new Individual
                    {
                       Name = "TestOne",
                       CompetencyScore = 1,
                       CurrentLevel = 1,
                       PointsToNext = 1,

                       Reviews = new List<Review>
                       {
                           new Review
                           {
                               ReviewDate = new DateTime(),
                               OverallScore = 1,

                               ReviewComment = new List<ReviewComment>
                               {
                                   new ReviewComment
                                   {
                                       UserId = 1,
                                       Subject = "TestSubject",
                                       Content = "TestContent",
                                   }
                               },

                               Categories = new List<Category>
                               {
                                   new Category
                                   {
                                       CategoryName = "TestCategory",
                                       OverallScore = 1,

                                       CategoryComment = new List<CategoryComment>
                                       {
                                           new CategoryComment
                                           {
                                               UserId = 1,
                                               Subject = "TestSubject",
                                               Content = "TestContent",
                                           }
                                       },

                                       SubCategories = new List<SubCategory>
                                       {
                                           new SubCategory
                                           {
                                               SubCategoryName = "TestSubCategory",
                                               Score = 1,

                                               SubCategoryComments = new List<SubCategoryComment>
                                               {
                                                   new SubCategoryComment
                                                   {
                                                       UserId = 1,
                                                       Subject = "TestSubject",
                                                       Content = "TestContent",
                                                   }
                                               }
                                           }
                                       }
                                   }


                               }
                           }
                       }
                    }
                };

                db.Individuals.AddRange(individuals);
                db.SaveChanges();
            }
        }
    }
}
