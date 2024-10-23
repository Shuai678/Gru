using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gru
{
    internal class Gru
    {
        public string numeroSeriale;
        public string produttore;
        public double pesoMassimoNominale;
        public double altezzaMassimaNominale;
        public double altezzaMinimaNominale;
        public double altezzaCorrente;

        public string NumeroSeriale 
        {
            get { return NumeroSeriale; }
        }
        public string Produttore 
        {
            get { return Produttore; }
        }
        public double PesoMassimoNominale 
        {
            get { return PesoMassimoNominale; }
            set { PesoMassimoNominale = value; }
        }
        public double AltezzaMassimaNominale 
        {
            get { return PesoMassimoNominale; }
            set { PesoMassimoNominale = value; }
        }
        public double AltezzaMinimaNominale 
        {
            get { return AltezzaMinimaNominale; }
            set { AltezzaMinimaNominale = value; }
        }
        public double AltezzaCorrente 
        {
            get { return AltezzaCorrente; }
            set { AltezzaCorrente = value; }
        }

        public Gru(string numeroSeriale, string produttore, double pesoMassimoNominale, double altezzaMassimaNominale, double altezzaMinimaNominale)
        {
            this.numeroSeriale = numeroSeriale;
            this.produttore = produttore;
            PesoMassimoNominale = pesoMassimoNominale;
            AltezzaMassimaNominale = altezzaMassimaNominale;
            AltezzaMinimaNominale = altezzaMinimaNominale;
            AltezzaCorrente = altezzaMinimaNominale;
        }

        public void Abbassa(double metri)
        {
            if (AltezzaCorrente - metri >= AltezzaMinimaNominale)
            {
                AltezzaCorrente -= metri;
            }
            else
            {
                Console.WriteLine("Errore: Non è possibile scendere sotto l'altezza minima nominale.");
            }
        }
    }
}
