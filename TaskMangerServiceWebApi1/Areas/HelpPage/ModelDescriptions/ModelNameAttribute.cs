﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskMangerServiceWebApi1.Areas.HelpPage.ModelDescriptions
{
    
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, AllowMultiple = false, Inherited = false)]
        public sealed class ModelNameAttribute : Attribute
        {
            public ModelNameAttribute(string name)
            {
                Name = name;
            }

            public string Name { get; private set; }
        }
    }
