using curve_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace curve_api.Data
{
    public class CurveDBContext : DbContext
    {
		public CurveDBContext(DbContextOptions<CurveDBContext> options) : base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region seededData
            int n = 1;
            modelBuilder.Entity<Individual>().HasData(
                   new Individual
                   {
                       Id = n++,
                       Email = "Nate@Test.com",
                       Name = "Nate",
                       CompetencyScore = 3,
                       CurrentLevel = 1,
                       PointsToNext = 1,

                   },
                   new Individual
                   {
                       Id = n++,
                       Email = "Hannah@Test.com",
                       Name = "Hannah",
                       CompetencyScore = 2,
                       CurrentLevel = 2,
                       PointsToNext = 1,

                   },
                   new Individual
                   {
                       Id = n++,
                       Email = "Caity@Test.com",
                       Name = "Caity",
                       CompetencyScore = 1,
                       CurrentLevel = 1,
                       PointsToNext = 3,

                   });
            n = 1;
            modelBuilder.Entity<Review>().HasData(
                   new Review
                   {
                       Id = n++,
                       ReviewDate = new DateTime(),
                       IndividualId = 1,
                       OverallScore = 1,

                   },
                   new Review
                   {
                       Id = n++,
                       ReviewDate = new DateTime(),
                       IndividualId = 2,
                       OverallScore = 3,

                   },
                   new Review
                   {
                       Id = n++,
                       ReviewDate = new DateTime(),
                       IndividualId = 3,
                       OverallScore = 4,

                   });
            n = 1;
            modelBuilder.Entity<ReviewComment>().HasData(
                   new ReviewComment
                   {
                       Id = n++,
                       UserId = 1,
                       ReviewId = 1,
                       Subject = "TestSubject - Review 1",
                       Content = "TestContent - Comment 1",

                   },
                   new ReviewComment
                   {
                       Id = n++,
                       UserId = 1,
                       ReviewId = 1,
                       Subject = "TestSubject - Review 1",
                       Content = "TestContent - Comment 2",

                   },
                   new ReviewComment
                   {
                       Id = n++,
                       UserId = 2,
                       ReviewId = 2,
                       Subject = "TestSubject - Review 2",
                       Content = "TestContent - Comment 1",

                   },
                   new ReviewComment
                   {
                       Id = n++,
                       UserId = 3,
                       ReviewId = 2,
                       Subject = "TestSubject - Review 2",
                       Content = "TestContent - Comment 2",

                   },
                   new ReviewComment
                   {
                       Id = n++,
                       UserId = 2,
                       ReviewId = 3,
                       Subject = "TestSubject - Review 3",
                       Content = "TestContent - Comment 1",

                   },
                   new ReviewComment
                   {
                       Id = n++,
                       UserId = 1,
                       ReviewId = 3,
                       Subject = "TestSubject - Review 3",
                       Content = "TestContent - Comment 2",

                   });
            n = 1;
            modelBuilder.Entity<Category>().HasData(
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Business Acumen",
                       OverallScore = 1,
                       ReviewId = 1,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Growth Mindset",
                       OverallScore = 1,
                       ReviewId = 1,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Leadership",
                       OverallScore = 1,
                       ReviewId = 1,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Craft",
                       OverallScore = 1,
                       ReviewId = 1,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Quality",
                       OverallScore = 1,
                       ReviewId = 1,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Communication",
                       OverallScore = 1,
                       ReviewId = 1,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Teamwork",
                       OverallScore = 1,
                       ReviewId = 1,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Results",
                       OverallScore = 1,
                       ReviewId = 1,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Business Acumen",
                       OverallScore = 2,
                       ReviewId = 2,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Growth Mindset",
                       OverallScore = 2,
                       ReviewId = 2,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Leadership",
                       OverallScore = 2,
                       ReviewId = 2,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Craft",
                       OverallScore = 2,
                       ReviewId = 2,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Quality",
                       OverallScore = 2,
                       ReviewId = 2,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Communication",
                       OverallScore = 2,
                       ReviewId = 2,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Teamwork",
                       OverallScore = 2,
                       ReviewId = 2,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Results",
                       OverallScore = 2,
                       ReviewId = 2,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Business Acumen",
                       OverallScore = 3,
                       ReviewId = 3,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Growth Mindset",
                       OverallScore = 3,
                       ReviewId = 3,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Leadership",
                       OverallScore = 3,
                       ReviewId = 3,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Craft",
                       OverallScore = 3,
                       ReviewId = 3,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Quality",
                       OverallScore = 3,
                       ReviewId = 3,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Communication",
                       OverallScore = 3,
                       ReviewId = 3,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Teamwork",
                       OverallScore = 3,
                       ReviewId = 3,

                   },
                   new Category
                   {
                       Id = n++,
                       CategoryName = "Results",
                       OverallScore = 3,
                       ReviewId = 3,

                   });
            n = 1;
            modelBuilder.Entity<CategoryComment>().HasData(
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 1",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 1",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 1",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 1",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 1",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 1",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 1",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 1",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 2",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 2",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 2",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 2",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 2",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 2",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 2,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 2",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 2,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 2",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 2,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 2,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 2,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 2,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 3,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 3,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 3,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 3,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   });
            n = 1;
            modelBuilder.Entity<SubCategory>().HasData(
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Mission and Vision",
                       Score = 3,
                       CategoryId = 1,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Customer Orientation",
                       Score = 4,
                       CategoryId = 1,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Adaptability",
                       Score = 2,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Curiosity",
                       Score = 3,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Constant Improvement",
                       Score = 4,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Handling Ambiguity",
                       Score = 2,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Inclusivity",
                       Score = 0,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Openness",
                       Score = 2,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Ambition and Initiative",
                       Score = 4,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Accountability",
                       Score = 1,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Integrity",
                       Score = 2,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Ownership",
                       Score = 3,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Mentorship",
                       Score = 4,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Networking",
                       Score = 1,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Succession",
                       Score = 0,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Health and Safety",
                       Score = 2,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Confidence",
                       Score = 0,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Credibility",
                       Score = 3,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Technical",
                       Score = 4,
                       CategoryId = 4,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Process",
                       Score = 3,
                       CategoryId = 4,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Innovation",
                       Score = 4,
                       CategoryId = 4,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Tool Proficiency",
                       Score = 2,
                       CategoryId = 4,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Judgement",
                       Score = 3,
                       CategoryId = 5,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Root Cause Resolution",
                       Score = 4,
                       CategoryId = 5,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Writing",
                       Score = 0,
                       CategoryId = 6,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Reading",
                       Score = 2,
                       CategoryId = 6,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Speaking",
                       Score = 1,
                       CategoryId = 6,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Listening",
                       Score = 3,
                       CategoryId = 6,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Collaboration",
                       Score = 4,
                       CategoryId = 7,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Agile",
                       Score = 2,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Organizational",
                       Score = 4,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Creative",
                       Score = 3,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Project Execution",
                       Score = 0,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Analytical Thinking",
                       Score = 3,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Prioritization",
                       Score = 4,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Problem Solving",
                       Score = 2,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Incremental Delivery",
                       Score = 4,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Decision Making",
                       Score = 3,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Appropriate Autonomy",
                       Score = 2,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Planning and Estimating",
                       Score = 0,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Dependability and Reliability",
                       Score = 1,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Mission and Vision",
                       Score = 3,
                       CategoryId = 9,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Customer Orientation",
                       Score = 2,
                       CategoryId = 9,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Adaptability",
                       Score = 4,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Curiousity",
                       Score = 3,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Constant Improvement",
                       Score = 2,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Handling Ambiguity",
                       Score = 2,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Inclusivity",
                       Score = 4,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Openness",
                       Score = 2,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Ambition and Initiative",
                       Score = 3,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Accountability",
                       Score = 0,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Integrity",
                       Score = 4,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Ownership",
                       Score = 4,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Mentorship",
                       Score = 2,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Networking",
                       Score = 3,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Succession",
                       Score = 2,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Health and Safety",
                       Score = 0,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Confidence",
                       Score = 4,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Credibility",
                       Score = 2,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Technical",
                       Score = 4,
                       CategoryId = 12,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Process",
                       Score = 1,
                       CategoryId = 12,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Innovation",
                       Score = 3,
                       CategoryId = 12,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Tool Proficiency",
                       Score = 4,
                       CategoryId = 12,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Judgement",
                       Score = 3,
                       CategoryId = 13,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Root Cause Resolution",
                       Score = 0,
                       CategoryId = 13,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Writing",
                       Score = 2,
                       CategoryId = 14,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Reading",
                       Score = 4,
                       CategoryId = 14,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Speaking",
                       Score = 1,
                       CategoryId = 14,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Listening",
                       Score = 2,
                       CategoryId = 14,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Collaboration",
                       Score = 4,
                       CategoryId = 15,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Agile",
                       Score = 3,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Organizational",
                       Score = 4,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Creative",
                       Score = 0,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Project Execution",
                       Score = 4,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Analytical Thinking",
                       Score = 2,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Prioritization",
                       Score = 3,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Problem Solving",
                       Score = 4,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Incremental Delivery",
                       Score = 3,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Decision Making",
                       Score = 4,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Appropriate Autonomy",
                       Score = 2,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Planning and Estimating",
                       Score = 3,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Dependability and Reliability",
                       Score = 1,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Mission and Vision",
                       Score = 4,
                       CategoryId = 17,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Customer Orientation",
                       Score = 2,
                       CategoryId = 17,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Adaptability",
                       Score = 0,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Curiousity",
                       Score = 0,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Constant Improvement",
                       Score = 2,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Handling Ambiguity",
                       Score = 3,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Inclusivity",
                       Score = 1,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Openness",
                       Score = 4,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Ambition and Initiative",
                       Score = 3,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Accountability",
                       Score = 2,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Integrity",
                       Score = 1,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Ownership",
                       Score = 1,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Mentorship",
                       Score = 3,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Networking",
                       Score = 2,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Succession",
                       Score = 2,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Health and Safety",
                       Score = 4,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Confidence",
                       Score = 1,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Credibility",
                       Score = 3,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Technical",
                       Score = 1,
                       CategoryId = 20,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Process",
                       Score = 2,
                       CategoryId = 20,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Innovation",
                       Score = 1,
                       CategoryId = 20,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Tool Proficiency",
                       Score = 4,
                       CategoryId = 20,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Judgement",
                       Score = 1,
                       CategoryId = 21,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Root Cause Resolution",
                       Score = 2,
                       CategoryId = 21,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Writing",
                       Score = 1,
                       CategoryId = 22,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Reading",
                       Score = 1,
                       CategoryId = 22,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Speaking",
                       Score = 4,
                       CategoryId = 22,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Listening",
                       Score = 2,
                       CategoryId = 22,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Collaboration",
                       Score = 3,
                       CategoryId = 23,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Agile",
                       Score = 4,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Organizational",
                       Score = 4,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Creative",
                       Score = 3,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Project Execution",
                       Score = 0,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Analytical Thinking",
                       Score = 4,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Prioritization",
                       Score = 2,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Problem Solving",
                       Score = 2,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Incremental Delivery",
                       Score = 3,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Decision Making",
                       Score = 4,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Appropriate Autonomy",
                       Score = 4,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Planning and Estimating",
                       Score = 3,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Dependability and Reliability",
                       Score = 4,
                       CategoryId = 24,

                   });
            n = 1;
            modelBuilder.Entity<SubCategoryComment>().HasData(
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 1",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 2,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 3,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  });

            #endregion
        }

        // Set DB tables
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewComment> ReviewComments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryComment> CategoryComments { get; set; }
        public DbSet<SubCategory> Subcategories { get; set; }
        public DbSet<SubCategoryComment> SubcategoryComments { get; set; }
    }
}
