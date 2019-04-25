using System;
using System.Collections;
using System.Collections.Generic;

namespace Laboratorio6
{
    public class AgregarSerie : Serie
    {


        public AgregarSerie() : base(Nombserie, Temporada, Año, Estado)
        {
            SetSerie(new List<Serie>());
            List.Add(Nombserie);

            List.Add(Estado);
        }

        public static int Temporada { get; }
        public static int Año { get; }
        public static string Estado { get; }
        public static string Nombserie { get; }
        public static int Atemporada { get; }

        private void SetSerie(List<Serie> list)
        {
            throw new NotImplementedException();
        }

    }
}