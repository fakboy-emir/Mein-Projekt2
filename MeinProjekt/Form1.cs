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



        public Form1()
        {
            InitializeComponent();
            Fahrzeugliste.DisplayMember = "PKW";
            this.tableLayoutPanel2.Visible = false;

        }


        public void BtnClick(object sender, EventArgs e)
        {


            using (Form2 hinzufügen = new Form2())
            {


                hinzufügen.ShowDialog();


                //Fahrzeugliste.Items.Add(hinzufügen.haupt);
                //fahrzeug.Add(hinzufügen.haupt);
                Form2 form = new Form2();
                
                if(form.FahrzeugTyp == "PKW")
                {
                    fahrzeug.Add(new PKWs());
                    fahrzeug[fahrzeug.Count - 1].FahrzeugTyp = "PKW";
                    fahrzeug[fahrzeug.Count - 1].Modell = hinzufügen.Modell;
                    fahrzeug[fahrzeug.Count - 1].Kennzeichen = hinzufügen.Kennzeichen;
                    fahrzeug[fahrzeug.Count - 1].Jahr_Der_Erstzulassung = hinzufügen.Jahr_Der_Erstzulassung;
                    fahrzeug[fahrzeug.Count - 1].Preis = hinzufügen.Preis;
                    fahrzeug[fahrzeug.Count - 1].Hersteller = hinzufügen.PKWMarke;

                   
           

                }
                else if(form.FahrzeugTyp == "LKW")
                {
                    fahrzeug.Add(new LKWs());
                    fahrzeug[fahrzeug.Count - 1].FahrzeugTyp = "LKW";
                    fahrzeug[fahrzeug.Count - 1].Modell = hinzufügen.Modell;
                    fahrzeug[fahrzeug.Count - 1].Kennzeichen = hinzufügen.Kennzeichen;
                    fahrzeug[fahrzeug.Count - 1].Jahr_Der_Erstzulassung = hinzufügen.Jahr_Der_Erstzulassung;
                    fahrzeug[fahrzeug.Count - 1].Preis = hinzufügen.Preis;
                    fahrzeug[fahrzeug.Count - 1].Hersteller = hinzufügen.PKWMarke;
                


                }
                else if (form.FahrzeugTyp == "Motorrad")
                {
                    fahrzeug.Add(new Motorräder());
                    fahrzeug[fahrzeug.Count - 1].FahrzeugTyp = "LKW";
                    fahrzeug[fahrzeug.Count - 1].Modell = hinzufügen.Modell;
                    fahrzeug[fahrzeug.Count - 1].Kennzeichen = hinzufügen.Kennzeichen;
                    fahrzeug[fahrzeug.Count - 1].Jahr_Der_Erstzulassung = hinzufügen.Jahr_Der_Erstzulassung;
                    fahrzeug[fahrzeug.Count - 1].Preis = hinzufügen.Preis;
                    fahrzeug[fahrzeug.Count - 1].Hersteller = hinzufügen.PKWMarke;
                    
          
                }
                Fahrzeugliste.Items.Add(fahrzeug);
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


      
        

        private void ausgebenBtn_Click(object sender, EventArgs e)
        {
            
            tableLayoutPanel2.Visible = true;
            
        }

       


    }
}
