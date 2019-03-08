using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public abstract class Fahrzeug
    {
        private string hersteller;

        public string Hersteller
        {
            get { return hersteller; }
            set { hersteller = value; }
        }

        private string modell;

        public string Modell
        {
            get { return modell; }
            set { modell = value; }
        }

        private string kennzeichen;

        public string Kennzeichen
        {
            get { return kennzeichen; }
            set { kennzeichen = value; }
        }

        private string jahr_der_erstzulassung;

        public string Jahr_Der_Erstzulassung
        {
            get { return jahr_der_erstzulassung; }
            set { jahr_der_erstzulassung = value; }
        }

        private string preis;

        public string Preis
        {
            get { return preis; }
            set { preis = value; }
        }

        private string fahrzeugtyp;
        
        public string FahrzeugTyp
        {
            get { return fahrzeugtyp; }
            set { fahrzeugtyp = value; }
        }

        private string steuerberechnen;

        public string SteuerBerechnen
        {
            get { return steuerberechnen; }
            set { steuerberechnen = value; }
        }

    




    }
}
