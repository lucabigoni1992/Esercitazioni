using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.DM
{
    internal class Studente : Persona
    {
        public List<string> Materie;
        public string CorsoDiStudi;
        public List<int> Voti;
        public Studente()
        {
            this.Test2();//public
            this.Test3();//intenal (sotto il solito namespace ConsoleApp5)
            this.Test4();//PROTECTED è è visbile solo alle classi che vanno a ereditare la classe base ma no all'esterno 
        }
    }
}
