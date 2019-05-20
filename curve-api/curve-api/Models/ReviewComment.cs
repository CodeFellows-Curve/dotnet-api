using System;
using System.Collections.Generic;
using System.Text;

namespace curve_api.Models
{
    public class ReviewComment
    {
        //Table
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ReviewId { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        //Nav
        public Review Review { get; set; }
    }
}
