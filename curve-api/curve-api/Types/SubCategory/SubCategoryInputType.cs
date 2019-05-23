using GraphQL.Types;

namespace curve_api.Types.SubCategory
{
    public class SubCategoryInputType : InputObjectGraphType
    {
        public SubCategoryInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("subCategoryName");
            Field<IntGraphType>("score");
            Field<IntGraphType>("categoryId");

        }
    }
}
