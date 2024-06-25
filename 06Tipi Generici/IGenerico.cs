using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Tipi_Generici
{
    //<t> è un tipo generico quindi può essere un qualsiasi tipo
    internal interface IGenerico<T>
    {
        T Somma(T elemento, T elemento2);
        void Stampa(T elemento);
    }
}
