using System;
using System.Web.Caching;
using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;

namespace Christoc.Modules.TuanMVC.Models
{
    public class Test_Author
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
