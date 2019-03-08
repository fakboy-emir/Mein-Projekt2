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
       
        public List<FahrzeugHinzufügen> fahrzeug
        {
            get { return fahrzeug; }
            set { fahrzeug = value; }
        }

        public Form1()
        {
            InitializeComponent();
            Fahrzeugliste.DisplayMember = "Kennzeichen";
            this.tableLayoutPanel2.Visible = false;
        }


        private void BtnClick(object sender, EventArgs e)
        {
          

            using (FahrzeugHinzufügen hinzufügen = new FahrzeugHinzufügen())
            {
             

                hinzufügen.ShowDialog();

                
                Fahrzeugliste.Items.Add(hinzufügen.haupt);
                fahrzeug.Add(hinzufügen);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(Fahrzeugliste.SelectedIndex != -1)
            {
                Fahrzeugliste.Items.RemoveAt(Fahrzeugliste.SelectedIndex);
            }
        }

        private void listlbl_Click(object sender, EventArgs e)
        {

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
            catch(IOException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Laden()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream;
                stream = new FileStream("FahrzeugChronik.ect", FileMode.Open);
                fahrzeug = (List<FahrzeugHinzufügen>)formatter.Deserialize(stream);
                stream.Close();

                foreach (Fahrzeug fahrzeug in fahrzeug)
                {
                    Fahrzeugliste.Add(fahrzeug);
                }
            }
            catch(IOException e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        private void Fahrzeugliste_DoubleClick(object sender, EventArgs e)
        {
            FahrzeugHinzufügen openForm = new FahrzeugHinzufügen();
            openForm.Show();
            Fahrzeugliste.BeginUpdate();
            Fahrzeugliste.EndUpdate();
        }

        private void berechnenbtn_Click(object sender, EventArgs e)
        {
            if (Fahrzeugliste.Items != null)
            {
                FahrzeugHinzufügen openForm = new FahrzeugHinzufügen();
                openForm.Show();
            }
            else
            {
                MessageBox.Show("Sie müssen erst ein Fahrzeug Hinzufügen");
            }
            
        }

        private void ausgebenBtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;
            Laden();
        }
    }
}
