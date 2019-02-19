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
    public partial class AddCar : Form
    {
        public AddCar()
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
                tableLayoutPanel1.Controls.Remove(Zuladunglbl);
                tableLayoutPanel1.Controls.Remove(textBox7);
                tableLayoutPanel1.Controls.Remove(textBox8);
                tableLayoutPanel1.Controls.Remove(Achsenlbl);
                tableLayoutPanel1.Controls.Add(Hubraumlbl, 0, 6);
                tableLayoutPanel1.Controls.Add(Leistunglbl, 0, 7);
                tableLayoutPanel1.Controls.Add(Klasselbl, 0, 8);
                tableLayoutPanel1.Controls.Add(klassecombo, 1, 8);
                tableLayoutPanel1.Controls.Remove(textBox1);
                tableLayoutPanel1.Controls.Remove(LKWMarkenCombo);
                tableLayoutPanel1.Controls.Remove(MotoMarkenCombo);
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
                tableLayoutPanel1.Controls.Remove(textBox8);
                tableLayoutPanel1.Controls.Remove(Hubraumlbl);
                tableLayoutPanel1.Controls.Remove(textBox7);
                tableLayoutPanel1.Controls.Remove(textBox1);
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
                tableLayoutPanel1.Controls.Remove(textBox8);
                tableLayoutPanel1.Controls.Remove(Zuladunglbl);
                tableLayoutPanel1.Controls.Remove(textBox5);
                tableLayoutPanel1.Controls.Remove(Achsenlbl);
                tableLayoutPanel1.Controls.Remove(textBox4);
                tableLayoutPanel1.Controls.Add(Hubraumlbl, 0, 6);
                tableLayoutPanel1.Controls.Add(textBox7, 1, 6);
                tableLayoutPanel1.Controls.Remove(textBox1);
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
            tableLayoutPanel1.Controls.Add(Hubraumlbl, 0, 8);
            tableLayoutPanel1.Controls.Add(Leistunglbl, 0, 9);
            tableLayoutPanel1.Controls.Add(Klasselbl, 0, 10);
            //Hier werden die Textboxen und ComboBoxen als nächstes auf ihre 
            //ursprüngliche Position gebracht
            tableLayoutPanel1.Controls.Add(comboBoxFahrzeugtyp, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox6, 1, 3);
            tableLayoutPanel1.Controls.Add(Jahrcombo, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 5);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 6);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 7);
            tableLayoutPanel1.Controls.Add(textBox7, 1, 8);
            tableLayoutPanel1.Controls.Add(textBox8, 1, 9);
            tableLayoutPanel1.Controls.Add(klassecombo, 1, 10);


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }


    }
}
