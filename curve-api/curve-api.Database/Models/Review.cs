using System;
using System.Collections.Generic;

namespace curve_api.Database.Models
{
    public class Review
    {
        //Table
        public int Id { get; set; }
        public DateTime ReviewDate { get; set; }
        public int IdividualId { get; set; }
        public int OverAllScore { get; set; }
        //Nav
        public Individual Individuals { get; set; }
        public List<Category> Categories { get; set; }
        public List<ReviewComment> ReviewComment { get; set; }
    }
}
