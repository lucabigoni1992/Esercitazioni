using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Classe_astratte.DM
{
    internal class Automobile:Veicolo
    {
        private string targa="";
        private bool avviata;
        private int nruote;
        



        public Automobile(string targ,double velo,double accelle) :base( velo, accelle)
        {
            this.targa = targ;
            nruote = 4;
        }
        #region get/set

        public string GetTarga()
        {
            return this.targa;
        }
        public bool GetAvviata()
        {
            return this.avviata;
        }
        public int GetNRuote()
        {
            return this.nruote;
        }
        

        public void SetTarga(string targ)
        {
            this.targa = targ;
        }
        public void Avvia()
        { this.avviata = true; }
        public void Spegni()
        { this.avviata = false; }
        public void SetNRuote(int x)
        {
            this.nruote = x;
        }

        #endregion

        public void Accellera(double accellerazione,int secondi)
        {
            if (this.avviata) 
            {
             //non so se sia il mtodo piu efficente per eseguire la richiesta 
                double vel = this.Getvelocità() + (accellerazione * secondi);
                this.Setvelocità(vel);
            }
            else
            {
                Console.WriteLine("veicolo Spento");
            }
        }

        public override void Stampanruote()
        {
            Console.WriteLine(GetNRuote());
        }


    }
}
