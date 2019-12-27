using api_graphql2.Models;
using api_graphql2.Types;
using GraphQL.Types;

namespace api_graphql2 {
    public class Mutation : ObjectGraphType
    {
        public Mutation() {
            Field<ClubType>(
                "createClub",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ClubInputType>> { Name = "club" }
                ),
                resolve: context =>
                {
                    var item = context.GetArgument<Club>("club");
                    return item;
                }
            );
        }
    }
}