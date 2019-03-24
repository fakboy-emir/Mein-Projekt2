using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public class LKWs : Fahrzeug
    {
        private string anzahl_der_achsen;

        public string Anzahl_Der_Achsen
        {
            get { return anzahl_der_achsen; }
            set { anzahl_der_achsen = value; }
        }

        private string zuladung;

        public string Zuladung
        {
            get { return zuladung; }
            set { zuladung = value; }
        }
        private string lkwMarke;

        public string LKWMarke
        {
            get { return lkwMarke; }
            set { lkwMarke = value; }
        }

        public override float Steuerschuld => throw new NotImplementedException();
    }
}
