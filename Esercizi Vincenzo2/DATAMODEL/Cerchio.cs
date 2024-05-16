using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Vincenzo2.DATAMODEL
{
    internal class Cerchio:Forma
    {
        private const double PI = 3.14;
        public double Raggio;
        


        public Cerchio(string color,string nomef,double ragg):base(color,nomef)
        {
            Raggio = ragg;

        }
        #region
        public double GetRaggio(double rag)
        {
            if (Raggio == 0)
            {
                throw new Exception("Raggio uguale a 0");
            }
            return Raggio;
        }

        public void SetRaggio(double rag)
        {
            if (rag==0)
            { 
                throw new Exception("Impossibile inserire valore 0"); 
            }
            Raggio = rag;
        }

        #endregion
        internal double Diametro()
        {
            double Diametro = 2 * Raggio;
            return Diametro;
        }

        public override double Area()
        {
            double Area = (Raggio * Raggio) * PI;
            return Area;

        }

        public override double Perimetro()
        {
            double perimetro = 2 * (PI + Raggio);
            return perimetro;

        }


    }
}
