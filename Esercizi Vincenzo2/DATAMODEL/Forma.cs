using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Vincenzo2.DATAMODEL
{
    internal class Forma
    {
        public string Colore;
        public string NomeForma;

        public Forma(string Color,string name) 
        { 
            Colore= Color;
            NomeForma= name;
        
        }
        /*
         Vorrei vedere due metodi virtuali che vengono poi sovrascritti nelle classi figlie
        -uno per il perimetro
        -uni per l'area
         */
    }
}
