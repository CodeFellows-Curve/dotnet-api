using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using curve_api.Models;

namespace XUnitTestProject1.GetSetTests.ReviewGetSetTests
{
    public class ReviewGetSetTests
    {
        //--------------Review Tests---------------------//
        //[Fact]
        //public void CanGetReviewDate()
        //{
        //    DateTime reviewTime = new DateTime();

        //    Assert.Equal(1, reviewTime.ReviewDate);
        //}

        //[Fact]
        //public void CanSetReviewDate()
        //{
        //    DateTime reviewTime = new DateTime()
        //    {
        //        ReviewDate = 1
        //    };
        //    reviewTime.ReviewDate = 2;

        //    Assert.Equal(2, reviewTime.ReviewDate);
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

        [Fact]
        public void CanGetReviewOverallScore()
        {
            Review overallScore = new Review()
            {
                OverallScore = 5
            };


            Assert.Equal(5, overallScore.OverallScore);
        }

        [Fact]
        public void CanSetReviewOverallScore()
        {
            Review overallScore = new Review()
            {
                OverallScore = 5
            };
            overallScore.OverallScore = 2;

            Assert.Equal(2, overallScore.OverallScore);
        }

    }
}
