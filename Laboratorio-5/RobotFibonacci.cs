using System;

namespace Laboratorio5
{
    public class RobotFibonacci : ICalcular
    {
        int ICalcular.Calcular() => throw new NotImplementedException();
        public int aux;
        public int a;
        public int b;

        public int Calcular()
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            a = numero + 1;
            b = numero - 1;
            aux = a;
            b = aux + a;
            return b;

        }
    }
}