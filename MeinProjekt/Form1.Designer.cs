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
            this.Fahrzeuge = new System.Windows.Forms.GroupBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fahrzeuge
            // 
            this.Fahrzeuge.Location = new System.Drawing.Point(275, 12);
            this.Fahrzeuge.Name = "Fahrzeuge";
            this.Fahrzeuge.Size = new System.Drawing.Size(328, 459);
            this.Fahrzeuge.TabIndex = 0;
            this.Fahrzeuge.TabStop = false;
            this.Fahrzeuge.Text = "FahrzeugListe";
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(609, 192);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(154, 46);
            this.Addbtn.TabIndex = 3;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Fahrzeuge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Fahrzeuge;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button button1;
    }
}

