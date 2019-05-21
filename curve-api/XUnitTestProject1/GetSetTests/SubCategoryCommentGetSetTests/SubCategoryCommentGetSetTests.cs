using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using curve_api.Models;

namespace XUnitTestProject1.GetSetTests.SubCategoryCommentGetSetTests
{
    public class SubCategoryCommentGetSetTests
    {
        //--------------SubCategoryComment Tests---------------------//
        [Fact]
        public void CanGetSubCategoryCommentUserId()
        {
            SubCategoryComment userId = new SubCategoryComment()
            {
                UserId = 7
            };


            Assert.Equal(7, userId.UserId);
        }

        [Fact]
        public void CanSetSubCategoryCommentUserId()
        {
            SubCategoryComment userId = new SubCategoryComment()
            {
                UserId = 7
            };
            userId.UserId = 16;

            Assert.Equal(16, userId.UserId);
        }

        [Fact]
        public void CanSubCategoryCommentSubCategoryId()
        {
            SubCategoryComment subCategoryId = new SubCategoryComment()
            {
                SubCategoryId = 98
            };


            Assert.Equal(98, subCategoryId.SubCategoryId);
        }

        [Fact]
        public void CanSetSubCategoryCommenSubCategoryId()
        {
            SubCategoryComment subCategoryId = new SubCategoryComment()
            {
                SubCategoryId = 98
            };
            subCategoryId.SubCategoryId = 99;

            Assert.Equal(99, subCategoryId.SubCategoryId);
        }

        [Fact]
        public void CanGetSubCategoryCommentSubject()
        {
            SubCategoryComment subject = new SubCategoryComment()
            {
                Subject = "subcat subject test"
            };


            Assert.Equal("subcat subject test", subject.Subject);
        }

        [Fact]
        public void CanSetSubCategoryCommentSubject()
        {
            SubCategoryComment subject = new SubCategoryComment()
            {
                Subject = "subcat subject test"
            };
            subject.Subject = "go outside and enjoy life";

            Assert.Equal("go outside and enjoy life", subject.Subject);
        }

        [Fact]
        public void CanGetSubCategoryCommentContent()
        {
            SubCategoryComment content = new SubCategoryComment()
            {
                Content = "tests are long"
            };


            Assert.Equal("tests are long", content.Content);
        }

        [Fact]
        public void CanSetSubCategoryCommentContent()
        {
            SubCategoryComment content = new SubCategoryComment()
            {
                Content = "tests are long"
            };
            content.Content = "but a needed feature all the time";

            Assert.Equal("but a needed feature all the time", content.Content);
        }
    }
}
