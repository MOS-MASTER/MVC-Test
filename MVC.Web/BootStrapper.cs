
using StructureMap;
using CS.Data;

namespace CS.Web
{
    public static class Bootstrapper
    {

        public static void ConfigureStructureMap()
        {
            StructureMapConfiguration.AddRegistry(new DbServiceRegistry());
            StructureMapConfiguration.AddRegistry(new WebRegistry());
        }
    }
}