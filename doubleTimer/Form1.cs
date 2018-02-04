using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doubleTimerV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int, timer> timers = new Dictionary<int, timer>();
        int activeTimer = 0;
        timer addTimer(string name, int val)
        {
            timers.Add(timers.Count(), new timer(this, timers.Count(), name, val));
            return timers[timers.Count() - 1];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            addTimer("abc", 156);
            timers[0].setisActive(true);
        }

        public void newActive(int ID)
        {
            timers[activeTimer].setisActive(false);
            activeTimer = ID;
            timers[activeTimer].setisActive(true);
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (timers[activeTimer].toggleTimer())
            {
                ((Button)sender).Text = "Stop";
            } else
            {
                ((Button)sender).Text = "Start";
            }
        }
    }
}
