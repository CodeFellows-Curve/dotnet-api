using curve_api.Data;
using curve_api.Models;
using curve_api.Models.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1.ServicesTests.IndividualServiceTests
{
    public class IndividualServiceTest
    {
        [Fact]
        public async Task CanCreateIndividual()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanCreateIndividual").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                Individual individual = new Individual()
                {
                    Id = 123,
                    Email = "Nate@Test.com",
                    Name = "Nate",
                    CompetencyScore = 1,
                    CurrentLevel = 1,
                    PointsToNext = 1,
                };
                IndividualService personService = new IndividualService(context);
                await personService.CreateIndividual(individual);
                Individual saved = await context.Individuals.FirstOrDefaultAsync();
                Assert.Equal("Nate", saved.Name);
            }
        }

        [Fact]
        public async Task CanDeleteIndividual()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanDeleteIndividual").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                Individual individual = new Individual()
                {
                    Id = 99,
                    Email = "Nate@Test.com",
                    Name = "Nate",
                    CompetencyScore = 1,
                    CurrentLevel = 1,
                    PointsToNext = 1,
                };
                IndividualService personService = new IndividualService(context);
                await personService.CreateIndividual(individual);
                await personService.DeleteIndividual(99);
                Individual saved = await context.Individuals.FirstOrDefaultAsync();
                Assert.Null(saved);
            }
        }

        [Fact]
        public async Task<List<CategoryComment>> CanGetIndividualByIndividualID()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanGetIndividualByIndividualID").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                Individual individual = new Individual()
                {
                    Id = 99,
                    Email = "Nate@Test.com",
                    Name = "Nate Dawg",
                    CompetencyScore = 1,
                    CurrentLevel = 1,
                    PointsToNext = 1,
                };
                IndividualService personService = new IndividualService(context);
                await personService.CreateIndividual(individual);
                await personService.GetIndividualByIndividualID(99);
                Individual saved = await context.Individuals.FirstOrDefaultAsync();
                Assert.Equal("Nate Dawg", saved.Name);
            }
            return null;
        }

        //[Fact]
        //public async Task<List<CategoryComment>> CanGetAllIndividuals()
        //{
        //    DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanGetCategoryById").Options;

        //    using (CurveDBContext context = new CurveDBContext(options))
        //    {
        //        Individual individual = new Individual()
        //        {
        //            Id = 99,
        //            Email = "Nate@Test.com",
        //            Name = "Nate Dawg",
        //            CompetencyScore = 1,
        //            CurrentLevel = 1,
        //            PointsToNext = 1,
        //        };
        //        IndividualService personService = new IndividualService(context);
        //        await personService.CreateIndividual(individual);
        //        await personService.GetAllIndividuals(personService.);
        //        Individual saved = await context.Individuals.FirstOrDefaultAsync();
        //        Assert.Equal("Leadership", saved.name);
        //    }
        //    return null;
        //}
    }
}

//[Fact]
//public async Task<List<CategoryComment>> CanGetAllByReviewId()
//{
//    DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanGetAllByReviewId").Options;

//    using (CurveDBContext context = new CurveDBContext(options))
//    {
//        Category kittyCat = new Category()
//        {
//            Id = 123,
//            CategoryName = "Growth Mindset",
//            OverallScore = 1,
//            ReviewId = 19,
//        };
//        CategoryService kittyCatService = new CategoryService(context);
//        await kittyCatService.CreateCategory(kittyCat);
//        await kittyCatService.GetAllByReviewId(kittyCat.ReviewId);
//        Category saved = await context.Categories.FirstOrDefaultAsync();
//        Assert.Equal("Growth Mindset", saved.CategoryName);
//    }
//    return null;
//}

//[Fact]
//public async Task<List<CategoryComment>> CanGetCategoryById()
//{
//    DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanGetCategoryById").Options;

//    using (CurveDBContext context = new CurveDBContext(options))
//    {
//        Category kittyCat = new Category()
//        {
//            Id = 123,
//            CategoryName = "Leadership",
//            OverallScore = 1,
//            ReviewId = 19,
//        };
//        CategoryService kittyCatService = new CategoryService(context);
//        await kittyCatService.CreateCategory(kittyCat);
//        await kittyCatService.GetCategoryById(123);
//        Category saved = await context.Categories.FirstOrDefaultAsync();
//        Assert.Equal("Leadership", saved.CategoryName);
//    }
//    return null;
//}

//[Fact]
//public async Task<List<CategoryComment>> CanUpdateCategory()
//{
//    DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanUpdateCategory").Options;

//    using (CurveDBContext context = new CurveDBContext(options))
//    {
//        Category kittyCat = new Category()
//        {
//            Id = 123,
//            CategoryName = "Quality",
//            OverallScore = 1,
//            ReviewId = 19,
//        };
//        CategoryService kittyCatService = new CategoryService(context);
//        await kittyCatService.CreateCategory(kittyCat);
//        kittyCat.CategoryName = "Quality";
//        await kittyCatService.UpdateCategory(kittyCat);
//        CategoryComment saved = await context.CategoryComments.FirstOrDefaultAsync();
//        Assert.Equal("Quality", kittyCat.CategoryName);
//    }
//    return null;
//}