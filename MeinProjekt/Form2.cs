using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeinProjekt
{
    public partial class Form2 : Form
    {
        public Fahrzeug fahrzeug { get; set; }

        public Form2()
        {
            InitializeComponent();

            this.SaveBtn.Visible = false;
            this.PkwMarkenCombo.Visible = false;
            this.LKWMarkenCombo.Visible = false;
            this.MotoMarkenCombo.Visible = false;
           
           
        }

        private void comboBoxFahrzeugtyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFahrzeugtyp.SelectedItem.ToString() == "PKW")
            {
                Back_To_Place();//Hier bringe ich die Form auf 0                       
                tableLayoutPanel1.Controls.Remove(Achsenlbl);
                tableLayoutPanel1.Controls.Remove(Zuladunglbl);
                tableLayoutPanel1.Controls.Remove(HerstellerText);
                tableLayoutPanel1.Controls.Remove(AchsenText);
                tableLayoutPanel1.Controls.Remove(ZuladungText);
                tableLayoutPanel1.Controls.Add(Hubraumlbl, 0 , 6 );
                tableLayoutPanel1.Controls.Add(HubraumText,1 , 6);
                tableLayoutPanel1.Controls.Add(Leistunglbl, 0, 7);
                tableLayoutPanel1.Controls.Add(LeistungText, 1, 7);
                tableLayoutPanel1.Controls.Add(Klasselbl, 0, 8);
                tableLayoutPanel1.Controls.Add(klassecombo,1 , 8);
                tableLayoutPanel1.Controls.Add(PkwMarkenCombo, 1, 1);
                this.PkwMarkenCombo.Visible = true;
                this.SaveBtn.Visible = true;
                tableLayoutPanel1.Controls.Add(SaveBtn, 1, 9);
            }
            if (comboBoxFahrzeugtyp.SelectedItem.ToString() == "LKW")
            {
                Back_To_Place();//Hier bringe ich die Form auf 0
                tableLayoutPanel1.Controls.Remove(Klasselbl);
                tableLayoutPanel1.Controls.Remove(klassecombo);
                tableLayoutPanel1.Controls.Remove(Leistunglbl);
                tableLayoutPanel1.Controls.Remove(LeistungText);
                tableLayoutPanel1.Controls.Remove(Hubraumlbl);
                tableLayoutPanel1.Controls.Remove(HubraumText);
                tableLayoutPanel1.Controls.Remove(HerstellerText);
                tableLayoutPanel1.Controls.Remove(PkwMarkenCombo);
                tableLayoutPanel1.Controls.Remove(MotoMarkenCombo);
                tableLayoutPanel1.Controls.Add(LKWMarkenCombo, 1, 1);
                this.LKWMarkenCombo.Visible = true;
                this.SaveBtn.Visible = true;
                tableLayoutPanel1.Controls.Add(SaveBtn, 1, 8);
            }
            if(comboBoxFahrzeugtyp.SelectedItem.ToString() == "Motorrad")
            {
                Back_To_Place();//Hier bringe ich die Form auf 0
                tableLayoutPanel1.Controls.Remove(Klasselbl);
                tableLayoutPanel1.Controls.Remove(klassecombo);
                tableLayoutPanel1.Controls.Remove(Leistunglbl);
                tableLayoutPanel1.Controls.Remove(LeistungText);
                tableLayoutPanel1.Controls.Remove(Zuladunglbl);
                tableLayoutPanel1.Controls.Remove(ZuladungText);
                tableLayoutPanel1.Controls.Remove(Achsenlbl);
                tableLayoutPanel1.Controls.Remove(AchsenText);
                tableLayoutPanel1.Controls.Add(Hubraumlbl, 0, 6);
                tableLayoutPanel1.Controls.Add(HubraumText, 1, 6);
                tableLayoutPanel1.Controls.Remove(HerstellerText);
                tableLayoutPanel1.Controls.Remove(PkwMarkenCombo);
                tableLayoutPanel1.Controls.Remove(LKWMarkenCombo);
                tableLayoutPanel1.Controls.Add(MotoMarkenCombo, 1, 1);
                this.MotoMarkenCombo.Visible = true;
                this.SaveBtn.Visible = true;
                tableLayoutPanel1.Controls.Add(SaveBtn, 1, 7);
            }

        }

       

        private void Back_To_Place() //Diese Methode wird verwendet um die Form auf 0 zu bringen
        {
            //Hier werden die Labels als erstes auf ihre 
            //ursprüngliche Position gebracht
            tableLayoutPanel1.Controls.Add(Typlbl7, 0, 0);
            tableLayoutPanel1.Controls.Add(Herstellerlbl, 0, 1);
            tableLayoutPanel1.Controls.Add(Modelllbl, 0, 2);
            tableLayoutPanel1.Controls.Add(Kennzeichenlbl, 0, 3);
            tableLayoutPanel1.Controls.Add(Jahrlbl, 0, 4);
            tableLayoutPanel1.Controls.Add(Preislbl, 0, 5);
            tableLayoutPanel1.Controls.Add(Achsenlbl, 0, 6);
            tableLayoutPanel1.Controls.Add(Zuladunglbl, 0, 7);
            tableLayoutPanel1.Controls.Add(Leistunglbl, 0, 8);
            tableLayoutPanel1.Controls.Add(Hubraumlbl, 0, 9);
            tableLayoutPanel1.Controls.Add(Klasselbl, 0, 10);
            //Hier werden die Textboxen und ComboBoxen als nächstes auf ihre 
            //ursprüngliche Position gebracht
            tableLayoutPanel1.Controls.Add(comboBoxFahrzeugtyp, 1, 0);
            tableLayoutPanel1.Controls.Add(HerstellerText, 1, 1);
            tableLayoutPanel1.Controls.Add(ModellText, 1, 2);
            tableLayoutPanel1.Controls.Add(maskedkenn, 1, 3);
            tableLayoutPanel1.Controls.Add(Jahrcombo, 1, 4);
            tableLayoutPanel1.Controls.Add(PreisText, 1, 5);
            tableLayoutPanel1.Controls.Add(AchsenText, 1, 6);
            tableLayoutPanel1.Controls.Add(ZuladungText, 1, 7);
            tableLayoutPanel1.Controls.Add(LeistungText, 1, 8);
            tableLayoutPanel1.Controls.Add(HubraumText, 1, 9);
            tableLayoutPanel1.Controls.Add(klassecombo, 1, 10);
            tableLayoutPanel1.Controls.Remove(PkwMarkenCombo);
            tableLayoutPanel1.Controls.Remove(LKWMarkenCombo);
            tableLayoutPanel1.Controls.Remove(MotoMarkenCombo);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
           
        }

        private void MotoMarkenCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(ModellText.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if(!char.IsDigit(ch) && ch != 999999)
            {
                e.Handled = true;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ModellText.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 500000)
            {
                e.Handled = true;

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ModellText.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 20)
            {
                e.Handled = true;

            }
        }

        private void Hubbtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ModellText.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 100)
            {
                e.Handled = true;

            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ModellText.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 550)
            {
                e.Handled = true;

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ModellText.Text.IndexOf(".") != -1 )
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch == 2)
            {
                e.Handled = true;

            }
        }
        
        public void FahrzeugHinzufügen_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

               if (fahrzeug.FahrzeugTyp == "PKW")
               {
                    fahrzeug.FahrzeugTyp = "PKW";
                    ((PKWs)fahrzeug).Leistung = LeistungText.Text;
                    ((PKWs)fahrzeug).PHubraum = HubraumText.Text;
                    ((PKWs)fahrzeug).Schadstoffklasse = klassecombo.Text;
                    ((PKWs)fahrzeug).PKWMarke = PkwMarkenCombo.Text;
                    fahrzeug.Modell = ModellText.Text;
                    fahrzeug.Kennzeichen = maskedkenn.Text;
                    fahrzeug.Jahr_Der_Erstzulassung = Jahrcombo.Text;
                    fahrzeug.Preis = PreisText.Text;
                    
               }
               else if (fahrzeug.FahrzeugTyp == "LKW")
               {
                    fahrzeug.FahrzeugTyp = "LKW";
                    fahrzeug = new LKWs();
                    ((LKWs)fahrzeug).Anzahl_Der_Achsen = AchsenText.Text;
                    ((LKWs)fahrzeug).Zuladung = ZuladungText.Text;
                    ((LKWs)fahrzeug).LKWMarke = LKWMarkenCombo.Text;
                    fahrzeug.Modell = ModellText.Text;
                    fahrzeug.Kennzeichen = maskedkenn.Text;
                    fahrzeug.Jahr_Der_Erstzulassung = Jahrcombo.Text;
                    fahrzeug.Preis = PreisText.Text;
                    
               }
               else if (fahrzeug.FahrzeugTyp == "Motorrad")
               {
                    fahrzeug.FahrzeugTyp = "Motorrad";
                    fahrzeug = new Motorräder();
                    ((Motorräder)fahrzeug).Hubraum = HubraumText.Text;
                    ((Motorräder)fahrzeug).MotoMarke = MotoMarkenCombo.Text;
                    fahrzeug.Modell = ModellText.Text;
                    fahrzeug.Kennzeichen = maskedkenn.Text;
                    fahrzeug.Jahr_Der_Erstzulassung = Jahrcombo.Text;
                    fahrzeug.Preis = PreisText.Text;

               }


            }
            catch (Exception)
            {


            }
        }

        public string FahrzeugTyp
        {
            get { return comboBoxFahrzeugtyp.Text; }
        }
        public string  LKWMarke
        {
            get { return LKWMarkenCombo.Text; }
          
        }
        public string PKWMarke
        {
            get { return PkwMarkenCombo.Text; }

        }
        public string MotoMarke
        {
            get { return MotoMarkenCombo.Text; }

        }
        public string Modell
        {
            get { return ModellText.Text; }
        }
        public string Kennzeichen
        {
            get { return maskedkenn.Text; }
        }
        public string Jahr_Der_Erstzulassung
        {
            get { return Jahrcombo.Text; }
        }
        public string Preis
        {
            get { return PreisText.Text; }
        }
        public string Anzahl_Der_Achsen
        {
            get { return AchsenText.Text; }
        }
        public string Zuladung
        {
            get { return ZuladungText.Text; }
        }
        public string Leistung
        {
            get { return LeistungText.Text; }
        }
        public string Hubraum
        {
            get { return HubraumText.Text; }
        }
        public string Schadstoffklasse
        {
            get { return klassecombo.Text; }
        }
      

        private double Ergebnis
        {
            get;
            set;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
