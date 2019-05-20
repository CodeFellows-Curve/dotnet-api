using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curve_api.Data
{
    public class CurveDBContext : DbContext
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Individual>().HasData(
               new Individual
               {
                   ID = 1,
                   Name = "TestOne",
                   CompetencyScore = 1,
                   CurrentLevel = 1,
                   PointsToNext = 1,

               });

        modelBuilder.Entity<Review>().HasData(
               new Review
               {
                   ID = 1,
                   ReviewDate = new DateTime(),
                   IndividualID = 1,
                   OverallScore = 1,

               });

        modelBuilder.Entity<ReviewComment>().HasData(
               new ReviewComment
               {
                   ID = 1,
                   UserID = 1,
                   ReviewID = 1,
                   Subject = "TestSubject",
                   Content = "TestContent",

               });

        modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   ID = 1,
                   CategoryName = "TestCategory",
                   OverallScore = 1,
                   ReviewID = 1,

               });

        modelBuilder.Entity<CategoryComment>().HasData(
               new CategoryComment
               {
                   ID = 1,
                   UserID = 1,
                   CategoryID = 1,
                   Subject = "TestSubject",
                   Content = "TestContent",

               });

        modelBuilder.Entity<Subcategory>().HasData(
               new Subcategory
               {
                   ID = 1,
                   SubcategoryName = "TestSubCategory",
                   Score = 1,
                   CategoryID = 1,

               });

        modelBuilder.Entity<SubcategoryComment>().HasData(
              new SubcategoryComment
              {
                  ID = 1,
                  UserID = 1,
                  SubcategoryID = 1,
                  Subject = "TestSubject",
                  Content = "TestContent",

              });
    }

    public DbSet<Individual> Individuals { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<ReviewComment> ReviewComments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryComment> CategoryComments { get; set; }
    public DbSet<Subcategory> Subcategories { get; set; }
    public DbSet<SubcategoryComment> SubcategoryComments { get; set; }

}
