using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Classe_astratte.DM
{
    internal abstract class Veicolo
    {
        private double velocità;
        private double accellerazione;

        public Veicolo()
        {
            velocità = 0;
            accellerazione = 0;
        
        }
        public Veicolo(double velo, double accelle)
        { 
            velocità = velo;
            accellerazione = accelle;
        
        }

        #region get/set

        public double Getvelocità()
        {
            return this.velocità;
        }
        public double Getaccellerazione()
        {
            return this.accellerazione;
        }

        public void Setvelocità(double velo)
        {
            this.velocità= velo;
        }
        public void Setaccellera(double accell)
        {
            this.accellerazione = accell;
        }

        #endregion

        static public void StampaVelocità (Veicolo x)
        {
            Console.WriteLine(x.Getvelocità());
        }

        public abstract void Stampanruote();



    }
}
