using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace curve_api.Types.SubCategory
{
    public class SubCategoryType : ObjectGraphType<Models.SubCategory>
    {
        public SubCategoryType()
        {
            Field(x => x.Id);
            Field(x => x.SubCategoryName);
            Field(x => x.Score);
            Field(x => x.CategoryId);
        }     
    }
}
