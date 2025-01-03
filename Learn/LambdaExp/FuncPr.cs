using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.LambdaExp
{
    internal class FuncPr
    {
        public void GetMain()
        {
            // Retorna algo 

            // En este caso es int
            Func<int> getRandomNumber = () => new Random().Next(1, 100);

            Console.WriteLine($"Ramdom Number: {getRandomNumber()}");

            // ingresan 2 str retorna un int
            Func<string, string, int> counter = (word1, word2) => word1.Length + word2.Length;
            Console.WriteLine($"Counter: {counter("Hola", "Saray")}");

            // ingresan 3 int retorna un str
            Func<int, int, int, string> volum = (height, width, depth) =>
            {
                int vol = height * width * depth;
                return $"El volumen es {vol}";

            };
            Console.WriteLine(volum(4, 5, 7));
            
        }
    }
}
