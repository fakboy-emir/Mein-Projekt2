using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    class Parkplätze
    {
        private bool frei_oder_nicht;

        public bool Frei_Oder_Nicht
        {
            get { return frei_oder_nicht; }
            set { frei_oder_nicht = value; }
        }

        private string zuweisung;

        public string Zuweisung
        {
            get { return zuweisung; }
            set { zuweisung = value; }
        }

        private double nummer;

        public double Nummer
        {
            get { return nummer; }
            set { nummer = value; }
        }

        private string parkplatz_typ;

        public string Parkplatz_typ
        {
            get { return parkplatz_typ; }
            set { parkplatz_typ = value; }
        }




    }
}
