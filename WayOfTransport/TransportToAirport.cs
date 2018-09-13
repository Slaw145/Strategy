using System;
using System.Collections.Generic;
using System.Text;

namespace TransportToTheAirport
{
    class TransportToAirport
    {
        private StrategyOfTransport _strategy;

        public TransportToAirport(StrategyOfTransport strategy)
        {
            _strategy = strategy;
        }

        public void Transport()
        {
            _strategy.Transport();
        }
    }
}
