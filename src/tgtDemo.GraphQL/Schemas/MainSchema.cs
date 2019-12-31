using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using tgtDemo.Queries.Container;

namespace tgtDemo.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}