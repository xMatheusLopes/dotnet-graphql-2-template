using System.Collections.Generic;
using api_graphql2.Models;
using api_graphql2.Types;
using GraphQL.Types;

namespace api_graphql2 {
    public class Query : ObjectGraphType
    {
        public Query() {
            
            Field<ListGraphType<ClubType>>(
                name: "clubs",
                resolve: context =>
                {
                    var club = new Club();
                    return club.getClubs();
                }
            );
        }
    }
}