using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Learn.LambdaExpr
{
    internal class Predicate
    {

        public void GetMain()
        {
            // Ejemplo 2: Usar una expresión lambda como predicado
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Usamos una expresión lambda en lugar de un método nombrado
            int result = numbers.Find(number => number > 3);

            Console.WriteLine(result); // Salida: 4


            // Ejemplo 3: Filtrar elementos con FindAll
            List<int> evenNumbers = numbers.FindAll(number => number % 2 == 0);

            Console.WriteLine(string.Join(", ", evenNumbers)); // Salida: 2, 4
        }
    }
}
