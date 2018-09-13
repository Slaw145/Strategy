using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class ImplementationOne : Interface
    {
        public void Algorithm()
        {
            Console.WriteLine("Called ImplementationOne");
        }
    }
}
