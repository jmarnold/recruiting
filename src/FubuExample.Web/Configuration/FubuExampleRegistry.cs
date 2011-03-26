using FubuMVC.Core;

namespace FubuExample.Web.Configuration
{
    public class FubuExampleRegistry : FubuRegistry
    {
        public FubuExampleRegistry()
        {
            Applies
                .ToThisAssembly();


        }
    }
}