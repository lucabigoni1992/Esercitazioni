using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
         Vorrei vedere due metodi virtuali che vengono poi sovrascritti nelle classi figlie
        -uno per il perimetro
        -uni per l'area
         */


namespace Esercizi_Vincenzo2.DATAMODEL
{
    internal class Forma
    {
        public string Colore;
        public string NomeForma;
        private double Base;
        private double Altezza;

        public Forma(string Color, string name)
        {
            Colore = Color;
            NomeForma = name;
        }

        #region setget
        
        public string GetColore()
        {
            if(string.IsNullOrEmpty(Colore))
            {
                throw new Exception("Colore Vuoto");
            }
            return Colore;
        }
        public string GetNomeForma() 
        { 
            if (string.IsNullOrEmpty(NomeForma))
            { 
                throw new Exception("Nome non valido"); 
            }
            return NomeForma;
                
        }
            public void SetColore(string colo)
        {
            if (string.IsNullOrEmpty(Colore)) 
            { 
            throw new Exception("Inserimento Colore non valido");
            }
            Colore = colo;

        }
        public void SetNomeForma(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Inserimento Nome non valido");
            }
            NomeForma = name;

        }
        #endregion
        public virtual double Perimetro()
        {
            
            double perimetro = 0;
            return perimetro;
        }
        public virtual double Area()
        {
           
            double are = 0;
            return are;

        }
        




    }

}
