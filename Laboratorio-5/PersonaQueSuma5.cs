using System;
namespace Laboratorio5
{
    public class PersonaQueSuma5 : ICalcular
    {

        int ICalcular.Calcular() => throw new NotImplementedException();

        public int Calcular()
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            return numero + 5;
        }
    }


}
