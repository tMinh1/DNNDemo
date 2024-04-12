using DotNetNuke.Web.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Christoc.Modules.TuanMVC.Components
{
    public class RouterMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
            "TuanMVC",
            "default",
            "{controller}/{action}",
            new[] { "Christoc.Modules.TuanMVC.Services" });
        }

    }
}
