using System;
using System.Collections.Generic;
using System.Text;

namespace curve_api.Models
{
    public class Category
    {
        //Table
        public int Name { get; set; }
        public string CategoryName { get; set; }
        public int OverallScore { get; set; }
        public int ReviewId { get; set; }
        //Nav
        public Review Review { get; set; }
        public List<SubCategory> SubCategories { get; set; }
        public List<CategoryComment> CategoryComment { get; set; }
    }
}
