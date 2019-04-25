using System;
using System.Collections.Generic;

namespace Laboratorio6
{
    public class MostrarSerie: Serie
    {


        public MostrarSerie() : base( Nombserie, Temporada, Año, Estado)
        {
            SetSerie(new List<Serie>());
        }

        public static int Temporada { get; }
        public static int Año { get; }
        public static string Estado { get; }
        public static string Nombserie { get; }

        private void SetSerie(List<Serie> list)
        {
            throw new NotImplementedException();
        }

    }
}
