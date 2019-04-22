using System;
using System.Collections.Generic;

namespace Laboratorio5
{
    class Calculadora
    {
        public int aux;
        public int a;
        public int b;
        private int numero;//que se usará para guardar el resultado actual.
        public Calculadora(int numero)
        {
            this.numero = numero;
            List<ICalcular> calculadoras = new List<ICalcular>();
        }
        public int GetNumero()
        {
            return numero;
        }
        public List<ICalcular> calculadora = new List<ICalcular>();

        public int Calcular(int numero)
        {
            return this.numero = numero;
        }

        public int Calcularelevadoa2(int numero)
        {
            return ((int)Math.Pow(numero, 2));
        }
        public int Calcularelevado3(int numero)
        {
            return ((int)Math.Pow(numero, 3));
        }
        public int Calcularsuma5(int numero)
        {
            return numero + 5;
        }


        public int CalcularFibonacci(int numero)
        {
            a = numero + 1;
            b = numero - 1;
            aux = a;
            b = aux + a;
            return b;

        }

      
        public int CalcularFactorial(int numero)
        {
            int fact = 1;
            for (int i = 1; i <= numero; i++)
            {
                fact *= i;
            }
            return fact;
        }

    }
}

