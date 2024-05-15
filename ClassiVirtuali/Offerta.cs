using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiVirtuali
{
    internal class Offerta
    {
        public float Sconto;
        public string Tipologia;

        public Offerta(float sconto, string tipologia)
        {
            Sconto = sconto;
            Tipologia = tipologia;
        }


        public float CalcolaOfferta(float prezzo)
        {
            return prezzo * Sconto;
        }
        public virtual float CalcolaOffertaTipo2(float prezzo)
        {
            return prezzo * Sconto;
        }
    }
}
