using System;
using System.Collections.Generic;
using System.Text;

namespace TransportToTheAirport
{
    class CityBus : StrategyOfTransport
    {
        public override void Transport()
        {
            Console.WriteLine("Client transported by: "+GetType().Name+"\n");
        }
    }
}
