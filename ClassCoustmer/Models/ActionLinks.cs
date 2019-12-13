using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassCoustmer.Models
{
    public class ActionLinks
    {
        internal readonly object ActionLink;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}