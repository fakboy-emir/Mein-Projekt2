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
    public partial class Form1 : Form
    {
        List<FahrzeugHinzufügen> Fahrzeug = new List<FahrzeugHinzufügen>();

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
                Fahrzeug.Add(hinzufügen);
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
            if(Fahrzeugliste.SelectedItem != null)
            {
               // Fahrzeugliste.SelectedItem = textBox7.Text();
            }
        }
    }
}
