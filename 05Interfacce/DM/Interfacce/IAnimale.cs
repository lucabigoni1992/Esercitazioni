using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Interfacce.DM.Interfacce
{
    public interface IAnimale
    {
        string Nome { get; set; }
        string Specie { get; set; }
        void Suono();
        void Mangia();

    }
}
