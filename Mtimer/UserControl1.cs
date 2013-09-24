using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mtimer
{
    public partial class Mtimer: UserControl
    {
        public Mtimer()
        {
            InitializeComponent();
        }
        public Boolean Endschalter { get; set; }
        public String Timername
        {
            get
            { 
                return lab_Name.Text;
            }
            set
            {
                this.lab_Name.Text = value;
            }
        }
        DateTime zielZeit;
        public event EventHandler MyEvent;

        protected virtual void OnMyEvent(EventArgs e)
        {
            EventHandler myEvent = MyEvent;
            if (myEvent != null)
            {
                myEvent(this, e);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                Stunde.ReadOnly = true;
                Minute.ReadOnly = true;
                Secunde.ReadOnly = true;
                if (String.IsNullOrEmpty(Stunde.Text))
                {
                    Stunde.Text = "0";
                }
                if (String.IsNullOrEmpty(Minute.Text))
                {
                    Minute.Text = "0";
                }
                if (String.IsNullOrEmpty(Secunde.Text))
                {
                    Secunde.Text = "0";
                }
                zielZeit = DateTime.Now.AddHours(Convert.ToDouble(Stunde.Text)).AddMinutes(Convert.ToDouble(Minute.Text)).AddSeconds(Convert.ToDouble(Secunde.Text));
                label1.Text = zielZeit.ToString("yyyy-MM-dd HH:mm:ss tt");
                button1.Text = "Stop";
                button1.ForeColor = Color.Crimson;
                timer1.Enabled = true;
            }
            else
            {
                Stunde.ReadOnly = false;
                Minute.ReadOnly = false;
                Secunde.ReadOnly = false;
                button1.Text = "Start";
                button1.ForeColor = Color.ForestGreen;
                timer1.Enabled = false;
            }
        }

        private void Stunde_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Stunde.Text))
            { 
            }
            else if (Convert.ToInt16(Stunde.Text) > 24)
            {
                Stunde.Text = "24";
            }
        }

        private void Minute_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Minute.Text))
            { 
            }
            else if (Convert.ToInt16(Minute.Text) > 59)
            {
                Minute.Text = "59";
            }
        }

        private void Secunde_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Secunde.Text))
            { 
            }
            else if (Convert.ToInt16(Secunde.Text) > 59)
            {
                Secunde.Text = "59";
            }
        }

        private void Stunde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890\b".IndexOf(e.KeyChar.ToString()) < 0)
            {
                e.Handled = true;
            }
        }

        private void Minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890\b".IndexOf(e.KeyChar.ToString()) < 0)
            {
                e.Handled = true;
            }
        }

        private void Secunde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890\b".IndexOf(e.KeyChar.ToString()) < 0)
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan restZeit = zielZeit - currentDate;
            Stunde.Text = restZeit.Hours.ToString();
            Minute.Text = restZeit.Minutes.ToString();
            Secunde.Text = restZeit.Seconds.ToString();
            if (restZeit.CompareTo(TimeSpan.Zero) < 0)
            {
                Stunde.ReadOnly = false;
                Minute.ReadOnly = false;
                Secunde.ReadOnly = false;
                button1.Text = "Start";
                button1.ForeColor = Color.ForestGreen;
                timer1.Enabled = false;
                Endschalter = true;
                OnMyEvent(EventArgs.Empty);
            }    
        }
    }
}
/*
       private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890\b".IndexOf(e.KeyChar.ToString()) < 0)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            { 
            }
            else if (Convert.ToInt16(textBox1.Text) > 24)
            {
                textBox1.Text = "24";
            }
        }
                private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.AddHours(Convert.ToDouble(textBox1.Text)).AddMinutes(Convert.ToDouble(textBox2.Text)).AddSeconds(Convert.ToDouble(textBox3.Text));
            label5.Text = currentDate.ToString("yyyy-MM-dd HH:mm:ss tt");

*/