﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Observer
{
    internal interface IObserver
    {
        public void Update(string status);
    }
}
