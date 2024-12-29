using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Stacks
{
    public class StackPR
    {
        public void Main()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Elemento en la parte superior: " + stack.Peek());
         
            Console.WriteLine("Elemento eliminado: " + stack.Pop());

            Console.WriteLine("Cantidad de elementos en la pila: " + stack.Count);
        }
    }
}
