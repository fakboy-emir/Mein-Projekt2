namespace MeinProjekt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.fügenBtn = new System.Windows.Forms.Button();
            this.LöschenBtn = new System.Windows.Forms.Button();
            this.Suchenbtn = new System.Windows.Forms.Button();
            this.ausgebenBtn = new System.Windows.Forms.Button();
            this.Berechnenbtn = new System.Windows.Forms.Button();
            this.ZuweisenBtn = new System.Windows.Forms.Button();
            this.listlbl = new System.Windows.Forms.Label();
            this.Fahrzeugliste = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Zuladunglbl = new System.Windows.Forms.Label();
            this.Achsenlbl = new System.Windows.Forms.Label();
            this.Preislbl = new System.Windows.Forms.Label();
            this.Jahrlbl = new System.Windows.Forms.Label();
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Hubbtn = new System.Windows.Forms.TextBox();
            this.Hubraumlbl = new System.Windows.Forms.Label();
            this.Leistunglbl = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fügenBtn
            // 
            this.fügenBtn.Location = new System.Drawing.Point(12, 355);
            this.fügenBtn.Name = "fügenBtn";
            this.fügenBtn.Size = new System.Drawing.Size(154, 46);
            this.fügenBtn.TabIndex = 1;
            this.fügenBtn.Text = "Hinzufügen";
            this.fügenBtn.UseVisualStyleBackColor = true;
            this.fügenBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // LöschenBtn
            // 
            this.LöschenBtn.Location = new System.Drawing.Point(186, 355);
            this.LöschenBtn.Name = "LöschenBtn";
            this.LöschenBtn.Size = new System.Drawing.Size(154, 46);
            this.LöschenBtn.TabIndex = 2;
            this.LöschenBtn.Text = "Löschen";
            this.LöschenBtn.UseVisualStyleBackColor = true;
            this.LöschenBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Suchenbtn
            // 
            this.Suchenbtn.Location = new System.Drawing.Point(364, 357);
            this.Suchenbtn.Name = "Suchenbtn";
            this.Suchenbtn.Size = new System.Drawing.Size(135, 44);
            this.Suchenbtn.TabIndex = 4;
            this.Suchenbtn.Text = "Suchen";
            this.Suchenbtn.UseVisualStyleBackColor = true;
            // 
            // ausgebenBtn
            // 
            this.ausgebenBtn.Location = new System.Drawing.Point(12, 494);
            this.ausgebenBtn.Name = "ausgebenBtn";
            this.ausgebenBtn.Size = new System.Drawing.Size(154, 44);
            this.ausgebenBtn.TabIndex = 5;
            this.ausgebenBtn.Text = "Ausgeben";
            this.ausgebenBtn.UseVisualStyleBackColor = true;
            this.ausgebenBtn.Click += new System.EventHandler(this.ausgebenBtn_Click);
            // 
            // Berechnenbtn
            // 
            this.Berechnenbtn.Location = new System.Drawing.Point(186, 494);
            this.Berechnenbtn.Name = "Berechnenbtn";
            this.Berechnenbtn.Size = new System.Drawing.Size(154, 44);
            this.Berechnenbtn.TabIndex = 3;
            this.Berechnenbtn.Text = "Berechnen";
            this.Berechnenbtn.UseVisualStyleBackColor = true;
            this.Berechnenbtn.Click += new System.EventHandler(this.berechnenbtn_Click);
            // 
            // ZuweisenBtn
            // 
            this.ZuweisenBtn.Location = new System.Drawing.Point(364, 494);
            this.ZuweisenBtn.Name = "ZuweisenBtn";
            this.ZuweisenBtn.Size = new System.Drawing.Size(135, 44);
            this.ZuweisenBtn.TabIndex = 6;
            this.ZuweisenBtn.Text = "Zuweisen";
            this.ZuweisenBtn.UseVisualStyleBackColor = true;
            // 
            // listlbl
            // 
            this.listlbl.AutoSize = true;
            this.listlbl.Location = new System.Drawing.Point(87, 9);
            this.listlbl.Name = "listlbl";
            this.listlbl.Size = new System.Drawing.Size(135, 17);
            this.listlbl.TabIndex = 0;
            this.listlbl.Text = "Meine Fahrzeugliste";
            this.listlbl.Click += new System.EventHandler(this.listlbl_Click);
            // 
            // Fahrzeugliste
            // 
            this.Fahrzeugliste.FormattingEnabled = true;
            this.Fahrzeugliste.ItemHeight = 16;
            this.Fahrzeugliste.Location = new System.Drawing.Point(12, 29);
            this.Fahrzeugliste.Name = "Fahrzeugliste";
            this.Fahrzeugliste.Size = new System.Drawing.Size(502, 308);
            this.Fahrzeugliste.TabIndex = 7;
            this.Fahrzeugliste.DoubleClick += new System.EventHandler(this.Fahrzeugliste_DoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Zuladunglbl, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.Achsenlbl, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.Preislbl, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.Jahrlbl, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Typlbl7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Herstellerlbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Klasselbl, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.Modelllbl, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Kennzeichenlbl, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBox5, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.textBox6, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox8, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.Hubbtn, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.Hubraumlbl, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.Leistunglbl, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.textBox7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox9, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox10, 1, 10);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(564, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.37681F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.62319F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 509);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // Zuladunglbl
            // 
            this.Zuladunglbl.AutoSize = true;
            this.Zuladunglbl.Location = new System.Drawing.Point(3, 303);
            this.Zuladunglbl.Name = "Zuladunglbl";
            this.Zuladunglbl.Size = new System.Drawing.Size(68, 17);
            this.Zuladunglbl.TabIndex = 8;
            this.Zuladunglbl.Text = "Zuladung";
            // 
            // Achsenlbl
            // 
            this.Achsenlbl.AutoSize = true;
            this.Achsenlbl.Location = new System.Drawing.Point(3, 258);
            this.Achsenlbl.Name = "Achsenlbl";
            this.Achsenlbl.Size = new System.Drawing.Size(55, 17);
            this.Achsenlbl.TabIndex = 7;
            this.Achsenlbl.Text = "Achsen";
            // 
            // Preislbl
            // 
            this.Preislbl.AutoSize = true;
            this.Preislbl.Location = new System.Drawing.Point(3, 212);
            this.Preislbl.Name = "Preislbl";
            this.Preislbl.Size = new System.Drawing.Size(40, 17);
            this.Preislbl.TabIndex = 6;
            this.Preislbl.Text = "Preis";
            // 
            // Jahrlbl
            // 
            this.Jahrlbl.AutoSize = true;
            this.Jahrlbl.Location = new System.Drawing.Point(3, 167);
            this.Jahrlbl.Name = "Jahrlbl";
            this.Jahrlbl.Size = new System.Drawing.Size(36, 17);
            this.Jahrlbl.TabIndex = 5;
            this.Jahrlbl.Text = "Jahr";
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
            this.Herstellerlbl.Location = new System.Drawing.Point(3, 33);
            this.Herstellerlbl.Name = "Herstellerlbl";
            this.Herstellerlbl.Size = new System.Drawing.Size(69, 17);
            this.Herstellerlbl.TabIndex = 2;
            this.Herstellerlbl.Text = "Hersteller";
            // 
            // Klasselbl
            // 
            this.Klasselbl.AutoSize = true;
            this.Klasselbl.Location = new System.Drawing.Point(3, 441);
            this.Klasselbl.Name = "Klasselbl";
            this.Klasselbl.Size = new System.Drawing.Size(115, 17);
            this.Klasselbl.TabIndex = 11;
            this.Klasselbl.Text = "Schadstoffklasse";
            // 
            // Modelllbl
            // 
            this.Modelllbl.AutoSize = true;
            this.Modelllbl.Location = new System.Drawing.Point(3, 72);
            this.Modelllbl.Name = "Modelllbl";
            this.Modelllbl.Size = new System.Drawing.Size(49, 17);
            this.Modelllbl.TabIndex = 3;
            this.Modelllbl.Text = "Modell";
            // 
            // Kennzeichenlbl
            // 
            this.Kennzeichenlbl.AutoSize = true;
            this.Kennzeichenlbl.Location = new System.Drawing.Point(3, 124);
            this.Kennzeichenlbl.Name = "Kennzeichenlbl";
            this.Kennzeichenlbl.Size = new System.Drawing.Size(90, 17);
            this.Kennzeichenlbl.TabIndex = 4;
            this.Kennzeichenlbl.Text = "Kennzeichen";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(182, 261);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 22);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(182, 306);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 22);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(182, 127);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(161, 22);
            this.textBox6.TabIndex = 4;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(182, 393);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 22);
            this.textBox8.TabIndex = 10;
            // 
            // Hubbtn
            // 
            this.Hubbtn.Location = new System.Drawing.Point(182, 350);
            this.Hubbtn.Name = "Hubbtn";
            this.Hubbtn.Size = new System.Drawing.Size(121, 22);
            this.Hubbtn.TabIndex = 9;
            // 
            // Hubraumlbl
            // 
            this.Hubraumlbl.AutoSize = true;
            this.Hubraumlbl.Location = new System.Drawing.Point(3, 390);
            this.Hubraumlbl.Name = "Hubraumlbl";
            this.Hubraumlbl.Size = new System.Drawing.Size(66, 17);
            this.Hubraumlbl.TabIndex = 10;
            this.Hubraumlbl.Text = "Hubraum";
            // 
            // Leistunglbl
            // 
            this.Leistunglbl.AutoSize = true;
            this.Leistunglbl.Location = new System.Drawing.Point(3, 347);
            this.Leistunglbl.Name = "Leistunglbl";
            this.Leistunglbl.Size = new System.Drawing.Size(62, 17);
            this.Leistunglbl.TabIndex = 9;
            this.Leistunglbl.Text = "Leistung";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(182, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 22);
            this.textBox7.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(182, 170);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(121, 22);
            this.textBox9.TabIndex = 13;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(182, 444);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(121, 22);
            this.textBox10.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 590);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.listlbl);
            this.Controls.Add(this.Fahrzeugliste);
            this.Controls.Add(this.ZuweisenBtn);
            this.Controls.Add(this.Berechnenbtn);
            this.Controls.Add(this.ausgebenBtn);
            this.Controls.Add(this.Suchenbtn);
            this.Controls.Add(this.LöschenBtn);
            this.Controls.Add(this.fügenBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fügenBtn;
        private System.Windows.Forms.Button LöschenBtn;
        private System.Windows.Forms.Button Suchenbtn;
        private System.Windows.Forms.Button ausgebenBtn;
        private System.Windows.Forms.Button Berechnenbtn;
        private System.Windows.Forms.Button ZuweisenBtn;
        private System.Windows.Forms.Label listlbl;
        private System.Windows.Forms.ListBox Fahrzeugliste;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Zuladunglbl;
        private System.Windows.Forms.Label Achsenlbl;
        private System.Windows.Forms.Label Preislbl;
        private System.Windows.Forms.Label Jahrlbl;
        private System.Windows.Forms.Label Typlbl7;
        private System.Windows.Forms.Label Herstellerlbl;
        private System.Windows.Forms.Label Klasselbl;
        private System.Windows.Forms.Label Modelllbl;
        private System.Windows.Forms.Label Kennzeichenlbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox Hubbtn;
        private System.Windows.Forms.Label Hubraumlbl;
        private System.Windows.Forms.Label Leistunglbl;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
    }
}

