using System;
using System.Collections.Generic;

namespace curve_api.Database.Models
{
    public class Review
    {
        //Table
        public int Id { get; set; }
        public DateTime ReviewDate { get; set; }
        public int IndividualId { get; set; }
        public int OverallScore { get; set; }
        //Nav
        public Individual Individuals { get; set; }
        public List<Category> Categories { get; set; }
        public List<ReviewComment> ReviewComment { get; set; }
    }
}
