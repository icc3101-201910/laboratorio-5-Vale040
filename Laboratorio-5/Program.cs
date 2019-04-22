using System;

namespace Laboratorio5
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("¿Que operación quiere realizar 1.El número que introduzca sume 5 - 2.EL número que introduzca entregue su fibonacci - 3. El número que introduzca entregue su factorial - 4. El número que introduzca entregue el número elevado a 3 - 5.El número que introduzca entregue el número elevado a 2  ");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    PersonaQueSuma5 personaquesuma5 = new PersonaQueSuma5();
                    Console.WriteLine( $"{personaquesuma5.Calcular()}");
                }
                else if (opcion == "2")
                {

                    RobotFibonacci robotfibonacci = new RobotFibonacci();
                    Console.WriteLine($"{robotfibonacci.Calcular()}");
                }
                else if (opcion == "3")
                {

                    PerroFactorial perrofactorial = new PerroFactorial();
                    Console.WriteLine($"{perrofactorial.Calcular()}");
                }
                else if (opcion == "5")
                {

                    Cubo cubo = new Cubo();
                    Console.WriteLine($"{cubo.Calcular()}");
                }
                else if (opcion == "6")
                {
                    Cuadrado cuadrado = new Cuadrado();
                    Console.WriteLine($"{cuadrado.Calcular()}");
                }

                else
                {
                    break;
                }

            }

        }
    }
}



