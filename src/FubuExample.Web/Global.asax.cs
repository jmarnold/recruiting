using System;
using System.Web.Routing;
using FubuExample.Web.Configuration;
using FubuExample.Web.Configuration.Bootstrapping;
using FubuMVC.Core;
using FubuMVC.StructureMap;

namespace FubuExample.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            FubuApplication
                .For<FubuExampleRegistry>()
                .StructureMapObjectFactory(x => x.AddRegistry<FubuExampleWebCoreRegistry>())
                .Bootstrap(RouteTable.Routes);
        }
    }
}