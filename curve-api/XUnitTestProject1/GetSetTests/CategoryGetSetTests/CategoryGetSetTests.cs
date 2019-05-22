using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using curve_api.Models;

namespace XUnitTestProject1.GetSetTests.CategoryGetSetTests
{
    public class CategoryGetSetTests
    {
        //--------------Category Tests---------------------//
        [Fact]
        public void CanGetCategoryName()
        {
            Category categoryName = new Category()
            {
                Id = 1
            };

            Assert.Equal(1, categoryName.Id);
        }

        [Fact]
        public void CanSetCategoryName()
        {
            Category categoryName = new Category()
            {
                Id = 1
            };
            categoryName.Id = 2;

            Assert.Equal(2, categoryName.Id);
        }

        [Fact]
        public void CanGetOverallScore()
        {
            Category overallScore = new Category()
            {
                OverallScore = 1
            };

            Assert.Equal(1, overallScore.OverallScore);
        }

        [Fact]
        public void CanSetOverallScore()
        {
            Category overallScore = new Category()
            {
                OverallScore = 1
            };
            overallScore.OverallScore = 2;

            Assert.Equal(2, overallScore.OverallScore);
        }

        [Fact]
        public void CanGetCategoryReviewId()
        {
            Category reviewId = new Category()
            {
                ReviewId = 1
            };

            Assert.Equal(1, reviewId.ReviewId);
        }

        [Fact]
        public void CanSetCategoryReviewId()
        {
            Category reviewId = new Category()
            {
                ReviewId = 1
            };
            reviewId.ReviewId = 2;

            Assert.Equal(2, reviewId.ReviewId);
        }
    }
}
