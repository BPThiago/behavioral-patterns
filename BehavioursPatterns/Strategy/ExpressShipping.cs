using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Strategy
{
    internal class ExpressShipping : IShippingStrategy
    {
        public int Calculate(int w)
        {
            return w / 4;
        }
    }
}
