using api_graphql2.Models;
using GraphQL.Types;

namespace api_graphql2.Types 
{
    public class ClubInputType : InputObjectGraphType
    {
        public ClubInputType() 
        {
            Name = "ClubInput";
            Field<NonNullGraphType<IntGraphType>>("id");
            Field<NonNullGraphType<StringGraphType>>("name");
        }
    }
}