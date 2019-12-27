using System;
using GraphQL;
using GraphQL.Types;

namespace api_graphql2
{
    public class GlobalSchema : Schema
    {
        public GlobalSchema(Query query, Mutation mutation)
        {
            Query = query;
            Mutation = mutation;
        }

    }
}
