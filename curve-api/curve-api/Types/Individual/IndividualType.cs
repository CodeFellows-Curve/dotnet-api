using curve_api.Models.Interfaces;
using curve_api.Types.Review;
using GraphQL.Types;

namespace curve_api.Types.Individual
{
    public class IndividualType : ObjectGraphType<Models.Individual>
    {
        public IndividualType(IReviewManager reviewManager)
        {
            Field(x => x.Id);
            Field(x => x.Email);
            Field(x => x.Name);
            Field(x => x.Email);
            Field(x => x.CompetencyScore);
            Field(x => x.CurrentLevel);
            Field(x => x.PointsToNext);
            Field<ListGraphType<ReviewType>>("review",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "last" }),
                resolve: context => {
                    var lastItemsFilter = context.GetArgument<int?>("last");
                    return lastItemsFilter != null
                        ? reviewManager.GetAllByIndividualId(context.Source.Id, lastItemsFilter.Value)
                        : reviewManager.GetAllByIndividualId(context.Source.Id);
                });
        }
    }
}

