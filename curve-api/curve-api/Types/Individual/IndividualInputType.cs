﻿using GraphQL.Types;

namespace curve_api.Types.Individual
{
    public class IndividualInputType : InputObjectGraphType
    {
        public IndividualInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<IntGraphType>("CompetencyScore");
            Field<IntGraphType>("CurrentLevel");
            Field<IntGraphType>("PointsToNext");
        }
    }
}
