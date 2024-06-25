using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _06Tipi_Generici
{
    internal class Generico<T> : IGenerico<T>
    {

        public T Somma(T elemento, T elemento2)
        {
            if (elemento is int)
                return (T)(object)((int)(object)elemento + (int)(object)elemento2);
            else if (elemento is string)
                return (T)(object)((string)(object)elemento + (string)(object)elemento2);
            else
                throw new Exception("Tipo non supportato");
        }

        public void Stampa(T elemento)
        {
            if (elemento is int)
                 Console.WriteLine((T)(object)((int)(object)elemento ));
            else if (elemento is string)
                 Console.WriteLine( (T)(object)((string)(object)elemento));
            else
                throw new Exception("Tipo non supportato");
        }
    }
}
