﻿namespace MeinProjekt
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
            this.listlbl = new System.Windows.Forms.Label();
            this.Fahrzeugliste = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.steuerschuldlbl = new System.Windows.Forms.Label();
            this.maskedkenn = new System.Windows.Forms.MaskedTextBox();
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
            this.HerstellerText = new System.Windows.Forms.TextBox();
            this.ModellText = new System.Windows.Forms.TextBox();
            this.PreisText = new System.Windows.Forms.TextBox();
            this.AchsenText = new System.Windows.Forms.TextBox();
            this.Hubraumlbl = new System.Windows.Forms.Label();
            this.Leistunglbl = new System.Windows.Forms.Label();
            this.ZuladungText = new System.Windows.Forms.TextBox();
            this.HubraumText = new System.Windows.Forms.TextBox();
            this.SteuerschuldText = new System.Windows.Forms.TextBox();
            this.Jahrcombo = new System.Windows.Forms.ComboBox();
            this.LeistungText = new System.Windows.Forms.TextBox();
            this.klassecombo = new System.Windows.Forms.ComboBox();
            this.GesSteuerbtn = new System.Windows.Forms.Button();
            this.SuchMask = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hilfebtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fügenBtn
            // 
            this.fügenBtn.BackColor = System.Drawing.Color.Silver;
            this.fügenBtn.ForeColor = System.Drawing.Color.Black;
            this.fügenBtn.Location = new System.Drawing.Point(12, 384);
            this.fügenBtn.Name = "fügenBtn";
            this.fügenBtn.Size = new System.Drawing.Size(154, 46);
            this.fügenBtn.TabIndex = 1;
            this.fügenBtn.Text = "Hinzufügen";
            this.fügenBtn.UseVisualStyleBackColor = false;
            this.fügenBtn.Click += new System.EventHandler(this.Hinzufügen_Click);
            // 
            // LöschenBtn
            // 
            this.LöschenBtn.BackColor = System.Drawing.Color.Silver;
            this.LöschenBtn.Location = new System.Drawing.Point(346, 384);
            this.LöschenBtn.Name = "LöschenBtn";
            this.LöschenBtn.Size = new System.Drawing.Size(154, 46);
            this.LöschenBtn.TabIndex = 2;
            this.LöschenBtn.Text = "Löschen";
            this.LöschenBtn.UseVisualStyleBackColor = false;
            this.LöschenBtn.Click += new System.EventHandler(this.Lösch_Click);
            // 
            // Suchenbtn
            // 
            this.Suchenbtn.BackColor = System.Drawing.Color.Silver;
            this.Suchenbtn.Location = new System.Drawing.Point(186, 501);
            this.Suchenbtn.Name = "Suchenbtn";
            this.Suchenbtn.Size = new System.Drawing.Size(154, 44);
            this.Suchenbtn.TabIndex = 4;
            this.Suchenbtn.Text = "Suchen";
            this.Suchenbtn.UseVisualStyleBackColor = false;
            this.Suchenbtn.Click += new System.EventHandler(this.Suchenbtn_Click);
            // 
            // listlbl
            // 
            this.listlbl.AutoSize = true;
            this.listlbl.ForeColor = System.Drawing.Color.Silver;
            this.listlbl.Location = new System.Drawing.Point(87, 9);
            this.listlbl.Name = "listlbl";
            this.listlbl.Size = new System.Drawing.Size(167, 17);
            this.listlbl.TabIndex = 0;
            this.listlbl.Text = "Ihre Erstellten Fahrzeuge";
            // 
            // Fahrzeugliste
            // 
            this.Fahrzeugliste.BackColor = System.Drawing.Color.Silver;
            this.Fahrzeugliste.FormattingEnabled = true;
            this.Fahrzeugliste.ItemHeight = 16;
            this.Fahrzeugliste.Items.AddRange(new object[] {
            "K-GS-01",
            "K-GS-02",
            "K-GS-03",
            "K-GS-04"});
            this.Fahrzeugliste.Location = new System.Drawing.Point(12, 29);
            this.Fahrzeugliste.Name = "Fahrzeugliste";
            this.Fahrzeugliste.Size = new System.Drawing.Size(502, 340);
            this.Fahrzeugliste.TabIndex = 7;
            this.Fahrzeugliste.SelectedIndexChanged += new System.EventHandler(this.Fahrzeugliste_SelectedIndexChanged);
            this.Fahrzeugliste.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Fahrzeugliste_MouseDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel2.Controls.Add(this.steuerschuldlbl, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.maskedkenn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.Zuladunglbl, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.Achsenlbl, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.Preislbl, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.Jahrlbl, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxFahrzeugtyp, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Typlbl7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Herstellerlbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Klasselbl, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.Modelllbl, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Kennzeichenlbl, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.HerstellerText, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ModellText, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.PreisText, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.AchsenText, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.Hubraumlbl, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.Leistunglbl, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.ZuladungText, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.HubraumText, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.SteuerschuldText, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.Jahrcombo, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.LeistungText, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.klassecombo, 1, 10);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(554, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(407, 581);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // steuerschuldlbl
            // 
            this.steuerschuldlbl.AutoSize = true;
            this.steuerschuldlbl.Location = new System.Drawing.Point(3, 528);
            this.steuerschuldlbl.Name = "steuerschuldlbl";
            this.steuerschuldlbl.Size = new System.Drawing.Size(91, 17);
            this.steuerschuldlbl.TabIndex = 19;
            this.steuerschuldlbl.Text = "Steuerschuld";
            // 
            // maskedkenn
            // 
            this.maskedkenn.BackColor = System.Drawing.Color.Silver;
            this.maskedkenn.Enabled = false;
            this.maskedkenn.Location = new System.Drawing.Point(202, 147);
            this.maskedkenn.Mask = "K-LL-0000";
            this.maskedkenn.Name = "maskedkenn";
            this.maskedkenn.Size = new System.Drawing.Size(121, 22);
            this.maskedkenn.TabIndex = 10;
            // 
            // Zuladunglbl
            // 
            this.Zuladunglbl.AutoSize = true;
            this.Zuladunglbl.Location = new System.Drawing.Point(3, 336);
            this.Zuladunglbl.Name = "Zuladunglbl";
            this.Zuladunglbl.Size = new System.Drawing.Size(68, 17);
            this.Zuladunglbl.TabIndex = 8;
            this.Zuladunglbl.Text = "Zuladung";
            // 
            // Achsenlbl
            // 
            this.Achsenlbl.AutoSize = true;
            this.Achsenlbl.Location = new System.Drawing.Point(3, 288);
            this.Achsenlbl.Name = "Achsenlbl";
            this.Achsenlbl.Size = new System.Drawing.Size(55, 17);
            this.Achsenlbl.TabIndex = 7;
            this.Achsenlbl.Text = "Achsen";
            // 
            // Preislbl
            // 
            this.Preislbl.AutoSize = true;
            this.Preislbl.Location = new System.Drawing.Point(3, 240);
            this.Preislbl.Name = "Preislbl";
            this.Preislbl.Size = new System.Drawing.Size(40, 17);
            this.Preislbl.TabIndex = 6;
            this.Preislbl.Text = "Preis";
            // 
            // Jahrlbl
            // 
            this.Jahrlbl.AutoSize = true;
            this.Jahrlbl.Location = new System.Drawing.Point(3, 192);
            this.Jahrlbl.Name = "Jahrlbl";
            this.Jahrlbl.Size = new System.Drawing.Size(36, 17);
            this.Jahrlbl.TabIndex = 5;
            this.Jahrlbl.Text = "Jahr";
            // 
            // comboBoxFahrzeugtyp
            // 
            this.comboBoxFahrzeugtyp.AllowDrop = true;
            this.comboBoxFahrzeugtyp.BackColor = System.Drawing.Color.Silver;
            this.comboBoxFahrzeugtyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFahrzeugtyp.Enabled = false;
            this.comboBoxFahrzeugtyp.ForeColor = System.Drawing.Color.White;
            this.comboBoxFahrzeugtyp.FormattingEnabled = true;
            this.comboBoxFahrzeugtyp.Items.AddRange(new object[] {
            "PKW",
            "LKW",
            "Motorrad"});
            this.comboBoxFahrzeugtyp.Location = new System.Drawing.Point(202, 3);
            this.comboBoxFahrzeugtyp.Name = "comboBoxFahrzeugtyp";
            this.comboBoxFahrzeugtyp.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFahrzeugtyp.TabIndex = 1;
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
            this.Herstellerlbl.Location = new System.Drawing.Point(3, 48);
            this.Herstellerlbl.Name = "Herstellerlbl";
            this.Herstellerlbl.Size = new System.Drawing.Size(69, 17);
            this.Herstellerlbl.TabIndex = 2;
            this.Herstellerlbl.Text = "Hersteller";
            // 
            // Klasselbl
            // 
            this.Klasselbl.AutoSize = true;
            this.Klasselbl.Location = new System.Drawing.Point(3, 480);
            this.Klasselbl.Name = "Klasselbl";
            this.Klasselbl.Size = new System.Drawing.Size(115, 17);
            this.Klasselbl.TabIndex = 11;
            this.Klasselbl.Text = "Schadstoffklasse";
            // 
            // Modelllbl
            // 
            this.Modelllbl.AutoSize = true;
            this.Modelllbl.Location = new System.Drawing.Point(3, 96);
            this.Modelllbl.Name = "Modelllbl";
            this.Modelllbl.Size = new System.Drawing.Size(49, 17);
            this.Modelllbl.TabIndex = 3;
            this.Modelllbl.Text = "Modell";
            // 
            // Kennzeichenlbl
            // 
            this.Kennzeichenlbl.AutoSize = true;
            this.Kennzeichenlbl.Location = new System.Drawing.Point(3, 144);
            this.Kennzeichenlbl.Name = "Kennzeichenlbl";
            this.Kennzeichenlbl.Size = new System.Drawing.Size(90, 17);
            this.Kennzeichenlbl.TabIndex = 4;
            this.Kennzeichenlbl.Text = "Kennzeichen";
            // 
            // HerstellerText
            // 
            this.HerstellerText.BackColor = System.Drawing.Color.Silver;
            this.HerstellerText.Enabled = false;
            this.HerstellerText.ForeColor = System.Drawing.Color.White;
            this.HerstellerText.Location = new System.Drawing.Point(202, 51);
            this.HerstellerText.Name = "HerstellerText";
            this.HerstellerText.Size = new System.Drawing.Size(121, 22);
            this.HerstellerText.TabIndex = 2;
            // 
            // ModellText
            // 
            this.ModellText.BackColor = System.Drawing.Color.Silver;
            this.ModellText.Enabled = false;
            this.ModellText.Location = new System.Drawing.Point(202, 99);
            this.ModellText.Name = "ModellText";
            this.ModellText.Size = new System.Drawing.Size(121, 22);
            this.ModellText.TabIndex = 3;
            // 
            // PreisText
            // 
            this.PreisText.BackColor = System.Drawing.Color.Silver;
            this.PreisText.Enabled = false;
            this.PreisText.Location = new System.Drawing.Point(202, 243);
            this.PreisText.Name = "PreisText";
            this.PreisText.Size = new System.Drawing.Size(121, 22);
            this.PreisText.TabIndex = 6;
            // 
            // AchsenText
            // 
            this.AchsenText.BackColor = System.Drawing.Color.Silver;
            this.AchsenText.Enabled = false;
            this.AchsenText.Location = new System.Drawing.Point(202, 291);
            this.AchsenText.Name = "AchsenText";
            this.AchsenText.Size = new System.Drawing.Size(121, 22);
            this.AchsenText.TabIndex = 7;
            // 
            // Hubraumlbl
            // 
            this.Hubraumlbl.AutoSize = true;
            this.Hubraumlbl.Location = new System.Drawing.Point(3, 432);
            this.Hubraumlbl.Name = "Hubraumlbl";
            this.Hubraumlbl.Size = new System.Drawing.Size(66, 17);
            this.Hubraumlbl.TabIndex = 10;
            this.Hubraumlbl.Text = "Hubraum";
            // 
            // Leistunglbl
            // 
            this.Leistunglbl.AutoSize = true;
            this.Leistunglbl.Location = new System.Drawing.Point(3, 384);
            this.Leistunglbl.Name = "Leistunglbl";
            this.Leistunglbl.Size = new System.Drawing.Size(62, 17);
            this.Leistunglbl.TabIndex = 9;
            this.Leistunglbl.Text = "Leistung";
            // 
            // ZuladungText
            // 
            this.ZuladungText.BackColor = System.Drawing.Color.Silver;
            this.ZuladungText.Enabled = false;
            this.ZuladungText.Location = new System.Drawing.Point(202, 339);
            this.ZuladungText.Name = "ZuladungText";
            this.ZuladungText.Size = new System.Drawing.Size(121, 22);
            this.ZuladungText.TabIndex = 8;
            // 
            // HubraumText
            // 
            this.HubraumText.BackColor = System.Drawing.Color.Silver;
            this.HubraumText.Enabled = false;
            this.HubraumText.Location = new System.Drawing.Point(202, 435);
            this.HubraumText.Name = "HubraumText";
            this.HubraumText.Size = new System.Drawing.Size(121, 22);
            this.HubraumText.TabIndex = 9;
            // 
            // SteuerschuldText
            // 
            this.SteuerschuldText.BackColor = System.Drawing.Color.Silver;
            this.SteuerschuldText.Enabled = false;
            this.SteuerschuldText.Location = new System.Drawing.Point(202, 531);
            this.SteuerschuldText.Name = "SteuerschuldText";
            this.SteuerschuldText.Size = new System.Drawing.Size(121, 22);
            this.SteuerschuldText.TabIndex = 20;
            // 
            // Jahrcombo
            // 
            this.Jahrcombo.BackColor = System.Drawing.Color.Silver;
            this.Jahrcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Jahrcombo.Enabled = false;
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
            this.Jahrcombo.Location = new System.Drawing.Point(202, 195);
            this.Jahrcombo.Name = "Jahrcombo";
            this.Jahrcombo.Size = new System.Drawing.Size(121, 24);
            this.Jahrcombo.TabIndex = 5;
            // 
            // LeistungText
            // 
            this.LeistungText.BackColor = System.Drawing.Color.Silver;
            this.LeistungText.Enabled = false;
            this.LeistungText.Location = new System.Drawing.Point(202, 387);
            this.LeistungText.Name = "LeistungText";
            this.LeistungText.Size = new System.Drawing.Size(121, 22);
            this.LeistungText.TabIndex = 10;
            // 
            // klassecombo
            // 
            this.klassecombo.BackColor = System.Drawing.Color.Silver;
            this.klassecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.klassecombo.Enabled = false;
            this.klassecombo.FormattingEnabled = true;
            this.klassecombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.klassecombo.Location = new System.Drawing.Point(202, 483);
            this.klassecombo.Name = "klassecombo";
            this.klassecombo.Size = new System.Drawing.Size(121, 24);
            this.klassecombo.TabIndex = 11;
            // 
            // GesSteuerbtn
            // 
            this.GesSteuerbtn.BackColor = System.Drawing.Color.Silver;
            this.GesSteuerbtn.Location = new System.Drawing.Point(12, 501);
            this.GesSteuerbtn.Name = "GesSteuerbtn";
            this.GesSteuerbtn.Size = new System.Drawing.Size(154, 44);
            this.GesSteuerbtn.TabIndex = 17;
            this.GesSteuerbtn.Text = "Gesamt Steuer";
            this.GesSteuerbtn.UseVisualStyleBackColor = false;
            this.GesSteuerbtn.Click += new System.EventHandler(this.GesShuldenbtn_Click);
            // 
            // SuchMask
            // 
            this.SuchMask.BackColor = System.Drawing.Color.Silver;
            this.SuchMask.Location = new System.Drawing.Point(222, 473);
            this.SuchMask.Mask = "K-LL-0000";
            this.SuchMask.Name = "SuchMask";
            this.SuchMask.Size = new System.Drawing.Size(86, 22);
            this.SuchMask.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(633, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Die Werte ihres Gesuchten Fahrzeuges";
            // 
            // Hilfebtn
            // 
            this.Hilfebtn.BackColor = System.Drawing.Color.Silver;
            this.Hilfebtn.Location = new System.Drawing.Point(346, 500);
            this.Hilfebtn.Name = "Hilfebtn";
            this.Hilfebtn.Size = new System.Drawing.Size(154, 45);
            this.Hilfebtn.TabIndex = 20;
            this.Hilfebtn.Text = "Hilfe zur Form";
            this.Hilfebtn.UseVisualStyleBackColor = false;
            this.Hilfebtn.Click += new System.EventHandler(this.Hilfebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(985, 634);
            this.Controls.Add(this.Hilfebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SuchMask);
            this.Controls.Add(this.GesSteuerbtn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.listlbl);
            this.Controls.Add(this.Fahrzeugliste);
            this.Controls.Add(this.Suchenbtn);
            this.Controls.Add(this.LöschenBtn);
            this.Controls.Add(this.fügenBtn);
            this.Name = "Form1";
            this.Text = "Ihre Fahrzeugverwalting";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fügenBtn;
        private System.Windows.Forms.Button LöschenBtn;
        private System.Windows.Forms.Button Suchenbtn;
        private System.Windows.Forms.Label listlbl;
        private System.Windows.Forms.ListBox Fahrzeugliste;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MaskedTextBox maskedkenn;
        private System.Windows.Forms.ComboBox klassecombo;
        private System.Windows.Forms.Label Zuladunglbl;
        private System.Windows.Forms.Label Achsenlbl;
        private System.Windows.Forms.Label Preislbl;
        private System.Windows.Forms.Label Jahrlbl;
        private System.Windows.Forms.TextBox LeistungText;
        private System.Windows.Forms.ComboBox comboBoxFahrzeugtyp;
        private System.Windows.Forms.Label Typlbl7;
        private System.Windows.Forms.Label Herstellerlbl;
        private System.Windows.Forms.Label Klasselbl;
        private System.Windows.Forms.Label Modelllbl;
        private System.Windows.Forms.Label Kennzeichenlbl;
        private System.Windows.Forms.TextBox HerstellerText;
        private System.Windows.Forms.TextBox ModellText;
        private System.Windows.Forms.TextBox PreisText;
        private System.Windows.Forms.TextBox AchsenText;
        private System.Windows.Forms.ComboBox Jahrcombo;
        private System.Windows.Forms.Label Hubraumlbl;
        private System.Windows.Forms.Label Leistunglbl;
        private System.Windows.Forms.TextBox ZuladungText;
        private System.Windows.Forms.TextBox HubraumText;
        private System.Windows.Forms.Button GesSteuerbtn;
        private System.Windows.Forms.MaskedTextBox SuchMask;
        private System.Windows.Forms.Label steuerschuldlbl;
        private System.Windows.Forms.TextBox SteuerschuldText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Hilfebtn;
    }
}

