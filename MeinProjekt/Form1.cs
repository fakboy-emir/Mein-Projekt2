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
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnClick(object sender, EventArgs e)
        {
            AddCar openForm = new AddCar();
            openForm.Show();
         
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
    }
}
