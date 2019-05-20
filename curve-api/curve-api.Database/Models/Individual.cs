using System;
using System.Collections.Generic;
using System.Text;

namespace curve_api.Database.Models
{
    public class Individual
    {
        //Table
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompetencyScore { get; set; }
        public int CurrentLevel { get; set; }
        public int PointsToNext { get; set; }
        //Nav
        public List<Review> Reviews { get; set; }
    }
}
