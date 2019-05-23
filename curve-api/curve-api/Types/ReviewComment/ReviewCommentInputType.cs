using GraphQL.Types;

namespace curve_api.Types.ReviewComment
{
    public class ReviewCommentInputType : InputObjectGraphType
    {
        public ReviewCommentInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("subject");
            Field<StringGraphType>("content");
        }
    }
}
