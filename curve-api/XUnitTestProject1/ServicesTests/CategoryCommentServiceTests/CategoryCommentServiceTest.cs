using curve_api.Models.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.EntityFrameworkCore.InMemory;
using curve_api.Data;
using Microsoft.EntityFrameworkCore;
using curve_api.Models;
using System.Threading.Tasks;

namespace XUnitTestProject1.ServicesTests.CategoryCommentServiceTests
{
    public class CategoryCommentServiceTest
    {
        [Fact]
        public async Task CanCreateCategoryComment()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanCreateCategoryComment").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
               CategoryComment comment = new CategoryComment()
                {
                    Id = 2000,
                    UserId = 5,
                    CategoryId = 6,
                    Subject = $"TestSubject - Category {6}",
                    Content = "TestContent - Review 1"
                };
                CategoryCommentService commentService = new CategoryCommentService(context);
                await commentService.CreateCategoryComment(comment);
                CategoryComment saved = await context.CategoryComments.FirstOrDefaultAsync();
                Assert.Equal("TestContent - Review 1", saved.Content);
            }
        }

        [Fact]
        public async Task CanDeleteCategoryComment()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanDeleteCategoryComment").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                CategoryComment comment = new CategoryComment()
                {
                    Id = 2000,
                    UserId = 5,
                    CategoryId = 6,
                    Subject = $"TestSubject - Category {6}",
                    Content = "TestContent - Review 1"
                };
                CategoryCommentService commentService = new CategoryCommentService(context);
                await commentService.CreateCategoryComment(comment);
                await commentService.DeleteCategoryComment(2000);
                CategoryComment saved = await context.CategoryComments.FirstOrDefaultAsync();
                Assert.Null(saved);
            }
        }

        [Fact]
        public async Task<List<CategoryComment>> CanGetAllByCategoryId()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanGetAllByCategoryId").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                CategoryComment comment = new CategoryComment()
                {
                    Id = 9001,
                    UserId = 5,
                    CategoryId = 6,
                    Subject = $"TestSubject - Category {6}",
                    Content = "TestContent - Review 1"
                };
                CategoryCommentService commentService = new CategoryCommentService(context);
                await commentService.CreateCategoryComment(comment);
                await commentService.GetAllByCategoryId(comment.CategoryId);
                CategoryComment saved = await context.CategoryComments.FirstOrDefaultAsync();
                Assert.Equal("TestContent - Review 1", saved.Content);
            }
            return null;
        }

        [Fact]
        public async Task<List<CategoryComment>> CanGetCategoryCommentById()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanGetCategoryCommentById").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                CategoryComment comment = new CategoryComment()
                {
                    Id = 001,
                    UserId = 5,
                    CategoryId = 6,
                    Subject = $"TestSubject - Category {6}",
                    Content = "TestContent - Review 1"
                };
                CategoryCommentService commentService = new CategoryCommentService(context);
                await commentService.CreateCategoryComment(comment);
                await commentService.GetCategoryCommentById(001);
                CategoryComment saved = await context.CategoryComments.FirstOrDefaultAsync();
                Assert.Equal("TestContent - Review 1", saved.Content);
            }
            return null;
        }

        [Fact]
        public async Task<List<CategoryComment>> CanUpdateCategoryComment()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanUpdateCategoryComment").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                CategoryComment comment = new CategoryComment()
                {
                    Id = 001,
                    UserId = 5,
                    CategoryId = 6,
                    Subject = $"TestSubject - Category {6}",
                    Content = "TestContent - Review 1"
                };
                CategoryCommentService commentService = new CategoryCommentService(context);
                await commentService.CreateCategoryComment(comment);
                comment.Content = "testing of all tests";
                //CategoryComment comment2 = new CategoryComment()
                //{
                //    Id = 001,
                //    UserId = 5,
                //    CategoryId = 6,
                //    Subject = $"TestSubject - Category {6}",
                //    Content = "another test"
                //};
                await commentService.UpdateCategoryComment(comment);
                CategoryComment saved = await context.CategoryComments.FirstOrDefaultAsync();
                Assert.Equal("testing of all tests", comment.Content);
            }
            return null;
        }
    }
}


