﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Models
{
    public class NameAttribute : Attribute
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public NameAttribute(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
