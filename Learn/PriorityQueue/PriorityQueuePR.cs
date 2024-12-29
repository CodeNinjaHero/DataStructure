using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Learns.PriorityQueue
{
    public class PriorityQueuePR
    {
        public void GetMain()
        {
            PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();

            priorityQueue.Enqueue("Tarea urgente", 1);
            priorityQueue.Enqueue("Tarea normal", 1);
            priorityQueue.Enqueue("Tarea importante", 2);

            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Peek()); 
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Count);
        }
    }

}
