using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    class PKWs : Fahrzeugarten
    {

        private double hubraum;

        public double Hubraum
        {
            get { return hubraum; }
            set { hubraum = value; }
        }

        private double leistung;

        public double Leistung
        {
            get { return leistung; }
            set { leistung = value; }
        }

        private double schadstoffklasse;

        public double Schadstoffklasse
        {
            get { return schadstoffklasse; }
            set { schadstoffklasse = value; }
        }

        private string steuer_berechnen;

        public string Steuer_Berechnen
        {
            get { return steuer_berechnen; }
            set { steuer_berechnen = value; }
        }


    }
}
