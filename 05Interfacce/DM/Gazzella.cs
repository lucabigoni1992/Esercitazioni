using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05Interfacce.DM.Interfacce;

namespace _05Interfacce.DM
{
    internal class Gazzella : IAnimale, IErbivoro
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public Gazzella()
        {
            Nome = "Gazzella";
            Specie = "Mammifero";
        }
        public Gazzella(string nome, string specie)
        {
            Nome = nome;
            Specie = specie;
        }
        public void Mangia()
        {
            Console.WriteLine("La gazzella mangia erba");
        }

        public void Suono()
        {
            Console.WriteLine("La gazzella emette un verso");
        }

        public void PiantaPreferita()
        {
            Console.WriteLine("La gazzella l'erba");
        }
    }
}
