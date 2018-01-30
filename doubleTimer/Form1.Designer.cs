namespace doubleTimer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.editTimersBtn = new System.Windows.Forms.Button();
            this.editLabelsBtn = new System.Windows.Forms.Button();
            this.editDisp1Sect1 = new System.Windows.Forms.TextBox();
            this.startPauseBtn = new System.Windows.Forms.Button();
            this.editDisp1Sect2 = new System.Windows.Forms.TextBox();
            this.editDisp1Sect3 = new System.Windows.Forms.TextBox();
            this.editDisp2Sect1 = new System.Windows.Forms.TextBox();
            this.editDisp2Sect3 = new System.Windows.Forms.TextBox();
            this.editDisp2Sect2 = new System.Windows.Forms.TextBox();
            this.labelDisp1 = new System.Windows.Forms.TextBox();
            this.labelDisp2 = new System.Windows.Forms.TextBox();
            this.semicolon11 = new System.Windows.Forms.Label();
            this.semicolon12 = new System.Windows.Forms.Label();
            this.semicolon22 = new System.Windows.Forms.Label();
            this.semicolon21 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.switchBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // editTimersBtn
            // 
            this.editTimersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTimersBtn.Location = new System.Drawing.Point(16, 277);
            this.editTimersBtn.Name = "editTimersBtn";
            this.editTimersBtn.Size = new System.Drawing.Size(160, 46);
            this.editTimersBtn.TabIndex = 2;
            this.editTimersBtn.Text = "Edit Timers";
            this.editTimersBtn.UseVisualStyleBackColor = true;
            this.editTimersBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // editLabelsBtn
            // 
            this.editLabelsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editLabelsBtn.Location = new System.Drawing.Point(417, 277);
            this.editLabelsBtn.Name = "editLabelsBtn";
            this.editLabelsBtn.Size = new System.Drawing.Size(156, 46);
            this.editLabelsBtn.TabIndex = 7;
            this.editLabelsBtn.Text = "Edit Labels";
            this.editLabelsBtn.UseVisualStyleBackColor = true;
            this.editLabelsBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // editDisp1Sect1
            // 
            this.editDisp1Sect1.BackColor = System.Drawing.SystemColors.Control;
            this.editDisp1Sect1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editDisp1Sect1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.editDisp1Sect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.editDisp1Sect1.ForeColor = System.Drawing.Color.Green;
            this.editDisp1Sect1.Location = new System.Drawing.Point(16, 9);
            this.editDisp1Sect1.MaxLength = 2;
            this.editDisp1Sect1.Name = "editDisp1Sect1";
            this.editDisp1Sect1.ReadOnly = true;
            this.editDisp1Sect1.Size = new System.Drawing.Size(125, 121);
            this.editDisp1Sect1.TabIndex = 8;
            this.editDisp1Sect1.Text = "00";
            this.editDisp1Sect1.TextChanged += new System.EventHandler(this.editDisp1Sect1_TextChanged);
            this.editDisp1Sect1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editDisp1Sect1_KeyPress);
            // 
            // startPauseBtn
            // 
            this.startPauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPauseBtn.Location = new System.Drawing.Point(182, 277);
            this.startPauseBtn.Name = "startPauseBtn";
            this.startPauseBtn.Size = new System.Drawing.Size(99, 46);
            this.startPauseBtn.TabIndex = 9;
            this.startPauseBtn.Text = "Start";
            this.startPauseBtn.UseVisualStyleBackColor = true;
            this.startPauseBtn.Click += new System.EventHandler(this.startPauseBtn_Click);
            // 
            // editDisp1Sect2
            // 
            this.editDisp1Sect2.BackColor = System.Drawing.SystemColors.Control;
            this.editDisp1Sect2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editDisp1Sect2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.editDisp1Sect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.editDisp1Sect2.ForeColor = System.Drawing.Color.Green;
            this.editDisp1Sect2.Location = new System.Drawing.Point(164, 9);
            this.editDisp1Sect2.MaxLength = 2;
            this.editDisp1Sect2.Name = "editDisp1Sect2";
            this.editDisp1Sect2.ReadOnly = true;
            this.editDisp1Sect2.Size = new System.Drawing.Size(125, 121);
            this.editDisp1Sect2.TabIndex = 10;
            this.editDisp1Sect2.Text = "00";
            this.editDisp1Sect2.TextChanged += new System.EventHandler(this.editDisp1Sect1_TextChanged);
            this.editDisp1Sect2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editDisp1Sect1_KeyPress);
            // 
            // editDisp1Sect3
            // 
            this.editDisp1Sect3.BackColor = System.Drawing.SystemColors.Control;
            this.editDisp1Sect3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editDisp1Sect3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.editDisp1Sect3.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.editDisp1Sect3.ForeColor = System.Drawing.Color.Green;
            this.editDisp1Sect3.Location = new System.Drawing.Point(313, 9);
            this.editDisp1Sect3.MaxLength = 2;
            this.editDisp1Sect3.Name = "editDisp1Sect3";
            this.editDisp1Sect3.ReadOnly = true;
            this.editDisp1Sect3.Size = new System.Drawing.Size(125, 121);
            this.editDisp1Sect3.TabIndex = 11;
            this.editDisp1Sect3.Text = "00";
            this.editDisp1Sect3.TextChanged += new System.EventHandler(this.editDisp1Sect1_TextChanged);
            this.editDisp1Sect3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editDisp1Sect1_KeyPress);
            // 
            // editDisp2Sect1
            // 
            this.editDisp2Sect1.BackColor = System.Drawing.SystemColors.Control;
            this.editDisp2Sect1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editDisp2Sect1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.editDisp2Sect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.editDisp2Sect1.Location = new System.Drawing.Point(16, 143);
            this.editDisp2Sect1.MaxLength = 2;
            this.editDisp2Sect1.Name = "editDisp2Sect1";
            this.editDisp2Sect1.ReadOnly = true;
            this.editDisp2Sect1.Size = new System.Drawing.Size(125, 121);
            this.editDisp2Sect1.TabIndex = 12;
            this.editDisp2Sect1.Text = "00";
            this.editDisp2Sect1.TextChanged += new System.EventHandler(this.editDisp1Sect1_TextChanged);
            this.editDisp2Sect1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editDisp1Sect1_KeyPress);
            // 
            // editDisp2Sect3
            // 
            this.editDisp2Sect3.BackColor = System.Drawing.SystemColors.Control;
            this.editDisp2Sect3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editDisp2Sect3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.editDisp2Sect3.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.editDisp2Sect3.Location = new System.Drawing.Point(313, 143);
            this.editDisp2Sect3.MaxLength = 2;
            this.editDisp2Sect3.Name = "editDisp2Sect3";
            this.editDisp2Sect3.ReadOnly = true;
            this.editDisp2Sect3.Size = new System.Drawing.Size(125, 121);
            this.editDisp2Sect3.TabIndex = 14;
            this.editDisp2Sect3.Text = "00";
            this.editDisp2Sect3.TextChanged += new System.EventHandler(this.editDisp1Sect1_TextChanged);
            this.editDisp2Sect3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editDisp1Sect1_KeyPress);
            // 
            // editDisp2Sect2
            // 
            this.editDisp2Sect2.BackColor = System.Drawing.SystemColors.Control;
            this.editDisp2Sect2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editDisp2Sect2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.editDisp2Sect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.editDisp2Sect2.Location = new System.Drawing.Point(164, 143);
            this.editDisp2Sect2.MaxLength = 2;
            this.editDisp2Sect2.Name = "editDisp2Sect2";
            this.editDisp2Sect2.ReadOnly = true;
            this.editDisp2Sect2.Size = new System.Drawing.Size(125, 121);
            this.editDisp2Sect2.TabIndex = 13;
            this.editDisp2Sect2.Text = "00";
            this.editDisp2Sect2.TextChanged += new System.EventHandler(this.editDisp1Sect1_TextChanged);
            this.editDisp2Sect2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editDisp1Sect1_KeyPress);
            // 
            // labelDisp1
            // 
            this.labelDisp1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDisp1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelDisp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelDisp1.Location = new System.Drawing.Point(444, 52);
            this.labelDisp1.Name = "labelDisp1";
            this.labelDisp1.ReadOnly = true;
            this.labelDisp1.Size = new System.Drawing.Size(123, 31);
            this.labelDisp1.TabIndex = 15;
            this.labelDisp1.Text = "Timer 1";
            // 
            // labelDisp2
            // 
            this.labelDisp2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDisp2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelDisp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelDisp2.Location = new System.Drawing.Point(444, 186);
            this.labelDisp2.Name = "labelDisp2";
            this.labelDisp2.ReadOnly = true;
            this.labelDisp2.Size = new System.Drawing.Size(123, 31);
            this.labelDisp2.TabIndex = 16;
            this.labelDisp2.Text = "Timer 2";
            // 
            // semicolon11
            // 
            this.semicolon11.AutoSize = true;
            this.semicolon11.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.semicolon11.ForeColor = System.Drawing.Color.Green;
            this.semicolon11.Location = new System.Drawing.Point(115, 1);
            this.semicolon11.Name = "semicolon11";
            this.semicolon11.Size = new System.Drawing.Size(80, 120);
            this.semicolon11.TabIndex = 17;
            this.semicolon11.Text = ":";
            // 
            // semicolon12
            // 
            this.semicolon12.AutoSize = true;
            this.semicolon12.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.semicolon12.ForeColor = System.Drawing.Color.Green;
            this.semicolon12.Location = new System.Drawing.Point(265, 1);
            this.semicolon12.Name = "semicolon12";
            this.semicolon12.Size = new System.Drawing.Size(80, 120);
            this.semicolon12.TabIndex = 18;
            this.semicolon12.Text = ":";
            // 
            // semicolon22
            // 
            this.semicolon22.AutoSize = true;
            this.semicolon22.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.semicolon22.Location = new System.Drawing.Point(265, 132);
            this.semicolon22.Name = "semicolon22";
            this.semicolon22.Size = new System.Drawing.Size(80, 120);
            this.semicolon22.TabIndex = 19;
            this.semicolon22.Text = ":";
            // 
            // semicolon21
            // 
            this.semicolon21.AutoSize = true;
            this.semicolon21.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.semicolon21.Location = new System.Drawing.Point(115, 132);
            this.semicolon21.Name = "semicolon21";
            this.semicolon21.Size = new System.Drawing.Size(80, 120);
            this.semicolon21.TabIndex = 20;
            this.semicolon21.Text = ":";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // switchBtn
            // 
            this.switchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switchBtn.Location = new System.Drawing.Point(444, 118);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(123, 46);
            this.switchBtn.TabIndex = 21;
            this.switchBtn.Text = "Switch";
            this.switchBtn.UseVisualStyleBackColor = true;
            this.switchBtn.Click += new System.EventHandler(this.switchBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetBtn.Location = new System.Drawing.Point(285, 277);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(126, 46);
            this.resetBtn.TabIndex = 22;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuTray
            // 
            this.contextMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.switchToolStripMenuItem,
            this.startPauseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuTray.Name = "contextMenuTray";
            this.contextMenuTray.Size = new System.Drawing.Size(114, 92);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // switchToolStripMenuItem
            // 
            this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            this.switchToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.switchToolStripMenuItem.Text = "Switch";
            this.switchToolStripMenuItem.Click += new System.EventHandler(this.switchToolStripMenuItem_Click);
            // 
            // startPauseToolStripMenuItem
            // 
            this.startPauseToolStripMenuItem.Name = "startPauseToolStripMenuItem";
            this.startPauseToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.startPauseToolStripMenuItem.Text = "Start";
            this.startPauseToolStripMenuItem.Click += new System.EventHandler(this.startPauseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 334);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.switchBtn);
            this.Controls.Add(this.labelDisp2);
            this.Controls.Add(this.labelDisp1);
            this.Controls.Add(this.editDisp2Sect3);
            this.Controls.Add(this.editDisp2Sect2);
            this.Controls.Add(this.editDisp2Sect1);
            this.Controls.Add(this.editDisp1Sect3);
            this.Controls.Add(this.editDisp1Sect2);
            this.Controls.Add(this.startPauseBtn);
            this.Controls.Add(this.editDisp1Sect1);
            this.Controls.Add(this.editLabelsBtn);
            this.Controls.Add(this.editTimersBtn);
            this.Controls.Add(this.semicolon11);
            this.Controls.Add(this.semicolon21);
            this.Controls.Add(this.semicolon22);
            this.Controls.Add(this.semicolon12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Double Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editTimersBtn;
        private System.Windows.Forms.Button editLabelsBtn;
        private System.Windows.Forms.TextBox editDisp1Sect1;
        private System.Windows.Forms.Button startPauseBtn;
        private System.Windows.Forms.TextBox editDisp1Sect2;
        private System.Windows.Forms.TextBox editDisp1Sect3;
        private System.Windows.Forms.TextBox editDisp2Sect1;
        private System.Windows.Forms.TextBox editDisp2Sect3;
        private System.Windows.Forms.TextBox editDisp2Sect2;
        private System.Windows.Forms.TextBox labelDisp1;
        private System.Windows.Forms.TextBox labelDisp2;
        private System.Windows.Forms.Label semicolon11;
        private System.Windows.Forms.Label semicolon12;
        private System.Windows.Forms.Label semicolon22;
        private System.Windows.Forms.Label semicolon21;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button switchBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuTray;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
    }
}

