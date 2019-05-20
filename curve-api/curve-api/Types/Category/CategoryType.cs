using GraphQL.Types;

namespace curve_api.Types.Category
{
    public class CategoryType : ObjectGraphType<Models.Category>
    {
        public CategoryType()
        {
            Field(x => x.Name);
            Field(x => x.CategoryName);
            Field(x => x.OverallScore);
            Field(x => x.ReviewId);
        }
    }
}
