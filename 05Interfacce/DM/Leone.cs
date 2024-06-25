using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05Interfacce.DM.Interfacce;

namespace _05Interfacce.DM
{
    internal class Leone : IAnimale, ICarnivori
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public Leone()
        {
            Nome = "Leone";
            Specie = "Flini";
        }
        public Leone(string nome, string specie)
        {
            Nome = nome;
            Specie = specie;
        }
        public void Mangia()
        {
            Console.WriteLine("Il leone mangia carne");
        }

        public void Suono()
        {
            Console.WriteLine("Il leone ruggisce");
        }

        public void PredaPreferita()
        {
            Console.WriteLine("La preda preferita del leone è la Gazzella");
        }
    }
}
