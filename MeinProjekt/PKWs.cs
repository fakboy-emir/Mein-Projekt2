using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public class PKWs : Fahrzeug
    {

        private string phubraum;

        public string PHubraum
        {
            get { return phubraum; }
            set { phubraum = value; }
        }

        private string leistung;

        public string Leistung
        {
            get { return leistung; }
            set { leistung = value; }
        }

        private string schadstoffklasse;

        public string Schadstoffklasse
        {
            get { return schadstoffklasse; }
            set { schadstoffklasse = value; }
        }

        private string pkwMarke;

        public string PKWMarke
        {
            get { return pkwMarke; }
            set { pkwMarke = value; }
        }

        public override double Steuerschuld => (Convert.ToDouble(PHubraum) + 99) / 100 * 10 * (Convert.ToDouble(Schadstoffklasse) + 1);
    }
}
