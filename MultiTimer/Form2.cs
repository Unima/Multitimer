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
using System.IO;
// \Sound

namespace MultiTimer
{
    public partial class Form2 : Form
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        ushort CalcVol;
        string dateiname;
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(System.Enum.GetNames(typeof(KnownColor)));
            comboBox2.Items.AddRange(System.Enum.GetNames(typeof(KnownColor)));
            comboBox3.Items.AddRange(System.Enum.GetNames(typeof(KnownColor)));
            comboBox4.Items.AddRange(System.Enum.GetNames(typeof(KnownColor)));
            comboBox5.Items.AddRange(System.Enum.GetNames(typeof(KnownColor)));
            comboBox6.Items.AddRange(System.Enum.GetNames(typeof(KnownColor)));
            comboBox7.Items.AddRange(System.Enum.GetNames(typeof(KnownColor)));
            comboBox8.Items.AddRange(System.Enum.GetNames(typeof(KnownColor)));
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
            Properties.Settings.Default.Tfarbe1 = panel1.BackColor;
            Properties.Settings.Default.Tfarbe2 = panel2.BackColor;
            Properties.Settings.Default.Tfarbe3 = panel3.BackColor;
            Properties.Settings.Default.Tfarbe4 = panel4.BackColor;
            Properties.Settings.Default.Tfarbe5 = panel5.BackColor;
            Properties.Settings.Default.Tfarbe6 = panel6.BackColor;
            Properties.Settings.Default.Tfarbe7 = panel7.BackColor;
            Properties.Settings.Default.Tfarbe8 = panel8.BackColor;
            Properties.Settings.Default.Sounddatei = dateiname;
            Properties.Settings.Default.Save();
            int NewVolume = trackBar1.Value;
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
            this.RefToForm1.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uint NewVolumeAllChannels = (((uint)CalcVol & 0x0000ffff) | ((uint)CalcVol << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
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
            CalcVol = (ushort)(CurrVol & 0x0000ffff);
            trackBar1.Value = CalcVol;
            int Soundvol = Convert.ToInt32(Convert.ToDouble(100) / Convert.ToDouble(65535) * Convert.ToDouble(CalcVol));
            label1.Text = Soundvol.ToString()+"%";
            dateiname = Properties.Settings.Default.Sounddatei;
            // Aufschlüßeln
            aufschlüßeln();
            // \Sound
            //design
            string index;
            index = Properties.Settings.Default.Tfarbe1.ToString();
            comboBox1.SelectedIndex = comboBox1.FindString(index.Substring(index.IndexOf("[") + 1, index.IndexOf("]") - index.IndexOf("[") - 1));
            index = Properties.Settings.Default.Tfarbe2.ToString();
            comboBox2.SelectedIndex = comboBox2.FindString(index.Substring(index.IndexOf("[") + 1, index.IndexOf("]") - index.IndexOf("[") - 1));
            index = Properties.Settings.Default.Tfarbe3.ToString();
            comboBox3.SelectedIndex = comboBox3.FindString(index.Substring(index.IndexOf("[") + 1, index.IndexOf("]") - index.IndexOf("[") - 1));
            index = Properties.Settings.Default.Tfarbe4.ToString();
            comboBox4.SelectedIndex = comboBox4.FindString(index.Substring(index.IndexOf("[") + 1, index.IndexOf("]") - index.IndexOf("[") - 1));
            index = Properties.Settings.Default.Tfarbe5.ToString();
            comboBox5.SelectedIndex = comboBox5.FindString(index.Substring(index.IndexOf("[") + 1, index.IndexOf("]") - index.IndexOf("[") - 1));
            index = Properties.Settings.Default.Tfarbe6.ToString();
            comboBox6.SelectedIndex = comboBox6.FindString(index.Substring(index.IndexOf("[") + 1, index.IndexOf("]") - index.IndexOf("[") - 1));
            index = Properties.Settings.Default.Tfarbe7.ToString();
            comboBox7.SelectedIndex = comboBox7.FindString(index.Substring(index.IndexOf("[") + 1, index.IndexOf("]") - index.IndexOf("[") - 1));
            index = Properties.Settings.Default.Tfarbe8.ToString();
            comboBox8.SelectedIndex = comboBox8.FindString(index.Substring(index.IndexOf("[") + 1, index.IndexOf("]") - index.IndexOf("[") - 1));
          
        }
        private void aufschlüßeln()
        {
            if (dateiname.Length < 34)
            {
                textBox9.Text = dateiname;
            }
            else
            {
                string teil_verz, teil_datei, teil_verz1, teil_lauf;
                teil_verz = Path.GetDirectoryName(dateiname);
                teil_datei = Path.GetFileName(dateiname);
                teil_verz1 = teil_verz.Substring(teil_verz.LastIndexOf('\\') + 1);
                teil_lauf = teil_verz.Substring(0, 3);
                textBox9.Text = teil_lauf + "...\\" + teil_verz1 + "\\" + teil_datei;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int NewVolume = trackBar1.Value;
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
            bool check = false;
            if (File.Exists(@dateiname))
            {
                check = true;
            }
            else
            {
                @dateiname = Application.StartupPath + "\\timer.wav";
                Properties.Settings.Default.Sounddatei = @dateiname;
                Properties.Settings.Default.Save();
                if (File.Exists(@dateiname))
                {
                    MessageBox.Show("Sound Datei Nicht vorhanden! \r\nAuf Standart gesetzt!");
                    check = true;
                }
                else
                {
                    MessageBox.Show("Sound Datei Nicht vorhanden! \r\nStandart Datei nich vorhanden!", "Sound Fehler",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                }

            }
            if (check == true)
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = @dateiname;
                myPlayer.Play();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dateiname = openFileDialog1.FileName;
                aufschlüßeln();
            }
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromName(comboBox1.SelectedItem.ToString());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromName(comboBox3.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromName(comboBox2.SelectedItem.ToString());
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromName(comboBox4.SelectedItem.ToString());
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromName(comboBox8.SelectedItem.ToString());
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromName(comboBox7.SelectedItem.ToString());
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromName(comboBox6.SelectedItem.ToString());
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromName(comboBox5.SelectedItem.ToString());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
        }
    }
}
