using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UeuesIsSilent
{
    class LegMedPrimaTal
    {
        public void Leg() 
        {
            Queue<string> name = new Queue<string>();
            Queue<DateTime> calendar = new Queue<DateTime>();
            Queue<int> sequence = new Queue<int>();
            name.Enqueue("Luke");
            name.Enqueue("Leila");
            name.Enqueue("Han");
            name.Enqueue("Yoda");
            name.Enqueue("Chewbaca");
            name.Enqueue("R2D2");

            sequence.Enqueue(2);
            sequence.Enqueue(3);
            sequence.Enqueue(5);
            sequence.Enqueue(7);
            sequence.Enqueue(11);

            int total = 0;

            while (sequence.Count > 0)
            {
                Console.WriteLine(sequence);
                sequence.Dequeue();
                total++;
            }

            Console.WriteLine(sequence.Count);
            Console.WriteLine(total);

            while(name.Count > 0)
            {
                string names = name.Dequeue();
                Console.WriteLine(names);
            }
            Console.ReadLine();
        }
    }
}
