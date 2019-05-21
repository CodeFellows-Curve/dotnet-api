using curve_api.Models.Interfaces;
using curve_api.Types.Individual;
using GraphQL.Types;

namespace curve_api.Queries
{
    public class IndividualQuery : ObjectGraphType
    {
        public IndividualQuery(IIndividualManager individualManager)
        {
            Field<ListGraphType<IndividualType>>(
                "individuals",
                resolve: context => individualManager.GetAllIndividuals());

            Field<IndividualType>(
                "individual",
                arguments: new QueryArguments(new QueryArgument<StringGraphType> { Name = "name" }),
                resolve: context => individualManager.GetIndividualByName(context.GetArgument<string>("name")));
        }
    }
}
