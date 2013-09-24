using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTimer
{
    public partial class Form1 : Form
    {
        string soundpfad;
        int sicht_trigger = 0;
        public Form1()
        {
            InitializeComponent();
            timer_einstellung();
            mtimer1.MyEvent += new EventHandler(myObject_MyEvent);
            mtimer2.MyEvent += new EventHandler(myObject_MyEvent);
            mtimer3.MyEvent += new EventHandler(myObject_MyEvent);
            mtimer4.MyEvent += new EventHandler(myObject_MyEvent);
            mtimer5.MyEvent += new EventHandler(myObject_MyEvent);
            mtimer6.MyEvent += new EventHandler(myObject_MyEvent);
            mtimer7.MyEvent += new EventHandler(myObject_MyEvent);
            mtimer8.MyEvent += new EventHandler(myObject_MyEvent);
            timer_position();
            timer_größe();
        }

        public void myObject_MyEvent(Object objSender, EventArgs e)
        {
            System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = @"E:\Delphi Projeckte\Timer Final\timer.wav";
            myPlayer.Play();
            
        }
        public void timer_position()
        {
            int timer_position_triger = Properties.Settings.Default.Spalten;
            if (timer_position_triger == 1)
            {
                mtimer1.Location = new Point(12, 50);
                mtimer2.Location = new Point(12, 141);
                mtimer3.Location = new Point(12, 232);
                mtimer4.Location = new Point(12, 323);
                mtimer5.Location = new Point(12, 414);
                mtimer6.Location = new Point(12, 505);
                mtimer7.Location = new Point(12, 596);
                mtimer8.Location = new Point(12, 687);
            }
            else
            {
                mtimer1.Location = new Point(12, 50);
                mtimer3.Location = new Point(12, 141);
                mtimer5.Location = new Point(12, 232);
                mtimer7.Location = new Point(12, 323);
                mtimer2.Location = new Point(203, 50);
                mtimer4.Location = new Point(203, 141);
                mtimer6.Location = new Point(203, 232);
                mtimer8.Location = new Point(203, 323);
            }
        }
        public void timer_größe()
        {
            int timer_position_triger = Properties.Settings.Default.Spalten;
            int timer_anzahl = Properties.Settings.Default.Anzahl;
            if (timer_position_triger == 1)
            {
                if (timer_anzahl == 1) { Width = 226; Height = 186; Sichtbarkeit(1); }
                else if (timer_anzahl == 2) { Width = 226; Height = 277; Sichtbarkeit(2); }
                else if (timer_anzahl == 3) { Width = 226; Height = 368; Sichtbarkeit(3); }
                else if (timer_anzahl == 4) { Width = 226; Height = 459; Sichtbarkeit(4); }
                else if (timer_anzahl == 5) { Width = 226; Height = 550; Sichtbarkeit(5); }
                else if (timer_anzahl == 6) { Width = 226; Height = 641; Sichtbarkeit(6); }
                else if (timer_anzahl == 7) { Width = 226; Height = 732; Sichtbarkeit(7); }
                else if (timer_anzahl == 8) { Width = 226; Height = 823; Sichtbarkeit(8); }
            }
            else
            {
                if (timer_anzahl == 1) { Width = 226; Height = 186; Sichtbarkeit(1); }
                else if (timer_anzahl == 2) { Width = 417; Height = 186; Sichtbarkeit(2); }
                else if (timer_anzahl == 3) { Width = 417; Height = 277; Sichtbarkeit(3); }
                else if (timer_anzahl == 4) { Width = 417; Height = 277; Sichtbarkeit(4); }
                else if (timer_anzahl == 5) { Width = 417; Height = 368; Sichtbarkeit(5); }
                else if (timer_anzahl == 6) { Width = 417; Height = 368; Sichtbarkeit(6); }
                else if (timer_anzahl == 7) { Width = 417; Height = 459; Sichtbarkeit(7); }
                else if (timer_anzahl == 8) { Width = 417; Height = 459; Sichtbarkeit(8); }
            }

        }
        public void Sichtbarkeit(int a)
        {
            for (int i = 1; i <= 8; i++)
            {
                GetControlByName("mtimer" + i).Visible = false;
                //Control changer = GetControlByName("mtimer" + a);
                //changer.visible = true;
            }
            for (int i = 1; i <= a; i++)
            {
                GetControlByName("mtimer" + i).Visible = true;
                //Control changer = GetControlByName("mtimer" + a);
                //changer.visible = true;
            }
        }
        private void trickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_position();
            Properties.Settings.Default.Anzahl = 3;
            Properties.Settings.Default.Save();
            timer_größe();
        }
        Control GetControlByName(string Name)
        {
            foreach (Control c in this.Controls)
                if (c.Name == Name)
                    return c;

            return null;
        }
        public void timer_einstellung()
        {
            mtimer1.BackColor = Properties.Settings.Default.Tfarbe1;
            mtimer2.BackColor = Properties.Settings.Default.Tfarbe2;
            mtimer3.BackColor = Properties.Settings.Default.Tfarbe3;
            mtimer4.BackColor = Properties.Settings.Default.Tfarbe4;
            mtimer5.BackColor = Properties.Settings.Default.Tfarbe5;
            mtimer6.BackColor = Properties.Settings.Default.Tfarbe6;
            mtimer7.BackColor = Properties.Settings.Default.Tfarbe7;
            mtimer8.BackColor = Properties.Settings.Default.Tfarbe8;
            BackColor = Properties.Settings.Default.Hintergrund;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                this.Left = Properties.Settings.Default.Pos_main_x;
                this.Top = Properties.Settings.Default.Pos_main_y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss    dd-MM-yyyy");
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 obj2 = new Form2();
            obj2.RefToForm1 = this;
            this.Visible = false;
            obj2.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Show();
            timer2.Enabled = false;
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                sicht_trigger = 1;
            }
            else if (this.Visible == true && sicht_trigger == 1)
            {
                timer_einstellung();
                timer_größe();
                timer_position();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Pos_main_x = this.Left;
            Properties.Settings.Default.Pos_main_y = this.Top;
            Properties.Settings.Default.Save();
        }
    }
}
