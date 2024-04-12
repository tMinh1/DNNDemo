using System;
using System.Web.Caching;
using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;

namespace Christoc.Modules.TuanMVC.Models
{
    public class Test_Books
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int? AuthorID { get; set; }

    }
}
