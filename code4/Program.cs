using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicializamos la variable salir en tipo booleano y la establecemos
            //como falso
            bool salir = false;


            //mientras while no sea diferente se ejecuta
            while (!salir)
            {

                try
                {
                  
                    //imprime mensaje en forma de menu
                    Console.WriteLine("1. Calcular Impuesto");
                    Console.WriteLine("2. Calcular Descuento");
                    Console.WriteLine("3. Aplicar  Descuento");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    // lee,convierte y almacena 
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    //condicion de casos
                    switch (opcion)
                    {  //En caso de que introduzca 1
                        case 1:
                            //imprime mensaje 
                            Console.WriteLine("Has elegido la opción 1: Calcular impuesto");
                            //imprime mensaje 
                            Console.WriteLine("Introduzca el precio de un producto:");
                            // lee y almacena 
                            string x = Console.ReadLine();
                            // convierte y almacena 
                            double value = Convert.ToDouble(x);
                            //imprime mensaje 
                            Console.WriteLine("Introduzca el iva:");
                            // lee,convierte y almacena 
                            int iva =Int32.Parse(Console.ReadLine());

                             double suma = cal_impuesto(value, iva); //llamada funcion 1

                            //imprime mensaje 
                            Console.WriteLine("El precio con IVA es de: ${0}", suma);
                            Console.WriteLine("Presiona cualquier tecla para volver al menu.");
                            Console.ReadLine();
                            break;

                        //En caso de que introduzca 2
                        case 2:
                            //imprime mensaje 
                            Console.WriteLine("Has elegido la opción 2: Calcular Descuento");
                            //inicializa las variables 
                            double cantidad, descuento, des,r;
                            //imprime mensaje 
                            Console.Write("Ingresa el precio: ");
                            // lee,convierte y almacena 
                            cantidad = double.Parse(Console.ReadLine());
                            //imprime mensaje 
                            Console.Write("Ingresa precio con descuento: ");
                            // lee,convierte y almacena
                            des = double.Parse(Console.ReadLine());

                          
                            descuento=cal_descuento(des,cantidad);//llamada funcion 2
                            //imprime mensaje 
                            Console.WriteLine("Valor del descuento: {0} %",descuento );
                            //imprime mensaje 
                            Console.WriteLine("Presiona cualquier tecla para volver al menu.");
                            break;

                        //En caso de que introduzca 3
                        case 3:
                            //imprime mensaje 
                            Console.WriteLine("Has elegido la opción 3: Aplicar  Descuento");

                            //imprime mensaje 
                            Console.Write("Ingresa el precio: ");
                            // lee,convierte y almacena
                            cantidad = float.Parse(Console.ReadLine());
                            //imprime mensaje 
                            Console.Write("Ingresa el descuento a aplicar: ");
                            des = float.Parse(Console.ReadLine());


                            descuento = apli_descuento(des, cantidad);//llamada funcion 3

                            //imprime mensaje 
                            Console.WriteLine("Precio con descuento: ${0}", descuento);
                            //imprime mensaje 
                            Console.WriteLine("Presiona cualquier tecla para volver al menu.");
                            break;

                        //En caso de que introduzca 4
                        case 4:
                            //imprime mensaje 
                            Console.WriteLine("Has elegido salir de la aplicación");
                            //cambia la variable y sale del bucle while
                            salir = true;

                            break;

                        //En caso de que introduzca algo diferente
                        default:
                            //imprime mensaje 
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();

        }

        //Declaracion Funcion 1
        public static double cal_impuesto(double value, double iva)
        {   
            //bloque de ecuaciones
            double Iva = (iva * value / 100);
            double suma = value - Iva;
            
            return suma;

        }
        //Declaracion Funcion 2
        public static double cal_descuento(double des, double cantidad)
        {
          //bloque de ecuaciones
          double  r = cantidad / des;
          double   descuento = 100 / r;

          return descuento;

        }
        //Declaracion Funcion 3
        public static double apli_descuento(double des, double cantidad)
        {
            //bloque de ecuaciones
            double r = 100 - des ;
            r = r * 0.01;
            double descuento = r * cantidad;

            return descuento;
         }
    }
}