namespace MeinProjekt
{
    partial class FahrzeugHinzufügen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.klassecombo = new System.Windows.Forms.ComboBox();
            this.Zuladunglbl = new System.Windows.Forms.Label();
            this.Achsenlbl = new System.Windows.Forms.Label();
            this.Preislbl = new System.Windows.Forms.Label();
            this.Jahrlbl = new System.Windows.Forms.Label();
            this.comboBoxFahrzeugtyp = new System.Windows.Forms.ComboBox();
            this.Typlbl7 = new System.Windows.Forms.Label();
            this.Herstellerlbl = new System.Windows.Forms.Label();
            this.Klasselbl = new System.Windows.Forms.Label();
            this.Modelllbl = new System.Windows.Forms.Label();
            this.Kennzeichenlbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Jahrcombo = new System.Windows.Forms.ComboBox();
            this.Hubbtn = new System.Windows.Forms.TextBox();
            this.Hubraumlbl = new System.Windows.Forms.Label();
            this.Leistunglbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PkwMarkenCombo = new System.Windows.Forms.ComboBox();
            this.LKWMarkenCombo = new System.Windows.Forms.ComboBox();
            this.MotoMarkenCombo = new System.Windows.Forms.ComboBox();
            this.Steuernlbl = new System.Windows.Forms.Label();
            this.maskedkenn = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.maskedkenn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.klassecombo, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.Zuladunglbl, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Achsenlbl, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Preislbl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Jahrlbl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxFahrzeugtyp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Typlbl7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Herstellerlbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Klasselbl, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.Modelllbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Kennzeichenlbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.Jahrcombo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Hubbtn, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.Hubraumlbl, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.Leistunglbl, 0, 8);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(149, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.37681F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.62319F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // klassecombo
            // 
            this.klassecombo.FormattingEnabled = true;
            this.klassecombo.Items.AddRange(new object[] {
            "-1",
            "0",
            "+1"});
            this.klassecombo.Location = new System.Drawing.Point(176, 448);
            this.klassecombo.Name = "klassecombo";
            this.klassecombo.Size = new System.Drawing.Size(121, 24);
            this.klassecombo.TabIndex = 11;
            // 
            // Zuladunglbl
            // 
            this.Zuladunglbl.AutoSize = true;
            this.Zuladunglbl.Location = new System.Drawing.Point(3, 307);
            this.Zuladunglbl.Name = "Zuladunglbl";
            this.Zuladunglbl.Size = new System.Drawing.Size(68, 17);
            this.Zuladunglbl.TabIndex = 8;
            this.Zuladunglbl.Text = "Zuladung";
            // 
            // Achsenlbl
            // 
            this.Achsenlbl.AutoSize = true;
            this.Achsenlbl.Location = new System.Drawing.Point(3, 262);
            this.Achsenlbl.Name = "Achsenlbl";
            this.Achsenlbl.Size = new System.Drawing.Size(55, 17);
            this.Achsenlbl.TabIndex = 7;
            this.Achsenlbl.Text = "Achsen";
            // 
            // Preislbl
            // 
            this.Preislbl.AutoSize = true;
            this.Preislbl.Location = new System.Drawing.Point(3, 216);
            this.Preislbl.Name = "Preislbl";
            this.Preislbl.Size = new System.Drawing.Size(40, 17);
            this.Preislbl.TabIndex = 6;
            this.Preislbl.Text = "Preis";
            // 
            // Jahrlbl
            // 
            this.Jahrlbl.AutoSize = true;
            this.Jahrlbl.Location = new System.Drawing.Point(3, 171);
            this.Jahrlbl.Name = "Jahrlbl";
            this.Jahrlbl.Size = new System.Drawing.Size(36, 17);
            this.Jahrlbl.TabIndex = 5;
            this.Jahrlbl.Text = "Jahr";
            // 
            // comboBoxFahrzeugtyp
            // 
            this.comboBoxFahrzeugtyp.FormattingEnabled = true;
            this.comboBoxFahrzeugtyp.Items.AddRange(new object[] {
            "PKW",
            "LKW",
            "Motorrad"});
            this.comboBoxFahrzeugtyp.Location = new System.Drawing.Point(176, 3);
            this.comboBoxFahrzeugtyp.Name = "comboBoxFahrzeugtyp";
            this.comboBoxFahrzeugtyp.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFahrzeugtyp.TabIndex = 1;
            this.comboBoxFahrzeugtyp.SelectedIndexChanged += new System.EventHandler(this.comboBoxFahrzeugtyp_SelectedIndexChanged);
            // 
            // Typlbl7
            // 
            this.Typlbl7.AutoSize = true;
            this.Typlbl7.Location = new System.Drawing.Point(3, 0);
            this.Typlbl7.Name = "Typlbl7";
            this.Typlbl7.Size = new System.Drawing.Size(92, 17);
            this.Typlbl7.TabIndex = 1;
            this.Typlbl7.Text = "FahrzeugTyp";
            // 
            // Herstellerlbl
            // 
            this.Herstellerlbl.AutoSize = true;
            this.Herstellerlbl.Location = new System.Drawing.Point(3, 35);
            this.Herstellerlbl.Name = "Herstellerlbl";
            this.Herstellerlbl.Size = new System.Drawing.Size(69, 17);
            this.Herstellerlbl.TabIndex = 2;
            this.Herstellerlbl.Text = "Hersteller";
            // 
            // Klasselbl
            // 
            this.Klasselbl.AutoSize = true;
            this.Klasselbl.Location = new System.Drawing.Point(3, 445);
            this.Klasselbl.Name = "Klasselbl";
            this.Klasselbl.Size = new System.Drawing.Size(115, 17);
            this.Klasselbl.TabIndex = 11;
            this.Klasselbl.Text = "Schadstoffklasse";
            // 
            // Modelllbl
            // 
            this.Modelllbl.AutoSize = true;
            this.Modelllbl.Location = new System.Drawing.Point(3, 76);
            this.Modelllbl.Name = "Modelllbl";
            this.Modelllbl.Size = new System.Drawing.Size(49, 17);
            this.Modelllbl.TabIndex = 3;
            this.Modelllbl.Text = "Modell";
            // 
            // Kennzeichenlbl
            // 
            this.Kennzeichenlbl.AutoSize = true;
            this.Kennzeichenlbl.Location = new System.Drawing.Point(3, 128);
            this.Kennzeichenlbl.Name = "Kennzeichenlbl";
            this.Kennzeichenlbl.Size = new System.Drawing.Size(90, 17);
            this.Kennzeichenlbl.TabIndex = 4;
            this.Kennzeichenlbl.Text = "Kennzeichen";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 219);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 265);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(176, 310);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 22);
            this.textBox5.TabIndex = 8;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(176, 397);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 22);
            this.textBox8.TabIndex = 10;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // Jahrcombo
            // 
            this.Jahrcombo.FormattingEnabled = true;
            this.Jahrcombo.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.Jahrcombo.Location = new System.Drawing.Point(176, 174);
            this.Jahrcombo.Name = "Jahrcombo";
            this.Jahrcombo.Size = new System.Drawing.Size(121, 24);
            this.Jahrcombo.TabIndex = 5;
            // 
            // Hubbtn
            // 
            this.Hubbtn.Location = new System.Drawing.Point(176, 354);
            this.Hubbtn.Name = "Hubbtn";
            this.Hubbtn.Size = new System.Drawing.Size(121, 22);
            this.Hubbtn.TabIndex = 9;
            this.Hubbtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hubbtn_KeyPress);
            // 
            // Hubraumlbl
            // 
            this.Hubraumlbl.AutoSize = true;
            this.Hubraumlbl.Location = new System.Drawing.Point(3, 394);
            this.Hubraumlbl.Name = "Hubraumlbl";
            this.Hubraumlbl.Size = new System.Drawing.Size(66, 17);
            this.Hubraumlbl.TabIndex = 10;
            this.Hubraumlbl.Text = "Hubraum";
            // 
            // Leistunglbl
            // 
            this.Leistunglbl.AutoSize = true;
            this.Leistunglbl.Location = new System.Drawing.Point(3, 351);
            this.Leistunglbl.Name = "Leistunglbl";
            this.Leistunglbl.Size = new System.Drawing.Size(62, 17);
            this.Leistunglbl.TabIndex = 9;
            this.Leistunglbl.Text = "Leistung";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(616, 490);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(129, 35);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PkwMarkenCombo
            // 
            this.PkwMarkenCombo.FormattingEnabled = true;
            this.PkwMarkenCombo.Items.AddRange(new object[] {
            "Achilles",
            "Acura",
            "Adler",
            "Aeon",
            "Offord",
            "Omega",
            "Savage",
            "Sebring",
            "Zoe",
            "Zuggy",
            "Zim",
            "Worthington",
            "VP",
            "Vinci"});
            this.PkwMarkenCombo.Location = new System.Drawing.Point(624, 440);
            this.PkwMarkenCombo.Name = "PkwMarkenCombo";
            this.PkwMarkenCombo.Size = new System.Drawing.Size(121, 24);
            this.PkwMarkenCombo.TabIndex = 2;
            // 
            // LKWMarkenCombo
            // 
            this.LKWMarkenCombo.FormattingEnabled = true;
            this.LKWMarkenCombo.Items.AddRange(new object[] {
            "Albion",
            "AMO",
            "Laffly",
            "Magirus",
            "Miele",
            "NAW",
            "Opel",
            "Peerless",
            "Reliance",
            "Robur",
            "Sterling Trucks",
            "Tribelhorn",
            "Unic",
            "White"});
            this.LKWMarkenCombo.Location = new System.Drawing.Point(624, 385);
            this.LKWMarkenCombo.Name = "LKWMarkenCombo";
            this.LKWMarkenCombo.Size = new System.Drawing.Size(121, 24);
            this.LKWMarkenCombo.TabIndex = 3;
            // 
            // MotoMarkenCombo
            // 
            this.MotoMarkenCombo.FormattingEnabled = true;
            this.MotoMarkenCombo.Items.AddRange(new object[] {
            "Harley-Davidson",
            "BMW-Motorrad",
            "Aprilia",
            "Horex",
            "Moto Guzzi",
            "Boss Hoss",
            "Buell",
            "DieselWiesel",
            "MZ",
            "SYM",
            "Yamaha",
            "Zero",
            "Royal Enfield",
            "Scorpa"});
            this.MotoMarkenCombo.Location = new System.Drawing.Point(624, 335);
            this.MotoMarkenCombo.Name = "MotoMarkenCombo";
            this.MotoMarkenCombo.Size = new System.Drawing.Size(121, 24);
            this.MotoMarkenCombo.TabIndex = 4;
            this.MotoMarkenCombo.SelectedIndexChanged += new System.EventHandler(this.MotoMarkenCombo_SelectedIndexChanged);
            // 
            // Steuernlbl
            // 
            this.Steuernlbl.AutoSize = true;
            this.Steuernlbl.Location = new System.Drawing.Point(659, 293);
            this.Steuernlbl.Name = "Steuernlbl";
            this.Steuernlbl.Size = new System.Drawing.Size(86, 17);
            this.Steuernlbl.TabIndex = 5;
            this.Steuernlbl.Text = "Ihre Steuern";
            // 
            // maskedkenn
            // 
            this.maskedkenn.Location = new System.Drawing.Point(176, 131);
            this.maskedkenn.Mask = "K-LL-0000";
            this.maskedkenn.Name = "maskedkenn";
            this.maskedkenn.Size = new System.Drawing.Size(121, 22);
            this.maskedkenn.TabIndex = 10;
            // 
            // FahrzeugHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.Steuernlbl);
            this.Controls.Add(this.MotoMarkenCombo);
            this.Controls.Add(this.LKWMarkenCombo);
            this.Controls.Add(this.PkwMarkenCombo);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FahrzeugHinzufügen";
            this.Text = "AddCar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FahrzeugHinzufügen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label Typlbl7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxFahrzeugtyp;
        private System.Windows.Forms.Label Herstellerlbl;
        private System.Windows.Forms.Label Kennzeichenlbl;
        private System.Windows.Forms.Label Modelllbl;
        private System.Windows.Forms.Label Preislbl;
        private System.Windows.Forms.Label Jahrlbl;
        private System.Windows.Forms.Label Achsenlbl;
        private System.Windows.Forms.ComboBox klassecombo;
        private System.Windows.Forms.Label Leistunglbl;
        private System.Windows.Forms.Label Hubraumlbl;
        private System.Windows.Forms.Label Zuladunglbl;
        private System.Windows.Forms.Label Klasselbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox Hubbtn;
        private System.Windows.Forms.TextBox textBox8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox Jahrcombo;
        private System.Windows.Forms.ComboBox PkwMarkenCombo;
        private System.Windows.Forms.ComboBox LKWMarkenCombo;
        private System.Windows.Forms.ComboBox MotoMarkenCombo;
        private System.Windows.Forms.Label Steuernlbl;
        private System.Windows.Forms.MaskedTextBox maskedkenn;
    }
}