using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;

namespace TaskMangerServiceWebApi1.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}