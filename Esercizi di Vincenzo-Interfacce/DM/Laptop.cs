using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_di_Vincenzo_Interfacce.DM
{
    internal class Laptop:IElectonicDevice
    {
        private int levelbatt { get; set; }
        private bool state {  get; set; }

        public Laptop() 
        { 
            this .levelbatt = 10;
            this .state = false;
        }
        public Laptop(int levelb)
        {
            this .levelbatt = levelb;
            this.state = false;
        }
    
        public void TurnOn()
        {
            this.state = true;
        }

        public void TurnOff() 
        { 
            this.state=false;
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
