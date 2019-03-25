using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UeuesIsSilent
{
    class ScuffedBus
    {
        public string RemoveBus()
        {
            string bus;
            try
            {
                Bus firstToleave = Bus.Busses.Dequeue();
                bus = string.Format("Busses with number: {0} left", firstToleave.BusNumber);
                return bus;
            }
            catch
            {
                bus = "No busses to remove";
                return bus;
            }
        }
        public string NextToleave()
        {
            string nLeave;
            try
            {
                Bus nextToLeave = Bus.Busses.Peek();
                nLeave = "next to leave " + nextToLeave.BusNumber;
                return nLeave;
            }
            catch
            {
                nLeave = "No bus to leave";
                return nLeave;
            }
        }
        public string PrintAllBusses()
        {
            string aBus;
            foreach (Bus busses in Bus.Busses)
            {
                aBus = "Bus color" + busses.Color + "buss number" + busses.BusNumber + "bus destination " + busses.Destination;

                return aBus;
            }
            aBus = "No busses left";
            return aBus; 
        }
        public void AddItem()
        {
            //inser input to create new bus start with u
            string uuserColor;
            int ubusNumber;
            int upeopleInBus;
            string udestintaion;
            Console.WriteLine("add new bus");
            try
            {
                Console.WriteLine("color");
                uuserColor = Console.ReadLine();
                Console.WriteLine("bus number");
                ubusNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("people in bus");
                upeopleInBus = int.Parse(Console.ReadLine());
                Console.WriteLine("destination");
                udestintaion = Console.ReadLine();

                Bus userBus = new Bus(uuserColor, ubusNumber, upeopleInBus, udestintaion);
            }
            catch
            {
                Console.WriteLine("Incorrect input");
                return;
            }
        }
    }
}
