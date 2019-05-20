using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace curve_api.Types.ReviewCommentType
{
    public class ReviewCommentType : ObjectGraphType<Models.ReviewComment>
    {
        public ReviewCommentType()
        {
            Field(x => x.Id);
            Field(x => x.UserId);
            Field(x => x.ReviewId);
            Field(x => x.Subject);
            Field(x => x.Content);
        }        
    }
}
