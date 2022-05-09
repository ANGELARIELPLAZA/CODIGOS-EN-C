using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class code2
    {
        static void Main(string[] args)
        {

            Console.Write("¿Cual es la temperatura actual? ");
            string temp = Console.ReadLine();
            float value = float.Parse(temp, CultureInfo.InvariantCulture.NumberFormat);
            
            if ( value > 20)
            {
                Console.WriteLine(value);
                Console.Write("El clima es caluroso");           
            }
            else if ( value < 20)
            {
                Console.WriteLine(value);
                Console.Write("El clima es frio");
            }


            Console.ReadKey();
        }
    }
}