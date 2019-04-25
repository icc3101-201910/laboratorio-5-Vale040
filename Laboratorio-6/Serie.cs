using System;
using System.Collections.Generic;

namespace Laboratorio6
{
    public class Serie
    {
        public int año;
        public string estado;
        public List<Serie> serie;
        public string nombserie;
        public int temporada;
        public int atemporada;

        private List<Serie> GetSerie()
        {
            return serie;
        }

        private void SetSerie(List<Serie> value)
        {
            serie = value;
        }

        public Serie(string nombserie, int temporada, int atemporada, string estado)
        {
            while (true)
            {
                Console.WriteLine(" Nombre de la serie?");
                string Nombserie = Console.ReadLine();

                Console.WriteLine(" Temporada de la serie");
                int Temporada = int.Parse(Console.ReadLine());

                Console.WriteLine(" Año de temporada");
                int Atemporada = int.Parse(Console.ReadLine());

                Console.WriteLine(" Estado : VISTO- POR VER- EN PROGRESO");
                string Estado = Console.ReadLine();

                this.estado = Estado;
                this.nombserie = Nombserie;
                this.temporada = Temporada;
                this.atemporada = Atemporada;




            }

        }


    }
}



