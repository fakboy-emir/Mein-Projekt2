using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public class Motorräder : Fahrzeug
    {
        private string hubraum;

        public string Hubraum
        {
            get { return hubraum; }
            set { hubraum = value; }
        }


        private string motoMarke;

        public string MotoMarke
        {
            get { return motoMarke; }
            set { motoMarke = value; }
        }

        public override float Steuerschuld => throw new NotImplementedException();
    }
}
