using StructureMap.Attributes;
using StructureMap.Configuration.DSL;
using CS.Data.DataAccess.SqlServer;

namespace CS.Data
{
    public class DbServiceRegistry : Registry
    {
        protected override void configure()
        {
            ForRequestedType<LinqTestDataContext>()
                .TheDefaultIs(() => new LinqTestDataContext())
                .CacheBy(InstanceScope.Hybrid);
        }
    }
}
