using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // un nome al singolare
    internal class Persona
    {
        //tutte le prorprietà che rappresentano quel'ente
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoDiNascita { get; set; }

        public Persona(string nome, string cognome, int annoDiNascita)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoDiNascita;
        }
        public Persona()
        {
            Nome = "";
            Cognome = "";
            AnnoDiNascita = 1990;
        }
    }
}
