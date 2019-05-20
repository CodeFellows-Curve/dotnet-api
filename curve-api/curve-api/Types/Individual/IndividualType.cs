using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curve_api.Types.Individual
{
    public class IndividualType : ObjectGraphType<Models.Individual>
    {
        public IndividualType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.CompetencyScore);
            Field(x => x.CurrentLevel);
            Field(x => x.PointsToNext);
        }
    }
}
