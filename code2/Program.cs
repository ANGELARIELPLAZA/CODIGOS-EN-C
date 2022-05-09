using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class code2
    {
        static void Main(string[] args)
        {
            List<string> materias = new List<string>();
            int num, i;
            string materia;
            Console.Write("¿Cuantas materias desea agregar?");
            num = Int32.Parse(Console.ReadLine());
            
            for ( i = 0; i < num; i++)
            {
                Console.Write("Ingrese el nombre de las materias: ");
                materia = Console.ReadLine();

                materias.Add(materia);

            }

            for ( i = 0; i < num; i++)
            {
                Console.WriteLine(materias[i]);
            }

            Console.ReadKey();
        }
    }
}