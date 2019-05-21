using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace curve_api.Types.Review
{
    public class ReviewType : ObjectGraphType<Models.Review>
    {
        public ReviewType()
        {
            Field(x => x.Id);
            Field(x => x.ReviewDate);
            Field(x => x.IndividualId);
            Field(x => x.OverallScore);
        }        
    }
}
