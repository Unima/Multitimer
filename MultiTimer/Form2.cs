﻿using System;
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
            Properties.Settings.Default.Save();
            this.RefToForm1.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = dlg.Color.Name;
                MessageBox.Show(str);
            }           
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
    }
}
