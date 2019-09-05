using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Data.Strategy
{
    public class Context
    {
        private readonly Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContentInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
