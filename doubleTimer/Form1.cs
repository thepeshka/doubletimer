using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using doubleTimer.Properties;
using System.Diagnostics;

namespace doubleTimer
{
    public partial class Form1 : Form
    {

        string targetTimer = "first";
        Dictionary<string,int> timer1;
        Dictionary<string, int> timer2;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (editTimersBtn.Text == "Edit Timers")
            {
                toogleTimer(false);
                startPauseBtn.Enabled = false;
                editDisp1Sect1.ReadOnly = false;
                editDisp1Sect2.ReadOnly = false;
                editDisp1Sect3.ReadOnly = false;
                editDisp2Sect1.ReadOnly = false;
                editDisp2Sect2.ReadOnly = false;
                editDisp2Sect3.ReadOnly = false;
                editTimersBtn.Text = "Set Timers";
            }
            else
            {
                editDisp1Sect1.ReadOnly = true;
                editDisp1Sect2.ReadOnly = true;
                editDisp1Sect3.ReadOnly = true;
                editDisp2Sect1.ReadOnly = true;
                editDisp2Sect2.ReadOnly = true;
                editDisp2Sect3.ReadOnly = true;
                timer1["hrs"] = Int32.Parse(editDisp1Sect1.Text);
                timer1["min"] = Int32.Parse(editDisp1Sect2.Text);
                timer1["sec"] = Int32.Parse(editDisp1Sect3.Text);
                timer2["hrs"] = Int32.Parse(editDisp2Sect1.Text);
                timer2["min"] = Int32.Parse(editDisp2Sect2.Text);
                timer2["sec"] = Int32.Parse(editDisp2Sect3.Text);
                editTimersBtn.Text = "Edit Timers";
                startPauseBtn.Enabled = true;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            labelDisp1.Enabled = !labelDisp1.Enabled;
            labelDisp2.Enabled = !labelDisp2.Enabled;
            editLabelsBtn.Text = (labelDisp1.Enabled ? "Set Labels" : "Edit Labels");
        }

        bool toogleTimer(params bool[]state)
        {
            bool targetState = (state.GetLength(0) > 0 ? state[0] : !timer.Enabled);
            startPauseBtn.Text = (targetState ? "Pause" : "Start");
            timer.Enabled = targetState;
            return targetState;
        }
        private void startPauseBtn_Click(object sender, EventArgs e)
        {
            toogleTimer();
        }

        string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (targetTimer == "first")
            {
                timer1["sec"]++;
                if (timer1["sec"] == 60)
                {
                    timer1["sec"] = 0;
                    timer1["min"]++;
                }
                if (timer1["min"] == 60)
                {
                    timer1["min"] = 0;
                    timer1["hrs"]++;
                }
                editDisp1Sect1.Text = (timer1["hrs"] < 10 ? "0":"") + timer1["hrs"].ToString();
                editDisp1Sect2.Text = (timer1["min"] < 10 ? "0" : "") + timer1["min"].ToString();
                editDisp1Sect3.Text = (timer1["sec"] < 10 ? "0" : "") + timer1["sec"].ToString();
            } else
            {
                timer2["sec"]++;
                if (timer2["sec"] == 60)
                {
                    timer2["sec"] = 0;
                    timer2["min"]++;
                }
                if (timer2["min"] == 60)
                {
                    timer2["min"] = 0;
                    timer2["hrs"]++;
                }
                editDisp2Sect1.Text = (timer2["hrs"] < 10 ? "0" : "") + timer2["hrs"].ToString();
                editDisp2Sect2.Text = (timer2["min"] < 10 ? "0" : "") + timer2["min"].ToString();
                editDisp2Sect3.Text = (timer2["sec"] < 10 ? "0" : "") + timer2["sec"].ToString();
            }
            string notifyIconText = labelDisp1.Text + ": " + editDisp1Sect1.Text + ":" + editDisp1Sect2.Text + ":" + editDisp1Sect3.Text + "; " + labelDisp2.Text + ": " + editDisp2Sect1.Text + ":" + editDisp2Sect2.Text + ":" + editDisp2Sect3.Text;
            notifyIcon.Text = Truncate(notifyIconText, 63);
        }

        void loadConfig()
        {
            try
            {
                string[] strTimer1 = Properties.Settings.Default.timer1.Split('.');
                timer1.Add("hrs", Int32.Parse(strTimer1[0]));
                timer1.Add("min", Int32.Parse(strTimer1[1]));
                timer1.Add("sec", Int32.Parse(strTimer1[2]));
                string[] strTimer2 = Properties.Settings.Default.timer2.Split('.');
                timer2.Add("hrs", Int32.Parse(strTimer2[0]));
                timer2.Add("min", Int32.Parse(strTimer2[1]));
                timer2.Add("sec", Int32.Parse(strTimer2[2]));
                targetTimer = Properties.Settings.Default.activeTimer;
                labelDisp1.Text = Properties.Settings.Default.timerName1;
                labelDisp2.Text = Properties.Settings.Default.timerName2;
            }
            catch
            {

                timer1.Add("hrs", 0);
                timer1.Add("min", 0);
                timer1.Add("sec", 0);
                timer2.Add("hrs", 0);
                timer2.Add("min", 0);
                timer2.Add("sec", 0);
                targetTimer = "first";
                labelDisp1.Text = "Timer 1";
                labelDisp2.Text = "Timer 2";
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new Dictionary<string, int>();
            timer2 = new Dictionary<string, int>();
            loadConfig();
            editDisp1Sect1.Text = (timer1["hrs"] < 10 ? "0" : "") + timer1["hrs"].ToString();
            editDisp1Sect2.Text = (timer1["min"] < 10 ? "0" : "") + timer1["min"].ToString();
            editDisp1Sect3.Text = (timer1["sec"] < 10 ? "0" : "") + timer1["sec"].ToString();
            editDisp2Sect1.Text = (timer2["hrs"] < 10 ? "0" : "") + timer2["hrs"].ToString();
            editDisp2Sect2.Text = (timer2["min"] < 10 ? "0" : "") + timer2["min"].ToString();
            editDisp2Sect3.Text = (timer2["sec"] < 10 ? "0" : "") + timer2["sec"].ToString();
            if (targetTimer != "first")
            {
                semicolon11.ForeColor = Color.Black;
                semicolon12.ForeColor = Color.Black;
                editDisp1Sect1.ForeColor = Color.Black;
                editDisp1Sect2.ForeColor = Color.Black;
                editDisp1Sect3.ForeColor = Color.Black;
                semicolon21.ForeColor = Color.Green;
                semicolon22.ForeColor = Color.Green;
                editDisp2Sect1.ForeColor = Color.Green;
                editDisp2Sect2.ForeColor = Color.Green;
                editDisp2Sect3.ForeColor = Color.Green;
            }
            string notifyIconText = labelDisp1.Text + ": " + editDisp1Sect1.Text + ":" + editDisp1Sect2.Text + ":" + editDisp1Sect3.Text + "; " + labelDisp2.Text + ": " + editDisp2Sect1.Text + ":" + editDisp2Sect2.Text + ":" + editDisp2Sect3.Text;
            notifyIcon.Text = Truncate(notifyIconText, 63);
        }

        private void switchBtn_Click(object sender, EventArgs e)
        {
            if (targetTimer == "first")
            {
                targetTimer = "second";
                semicolon11.ForeColor = Color.Black;
                semicolon12.ForeColor = Color.Black;
                editDisp1Sect1.ForeColor = Color.Black;
                editDisp1Sect2.ForeColor = Color.Black;
                editDisp1Sect3.ForeColor = Color.Black;
                semicolon21.ForeColor = Color.Green;
                semicolon22.ForeColor = Color.Green;
                editDisp2Sect1.ForeColor = Color.Green;
                editDisp2Sect2.ForeColor = Color.Green;
                editDisp2Sect3.ForeColor = Color.Green;
            } else
            {
                targetTimer = "first";
                semicolon11.ForeColor = Color.Green;
                semicolon12.ForeColor = Color.Green;
                editDisp1Sect1.ForeColor = Color.Green;
                editDisp1Sect2.ForeColor = Color.Green;
                editDisp1Sect3.ForeColor = Color.Green;
                semicolon21.ForeColor = Color.Black;
                semicolon22.ForeColor = Color.Black;
                editDisp2Sect1.ForeColor = Color.Black;
                editDisp2Sect2.ForeColor = Color.Black;
                editDisp2Sect3.ForeColor = Color.Black;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            startPauseBtn.Text = "Start";
            timer1["hrs"] = 0;
            timer1["min"] = 0;
            timer1["sec"] = 0;
            timer2["hrs"] = 0;
            timer2["min"] = 0;
            timer2["sec"] = 0;
            editDisp1Sect1.Text = (timer1["hrs"] < 10 ? "0" : "") + timer1["hrs"].ToString();
            editDisp1Sect2.Text = (timer1["min"] < 10 ? "0" : "") + timer1["min"].ToString();
            editDisp1Sect3.Text = (timer1["sec"] < 10 ? "0" : "") + timer1["sec"].ToString();
            editDisp2Sect1.Text = (timer1["hrs"] < 10 ? "0" : "") + timer1["hrs"].ToString();
            editDisp2Sect2.Text = (timer1["min"] < 10 ? "0" : "") + timer1["min"].ToString();
            editDisp2Sect3.Text = (timer1["sec"] < 10 ? "0" : "") + timer1["sec"].ToString();
        }

        void saveSettings()
        {
            Properties.Settings.Default.timer1 = timer1["hrs"].ToString() + "." + timer1["min"].ToString() + "." + timer1["sec"].ToString();
            Properties.Settings.Default.timer2 = timer2["hrs"].ToString() + "." + timer2["min"].ToString() + "." + timer2["sec"].ToString();
            Properties.Settings.Default.activeTimer = targetTimer;
            Properties.Settings.Default.timerName1 = labelDisp1.Text;
            Properties.Settings.Default.timerName2 = labelDisp2.Text;
            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }
        
        private void editDisp1Sect1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, "  ^ [0-9]"))
            {
                textBox.Text = "";
            }
            if (textBox.Text != "" && Int32.Parse(textBox.Text) > 59)
            {
                textBox.Text = "59";
            }
        }

        private void editDisp1Sect1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchBtn_Click(sender,e);
        }

        private void startPauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startPauseBtn_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@FIXME: window showed by right clicking
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}
