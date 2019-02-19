using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    class LKWs : Fahrzeugarten
    {
        private double anzahl_der_achsen;

        public double Anzahl_Der_Achsen
        {
            get { return anzahl_der_achsen; }
            set { anzahl_der_achsen = value; }
        }

        private double zuladung;

        public double Zuladung
        {
            get { return zuladung; }
            set { zuladung = value; }
        }

        private string steuer_berechnen;

        public string Steuer_Berechnen
        {
            get { return steuer_berechnen; }
            set { steuer_berechnen = value; }
        }





    }
}
