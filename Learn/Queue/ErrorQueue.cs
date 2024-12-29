using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Queue
{
    public class ErrorQueue : Exception
    {
        public ErrorQueue() : base("No hay elementos") => Console.WriteLine(Message);
        public ErrorQueue(string message) : base(message) => Console.WriteLine(message);
    }
}
