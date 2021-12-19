using System;
using System.Linq;

namespace programando_con_clases_c#
{
    class calculadora_de_area
    {
        public static string opcion;
        public static double pi = 3.14;
        class cuadro_calculador
        {
            public static int vradio;
            public static int vbase;
            public static int valtura;
            public static double resultado;

            public void areadeltriangulo()
            {
                Console.WriteLine("USTED ESCOGIO CALCULAR EL AREA DEL TRIANGULO\n");
                Console.WriteLine("Cual es la base:");
                vbase = Int32.Parse(Console.ReadLine());
                Double x = (Double)vbase;
                Console.WriteLine("Cual es la altura:");
                valtura = Int32.Parse(Console.ReadLine());
                Double y = (Double)valtura;
                resultado = (valtura * vbase) / 2;
                System.Console.WriteLine("El resultado es: " + resultado);
            }
            public void areadelcirculo()
            {
                Console.WriteLine("USTED ESCOGIO CALCULAR EL AREA DEL CIRCULO\n");
                Console.WriteLine("Cual es el radio:");
                vradio = Int32.Parse(Console.ReadLine());
                Double x = (Double)vradio;
                resultado = pi * (x * x);
                System.Console.WriteLine("El resultado es: " + resultado);
            }
            public void areadelrectangulo()
            {
                Console.WriteLine("USTED ESCOGIO CALCULAR EL AREA DEL RECTANGULO\n");
                Console.WriteLine("Cual es la base:");
                vbase = Int32.Parse(Console.ReadLine());
                Double x = (Double)vbase;
                Console.WriteLine("Cual es la altura:");
                valtura = Int32.Parse(Console.ReadLine());
                Double y = (Double)valtura;
                resultado = vbase * valtura;
                System.Console.WriteLine("El resultado es: " + resultado);
            }
            public void menu_opciones()
            {
                Console.WriteLine("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir\n");

            }

        }
        static void Main(string[] args)
        {
            cuadro_calculador llamartodo = new cuadro_calculador();
            string marco = string.Concat(Enumerable.Repeat("*", 50));
            System.Console.WriteLine(marco + "\n\t PROGRAMA PARA GEOMETRIA \n" + marco);
            Console.WriteLine("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir\n");
            while (opcion != "s")
            {
                System.Console.WriteLine("Ingrese su opcion: ");
                opcion = Console.ReadLine();
                System.Console.WriteLine();
                Console.Clear();
                if (opcion == "s")
                {
                    System.Console.WriteLine("\n\nGRACIAS POR USAR EL PROGRAMA DE CALCULO GEOMETRICO\n\n");
                    break;
                }
                else if (opcion == "c")
                {
                    llamartodo.areadelcirculo();
                    string marco2 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco2);
                    llamartodo.menu_opciones();
                }
                else if (opcion == "r")
                {
                    llamartodo.areadelrectangulo();
                    string marco3 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco3);
                    llamartodo.menu_opciones();
                }
                else if (opcion == "t")
                {
                    llamartodo.areadeltriangulo();
                    string marco4 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco4);
                    llamartodo.menu_opciones();
                }
                else
                {
                    System.Console.WriteLine("OH! AL PARECER OCURRIO UN ERROR!\nPOR FAVOR INTRODUZCA UNA DE LA LETRAS QUE SE LE MUESTRA EN EL MENU!");
                    System.Console.WriteLine("PARA CONTINUAR PRESIONE UNA TECLA!!!");
                    llamartodo.menu_opciones();
                }
            }
        }
    }
}
