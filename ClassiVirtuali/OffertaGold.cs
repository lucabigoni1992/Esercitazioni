using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiVirtuali
{
    internal class OffertaGold : Offerta
    {
        public OffertaGold(float sconto, string tipologia) : base(sconto, tipologia)
        {
        }
        //shadowing si nascond e il metodo della classe base (ma esso continua a esistere)
       /* public float CalcolaOfferta(float prezzo)
        {
            return prezzo * (Sconto*2);
        }
       */
        //si sovrascrive il metodo della classe base
        public override float CalcolaOffertaTipo2(float prezzo) 
        {
            return prezzo * (Sconto*2);
        }
    }
}
