using GraphQL.Types;


namespace curve_api.Types.Review
{
    public class ReviewInputType : InputObjectGraphType
    {
        public ReviewInputType()
        {
            Field<DateTimeGraphType>("reviewDate");
            Field<IntGraphType>("individualId");
            Field<IntGraphType>("overallScore");
        }
    }
}
