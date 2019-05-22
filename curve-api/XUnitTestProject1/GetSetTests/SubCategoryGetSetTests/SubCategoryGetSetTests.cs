using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using curve_api.Models;

namespace XUnitTestProject1.GetSetTests.SubCategoryGetSetTests
{
    public class SubCategoryGetSetTests
    {
        //--------------SubCategory Tests---------------------//
        [Fact]
        public void CanGetSubCategorySubCategoryName()
        {
            SubCategory subCategoryName = new SubCategory()
            {
                SubCategoryName = "this is a category"
            };


            Assert.Equal("this is a category", subCategoryName.SubCategoryName);
        }

        [Fact]
        public void CanSetSubCategorySubCategoryName()
        {
            SubCategory subCategoryName = new SubCategory()
            {
                SubCategoryName = "this is a category"
            };
            subCategoryName.SubCategoryName = "this is as well";

            Assert.Equal("this is as well", subCategoryName.SubCategoryName);
        }

        [Fact]
        public void CanGetSubCategoryScore()
        {
            SubCategory score = new SubCategory()
            {
                Score = 10
            };


            Assert.Equal(10, score.Score);
        }

        [Fact]
        public void CanSetSubCategoryScore()
        {
            SubCategory score = new SubCategory()
            {
                Score = 10
            };
            score.Score = 5;

            Assert.Equal(5, score.Score);
        }

        [Fact]
        public void CanGetSubCategoryCategoryId()
        {
            SubCategory categoryId = new SubCategory()
            {
                CategoryId = 12
            };


            Assert.Equal(12, categoryId.CategoryId);
        }

        [Fact]
        public void CanSetSubCategoryCategoryId()
        {
            SubCategory categoryId = new SubCategory()
            {
                CategoryId = 12
            };
            categoryId.CategoryId = 20;

            Assert.Equal(20, categoryId.CategoryId);
        }
    }
}
