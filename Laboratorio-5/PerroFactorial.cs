using System;

namespace Laboratorio5
{
    public class PerroFactorial : ICalcular
    {
        int ICalcular.Calcular() => throw new NotImplementedException();
        public int aux;
        public int a;
        public int b;

        public int Calcular()
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= numero; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
