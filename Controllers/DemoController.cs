using System;
using System.Linq;
using System.Web.Mvc;
using Christoc.Modules.TuanMVC.Components;
using Christoc.Modules.TuanMVC.Models;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Entities.Users;
using DotNetNuke.Framework.JavaScriptLibraries;

namespace Christoc.Modules.TuanMVC.Controllers
{
    [DnnHandleError]
    public class DemoController : DnnController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
