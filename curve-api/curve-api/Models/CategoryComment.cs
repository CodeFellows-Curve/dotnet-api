using System;
using System.Collections.Generic;
using System.Text;

namespace curve_api.Models
{
    public class CategoryComment
    {
        //Table
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        //Nav
        public Category Category { get; set; }
    }
}
