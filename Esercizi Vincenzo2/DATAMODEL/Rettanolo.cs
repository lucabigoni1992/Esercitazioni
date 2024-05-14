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


        public double Perimetro(int bas, int altez)
        {
            double perimetro =(2 *bas) + (2*altez);
            return perimetro;
        }
        public double Area(int bas,int altez)
        {
            double are = bas * altez;
            return are;

        }

    }
}
