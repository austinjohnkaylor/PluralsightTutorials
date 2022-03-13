using GraphQL;
using GraphQL.Types;

namespace CarvedRock.Api.GraphQL
{
    public class CarvedRockSchema: Schema
    {
        public CarvedRockSchema(IDependencyResolver resolver): base(resolver) // IDependencyResolver is an abstraction built on-top of whatever DI you are using. In this case, ASP.NET Core's DI container.
        {           
            Query = resolver.Resolve<CarvedRockQuery>();
        }
    }
}