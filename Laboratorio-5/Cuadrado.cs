using System;
namespace Laboratorio5
{
    public class Cuadrado : ICalcular
    {
        int ICalcular.Calcular() => throw new NotImplementedException();

        public int Calcular()
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            return (int)Math.Pow(numero, 2);

        }
        

    }
}
