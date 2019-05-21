using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace curve_api.Types.SubCategoryComment
{
    public class SubCategoryCommentType : ObjectGraphType<Models.SubCategoryComment>
    {
        public SubCategoryCommentType()
        {
            Field(x => x.Id);
            Field(x => x.UserId);
            Field(x => x.SubCategoryId);
            Field(x => x.Subject);
            Field(x => x.Content);
        }  
    }
}
