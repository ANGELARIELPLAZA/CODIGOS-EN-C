using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class code2
    {
        static void Main(string[] args)
        {   //Creamos una lista de tipo string para almacenar las materias de manera
            //local(main) 
            List<string> materias = new List<string>();
            //Creamos  dos variables de tipo entero de manera local(main)
            int num, i;
            //Creamos una variable de tipo string de manera local
            string materia;
            //Imprimimos un mensaje de cuantas materias desea agregar
            Console.Write("¿Cuantas materias desea agregar?");
            //leemos el dato ingresado y lo convertimos a entero posterior a ello
            // lo almacenamos en num
            num = Int32.Parse(Console.ReadLine());
            
           /*utilizamos un for para poder almacenar en la lista que creamos,
           el nombre de las materias
           
            1. inicializamos la variable i con el valor de 0
            2. comparamos si i es menor a num(el numero de materias a agregar)
            3. si la condicion anterior se cumple entonces entramos en el for y ejecutamos
                las instrucciones, cada vez que se ejecute el bloque de instrucciones 
                se ira aumenando el contador i (+1) y se detendra hasta que el i sea mayor a num 
            */

            
            for ( i = 0; i < num; i++)
            {
                //Imprimimos un mensaje de el nombre de las materias
                Console.Write("Ingrese el nombre de las materias: ");
                //Almacenamos lo que el usuario ingreso a la variable materia
                materia = Console.ReadLine();
                //Agregamos la materia a la lista materias
                materias.Add(materia);

            }
            /*
             Posterior a ello se ejecutara otro ciclo for este con la finalidad de
            poder recorrer toda la lista  e imprimirla 
             */
            for ( i = 0; i < num; i++)
            {
                /*Imprimimos la lista materias y la variable i se encarga de cambiar conforme
                cada vez que la i aumenta haciendo que recorra los indices de la lista e 
                imprimiendola*/
                Console.WriteLine(materias[i]);
            }
            //Espera a que se presione alguna tecla y posterior enter para salir
            Console.ReadKey();
        }
    }
}