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
            this.components = new System.ComponentModel.Container();
            this.aerial = new System.Windows.Forms.CheckBox();
            this.LogOutput = new System.Windows.Forms.TextBox();
            this.Score = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.Rate = new System.Windows.Forms.TextBox();
            this.StartGame = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.PowerSwitch = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TapePlaying = new System.Windows.Forms.CheckBox();
            this.Interference = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // aerial
            // 
            this.aerial.AutoSize = true;
            this.aerial.Checked = true;
            this.aerial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aerial.Location = new System.Drawing.Point(160, 161);
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
            // PowerSwitch
            // 
            this.PowerSwitch.AutoSize = true;
            this.PowerSwitch.Checked = true;
            this.PowerSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PowerSwitch.Location = new System.Drawing.Point(33, 161);
            this.PowerSwitch.Name = "PowerSwitch";
            this.PowerSwitch.Size = new System.Drawing.Size(91, 17);
            this.PowerSwitch.TabIndex = 15;
            this.PowerSwitch.Text = "Power Switch";
            this.PowerSwitch.UseVisualStyleBackColor = true;
            this.PowerSwitch.CheckedChanged += new System.EventHandler(this.PowerSwitch_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TapePlaying
            // 
            this.TapePlaying.AutoSize = true;
            this.TapePlaying.Location = new System.Drawing.Point(33, 67);
            this.TapePlaying.Name = "TapePlaying";
            this.TapePlaying.Size = new System.Drawing.Size(88, 17);
            this.TapePlaying.TabIndex = 19;
            this.TapePlaying.Text = "Tape Playing";
            this.TapePlaying.UseVisualStyleBackColor = true;
            this.TapePlaying.CheckedChanged += new System.EventHandler(this.TapePlaying_CheckedChanged);
            // 
            // Interference
            // 
            this.Interference.AutoSize = true;
            this.Interference.Location = new System.Drawing.Point(33, 116);
            this.Interference.Name = "Interference";
            this.Interference.Size = new System.Drawing.Size(83, 17);
            this.Interference.TabIndex = 20;
            this.Interference.Text = "Interference";
            this.Interference.UseVisualStyleBackColor = true;
            this.Interference.CheckedChanged += new System.EventHandler(this.Interference_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 409);
            this.Controls.Add(this.Interference);
            this.Controls.Add(this.TapePlaying);
            this.Controls.Add(this.PowerSwitch);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.LogOutput);
            this.Controls.Add(this.aerial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox aerial;
        private System.Windows.Forms.TextBox LogOutput;
        private System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox Rate;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.CheckBox PowerSwitch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox TapePlaying;
        private System.Windows.Forms.CheckBox Interference;
    }
}

