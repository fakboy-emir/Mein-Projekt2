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
    public partial class Form1 : Form
    {
        public List<Fahrzeug> fahrzeug = new List<Fahrzeug>();


        double tmpSteuer;
        public Form1()
        {
            InitializeComponent();
            Fahrzeugliste.DisplayMember = "Kennzeichen";
            this.tableLayoutPanel2.Visible = false;
        }


        public void BtnClick(object sender, EventArgs e)
        {


            using (Form2 hinzufügen = new Form2())
            {


                hinzufügen.ShowDialog();


                //Fahrzeugliste.Items.Add(hinzufügen.haupt);
                //fahrzeug.Add(hinzufügen.haupt);
                
                if(hinzufügen.FahrzeugTyp == "PKW")
                {
 
                    fahrzeug.Add(new PKWs());
                    fahrzeug[fahrzeug.Count - 1].FahrzeugTyp = "PKW";
                    fahrzeug[fahrzeug.Count - 1].Modell = hinzufügen.Modell;
                    fahrzeug[fahrzeug.Count - 1].Kennzeichen = hinzufügen.Kennzeichen.ToUpper();
                    fahrzeug[fahrzeug.Count - 1].Jahr_Der_Erstzulassung = hinzufügen.Jahr_Der_Erstzulassung;
                    fahrzeug[fahrzeug.Count - 1].Preis = hinzufügen.Preis;
                    (fahrzeug[fahrzeug.Count - 1] as PKWs).PKWMarke = hinzufügen.PKWMarke;
                    (fahrzeug[fahrzeug.Count - 1] as PKWs).Leistung = hinzufügen.Leistung;
                    (fahrzeug[fahrzeug.Count - 1] as PKWs).PHubraum = hinzufügen.Hubraum;
                    (fahrzeug[fahrzeug.Count - 1] as PKWs).Schadstoffklasse = hinzufügen.Schadstoffklasse;
                   

                }
                else if(hinzufügen.FahrzeugTyp == "LKW")
                {
                    fahrzeug.Add(new LKWs());
                    fahrzeug[fahrzeug.Count - 1].FahrzeugTyp = "LKW";
                    fahrzeug[fahrzeug.Count - 1].Modell = hinzufügen.Modell;
                    fahrzeug[fahrzeug.Count - 1].Kennzeichen = hinzufügen.Kennzeichen.ToUpper();
                    fahrzeug[fahrzeug.Count - 1].Jahr_Der_Erstzulassung = hinzufügen.Jahr_Der_Erstzulassung;
                    fahrzeug[fahrzeug.Count - 1].Preis = hinzufügen.Preis;
                    (fahrzeug[fahrzeug.Count - 1] as LKWs).LKWMarke  = hinzufügen.LKWMarke;
                    (fahrzeug[fahrzeug.Count - 1] as LKWs).Anzahl_Der_Achsen = hinzufügen.Anzahl_Der_Achsen;
                    (fahrzeug[fahrzeug.Count - 1] as LKWs).Zuladung = hinzufügen.Zuladung;



                }
                else if (hinzufügen.FahrzeugTyp == "Motorrad")
                {
                    fahrzeug.Add(new Motorräder());
                    fahrzeug[fahrzeug.Count - 1].FahrzeugTyp = "Motorrad";
                    fahrzeug[fahrzeug.Count - 1].Modell = hinzufügen.Modell;
                    fahrzeug[fahrzeug.Count - 1].Kennzeichen = hinzufügen.Kennzeichen.ToUpper();
                    fahrzeug[fahrzeug.Count - 1].Jahr_Der_Erstzulassung = hinzufügen.Jahr_Der_Erstzulassung;
                    fahrzeug[fahrzeug.Count - 1].Preis = hinzufügen.Preis;
                    (fahrzeug[fahrzeug.Count - 1] as Motorräder).MotoMarke = hinzufügen.MotoMarke;
                    (fahrzeug[fahrzeug.Count - 1] as Motorräder).Hubraum = hinzufügen.Hubraum;
          
                }
                Fahrzeugliste.Items.Add(fahrzeug[fahrzeug.Count -1]);
            }

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (Fahrzeugliste.SelectedIndex != -1)
            {
                Fahrzeugliste.Items.RemoveAt(Fahrzeugliste.SelectedIndex);
            }
        }

       

        public void Speichern()
        {
            try
            {
                FileStream stream;
                stream = new FileStream("FahrzeugChronik.ect", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, fahrzeug);
                stream.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Laden()
        {

        }


      
        
        
     

       

        private void Fahrzeugliste_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tableLayoutPanel2.Visible = true;
            if (Fahrzeugliste.SelectedItem != null)
            {
                Fahrzeug fahrzeug = Fahrzeugliste.SelectedItem as Fahrzeug;

                comboBoxFahrzeugtyp.Text = fahrzeug.FahrzeugTyp;
                ModellText.Text = fahrzeug.Modell;
                maskedkenn.Text = fahrzeug.Kennzeichen;
                Jahrcombo.Text = fahrzeug.Jahr_Der_Erstzulassung;
                PreisText.Text = fahrzeug.Preis;

                if(fahrzeug is PKWs)
                {
                    Back_To_Place();//Hier bringe ich die Form auf 0
                    tableLayoutPanel2.Controls.Remove(Zuladunglbl);
                    tableLayoutPanel2.Controls.Remove(Achsenlbl);
                    tableLayoutPanel2.Controls.Remove(ZuladungText);
                    tableLayoutPanel2.Controls.Remove(AchsenText);
                    tableLayoutPanel2.Controls.Add(Hubraumlbl, 0, 6);
                    tableLayoutPanel2.Controls.Add(Leistunglbl, 0, 7);
                    tableLayoutPanel2.Controls.Add(Klasselbl, 0, 8);
                    tableLayoutPanel2.Controls.Add(HubraumText, 1, 6);
                    tableLayoutPanel2.Controls.Add(LeistungText, 1, 7);              
                    tableLayoutPanel2.Controls.Add(klassecombo, 1, 8);
                    tableLayoutPanel2.Controls.Add(SchuldText, 1, 9);
                    tableLayoutPanel2.Controls.Add(Steuerlbl,  0, 9);
                    HubraumText.Text = ((PKWs)fahrzeug).PHubraum;
                    klassecombo.Text = ((PKWs)fahrzeug).Schadstoffklasse;
                    LeistungText.Text = ((PKWs)fahrzeug).Leistung;
                    HerstellerText.Text = ((PKWs)fahrzeug).PKWMarke;
                    SchuldText.Text = Convert.ToString(((PKWs)fahrzeug).Steuerschuld);
               
                }
                else if(fahrzeug is LKWs)
                {
                    Back_To_Place();//Hier bringe ich die Form auf 0
                    tableLayoutPanel2.Controls.Remove(Klasselbl);
                    tableLayoutPanel2.Controls.Remove(klassecombo);
                    tableLayoutPanel2.Controls.Remove(Leistunglbl);
                    tableLayoutPanel2.Controls.Remove(LeistungText);
                    tableLayoutPanel2.Controls.Remove(Hubraumlbl);
                    tableLayoutPanel2.Controls.Remove(HubraumText);
                    tableLayoutPanel2.Controls.Add(SchuldText, 1, 8);
                    tableLayoutPanel2.Controls.Add(Steuerlbl, 0, 8);
                    AchsenText.Text = ((LKWs)fahrzeug).Anzahl_Der_Achsen;
                    ZuladungText.Text = ((LKWs)fahrzeug).Zuladung;
                    HerstellerText.Text = ((LKWs)fahrzeug).LKWMarke;
                    SchuldText.Text = Convert.ToString(((LKWs)fahrzeug).Steuerschuld);

                }
                else if(fahrzeug is Motorräder)
                {
                    Back_To_Place();//Hier bringe ich die Form auf 0
                    tableLayoutPanel2.Controls.Remove(Klasselbl);
                    tableLayoutPanel2.Controls.Remove(klassecombo);
                    tableLayoutPanel2.Controls.Remove(Leistunglbl);
                    tableLayoutPanel2.Controls.Remove(LeistungText);
                    tableLayoutPanel2.Controls.Remove(Zuladunglbl);
                    tableLayoutPanel2.Controls.Remove(ZuladungText);
                    tableLayoutPanel2.Controls.Remove(Achsenlbl);
                    tableLayoutPanel2.Controls.Remove(AchsenText);
                    tableLayoutPanel2.Controls.Add(Hubraumlbl, 0, 6);
                    tableLayoutPanel2.Controls.Add(HubraumText, 1, 6);
                    tableLayoutPanel2.Controls.Add(SchuldText, 1, 7);
                    tableLayoutPanel2.Controls.Add(Steuerlbl, 0, 7);

                    HubraumText.Text = ((Motorräder)fahrzeug).Hubraum;
                    HerstellerText.Text = ((Motorräder)fahrzeug).MotoMarke;
                    SchuldText.Text = Convert.ToString(((Motorräder)fahrzeug).Steuerschuld);
                }

            }


        }
        private void Back_To_Place() //Diese Methode wird verwendet um die Form auf 0 zu bringen
        {
            //Hier werden die Labels als erstes auf ihre 
            //ursprüngliche Position gebracht
            tableLayoutPanel2.Controls.Add(Typlbl7, 0, 0);
            tableLayoutPanel2.Controls.Add(Herstellerlbl, 0, 1);
            tableLayoutPanel2.Controls.Add(Modelllbl, 0, 2);
            tableLayoutPanel2.Controls.Add(Kennzeichenlbl, 0, 3);
            tableLayoutPanel2.Controls.Add(Jahrlbl, 0, 4);
            tableLayoutPanel2.Controls.Add(Preislbl, 0, 5);
            tableLayoutPanel2.Controls.Add(Achsenlbl, 0, 6);
            tableLayoutPanel2.Controls.Add(Zuladunglbl, 0, 7);
            tableLayoutPanel2.Controls.Add(Leistunglbl, 0, 8);
            tableLayoutPanel2.Controls.Add(Hubraumlbl, 0, 9);
            tableLayoutPanel2.Controls.Add(Klasselbl, 0, 10);
            //Hier werden die Textboxen und ComboBoxen als nächstes auf ihre 
            //ursprüngliche Position gebracht
            tableLayoutPanel2.Controls.Add(comboBoxFahrzeugtyp, 1, 0);
            tableLayoutPanel2.Controls.Add(HerstellerText, 1, 1);
            tableLayoutPanel2.Controls.Add(ModellText, 1, 2);
            tableLayoutPanel2.Controls.Add(maskedkenn, 1, 3);
            tableLayoutPanel2.Controls.Add(Jahrcombo, 1, 4);
            tableLayoutPanel2.Controls.Add(PreisText, 1, 5);
            tableLayoutPanel2.Controls.Add(AchsenText, 1, 6);
            tableLayoutPanel2.Controls.Add(ZuladungText, 1, 7);
            tableLayoutPanel2.Controls.Add(LeistungText, 1, 8);
            tableLayoutPanel2.Controls.Add(HubraumText, 1, 9);
            tableLayoutPanel2.Controls.Add(klassecombo, 1, 10);


        }

        private void Schuldbtn_Click(object sender, EventArgs e)
        {
          
        }

        private void GesShuldenbtn_Click(object sender, EventArgs e)
        {
            foreach (Fahrzeug fahrzeug in fahrzeug)
            {
                tmpSteuer += fahrzeug.Steuerschuld;
            }
            MessageBox.Show(tmpSteuer.ToString(), "Steuerschuld für Alle Fahrzeuge", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Suchenbtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;
            Fahrzeugliste.SelectedIndex = Fahrzeugliste.FindString(SuchMask.Text);
        }
    }
}
