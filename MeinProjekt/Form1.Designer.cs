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
            this.Addbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.OutPutbtn = new System.Windows.Forms.Button();
            this.Calcbtn = new System.Windows.Forms.Button();
            this.Assignbtn = new System.Windows.Forms.Button();
            this.Fahrzeugliste = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(115, 100);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(154, 46);
            this.Addbtn.TabIndex = 3;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(609, 102);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(135, 44);
            this.Searchbtn.TabIndex = 5;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            // 
            // OutPutbtn
            // 
            this.OutPutbtn.Location = new System.Drawing.Point(609, 200);
            this.OutPutbtn.Name = "OutPutbtn";
            this.OutPutbtn.Size = new System.Drawing.Size(135, 44);
            this.OutPutbtn.TabIndex = 6;
            this.OutPutbtn.Text = "OutPut";
            this.OutPutbtn.UseVisualStyleBackColor = true;
            // 
            // Calcbtn
            // 
            this.Calcbtn.Location = new System.Drawing.Point(609, 298);
            this.Calcbtn.Name = "Calcbtn";
            this.Calcbtn.Size = new System.Drawing.Size(135, 44);
            this.Calcbtn.TabIndex = 7;
            this.Calcbtn.Text = "Calculate";
            this.Calcbtn.UseVisualStyleBackColor = true;
            // 
            // Assignbtn
            // 
            this.Assignbtn.Location = new System.Drawing.Point(609, 386);
            this.Assignbtn.Name = "Assignbtn";
            this.Assignbtn.Size = new System.Drawing.Size(135, 44);
            this.Assignbtn.TabIndex = 8;
            this.Assignbtn.Text = "Assign";
            this.Assignbtn.UseVisualStyleBackColor = true;
            // 
            // Fahrzeugliste
            // 
            this.Fahrzeugliste.FormattingEnabled = true;
            this.Fahrzeugliste.ItemHeight = 16;
            this.Fahrzeugliste.Items.AddRange(new object[] {
            "hallo"});
            this.Fahrzeugliste.Location = new System.Drawing.Point(275, 12);
            this.Fahrzeugliste.Name = "Fahrzeugliste";
            this.Fahrzeugliste.Size = new System.Drawing.Size(328, 468);
            this.Fahrzeugliste.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 500);
            this.Controls.Add(this.Fahrzeugliste);
            this.Controls.Add(this.Assignbtn);
            this.Controls.Add(this.Calcbtn);
            this.Controls.Add(this.OutPutbtn);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Addbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button OutPutbtn;
        private System.Windows.Forms.Button Calcbtn;
        private System.Windows.Forms.Button Assignbtn;
        private System.Windows.Forms.ListBox Fahrzeugliste;
    }
}

