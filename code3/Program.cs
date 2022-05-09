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
            //Imprime mensaje 
            Console.Write("¿Cual es la temperatura actual? ");
            //lee consola e almacena en variable temp  tipo string
            string temp = Console.ReadLine();
            //convierte la variable temp de string a flotante
            float value = float.Parse(temp, CultureInfo.InvariantCulture.NumberFormat);
            
            //evalua value  y compara si es mayor a 20
            if ( value > 20)
            { //si es menor a 20 imprime la temperatura
                Console.WriteLine(value);
              //imprime el mensaje de que el clima es caluroso
                Console.Write("El clima es caluroso");           
            }
            //evalua value  y compara si es menor a 20
            else if ( value < 20)
            {   // si  value es menor a 20
                // imprime la temperatura
                Console.WriteLine(value);
                //imprime el mensaje de que el clima es frio
                Console.Write("El clima es frio");
            }


            Console.ReadKey();
        }
    }
}