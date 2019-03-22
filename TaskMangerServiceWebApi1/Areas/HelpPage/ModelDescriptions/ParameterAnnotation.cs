using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskMangerServiceWebApi1.Areas.HelpPage.ModelDescriptions
{
    public class ParameterAnnotation
    {
        public Attribute AnnotationAttribute { get; set; }

        public string Documentation { get; set; }
    }
}