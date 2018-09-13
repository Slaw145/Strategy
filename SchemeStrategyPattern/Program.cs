using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            context = new Context(new ImplementationOne());
            context.ContextInterface();

            context = new Context(new ImplementationTwo());
            context.ContextInterface();

            Console.ReadKey();
        }
    }
}
