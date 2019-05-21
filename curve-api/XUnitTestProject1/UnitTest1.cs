using System;
using Xunit;
using curve_api.Models;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
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
        public void CanGetReviewId()
        {
            Category reviewId = new Category()
            {
                ReviewId = 1
            };

            Assert.Equal(1, reviewId.ReviewId);
        }

        [Fact]
        public void CanSetReviewId()
        {
            Category reviewId = new Category()
            {
                ReviewId = 1
            };
            reviewId.ReviewId = 2;

            Assert.Equal(2, reviewId.ReviewId);
        }

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

        [Fact]
        public void CanGetIndividualName()
        {
            Individual name = new Individual()
            {
                Name = "DemiDoggo"
            };


            Assert.Equal("DemiDoggo", name.Name);
        }

        [Fact]
        public void CanSetIndividualName()
        {
            Individual name = new Individual()
            {
                Name = "DemiDoggo"
            };
            name.Name = "DemiTheDoggo";

            Assert.Equal("DemiTheDoggo", name.Name);
        }

        [Fact]
        public void CanGetIndividualCompetencyScore()
        {
            Individual competencyScore = new Individual()
            {
                CompetencyScore = 1
            };


            Assert.Equal(1, competencyScore.CompetencyScore);
        }

        [Fact]
        public void CanSetIndividualCompetencyScore()
        {
            Individual competencyScore = new Individual()
            {
                CompetencyScore = 1
            };
            competencyScore.CompetencyScore = 2;

            Assert.Equal(2, competencyScore.CompetencyScore);
        }

        [Fact]
        public void CanGetIndividualCurrentLevel()
        {
            Individual userId = new Individual()
            {
                CurrentLevel = 1
            };


            Assert.Equal(1, userId.CurrentLevel);
        }

        [Fact]
        public void CanSetIndividualCurrentLevel()
        {
            Individual userId = new Individual()
            {
                CurrentLevel = 1
            };
            userId.CurrentLevel = 9001;
            //supa sayian
            Assert.Equal(9001, userId.CurrentLevel);
        }

        [Fact]
        public void CanGetIndividualPointsToNext()
        {
            Individual pointsToNext = new Individual()
            {
                PointsToNext = 10
            };


            Assert.Equal(10, pointsToNext.PointsToNext);
        }

        [Fact]
        public void CanSetIndividualPointsToNext()
        {
            Individual pointsToNext = new Individual()
            {
                PointsToNext = 10
            };
            pointsToNext.PointsToNext = 27;

            Assert.Equal(27, pointsToNext.PointsToNext);
        }

        //[Fact]
        //public void CanGetReviewDateTime()
        //{
        //    DateTime testTime = new DateTime();         

        //    Assert.Equal(1, testTime.DateTime);
        //}

        //[Fact]
        //public void CanSetReviewDateTime()
        //{
        //    DateTime testTime = new DateTime()
        //    {
        //        UserId = 1
        //    };
        //    userId.Id = 2;

        //    Assert.Equal(2, userId.UserId);
        //}

        [Fact]
        public void CanGetReviewIndividualId()
        {
            Review individualId = new Review()
            {
                IndividualId = 12
            };


            Assert.Equal(12, individualId.IndividualId);
        }

        [Fact]
        public void CanSetReviewIndividualId()
        {
            Review individualId = new Review()
            {
                IndividualId = 12
            };
            individualId.IndividualId = 37;

            Assert.Equal(37, individualId.IndividualId);
        }

        //[Fact]
        //public void CanGetCategoryCommentUserId()
        //{
        //    CategoryComment userId = new CategoryComment()
        //    {
        //        UserId = 1
        //    };


        //    Assert.Equal(1, userId.UserId);
        //}

        //[Fact]
        //public void CanSetCategoryCommentUserId()
        //{
        //    CategoryComment userId = new CategoryComment()
        //    {
        //        UserId = 1
        //    };
        //    userId.Id = 2;

        //    Assert.Equal(2, userId.UserId);
        //}
    }
}
