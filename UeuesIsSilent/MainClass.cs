using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UeuesIsSilent
{
    class MainClass
    {
        public string userChoice;
        static ScuffedBus scuffedBus = new ScuffedBus();
        static MainClass menu = new MainClass();
        static void Main(string[] args)
        {
            //    LegMedPrimaTal legPri = new LegMedPrimaTal();
            //    legPri.Leg();
            //    FiFo fifo = new FiFo();
            //    fifo.FirstInFirstOut();
            while (true) {
                Console.Clear();
                Console.WriteLine("UserChoice for menu");
                Console.WriteLine("1: add bus");
                Console.WriteLine("2: remove bus (bus left)");
                Console.WriteLine("3: next bus to leave");
                Console.WriteLine("4: print all busses");
                menu.userChoice = Console.ReadLine();
                menu.Menu();

                Console.ReadLine();
            }
        }
        public void Menu()
        {
            string bigBus;
            Console.Clear();
            switch (userChoice)
            {
                case "1":
                    scuffedBus.AddItem();
                    break;
                case "2":
                    bigBus = scuffedBus.RemoveBus();
                    Console.WriteLine(bigBus);
                    break;
                case "3":
                    bigBus = scuffedBus.NextToleave();
                    Console.WriteLine(bigBus);
                    break;
                case "4":
                    bigBus = scuffedBus.PrintAllBusses();
                    Console.WriteLine(bigBus);
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }

    }
}
