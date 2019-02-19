using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    class Parkhaus
    {
        private string ort;

        public string Ort
        {
            get { return ort; }
            set { ort = value; }
        }

        private int plz;

        public int PLZ
        {
            get { return plz; }
            set { plz = value; }
        }

        private string straße;

        public string Straße
        {
            get { return straße; }
            set { straße = value; }
        }

        private string parkplatz_typ;

        public string Parkplatz_Typ
        {
            get { return parkplatz_typ; }
            set { parkplatz_typ = value; }
        }




    }
}
