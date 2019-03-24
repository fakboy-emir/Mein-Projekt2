using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public class PKWs : Fahrzeug
    {

        private string hubraum;

        public string Hubraum
        {
            get { return hubraum; }
            set { hubraum = value; }
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

        public override float Steuerschuld => throw new NotImplementedException();
    }
}
