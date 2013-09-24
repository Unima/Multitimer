namespace Mtimer
{
    partial class Mtimer
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_1_1 = new System.Windows.Forms.Label();
            this.lab_1_2 = new System.Windows.Forms.Label();
            this.lab_1_3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Stunde = new System.Windows.Forms.TextBox();
            this.Minute = new System.Windows.Forms.TextBox();
            this.Secunde = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.BackColor = System.Drawing.SystemColors.Control;
            this.lab_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_Name.Location = new System.Drawing.Point(12, 12);
            this.lab_Name.MaximumSize = new System.Drawing.Size(0, 15);
            this.lab_Name.MinimumSize = new System.Drawing.Size(161, 0);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(161, 15);
            this.lab_Name.TabIndex = 0;
            this.lab_Name.Text = "Timer";
            this.lab_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lab_1_1
            // 
            this.lab_1_1.AutoSize = true;
            this.lab_1_1.Location = new System.Drawing.Point(36, 37);
            this.lab_1_1.Name = "lab_1_1";
            this.lab_1_1.Size = new System.Drawing.Size(10, 13);
            this.lab_1_1.TabIndex = 1;
            this.lab_1_1.Text = ":";
            // 
            // lab_1_2
            // 
            this.lab_1_2.AutoSize = true;
            this.lab_1_2.Location = new System.Drawing.Point(70, 37);
            this.lab_1_2.Name = "lab_1_2";
            this.lab_1_2.Size = new System.Drawing.Size(10, 13);
            this.lab_1_2.TabIndex = 2;
            this.lab_1_2.Text = ":";
            // 
            // lab_1_3
            // 
            this.lab_1_3.AutoSize = true;
            this.lab_1_3.Location = new System.Drawing.Point(12, 61);
            this.lab_1_3.Name = "lab_1_3";
            this.lab_1_3.Size = new System.Drawing.Size(43, 13);
            this.lab_1_3.TabIndex = 3;
            this.lab_1_3.Text = "Zielzeit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00:00";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(108, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stunde
            // 
            this.Stunde.Location = new System.Drawing.Point(12, 34);
            this.Stunde.Name = "Stunde";
            this.Stunde.Size = new System.Drawing.Size(22, 20);
            this.Stunde.TabIndex = 6;
            this.Stunde.Text = "0";
            this.Stunde.TextChanged += new System.EventHandler(this.Stunde_TextChanged);
            this.Stunde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Stunde_KeyPress);
            // 
            // Minute
            // 
            this.Minute.Location = new System.Drawing.Point(47, 34);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(22, 20);
            this.Minute.TabIndex = 7;
            this.Minute.Text = "0";
            this.Minute.TextChanged += new System.EventHandler(this.Minute_TextChanged);
            this.Minute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Minute_KeyPress);
            // 
            // Secunde
            // 
            this.Secunde.Location = new System.Drawing.Point(81, 34);
            this.Secunde.Name = "Secunde";
            this.Secunde.Size = new System.Drawing.Size(22, 20);
            this.Secunde.TabIndex = 8;
            this.Secunde.Text = "0";
            this.Secunde.TextChanged += new System.EventHandler(this.Secunde_TextChanged);
            this.Secunde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Secunde_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Mtimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Secunde);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.Stunde);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_1_3);
            this.Controls.Add(this.lab_1_2);
            this.Controls.Add(this.lab_1_1);
            this.Controls.Add(this.lab_Name);
            this.Name = "Mtimer";
            this.Size = new System.Drawing.Size(185, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_1_1;
        private System.Windows.Forms.Label lab_1_2;
        private System.Windows.Forms.Label lab_1_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Stunde;
        private System.Windows.Forms.TextBox Minute;
        private System.Windows.Forms.TextBox Secunde;
        private System.Windows.Forms.Timer timer1;
    }
}
