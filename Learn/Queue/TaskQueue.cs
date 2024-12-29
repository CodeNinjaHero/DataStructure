using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Learns.Queue;

namespace Learn.Queue
{
    public class TaskQueue<T>
    {
        Queue<T> queue = new Queue<T>();
        public void Add(T element)
        {
            queue.Enqueue(element);
        }

        public void Remove()
        {
            if (queue.Count > 0) {
                queue.Dequeue();
            } else new ErrorQueue("No hay elementos en la cola"); 

        }

        public void PrintQueue()
        {
            var temQueue = new Queue<T>(queue);
            if (temQueue.Count <= 0) new ErrorQueue();
            foreach (T element in temQueue)
            {
                Console.WriteLine(element);  
            }
        }

        public void GetMain()
        {
            

            var taskQueue = new TaskQueue<string>();

            taskQueue.Add("Tarea 1");
            taskQueue.Add("Tarea 2");
            taskQueue.Add("Tarea 3");
            taskQueue.Add("Tarea 4");
            taskQueue.Add("Tarea 5");

            Console.WriteLine("Todas las tareas: ");
            taskQueue.PrintQueue();


            // procesar
            taskQueue.Remove();
            taskQueue.Remove();
            taskQueue.Remove();
            taskQueue.Remove();

            Console.WriteLine("Todas las tareas: ");
            taskQueue.PrintQueue();

            taskQueue.Remove();
            taskQueue.Remove();

            Console.WriteLine("Todas las tareas: ");
            taskQueue.PrintQueue();
        }

    }
}
