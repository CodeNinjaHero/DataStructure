using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.LambdaExp
{
    internal class ActionPr
    {
        public void GetMain()
        {
            // No retorna nada
            Action<Object> print = a => Console.WriteLine(a);

            print(1);
            print("Tu y yo");
            print('S');
        }

    }
}
