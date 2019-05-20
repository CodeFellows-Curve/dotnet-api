using System;
using System.Collections.Generic;
using System.Text;

namespace curve_api.Database.Models
{
    public class SubCategory
    {
        //Table
        public int Id { get; set; }
        public string SubCategoryName { get; set; }
        public int Score { get; set; }
        public int CategoryId { get; set; }
        //Nav
        public Category Category { get; set; }
        public List<SubCategoryComments> SubCategoryComments { get; set; }
    }
}
