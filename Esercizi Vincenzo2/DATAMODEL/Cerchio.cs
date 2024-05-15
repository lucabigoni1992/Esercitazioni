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
        public double Area()
        {
            double Area = (Raggio * Raggio) * PI;
            return Area;

        }

        public double Perimetro()
        {


        }


    }
}
