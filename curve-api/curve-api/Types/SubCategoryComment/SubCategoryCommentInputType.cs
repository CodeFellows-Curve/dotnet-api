using GraphQL.Types;

namespace curve_api.Types.SubCategoryComment
{
    public class SubCategoryCommentInputType : InputObjectGraphType
    {
        public SubCategoryCommentInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("subject");
            Field<StringGraphType>("content");
        }
    }
}
