//CODIGO 1: nombre de la instruccion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class code1
    {   
        //inicializacion de varibale de manera global
        static long num; //variable long 

        //Funcion operacion tipo long, donde al mandarla a llamar hay que ingresar un numero (n) 
        static long operacion(int n)
        {
           //Formula para sacar el cubo de un numero
            num = n*n*n; //opcion 1
            num = n*3;   //opcion 2
            //Retorna el resultado obtenido al metodo
            return num; 
        }

        //Funcion main , lo que este dentro de aqui se ejecuta y manda a llamar otras funciones
        static void Main()
        {
            /* ciclo for con inicializacion i=1
            mientras i sea menor a 11 se ejecutara
            i++ significa que cada vez que se ejecute el contador i aumentara 1+ */

            for (int i = 1; i < 11; i++)
            {
            /*Esta instruccion imprime en pantalla  un mensaje e igual la variable i,
            para saber cuantas veces se ha ejecutado este fragmento de codigo*/
            Console.Write("{0}. Ingrese un numero para mostrar su valor al cubo: ", i);
            /* inicializacion de variable int de manera local (dentro de main),
               int parse convierte lo que el usuario introduzca por consola a entero
             primero lee,luego convierte y por ultimo almacena*/
            int n = int.Parse(Console.ReadLine());
            /*Mandamos a llamar a la funcion operacion y le pasamos el parametro n 
            nos retorna n y posterior a ello lo almacena en la variable result de tipo long*/
            long result = operacion(n);
            /*imprime en pantalla con salto de linea mensaje con el numero introducido por el usuario 
            asi como su numero al cubo
             */
            Console.WriteLine("El cubo de {0} es {1} ",n,result);

            }
            //Espera a que se presione una tecla para continuar y luego enter para salir
            Console.ReadKey();
        }
    }
}
