using GraphQL.Types;

namespace curve_api.Types.CategoryComment
{
    public class CategoryCommentInputType : InputObjectGraphType
    {
        public CategoryCommentInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("subject");
            Field<StringGraphType>("content");
        }
    }
}
