using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using curve_api.Models;

namespace XUnitTestProject1.GetSetTests.CategoryCommentGetSetTests
{
    public class CategoryCommentGetSetTests
    {
        //--------------CategoryComment Tests---------------------//
        [Fact]
        public void CanGetCategoryCommentUserId()
        {
            CategoryComment userId = new CategoryComment()
            {
                UserId = 1
            };


            Assert.Equal(1, userId.UserId);
        }

        [Fact]
        public void CanSetCategoryCommentUserId()
        {
            CategoryComment userId = new CategoryComment()
            {
                UserId = 1
            };
            userId.UserId = 2;

            Assert.Equal(2, userId.UserId);
        }

        [Fact]
        public void CanGetCategoryId()
        {
            CategoryComment categoryId = new CategoryComment()
            {
                CategoryId = 1
            };


            Assert.Equal(1, categoryId.CategoryId);
        }

        [Fact]
        public void CanSetCategoryId()
        {
            CategoryComment categoryId = new CategoryComment()
            {
                CategoryId = 1
            };
            categoryId.CategoryId = 2;

            Assert.Equal(2, categoryId.CategoryId);
        }

        [Fact]
        public void CanGetCategoryCommentSubject()
        {
            CategoryComment subject = new CategoryComment()
            {
                Subject = "life"
            };


            Assert.Equal("life", subject.Subject);
        }

        [Fact]
        public void CanSetCategoryCommentSubject()
        {
            CategoryComment subject = new CategoryComment()
            {
                Subject = "life"
            };
            subject.Subject = "happy";

            Assert.Equal("happy", subject.Subject);
        }

        [Fact]
        public void CanGetCategoryCommentContent()
        {
            CategoryComment content = new CategoryComment()
            {
                Content = "These hands rated E for everyone"
            };


            Assert.Equal("These hands rated E for everyone", content.Content);
        }

        [Fact]
        public void CanSetCategoryCommentContent()
        {
            CategoryComment content = new CategoryComment()
            {
                Content = "These hands rated E for everyone"
            };
            content.Content = "But really, come get em";

            Assert.Equal("But really, come get em", content.Content);
        }
    }
}
