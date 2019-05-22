using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using curve_api.Models;

namespace XUnitTestProject1.GetSetTests.IndividualGetSetTests
{
    public class IndividualGetSetTests
    {
        //--------------Individual Tests---------------------//
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
            Individual currentLevel = new Individual()
            {
                CurrentLevel = 1
            };


            Assert.Equal(1, currentLevel.CurrentLevel);
        }

        [Fact]
        public void CanSetIndividualCurrentLevel()
        {
            Individual currentLevel = new Individual()
            {
                CurrentLevel = 1
            };
            currentLevel.CurrentLevel = 9001;
            //supa sayian
            Assert.Equal(9001, currentLevel.CurrentLevel);
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
    }
}
