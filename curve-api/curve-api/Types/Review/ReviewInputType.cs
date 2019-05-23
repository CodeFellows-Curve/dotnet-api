using GraphQL.Types;


namespace curve_api.Types.Review
{
    public class ReviewInputType : InputObjectGraphType
    {
        public ReviewInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("subject");
            Field<StringGraphType>("content");
        }
    }
}
