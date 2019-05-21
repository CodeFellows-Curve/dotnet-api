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
            int n = 1;
            modelBuilder.Entity<Individual>().HasData(
                   new Individual
                   {
                       Id = n++,
                       Email = "Nate@Test.com",
                       Name = "Nate",
                       CompetencyScore = 1,
                       CurrentLevel = 1,
                       PointsToNext = 1,

                   },
                   new Individual
                   {
                       Id = n++,
                       Email = "Hannah@Test.com",
                       Name = "Hannah",
                       CompetencyScore = 1,
                       CurrentLevel = 2,
                       PointsToNext = 1,

                   },
                   new Individual
                   {
                       Id = n++,
                       Email = "TestOne@Test.com",
                       Name = "TestOne",
                       CompetencyScore = 1,
                       CurrentLevel = 1,
                       PointsToNext = 1,

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
                       OverallScore = 1,

                   },
                   new Review
                   {
                       Id = n++,
                       ReviewDate = new DateTime(),
                       IndividualId = 3,
                       OverallScore = 1,

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
                       UserId = 1,
                       ReviewId = 2,
                       Subject = "TestSubject - Review 2",
                       Content = "TestContent - Comment 1",

                   },
                   new ReviewComment
                   {
                       Id = n++,
                       UserId = 1,
                       ReviewId = 2,
                       Subject = "TestSubject - Review 2",
                       Content = "TestContent - Comment 2",

                   },
                   new ReviewComment
                   {
                       Id = n++,
                       UserId = 1,
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
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
                       CategoryId = n++,
                       Subject = $"TestSubject - Category {n - 1}",
                       Content = "TestContent - Review 3",

                   },
                   new CategoryComment
                   {
                       Id = n,
                       UserId = 1,
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
                       Score = 1,
                       CategoryId = 1,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Customer Orientation",
                       Score = 1,
                       CategoryId = 1,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Adaptability",
                       Score = 1,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Curiousity",
                       Score = 1,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Constant Improvement",
                       Score = 1,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Handling Ambiguity",
                       Score = 1,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Inclusivity",
                       Score = 1,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Openness",
                       Score = 1,
                       CategoryId = 2,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Ambition and Initiative",
                       Score = 1,
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
                       Score = 1,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Ownership",
                       Score = 1,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Mentorship",
                       Score = 1,
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
                       Score = 1,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Health and Safety",
                       Score = 1,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Confidence",
                       Score = 1,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Credibility",
                       Score = 1,
                       CategoryId = 3,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Technical",
                       Score = 1,
                       CategoryId = 4,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Process",
                       Score = 1,
                       CategoryId = 4,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Innovation",
                       Score = 1,
                       CategoryId = 4,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Tool Proficiency",
                       Score = 1,
                       CategoryId = 4,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Judgement",
                       Score = 1,
                       CategoryId = 5,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Root Cause Resolution",
                       Score = 1,
                       CategoryId = 5,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Writing",
                       Score = 1,
                       CategoryId = 6,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Reading",
                       Score = 1,
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
                       Score = 1,
                       CategoryId = 6,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Collaboration",
                       Score = 1,
                       CategoryId = 7,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Agile",
                       Score = 1,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Organizational",
                       Score = 1,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Creative",
                       Score = 1,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Project Execution",
                       Score = 1,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Analytical Thinking",
                       Score = 1,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Prioritization",
                       Score = 1,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Problem Solving",
                       Score = 1,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Incremental Delivery",
                       Score = 1,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Decision Making",
                       Score = 1,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Appropriate Autonomy",
                       Score = 1,
                       CategoryId = 8,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Planning and Estimating",
                       Score = 1,
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
                       Score = 1,
                       CategoryId = 9,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Customer Orientation",
                       Score = 1,
                       CategoryId = 9,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Adaptability",
                       Score = 1,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Curiousity",
                       Score = 1,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Constant Improvement",
                       Score = 1,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Handling Ambiguity",
                       Score = 1,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Inclusivity",
                       Score = 1,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Openness",
                       Score = 1,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Ambition and Initiative",
                       Score = 1,
                       CategoryId = 10,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Accountability",
                       Score = 1,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Integrity",
                       Score = 1,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Ownership",
                       Score = 1,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Mentorship",
                       Score = 1,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Networking",
                       Score = 1,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Succession",
                       Score = 1,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Health and Safety",
                       Score = 1,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Confidence",
                       Score = 1,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Credibility",
                       Score = 1,
                       CategoryId = 11,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Technical",
                       Score = 1,
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
                       Score = 1,
                       CategoryId = 12,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Tool Proficiency",
                       Score = 1,
                       CategoryId = 12,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Judgement",
                       Score = 1,
                       CategoryId = 13,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Root Cause Resolution",
                       Score = 1,
                       CategoryId = 13,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Writing",
                       Score = 1,
                       CategoryId = 14,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Reading",
                       Score = 1,
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
                       Score = 1,
                       CategoryId = 14,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Collaboration",
                       Score = 1,
                       CategoryId = 15,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Agile",
                       Score = 1,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Organizational",
                       Score = 1,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Creative",
                       Score = 1,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Project Execution",
                       Score = 1,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Analytical Thinking",
                       Score = 1,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Prioritization",
                       Score = 1,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Problem Solving",
                       Score = 1,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Incremental Delivery",
                       Score = 1,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Decision Making",
                       Score = 1,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Appropriate Autonomy",
                       Score = 1,
                       CategoryId = 16,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Planning and Estimating",
                       Score = 1,
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
                       Score = 1,
                       CategoryId = 17,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Customer Orientation",
                       Score = 1,
                       CategoryId = 17,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Adaptability",
                       Score = 1,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Curiousity",
                       Score = 1,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Constant Improvement",
                       Score = 1,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Handling Ambiguity",
                       Score = 1,
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
                       Score = 1,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Ambition and Initiative",
                       Score = 1,
                       CategoryId = 18,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Accountability",
                       Score = 1,
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
                       Score = 1,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Networking",
                       Score = 1,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Succession",
                       Score = 1,
                       CategoryId = 19,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Health and Safety",
                       Score = 1,
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
                       Score = 1,
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
                       Score = 1,
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
                       Score = 1,
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
                       Score = 1,
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
                       Score = 1,
                       CategoryId = 22,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Listening",
                       Score = 1,
                       CategoryId = 22,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Collaboration",
                       Score = 1,
                       CategoryId = 23,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Agile",
                       Score = 1,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Organizational",
                       Score = 1,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Creative",
                       Score = 1,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Project Execution",
                       Score = 1,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Analytical Thinking",
                       Score = 1,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Prioritization",
                       Score = 1,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Problem Solving",
                       Score = 1,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Incremental Delivery",
                       Score = 1,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Decision Making",
                       Score = 1,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Appropriate Autonomy",
                       Score = 1,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Planning and Estimating",
                       Score = 1,
                       CategoryId = 24,

                   },
                   new SubCategory
                   {
                       Id = n++,
                       SubCategoryName = "Dependability and Reliability",
                       Score = 1,
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
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 2",

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

                  },
                  new SubCategoryComment
                  {
                      Id = n,
                      UserId = 1,
                      SubCategoryId = n++,
                      Subject = $"TestSubject - SubCategory {n - 1}",
                      Content = "TestContent - Review 3",

                  });
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
