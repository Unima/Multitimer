namespace MultiTimer
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
            this.components = new System.ComponentModel.Container();
            this.mtimer1 = new Mtimer.Mtimer();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtimer2 = new Mtimer.Mtimer();
            this.mtimer3 = new Mtimer.Mtimer();
            this.mtimer4 = new Mtimer.Mtimer();
            this.mtimer5 = new Mtimer.Mtimer();
            this.mtimer6 = new Mtimer.Mtimer();
            this.mtimer7 = new Mtimer.Mtimer();
            this.mtimer8 = new Mtimer.Mtimer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtimer1
            // 
            this.mtimer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtimer1.Endschalter = false;
            this.mtimer1.Location = new System.Drawing.Point(12, 50);
            this.mtimer1.Name = "mtimer1";
            this.mtimer1.Size = new System.Drawing.Size(185, 85);
            this.mtimer1.TabIndex = 0;
            this.mtimer1.Timername = "Timer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.MinimumSize = new System.Drawing.Size(185, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(308, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trickerToolStripMenuItem,
            this.form2ToolStripMenuItem});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programmToolStripMenuItem.Text = "Programm";
            // 
            // trickerToolStripMenuItem
            // 
            this.trickerToolStripMenuItem.Name = "trickerToolStripMenuItem";
            this.trickerToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.trickerToolStripMenuItem.Text = "Tricker";
            this.trickerToolStripMenuItem.Click += new System.EventHandler(this.trickerToolStripMenuItem_Click);
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.form2ToolStripMenuItem.Text = "Configuration";
            this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
            // 
            // mtimer2
            // 
            this.mtimer2.BackColor = System.Drawing.SystemColors.Control;
            this.mtimer2.Endschalter = false;
            this.mtimer2.Location = new System.Drawing.Point(12, 141);
            this.mtimer2.Name = "mtimer2";
            this.mtimer2.Size = new System.Drawing.Size(185, 85);
            this.mtimer2.TabIndex = 3;
            this.mtimer2.Timername = "Timer";
            // 
            // mtimer3
            // 
            this.mtimer3.BackColor = System.Drawing.SystemColors.Control;
            this.mtimer3.Endschalter = false;
            this.mtimer3.Location = new System.Drawing.Point(12, 232);
            this.mtimer3.Name = "mtimer3";
            this.mtimer3.Size = new System.Drawing.Size(185, 85);
            this.mtimer3.TabIndex = 4;
            this.mtimer3.Timername = "Timer";
            // 
            // mtimer4
            // 
            this.mtimer4.BackColor = System.Drawing.SystemColors.Control;
            this.mtimer4.Endschalter = false;
            this.mtimer4.Location = new System.Drawing.Point(12, 323);
            this.mtimer4.Name = "mtimer4";
            this.mtimer4.Size = new System.Drawing.Size(185, 85);
            this.mtimer4.TabIndex = 5;
            this.mtimer4.Timername = "Timer";
            // 
            // mtimer5
            // 
            this.mtimer5.BackColor = System.Drawing.SystemColors.Control;
            this.mtimer5.Endschalter = false;
            this.mtimer5.Location = new System.Drawing.Point(12, 414);
            this.mtimer5.Name = "mtimer5";
            this.mtimer5.Size = new System.Drawing.Size(185, 85);
            this.mtimer5.TabIndex = 6;
            this.mtimer5.Timername = "Timer";
            // 
            // mtimer6
            // 
            this.mtimer6.BackColor = System.Drawing.SystemColors.Control;
            this.mtimer6.Endschalter = false;
            this.mtimer6.Location = new System.Drawing.Point(12, 505);
            this.mtimer6.Name = "mtimer6";
            this.mtimer6.Size = new System.Drawing.Size(185, 85);
            this.mtimer6.TabIndex = 7;
            this.mtimer6.Timername = "Timer";
            this.mtimer6.Visible = false;
            // 
            // mtimer7
            // 
            this.mtimer7.BackColor = System.Drawing.SystemColors.Control;
            this.mtimer7.Endschalter = false;
            this.mtimer7.Location = new System.Drawing.Point(12, 596);
            this.mtimer7.Name = "mtimer7";
            this.mtimer7.Size = new System.Drawing.Size(185, 85);
            this.mtimer7.TabIndex = 8;
            this.mtimer7.Timername = "Timer";
            this.mtimer7.Visible = false;
            // 
            // mtimer8
            // 
            this.mtimer8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtimer8.Endschalter = false;
            this.mtimer8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtimer8.Location = new System.Drawing.Point(12, 687);
            this.mtimer8.Name = "mtimer8";
            this.mtimer8.Size = new System.Drawing.Size(185, 85);
            this.mtimer8.TabIndex = 9;
            this.mtimer8.Timername = "Timer";
            this.mtimer8.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 885);
            this.Controls.Add(this.mtimer8);
            this.Controls.Add(this.mtimer7);
            this.Controls.Add(this.mtimer6);
            this.Controls.Add(this.mtimer5);
            this.Controls.Add(this.mtimer4);
            this.Controls.Add(this.mtimer3);
            this.Controls.Add(this.mtimer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtimer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(500, 500);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trickerToolStripMenuItem;
        private Mtimer.Mtimer mtimer2;
        private Mtimer.Mtimer mtimer3;
        private Mtimer.Mtimer mtimer4;
        private Mtimer.Mtimer mtimer5;
        private Mtimer.Mtimer mtimer6;
        private Mtimer.Mtimer mtimer7;
        private Mtimer.Mtimer mtimer8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        public System.Windows.Forms.Timer timer2;
        private Mtimer.Mtimer mtimer1;
    }
}

