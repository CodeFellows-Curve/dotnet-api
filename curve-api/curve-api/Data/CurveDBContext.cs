using curve_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace curve_api.Data
{
    public class CurveDBContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Individual>().HasData(
                   new Individual
                   {
                       Id = 1,
                       Name = "TestOne",
                       CompetencyScore = 1,
                       CurrentLevel = 1,
                       PointsToNext = 1,

                   });

            modelBuilder.Entity<Review>().HasData(
                   new Review
                   {
                       Id = 1,
                       ReviewDate = new DateTime(),
                       IndividualId = 1,
                       OverallScore = 1,

                   });

            modelBuilder.Entity<ReviewComment>().HasData(
                   new ReviewComment
                   {
                       Id = 1,
                       UserId = 1,
                       ReviewId = 1,
                       Subject = "TestSubject",
                       Content = "TestContent",

                   });

            modelBuilder.Entity<Category>().HasData(
                   new Category
                   {
                       Name = 1,
                       CategoryName = "TestCategory",
                       OverallScore = 1,
                       ReviewId = 1,

                   });

            modelBuilder.Entity<CategoryComment>().HasData(
                   new CategoryComment
                   {
                       Id = 1,
                       UserId = 1,
                       CategoryId = 1,
                       Subject = "TestSubject",
                       Content = "TestContent",

                   });

            modelBuilder.Entity<SubCategory>().HasData(
                   new SubCategory
                   {
                       Id = 1,
                       SubCategoryName = "TestSubCategory",
                       Score = 1,
                       CategoryId = 1,

                   });

            modelBuilder.Entity<SubCategoryComment>().HasData(
                  new SubCategoryComment
                  {
                      Id = 1,
                      UserId = 1,
                      SubCategoryId = 1,
                      Subject = "TestSubject",
                      Content = "TestContent",

                  });
        }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewComment> ReviewComments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryComment> CategoryComments { get; set; }
        public DbSet<SubCategory> Subcategories { get; set; }
        public DbSet<SubCategoryComment> SubcategoryComments { get; set; }
    }
}
