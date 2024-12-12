using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Strategy
{
    internal class ShippingCalculator
    {
        private IShippingStrategy _strategy;

        public ShippingCalculator(IShippingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IShippingStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Calculate(int w)
        {
            return _strategy.Calculate(w);
        }
    }
}
