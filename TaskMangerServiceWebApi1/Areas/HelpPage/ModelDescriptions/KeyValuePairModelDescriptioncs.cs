using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskMangerServiceWebApi1.Areas.HelpPage.ModelDescriptions
{
    public class KeyValuePairModelDescription : ModelDescription
    {
        public ModelDescription KeyModelDescription { get; set; }

        public ModelDescription ValueModelDescription { get; set; }
    }
}