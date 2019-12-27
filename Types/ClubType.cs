using api_graphql2.Models;
using GraphQL.Types;

namespace api_graphql2.Types 
{
    public class ClubType : ObjectGraphType<Club>
    {
        public ClubType() 
        {
            Field(i => i.ID);
            Field(i => i.Name);
        }
    }
}