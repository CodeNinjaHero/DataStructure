using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learns.Queue
{
    internal class QueuePR
    {
        public void GetMain()
        {
            
            Queue<string> queue = new Queue<string>();

            
            queue.Enqueue("Persona 1");
            queue.Enqueue("Persona 2");
            queue.Enqueue("Persona 3");

           
            Console.WriteLine("Elemento al frente: " + queue.Peek()); 

            
            while (queue.Count > 0)
            {
                Console.WriteLine("Atendiendo: " + queue.Dequeue());
            }
        }
    }
}
