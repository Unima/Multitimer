using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Sound
using System.Runtime.InteropServices;
// \Sound

namespace MultiTimer
{
    public partial class Form2 : Form
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        public Form2()
        {
            InitializeComponent();
        }
        public Form RefToForm1 { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            int Anzahl;
            int Spalten;
            if (radioButton1.Checked == true) { Spalten = 1; }
            else { Spalten = 2; }
            if (radioButton3.Checked == true) { Anzahl = 1; }
            else if (radioButton4.Checked == true) { Anzahl = 2; }
            else if (radioButton5.Checked == true) { Anzahl = 3; }
            else if (radioButton6.Checked == true) { Anzahl = 4; }
            else if (radioButton7.Checked == true) { Anzahl = 5; }
            else if (radioButton8.Checked == true) { Anzahl = 6; }
            else if (radioButton9.Checked == true) { Anzahl = 7; }
            else { Anzahl = 8; }
            Properties.Settings.Default.Spalten = Spalten;
            Properties.Settings.Default.Anzahl = Anzahl;
            Properties.Settings.Default.Tname1 = textBox1.Text;
            Properties.Settings.Default.Tname2 = textBox2.Text;
            Properties.Settings.Default.Tname3 = textBox3.Text;
            Properties.Settings.Default.Tname4 = textBox4.Text;
            Properties.Settings.Default.Tname5 = textBox5.Text;
            Properties.Settings.Default.Tname6 = textBox6.Text;
            Properties.Settings.Default.Tname7 = textBox7.Text;
            Properties.Settings.Default.Tname8 = textBox8.Text;
            Properties.Settings.Default.Save();
            this.RefToForm1.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            /*
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = dlg.Color.Name;
                MessageBox.Show(str);
            }  
             */
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int Anzahl;
            int Spalten;
            Anzahl = Properties.Settings.Default.Anzahl;
            if (Anzahl == 1) {radioButton3.Checked = true;}
            else if (Anzahl == 2) {radioButton4.Checked = true;}
            else if (Anzahl == 3) {radioButton5.Checked = true;}
            else if (Anzahl == 4) {radioButton6.Checked = true;}
            else if (Anzahl == 5) {radioButton7.Checked = true;}
            else if (Anzahl == 6) {radioButton8.Checked = true;}
            else if (Anzahl == 7) {radioButton9.Checked = true;}
            else { radioButton10.Checked = true; }
            Spalten = Properties.Settings.Default.Spalten;
            textBox1.Text = Properties.Settings.Default.Tname1;
            textBox2.Text = Properties.Settings.Default.Tname2;
            textBox3.Text = Properties.Settings.Default.Tname3;
            textBox4.Text = Properties.Settings.Default.Tname4;
            textBox5.Text = Properties.Settings.Default.Tname5;
            textBox6.Text = Properties.Settings.Default.Tname6;
            textBox7.Text = Properties.Settings.Default.Tname7;
            textBox8.Text = Properties.Settings.Default.Tname8;
            if (Spalten == 1) {radioButton1.Checked = true;}
            else { radioButton2.Checked = true; }
            // Sound
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            trackBar1.Value = CalcVol;
            int Soundvol = Convert.ToInt32(Convert.ToDouble(100) / Convert.ToDouble(65535) * Convert.ToDouble(CalcVol));
            label1.Text = Soundvol.ToString()+"%";
            // \Sound

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int NewVolume = ((ushort.MaxValue / 10) * 5);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            label1.Text = CalcVol.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefToForm1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { Sichtbarkeit(1); }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) { Sichtbarkeit(2); }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true) { Sichtbarkeit(3); }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true) { Sichtbarkeit(4); }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true) { Sichtbarkeit(5); }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true) { Sichtbarkeit(6); }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true) { Sichtbarkeit(7); }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true) { Sichtbarkeit(8); }
        }

        public void Sichtbarkeit(int a)
        {
            for (int i = 1; i <= 8; i++)
            {
                Control[] found = this.Controls.Find("textBox" + i.ToString(), true);
                ((TextBox)found[0]).Visible =false;
                Control[] found2 = this.Controls.Find("tname_lab" + i.ToString(), true);
                ((Label)found2[0]).Visible = false;
            }
            for (int i = 1; i <= a; i++)
            {
                Control[] found = this.Controls.Find("textBox" + i.ToString(), true);
                ((TextBox)found[0]).Visible = true;
                Control[] found2 = this.Controls.Find("tname_lab" + i.ToString(), true);
                ((Label)found2[0]).Visible = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int Soundvol = Convert.ToInt32(Convert.ToDouble(100) / Convert.ToDouble(65535) * Convert.ToDouble(trackBar1.Value));
            label1.Text = Soundvol.ToString() + "%";
        }
    }
}
