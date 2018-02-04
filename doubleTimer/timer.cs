using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;

namespace doubleTimerV2
{
    class timer
    {
        int val = 0;
        string name = "Timer";
        int id = 0;
        Panel root;
        TextBox label;
        TextBox display;
        Button swtchBtn;
        Timer _timer;
        bool isActive = false;
        Form1 parent;

        void log(params string[] logStrs)
        {
            Debug.WriteLine(String.Join("; ", logStrs));
        }
        void log(params int[] logInts)
        {
            string[] logStrs = new string[logInts.Length];
            for (int i = 0; i < logInts.Length; i++)
            {
                logStrs[i] = logInts[i].ToString();
            }
            Debug.WriteLine(String.Join("; ", logStrs));
        }
        string maskTime(string mask, int h, int m, int s)
        {
            
            mask = mask.Replace("%hh", (h < 10 ? "0" : "") + h.ToString());
            mask = mask.Replace("%h", h.ToString());
            mask = mask.Replace("%mm", (m < 10 ? "0" : "") + m.ToString());
            mask = mask.Replace("%m", m.ToString());
            mask = mask.Replace("%ss", (s < 10 ? "0" : "") + s.ToString());
            mask = mask.Replace("%s", s.ToString());
            return mask;
        }

        public Dictionary<string, int> getTimeComps(int val)
        {
            Dictionary<string, int> comps = new Dictionary<string, int>();
            comps.Add("h", val / 60 / 60);
            comps.Add("m", val / 60 % 60);
            comps.Add("s", val % 60);
            return comps;
        }

        public void refreshPanel()
        {
            Dictionary<string, int> timeComps = getTimeComps(val);
            display.Text = maskTime("%hh:%mm:%ss", timeComps["h"], timeComps["m"], timeComps["s"]);
            if (isActive)
            {
                display.ForeColor = System.Drawing.Color.Green;
                swtchBtn.Enabled = false;
            } else
            {
                display.ForeColor = System.Drawing.Color.Black;
                swtchBtn.Enabled = true;
            }

        }

        private void handleTick(object sender, EventArgs e)
        {
            this.val++;
            refreshPanel();
        }

        public void setisActive(bool isActive)
        {
            this.isActive = isActive;
            _timer.Enabled = isActive;
            refreshPanel();
        }

        private void swtchBtnClick(object sender, EventArgs e)
        {
            parent.newActive(id);
            parent.Controls.Find("startStopBtn", false)[0].Text = "Stop";
        }

        //0 is stop, 1 is start, 2 is toggle
        public bool toggleTimer(int state = 2)
        {
            switch (state)
            {
                case 0:
                    _timer.Stop();
                    refreshPanel();
                    break;
                case 1:
                    _timer.Start();
                    refreshPanel();
                    break;
                case 2:
                    _timer.Enabled = !_timer.Enabled;
                    break;
            }
            return _timer.Enabled;
        }

        public void deselectDipsplay()
        {
            this.display.Select(0, 0);
        }

        public timer(Control parent, int id, string name, int val = 0)
        {
            log("trying to add timer id=" + id.ToString());
            this.parent = (Form1)parent;
            this.id = id;
            this.name = name;
            this.val = val;
            Dictionary<string, int> timeComps = getTimeComps(val);
            root = new System.Windows.Forms.Panel();
            display = new System.Windows.Forms.TextBox();
            swtchBtn = new System.Windows.Forms.Button();
            label = new System.Windows.Forms.TextBox();
            this._timer = new Timer();/*
            root.SuspendLayout();
            parent.SuspendLayout();*/
            // 
            // root
            // 
            root.Controls.Add(swtchBtn);
            root.Controls.Add(label);
            root.Controls.Add(display);
            root.Location = new System.Drawing.Point(12,20 + (12 + 81) * id);
            root.Name = "panel"+id.ToString();
            root.Size = new System.Drawing.Size(571, 81);
            parent.Height = 80 + root.Location.Y + root.Size.Height + 12;
            root.TabIndex = 0;
            // 
            // display
            // 
            display.BackColor = System.Drawing.SystemColors.Control;
            display.BorderStyle = BorderStyle.None;
            display.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            display.Location = new System.Drawing.Point(3, -19);
            display.Name = "display";
            display.Size = new System.Drawing.Size(419, 121);
            display.TabIndex = 0;
            display.Text = maskTime("%hh:%mm:%ss",timeComps["h"],timeComps["m"],timeComps["s"]);
            //
            // label
            // 
            label.BackColor = System.Drawing.SystemColors.Control;
            label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.Location = new System.Drawing.Point(428, 25);
            label.Name = "label";
            label.Size = new System.Drawing.Size(138, 31);
            label.TabIndex = 1;
            label.Text = name;
            // 
            // swtchBtn
            // 
            swtchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            swtchBtn.Location = new System.Drawing.Point(534, 3);
            swtchBtn.Name = "swtchBtn";
            swtchBtn.Size = new System.Drawing.Size(32, 78);
            swtchBtn.TabIndex = 2;
            swtchBtn.Text = "<";
            swtchBtn.UseVisualStyleBackColor = true;
            swtchBtn.Click += new System.EventHandler(this.swtchBtnClick);
            //
            // _timer
            //
            _timer.Tick += new System.EventHandler(this.handleTick);
            _timer.Interval = 1000;
            parent.Controls.Add(root);/*
            root.ResumeLayout(false);
            root.PerformLayout();
            parent.ResumeLayout(false);*/
        }
        
    }
}
