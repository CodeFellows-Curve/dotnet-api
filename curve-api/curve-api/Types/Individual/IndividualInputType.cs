using GraphQL.Types;

namespace curve_api.Types.Individual
{
    public class IndividualInputType : InputObjectGraphType
    {
        public IndividualInputType()
        {
            Field<StringGraphType>("email");
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<IntGraphType>("competencyScore");
            Field<IntGraphType>("currentLevel");
            Field<IntGraphType>("pointsToNext");
        }
    }
}
