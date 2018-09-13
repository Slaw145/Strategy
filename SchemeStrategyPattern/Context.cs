using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Context
    {
        private Interface _strategy;

        public Context(Interface strategy)
        {
            _strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.Algorithm();
        }
    }
}
