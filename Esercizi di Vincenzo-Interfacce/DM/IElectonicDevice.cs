using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_di_Vincenzo_Interfacce.DM
{
    internal interface IElectonicDevice
    {


        void TurnOn();
        void TurnOff();

        int BatteryLevel();
    }
}
