using curve_api.Mutations;
using curve_api.Queries;
using GraphQL;

namespace curve_api.Schema
{
    public class CurveSchema : GraphQL.Types.Schema
    {
        public CurveSchema(IDependencyResolver resolver)
            :base(resolver)
        {
            Query = resolver.Resolve<IndividualQuery>();
            Mutation = resolver.Resolve<IndividualMutation>();
        }
    }
}
