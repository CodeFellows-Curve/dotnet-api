using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using curve_api.Models;

namespace XUnitTestProject1.GetSetTests.ReviewCommentGetSetTests
{
   public class ReviewCommentGetSetTests
    {
        //--------------ReviewComment Tests---------------------//
        [Fact]
        public void CanGetReviewCommentUserId()
        {
            ReviewComment userId = new ReviewComment()
            {
                UserId = 1
            };


            Assert.Equal(1, userId.UserId);
        }

        [Fact]
        public void CanSetReviewCommentUserId()
        {
            ReviewComment userId = new ReviewComment()
            {
                UserId = 1
            };
            userId.UserId = 2;

            Assert.Equal(2, userId.UserId);
        }

        [Fact]
        public void CanGetReviewCommentReviewId()
        {
            ReviewComment reviewId = new ReviewComment()
            {
                ReviewId = 1
            };


            Assert.Equal(1, reviewId.ReviewId);
        }

        [Fact]
        public void CanSetReviewCommentReviewId()
        {
            ReviewComment reviewId = new ReviewComment()
            {
                ReviewId = 1
            };
            reviewId.ReviewId = 2;

            Assert.Equal(2, reviewId.ReviewId);
        }

        [Fact]
        public void CanGetReviewCommentSubject()
        {
            ReviewComment subject = new ReviewComment()
            {
                Subject = "tests"
            };


            Assert.Equal("tests", subject.Subject);
        }

        [Fact]
        public void CanSetReviewCommentSubject()
        {
            ReviewComment subject = new ReviewComment()
            {
                Subject = "tests"
            };
            subject.Subject = "go outside and enjoy life";

            Assert.Equal("go outside and enjoy life", subject.Subject);
        }

        [Fact]
        public void CanGetReviewCommentContent()
        {
            ReviewComment content = new ReviewComment()
            {
                Content = "tests are long"
            };


            Assert.Equal("tests are long", content.Content);
        }

        [Fact]
        public void CanSetReviewCommentContent()
        {
            ReviewComment content = new ReviewComment()
            {
                Content = "tests are long"
            };
            content.Content = "but a needed feature";

            Assert.Equal("but a needed feature", content.Content);
        }

    }
}
