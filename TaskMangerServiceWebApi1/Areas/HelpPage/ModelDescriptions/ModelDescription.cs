using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskMangerServiceWebApi1.Areas.HelpPage.ModelDescriptions
{
    public abstract class ModelDescription
    {
        public string Documentation { get; set; }

        public Type ModelType { get; set; }

        public string Name { get; set; }
    }
}