using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MeinProjekt
{
    public partial class Form2 : Form
    {
        public Fahrzeug fahrzeug { get; set; }//Ein objekt meiner Liste wird erstellt 

        public Form2()
        {
            InitializeComponent();
            //Alles wird invisible gemacht 
            this.SaveBtn.Visible = false;
            this.PkwMarkenCombo.Visible = false;
            this.LKWMarkenCombo.Visible = false;
            this.MotoMarkenCombo.Visible = false;
           
           
        } //Hier werden nur ein Paar Comboboxen und ein Button auf Visible = false gesetzt

        private void comboBoxFahrzeugtyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFahrzeugtyp.SelectedItem.ToString() == "PKW")
            {
                Zurücksetzen();//Hier bringe ich die Form auf 0      
                //Ich lösche hier Textboxen und Label die ein PKW nicht benötigt
                tableLayoutPanel1.Controls.Remove(Achsenlbl);
                tableLayoutPanel1.Controls.Remove(Zuladunglbl);
                tableLayoutPanel1.Controls.Remove(HerstellerText);
                tableLayoutPanel1.Controls.Remove(AchsenText);
                tableLayoutPanel1.Controls.Remove(ZuladungText);
                //Ich füge hier Textboxen und Label hinzu die Ein PKW benötigt
                tableLayoutPanel1.Controls.Add(Hubraumlbl, 0 , 6 );
                tableLayoutPanel1.Controls.Add(HubraumText,1 , 6);
                tableLayoutPanel1.Controls.Add(Leistunglbl, 0, 7);
                tableLayoutPanel1.Controls.Add(LeistungText, 1, 7);
                tableLayoutPanel1.Controls.Add(Klasselbl, 0, 8);
                tableLayoutPanel1.Controls.Add(klassecombo,1 , 8);
                tableLayoutPanel1.Controls.Add(PkwMarkenCombo, 1, 1);
                //Außerdem wird noch eine Eigene combobox mit PKW marken visible gemacht 
                this.PkwMarkenCombo.Visible = true;
                //Es wird ein button namens Save hinzugefügt und Visible gemacht 
                this.SaveBtn.Visible = true;
                tableLayoutPanel1.Controls.Add(SaveBtn, 1, 9);
            }
            if (comboBoxFahrzeugtyp.SelectedItem.ToString() == "LKW")
            {
                Zurücksetzen();//Hier bringe ich die Form auf 0
                //Ich lösche hier Textboxen und Label die ein LKW nicht benötigt
                tableLayoutPanel1.Controls.Remove(Klasselbl);
                tableLayoutPanel1.Controls.Remove(klassecombo);
                tableLayoutPanel1.Controls.Remove(Leistunglbl);
                tableLayoutPanel1.Controls.Remove(LeistungText);
                tableLayoutPanel1.Controls.Remove(Hubraumlbl);
                tableLayoutPanel1.Controls.Remove(HubraumText);
                tableLayoutPanel1.Controls.Remove(HerstellerText);
                tableLayoutPanel1.Controls.Remove(PkwMarkenCombo);
                tableLayoutPanel1.Controls.Remove(MotoMarkenCombo);
                //Ich füge hier Textboxen und Label hinzu die Ein LKW benötigt
                tableLayoutPanel1.Controls.Add(LKWMarkenCombo, 1, 1);
                //Außerdem wird noch eine Eigene combobox mit LKW marken visible gemacht 
                this.LKWMarkenCombo.Visible = true;
                //Es wird ein button namens Save hinzugefügt und Visible gemacht 
                this.SaveBtn.Visible = true;
                tableLayoutPanel1.Controls.Add(SaveBtn, 1, 8);
            }
            if(comboBoxFahrzeugtyp.SelectedItem.ToString() == "Motorrad")
            {
                Zurücksetzen();//Hier bringe ich die Form auf 0
                //Ich lösche hier Textboxen und Label die ein LKW nicht benötigt
                tableLayoutPanel1.Controls.Remove(Klasselbl);
                tableLayoutPanel1.Controls.Remove(klassecombo);
                tableLayoutPanel1.Controls.Remove(Leistunglbl);
                tableLayoutPanel1.Controls.Remove(LeistungText);
                tableLayoutPanel1.Controls.Remove(Zuladunglbl);
                tableLayoutPanel1.Controls.Remove(ZuladungText);
                tableLayoutPanel1.Controls.Remove(Achsenlbl);
                tableLayoutPanel1.Controls.Remove(AchsenText);
                tableLayoutPanel1.Controls.Remove(HerstellerText);
                tableLayoutPanel1.Controls.Remove(PkwMarkenCombo);
                tableLayoutPanel1.Controls.Remove(LKWMarkenCombo);
                //Ich füge hier Textboxen und Label hinzu die Ein LKW benötigt
                tableLayoutPanel1.Controls.Add(Hubraumlbl, 0, 6);
                tableLayoutPanel1.Controls.Add(HubraumText, 1, 6);
                tableLayoutPanel1.Controls.Add(MotoMarkenCombo, 1, 1);
                //Außerdem wird noch eine Eigene combobox mit LKW marken visible gemacht 
                this.MotoMarkenCombo.Visible = true;
                //Es wird ein button namens Save hinzugefügt und Visible gemacht 
                this.SaveBtn.Visible = true;
                tableLayoutPanel1.Controls.Add(SaveBtn, 1, 7);
            }

        }

       

        private void Zurücksetzen() //Diese Methode wird verwendet um die Form auf 0 zu bringen
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



        private void Speichern_Click(object sender, EventArgs e)
        {
        
            this.Close();//Es soll nur diese Form geschlossen werden
           
        } //Der Save Button ist nur da um die Form zu schließen

       
        //Diese Region ist dafür zuständig das ich keine "." eingeben kann und Buchstaben
        #region
        private void Hubbtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (HubraumText.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }
       
        private void AchsenText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (AchsenText.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }
        
        private void LeistungText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (LeistungText.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }
        private void ZuladungText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ZuladungText.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        private void PreisText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ModellText.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if(!Char.IsDigit(ch) && ch != 8 && ch!= 46)
            {
                e.Handled = true;
            }
        }
        #endregion


        public void NurWerte()
        {
            if (PkwMarkenCombo.Text == null && LKWMarkenCombo.Text == null && MotoMarkenCombo.Text == null && ModellText.Text == null && maskedkenn.Text == null && Jahrcombo.Text == null && PreisText.Text == null && AchsenText.Text == null && ZuladungText.Text == null && LeistungText.Text == null && HubraumText.Text == null && klassecombo.Text == null)
            {
                MessageBox.Show("Sie müssen Einen Wert eingeben oder noch auswählen",
                    "Bitte machen sie dies", MessageBoxButtons.OK);
            }
        } //Sorgt dafür das man auch Überal etwas eingibt oder auswählt


        public void FahrzeugHinzufügen_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

               if (fahrzeug.FahrzeugTyp == "PKW")//Wenn FahrzeugTyp PKW ist soll dies Passieren
               {
                   
                    fahrzeug.FahrzeugTyp = "PKW";//FahrzeugTyp ist PKW
                    ((PKWs)fahrzeug).Leistung = LeistungText.Text;//Es wird gecastet damit man auf die Eigenschaft Leistung zugreifen kann 
                    ((PKWs)fahrzeug).PHubraum = HubraumText.Text;//Es wird gecastet damit man auf die Eigenschaft PHubraum zugreifen kann 
                    ((PKWs)fahrzeug).Schadstoffklasse = klassecombo.Text;//Es wird gecastet damit man auf die Eigenschaft Schadstoffklasse zugreifen kann 
                    ((PKWs)fahrzeug).PKWMarke = PkwMarkenCombo.Text;//Es wird gecastet damit man auf die Eigenschaft PKWMarke zugreifen kann, dies ist der Hersteller
                    fahrzeug.Modell = ModellText.Text;//Modell ist gleich das was man in der Textbox Modell eingegeben hat 
                    fahrzeug.Kennzeichen = maskedkenn.Text;//Kennzeichen ist gleich das was man in der MaskedTextbox maskedkenn eingegeben hat 
                    fahrzeug.Jahr_Der_Erstzulassung = Jahrcombo.Text;//Jahr_Der_Erstzulassung ist gleich das was man in der Combobox Jahrcombo eingegeben hat 
                    fahrzeug.Preis = PreisText.Text;//Preis ist gleich das was man in der Textbox Preis eingegeben hat 
                    NurWerte();//Die Form soll nicht beendet werden, wenn es noch Textboxen oder Comboboxen gibt die keinen wert haben
                }
               else if (fahrzeug.FahrzeugTyp == "LKW")
               {
                    fahrzeug = new LKWs();
                    fahrzeug.FahrzeugTyp = "LKW";//FahrzeugTyp ist LKW
                    ((LKWs)fahrzeug).Anzahl_Der_Achsen = AchsenText.Text;//Es wird gecastet damit man auf die Eigenschaft Leistung zugreifen kann 
                    ((LKWs)fahrzeug).Zuladung = ZuladungText.Text;//Es wird gecastet damit man auf die Eigenschaft Leistung zugreifen kann 
                    ((LKWs)fahrzeug).LKWMarke = LKWMarkenCombo.Text;//Es wird gecastet damit man auf die Eigenschaft Leistung zugreifen kann 
                    fahrzeug.Modell = ModellText.Text;//Modell ist gleich das was man in der Textbox Modell eingegeben hat 
                    fahrzeug.Kennzeichen = maskedkenn.Text;//Kennzeichen ist gleich das was man in der MaskedTextbox maskedkenn eingegeben hat 
                    fahrzeug.Jahr_Der_Erstzulassung = Jahrcombo.Text;//Jahr_Der_Erstzulassung ist gleich das was man in der Combobox Jahrcombo eingegeben hat
                    fahrzeug.Preis = PreisText.Text;//Preis ist gleich das was man in der Textbox Preis eingegeben hat 
                    NurWerte();//Die Form soll nicht beendet werden, wenn es noch Textboxen oder Comboboxen gibt die keinen wert haben
                }
               else if (fahrzeug.FahrzeugTyp == "Motorrad")
               {
                    fahrzeug = new Motorräder();
                    fahrzeug.FahrzeugTyp = "Motorrad";//FahrzeugTyp ist Motorrad
                    ((Motorräder)fahrzeug).Hubraum = HubraumText.Text;//Es wird gecastet damit man auf die Eigenschaft Hubraum zugreifen kann 
                    ((Motorräder)fahrzeug).MotoMarke = MotoMarkenCombo.Text;//Es wird gecastet damit man auf die Eigenschaft MotoMarke zugreifen kann, was der Hersteller ist
                    fahrzeug.Modell = ModellText.Text;//Modell ist gleich das was man in der Textbox Modell eingegeben hat 
                    fahrzeug.Kennzeichen = maskedkenn.Text;//Kennzeichen ist gleich das was man in der MaskedTextbox maskedkenn eingegeben hat 
                    fahrzeug.Jahr_Der_Erstzulassung = Jahrcombo.Text;//Jahr_Der_Erstzulassung ist gleich das was man in der Combobox Jahrcombo eingegeben hat
                    fahrzeug.Preis = PreisText.Text;//Preis ist gleich das was man in der Textbox Preis eingegeben hat
                    NurWerte();//Die Form soll nicht beendet werden, wenn es noch Textboxen oder Comboboxen gibt die keinen wert haben
                }
              

            }
            catch (Exception)
            {


            }
        } //Wenn die Form sich schliesst, sollen alle Daten in das Objekt fahrzeug gespeichert werden

       
        //Die einzelnen Eingenschaften kriegen einen wert zugewiesen
        #region
        public string FahrzeugTyp
        {
            get { return comboBoxFahrzeugtyp.Text; }
        }
        public string LKWMarke
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



        #endregion

        private void Hilfebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("K-BE-2000",
                "Beispiel für ein richtiges Kennzeichen", MessageBoxButtons.OK);
        } //Hilfe zu meiner MaskedTextbox


        //Diese Region ist dafür zuständig das man nicht eine unendliche lange Zahl eingeben kann     
        #region
        private void PreisText_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(PreisText.Text) >= 50000)
            {
                MessageBox.Show("Ihr wert ist zu hoch,Er muss unter 50,0000 liegen",
                    "bitte wählen sie einen Niedrigeren Wert", MessageBoxButtons.RetryCancel);
                PreisText.Clear();

            }
        }

        private void ZuladungText_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(ZuladungText.Text) >= 10)
            {
                MessageBox.Show("Ihr wert ist zu hoch, Er muss unter 10 liegen",
                    "bitte wählen sie einen Niedrigeren Wert", MessageBoxButtons.OK);
                ZuladungText.Clear();

            }
        }

        private void LeistungText_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(LeistungText.Text) >= 150)
            {
                MessageBox.Show("Ihr wert ist zu hoch, Er muss unter 150 liegen",
                    "bitte wählen sie einen Niedrigeren Wert", MessageBoxButtons.OK);
                LeistungText.Clear();

            }
        }

        private void HubraumText_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(HubraumText.Text) >= 2500)
            {
                MessageBox.Show("Ihr wert ist zu hoch,Er muss unter 2500 liegen",
                    "bitte wählen sie einen Niedrigeren Wert", MessageBoxButtons.OK);
                HubraumText.Clear();

            }
        }

        private void AchsenText_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(AchsenText.Text) >= 35000)
            {
                MessageBox.Show("Ihr wert ist zu hoch,Er muss unter 35000 liegen",
                    "bitte wählen sie einen Niedrigeren Wert", MessageBoxButtons.OK);
                HubraumText.Clear();

            }
        }
        #endregion
    }
}
