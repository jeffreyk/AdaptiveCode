﻿using Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    public class ComponentClient 
    {
        public void Run(IComponent component)
        {
            Debug.Assert(component != null);

            component.DoSomething();
        }
    }
}
