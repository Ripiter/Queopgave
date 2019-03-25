using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UeuesIsSilent
{
    class FiFo
    {
        public void FirstInFirstOut()
        {
            Queue<Guest> guests = new Queue<Guest>();
            guests.Enqueue(new Guest() { age = 25, Name = "John" });
            guests.Enqueue(new Guest() { age = 24, Name = "Barbara" });
            guests.Enqueue(new Guest() { age = 24, Name = "Phil" });
            guests.Enqueue(new Guest() { age = 23, Name = "Fred" });
            guests.Enqueue(new Guest() { age = 26, Name = "Hannah" });
            guests.Enqueue(new Guest() { age = 27, Name = "Cindy" });

            Console.WriteLine("Full list of Q");
            foreach (Guest guest in guests)
            {
                Console.WriteLine("{0}, {1}",guest.Name,guest.age);
            }

            Guest firstToLeave = guests.Dequeue();

            Console.WriteLine(string.Format("First to leave: {0}", firstToLeave.Name));
            Console.WriteLine("Guest list after the first goodbye");
            foreach (Guest guest in guests)
            {
                Console.WriteLine("{0}, {1}", guest.Name, guest.age);
            }


            Guest soonToLeave = guests.Peek();
            Console.WriteLine("Guest that will leave next: {0}",soonToLeave.Name);


            Console.ReadLine();
        }
    }
    //I know that i should not make a class like but,
    //It seems like overkill to make a new page for guest class
    public class Guest
    {
        public string Name { get; set; }
        public int age { get; set; }
    }
}
