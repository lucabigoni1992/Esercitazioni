using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Vincenzo2.DATAMODEL
{
    internal class Rettanolo:Forma
    {

        public double Base;
        public double Altezza;


        public Rettanolo(string colore,string nomef,double b,double h):base(colore,nomef)
        {
            Base = b;
            Altezza = h;
        }

        #region SETGET

        public void SetBase(double bas)
        {
            if (bas==0)
            {
                throw new Exception("Valore non valido");
            }
            Base = bas;
        
        }
        public void SetAltezza(double h)
        {
            if (h == 0)
            {
                throw new Exception("Valore non valido");
            }
            Altezza=h;

        }

        public double GetBase()
        {  
            if(Base==0)
            { 
                throw new Exception("Valore uguale a 0 "); 
            }
            return Base; 
        }
        public double GetAltezza()
        {
            if (Altezza == 0)
            {
                throw new Exception("Valore uguale a 0 ");
            }
            return Altezza ;
        }

        #endregion

        //--------------------------PER LUCA------------------------------
        // gli overraid posso essere usati solo su metodi con gli stessi parametri di ingresso ?
        public override double Perimetro()
        {
            double perimetro =(2 *Base) + (2*Altezza);
            return perimetro;
        }
        public override double Area()
        {
            double are = Base * Altezza;
            return are;

        }

    }
}
