using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_di_Vincenzo_Interfacce.DM
{
    internal class Smartphone : IElectonicDevice
    {

        private int levelbatt { get; set; }

        private bool state { get; set; }

        public Smartphone()
        {
            levelbatt = 10;
            state = false;
        }
        public Smartphone(int levelbatt)
        {
            this.levelbatt =levelbatt;
            this.state = false;
        }

        public void TurnOn()
        {
            state = true;
        }
        public void TurnOff()
        {
            state = false;
        }

        public int BatteryLevel()
        {
            if (this.state == true)
            {
                return this.levelbatt;
            }
            else
            { return 0; }

        }
    }
}
