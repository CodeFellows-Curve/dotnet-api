using curve_api.Models;
using curve_api.Models.Interfaces;
using curve_api.Types.Individual;
using GraphQL.Types;
using System;

namespace curve_api.Mutations
{
    public class IndividualMutation : ObjectGraphType
    {
        public IndividualMutation(IIndividualManager individualManager)
        {
            Field<IndividualType>(
                "addIndividual",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IndividualInputType>> { Name = "individual" }),
                resolve: context =>
                {
                    var individual = context.GetArgument<Individual>("individual");
                    return individualManager.CreateIndividual(individual);
                });

            Field<IndividualType>(
                "editIndividual",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IndividualInputType>> { Name = "individual" }),
                resolve: context =>
                {
                    var individual = context.GetArgument<Individual>("individual");
                    return individualManager.UpdateIndividual(individual);
                });

            Field<IndividualType>(
                "deleteIndividual",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return individualManager.DeleteIndividual(id);
                });
        }
    }
}
