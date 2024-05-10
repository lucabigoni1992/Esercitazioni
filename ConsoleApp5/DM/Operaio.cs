using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.DM
{
    //operaio v a ereditare tutte le proprietà e metodi publici interni o protected di Pesona e sono completamente usabili qua dento no quelli privati
    internal class Operaio: Persona
    {
        public List<string> Mansioni;
        public string Responsabile;
        public List<string> Specializzazoni;
        public Operaio()
        {
            this.Test2();//public
            this.Test3();//intenal (sotto il solito namespace ConsoleApp5)
            this.Test4();//PROTECTED è è visbile solo alle classi che vanno a ereditare la classe base ma no all'esterno 
        }
    }
}
