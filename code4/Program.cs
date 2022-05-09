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

            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Calcular Impuesto");
                    Console.WriteLine("2. Calcular Descuento");
                    Console.WriteLine("3. Aplicar  Descuento");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Elige una de las opciones");

                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has elegido la opción 1: Calcular impuesto");
                            
                            Console.WriteLine("Introduzca el precio de un producto:");
                            string x = Console.ReadLine();
                            double value = Convert.ToDouble(x);

                            Console.WriteLine("Introduzca el iva:");
                            int iva =Int32.Parse(Console.ReadLine());

                             double suma = cal_impuesto(value, iva); //llamada funcion
                           

                            Console.WriteLine("El precio con IVA es de: ${0}", suma);
                            Console.WriteLine("Presiona cualquier tecla para volver al menu.");
                            Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Has elegido la opción 2: Calcular Descuento");
                            
                            double cantidad, descuento, des,r;
                            
                            Console.Write("Ingresa el precio: ");
                            cantidad = double.Parse(Console.ReadLine());
                            
                            Console.Write("Ingresa precio con descuento: ");
                            des = double.Parse(Console.ReadLine());

                          
                            descuento=cal_descuento(des,cantidad);

                            Console.WriteLine("Valor del descuento: {0} %",descuento );
                            
                            Console.WriteLine("Presiona cualquier tecla para volver al menu.");
                            break;

                        case 3:
                            Console.WriteLine("Has elegido la opción 3: Aplicar  Descuento");
                            

                            Console.Write("Ingresa el precio: ");
                            cantidad = float.Parse(Console.ReadLine());

                            Console.Write("Ingresa el descuento a aplicar: ");
                            des = float.Parse(Console.ReadLine());


                            descuento = apli_descuento(des, cantidad);

                            Console.WriteLine("Precio con descuento: ${0}", descuento);

                            Console.WriteLine("Presiona cualquier tecla para volver al menu.");
                            break;
                        case 4:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
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

            double Iva = (iva * value / 100);
            double suma = value - Iva;
            
            return suma;

        }
        //Declaracion Funcion 2
        public static double cal_descuento(double des, double cantidad)
        {
            
          double  r = cantidad / des;
          double   descuento = 100 / r;

          return descuento;

        }
        //Declaracion Funcion 3
        public static double apli_descuento(double des, double cantidad)
        {
            double r = 100 - des ;
            r = r * 0.01;
            double descuento = r * cantidad;

            return descuento;
         }
    }
}