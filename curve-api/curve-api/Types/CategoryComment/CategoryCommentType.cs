using GraphQL.Types;

namespace curve_api.Types.CategoryComment
{
    public class CategoryCommentType : ObjectGraphType<Models.CategoryComment>
    {
        public CategoryCommentType()
        {
            Field(x => x.Id);
            Field(x => x.UserId);
            Field(x => x.CategoryId);
            Field(x => x.Subject);
            Field(x => x.Content);
        }
    }
}
