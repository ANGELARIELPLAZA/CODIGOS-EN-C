
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class code1
    {
        static long num;

        static long operacion(int n)
        {
           
            num = n*n*n;
            
            return num;
        }


        static void Main()
        {
            
            for (int i = 1; i < 11; i++)
            {
            Console.Write("{0}. Ingrese un numero para mostrar su valor al cubo: ", i);
            int n = int.Parse(Console.ReadLine());
            long result = operacion(n);

            Console.WriteLine("El cubo de {0} es {1} ",n,result);

            }
            Console.ReadKey();
        }
    }
}
