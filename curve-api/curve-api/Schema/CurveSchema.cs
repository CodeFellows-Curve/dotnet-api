using GraphQL;

namespace curve_api.Schema
{
    public class CurveSchema : GraphQL.Types.Schema
    {
        public CurveSchema(IDependencyResolver resolver)
            :base(resolver)
        {

        }
    }
}
