using FubuExample.Configuration.Booststrapping;
using StructureMap.Configuration.DSL;

namespace FubuExample.Web.Configuration.Bootstrapping
{
    public class FubuExampleWebCoreRegistry : Registry
    {
        public FubuExampleWebCoreRegistry()
        {
            Scan(x =>
                     {
                         x.TheCallingAssembly();
                         x.LookForRegistries();
                     });

            IncludeRegistry<FubuExampleCoreRegistry>();
        }
    }
}