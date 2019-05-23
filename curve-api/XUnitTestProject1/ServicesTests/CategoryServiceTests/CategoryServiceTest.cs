using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using curve_api.Models.Services;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using curve_api.Data;
using curve_api.Models;

namespace XUnitTestProject1.ServicesTests.CategoryServiceTests
{
    public class CategoryServiceTest
    {
        [Fact]
        public async Task CanCreateCategory()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanCreateCategory").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                Category kittyCat = new Category()
                {
                    Id = 12,
                    CategoryName = "Business Acumen",
                    OverallScore = 1,
                    ReviewId = 1,
                };
                CategoryService kittyCatService = new CategoryService(context);
                await kittyCatService.CreateCategory(kittyCat);
                Category saved = await context.Categories.FirstOrDefaultAsync();
                Assert.Equal("Business Acumen", saved.CategoryName);
            }
        }

        [Fact]
        public async Task CanDeleteCategory()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanDeleteCategory").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                Category kittyCat = new Category()
                {
                    Id = 123,
                    CategoryName = "Business Acumen",
                    OverallScore = 1,
                    ReviewId = 1,
                };
                CategoryService kittyCatService = new CategoryService(context);
                await kittyCatService.CreateCategory(kittyCat);
                await kittyCatService.DeleteCategory(123);
                Category saved = await context.Categories.FirstOrDefaultAsync();
                Assert.Null(saved);
            }
        }

        [Fact]
        public async Task<List<CategoryComment>> CanGetAllByReviewId()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanGetAllByReviewId").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                Category kittyCat = new Category()
                {
                    Id = 123,
                    CategoryName = "Growth Mindset",
                    OverallScore = 1,
                    ReviewId = 19,
                };
                CategoryService kittyCatService = new CategoryService(context);
                await kittyCatService.CreateCategory(kittyCat);
                await kittyCatService.GetAllByReviewId(kittyCat.ReviewId);
                Category saved = await context.Categories.FirstOrDefaultAsync();
                Assert.Equal("Growth Mindset", saved.CategoryName);
            }
            return null;
        }

        [Fact]
        public async Task<List<CategoryComment>> CanGetCategoryById()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanGetCategoryById").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                Category kittyCat = new Category()
                {
                    Id = 123,
                    CategoryName = "Leadership",
                    OverallScore = 1,
                    ReviewId = 19,
                };
                CategoryService kittyCatService = new CategoryService(context);
                await kittyCatService.CreateCategory(kittyCat);
                await kittyCatService.GetCategoryById(123);
                Category saved = await context.Categories.FirstOrDefaultAsync();
                Assert.Equal("Leadership", saved.CategoryName);
            }
            return null;
        }

        [Fact]
        public async Task<List<CategoryComment>> CanUpdateCategory()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanUpdateCategory").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                Category kittyCat = new Category()
                {
                    Id = 123,
                    CategoryName = "Quality",
                    OverallScore = 1,
                    ReviewId = 19,
                };
                CategoryService kittyCatService = new CategoryService(context);
                await kittyCatService.CreateCategory(kittyCat);
                kittyCat.CategoryName = "Quality";            
                await kittyCatService.UpdateCategory(kittyCat);
                CategoryComment saved = await context.CategoryComments.FirstOrDefaultAsync();
                Assert.Equal("Quality", kittyCat.CategoryName);
            }
            return null;
        }
    }
}