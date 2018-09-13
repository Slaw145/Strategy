using System;

namespace TransportToTheAirport
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportToAirport transporttoairport;

            Console.WriteLine("Client wants to be transported by CityBus");

            transporttoairport = new TransportToAirport(new CityBus());
            transporttoairport.Transport();

            Console.WriteLine("Client wants to be transported by Car");

            transporttoairport = new TransportToAirport(new Car());
            transporttoairport.Transport();

            Console.WriteLine("Client wants to be transported by Taxi");

            transporttoairport = new TransportToAirport(new Taxi());
            transporttoairport.Transport();

            Console.ReadKey();
        }
    }
}
