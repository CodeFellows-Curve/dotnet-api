using GraphQL.Types;

namespace curve_api.Types.Category
{
    public class CategoryInputType : InputObjectGraphType
    {
        public CategoryInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("categoryname");
            Field<IntGraphType>("overallscore");
        }
    }
}
