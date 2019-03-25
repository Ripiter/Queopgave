using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UeuesIsSilent
{
    class Bus
    {
        string color;
        int busNumber;
        int peopleInBus;
        string destination;

        #region Get, set and properties
        public static Queue<Bus> Busses{
            get
            {
                return busses;
            }
            set
            {
                busses = value;
            }

        }
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        public int BusNumber
        {
            get
            {
                return this.busNumber;
            }
            set
            {
                this.busNumber = value;
            }
        }
        public int PeopleInBus
        {
            get
            {
                return this.peopleInBus;
            }
            set
            {
                this.peopleInBus = value;
            }
        }
        public string Destination
        {
            get
            {
                return this.destination;
            }
            set
            {
                this.destination = value;
            }
        }
        #endregion

        static Queue<Bus> busses = new Queue<Bus>();

        public Bus(string color, int busNumber, int peopleInBus, string destination)
        {
            this.color = color;
            this.busNumber = busNumber;
            this.peopleInBus = peopleInBus;
            this.destination = destination;
            busses.Enqueue(this);
        }
    }
}
