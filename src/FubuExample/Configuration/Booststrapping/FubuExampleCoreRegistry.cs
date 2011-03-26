using StructureMap.Configuration.DSL;

namespace FubuExample.Configuration.Booststrapping
{
    public class FubuExampleCoreRegistry : Registry
    {
        public FubuExampleCoreRegistry()
        {
            Scan(x =>
                     {
                         x.TheCallingAssembly();
                         x.LookForRegistries();
                     });
        }
    }
}