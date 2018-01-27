namespace Tester
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
            this.tape1 = new System.Windows.Forms.RadioButton();
            this.tape2 = new System.Windows.Forms.RadioButton();
            this.tape3 = new System.Windows.Forms.RadioButton();
            this.tape4 = new System.Windows.Forms.RadioButton();
            this.tape5 = new System.Windows.Forms.RadioButton();
            this.aerial = new System.Windows.Forms.CheckBox();
            this.LogOutput = new System.Windows.Forms.TextBox();
            this.Score = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.Rate = new System.Windows.Forms.TextBox();
            this.StartGame = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Green = new System.Windows.Forms.RadioButton();
            this.Red = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.KillSwitch = new System.Windows.Forms.CheckBox();
            this.Play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tape1
            // 
            this.tape1.AutoSize = true;
            this.tape1.Location = new System.Drawing.Point(13, 19);
            this.tape1.Name = "tape1";
            this.tape1.Size = new System.Drawing.Size(59, 17);
            this.tape1.TabIndex = 0;
            this.tape1.TabStop = true;
            this.tape1.Text = "Tape 1";
            this.tape1.UseVisualStyleBackColor = true;
            this.tape1.CheckedChanged += new System.EventHandler(this.tape1_CheckedChanged);
            // 
            // tape2
            // 
            this.tape2.AutoSize = true;
            this.tape2.Location = new System.Drawing.Point(78, 19);
            this.tape2.Name = "tape2";
            this.tape2.Size = new System.Drawing.Size(59, 17);
            this.tape2.TabIndex = 1;
            this.tape2.TabStop = true;
            this.tape2.Text = "Tape 2";
            this.tape2.UseVisualStyleBackColor = true;
            this.tape2.CheckedChanged += new System.EventHandler(this.tape2_CheckedChanged);
            // 
            // tape3
            // 
            this.tape3.AutoSize = true;
            this.tape3.Location = new System.Drawing.Point(143, 19);
            this.tape3.Name = "tape3";
            this.tape3.Size = new System.Drawing.Size(59, 17);
            this.tape3.TabIndex = 2;
            this.tape3.TabStop = true;
            this.tape3.Text = "Tape 3";
            this.tape3.UseVisualStyleBackColor = true;
            this.tape3.CheckedChanged += new System.EventHandler(this.tape3_CheckedChanged);
            // 
            // tape4
            // 
            this.tape4.AutoSize = true;
            this.tape4.Location = new System.Drawing.Point(208, 19);
            this.tape4.Name = "tape4";
            this.tape4.Size = new System.Drawing.Size(59, 17);
            this.tape4.TabIndex = 3;
            this.tape4.TabStop = true;
            this.tape4.Text = "Tape 4";
            this.tape4.UseVisualStyleBackColor = true;
            this.tape4.CheckedChanged += new System.EventHandler(this.tape4_CheckedChanged);
            // 
            // tape5
            // 
            this.tape5.AutoSize = true;
            this.tape5.Location = new System.Drawing.Point(273, 19);
            this.tape5.Name = "tape5";
            this.tape5.Size = new System.Drawing.Size(59, 17);
            this.tape5.TabIndex = 4;
            this.tape5.TabStop = true;
            this.tape5.Text = "Tape 5";
            this.tape5.UseVisualStyleBackColor = true;
            this.tape5.CheckedChanged += new System.EventHandler(this.tape5_CheckedChanged);
            // 
            // aerial
            // 
            this.aerial.AutoSize = true;
            this.aerial.Location = new System.Drawing.Point(417, 261);
            this.aerial.Name = "aerial";
            this.aerial.Size = new System.Drawing.Size(72, 17);
            this.aerial.TabIndex = 5;
            this.aerial.Text = "Aerial Out";
            this.aerial.UseVisualStyleBackColor = true;
            this.aerial.CheckedChanged += new System.EventHandler(this.aerial_CheckedChanged);
            // 
            // LogOutput
            // 
            this.LogOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutput.Location = new System.Drawing.Point(563, 65);
            this.LogOutput.Multiline = true;
            this.LogOutput.Name = "LogOutput";
            this.LogOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogOutput.Size = new System.Drawing.Size(450, 332);
            this.LogOutput.TabIndex = 6;
            // 
            // Score
            // 
            this.Score.Location = new System.Drawing.Point(563, 23);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(100, 20);
            this.Score.TabIndex = 7;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(913, 23);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(100, 20);
            this.Time.TabIndex = 8;
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(741, 23);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(100, 20);
            this.Rate.TabIndex = 9;
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(13, 13);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(75, 23);
            this.StartGame.TabIndex = 10;
            this.StartGame.Text = "Start";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(94, 13);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(308, 65);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(181, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tape1);
            this.groupBox1.Controls.Add(this.tape2);
            this.groupBox1.Controls.Add(this.tape3);
            this.groupBox1.Controls.Add(this.tape4);
            this.groupBox1.Controls.Add(this.tape5);
            this.groupBox1.Location = new System.Drawing.Point(140, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 56);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tapes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Green);
            this.groupBox2.Controls.Add(this.Red);
            this.groupBox2.Controls.Add(this.Blue);
            this.groupBox2.Location = new System.Drawing.Point(308, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 52);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bands";
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(110, 19);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(54, 17);
            this.Green.TabIndex = 16;
            this.Green.TabStop = true;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.Green_CheckedChanged);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(59, 19);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(45, 17);
            this.Red.TabIndex = 15;
            this.Red.TabStop = true;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(7, 20);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(46, 17);
            this.Blue.TabIndex = 0;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.Blue_CheckedChanged);
            // 
            // KillSwitch
            // 
            this.KillSwitch.AutoSize = true;
            this.KillSwitch.Location = new System.Drawing.Point(33, 261);
            this.KillSwitch.Name = "KillSwitch";
            this.KillSwitch.Size = new System.Drawing.Size(71, 17);
            this.KillSwitch.TabIndex = 15;
            this.KillSwitch.Text = "KillSwitch";
            this.KillSwitch.UseVisualStyleBackColor = true;
            this.KillSwitch.CheckedChanged += new System.EventHandler(this.KillSwitch_CheckedChanged);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(113, 82);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 16;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "00:00 - 00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.KillSwitch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.LogOutput);
            this.Controls.Add(this.aerial);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton tape1;
        private System.Windows.Forms.RadioButton tape2;
        private System.Windows.Forms.RadioButton tape3;
        private System.Windows.Forms.RadioButton tape4;
        private System.Windows.Forms.RadioButton tape5;
        private System.Windows.Forms.CheckBox aerial;
        private System.Windows.Forms.TextBox LogOutput;
        private System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox Rate;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.CheckBox KillSwitch;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label label1;
    }
}

