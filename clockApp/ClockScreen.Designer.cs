namespace clockApp
{
    partial class ClockScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.settingsButton = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.output24Hour = new System.Windows.Forms.Label();
            this.amPmOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = true;
            this.settingsButton.Font = new System.Drawing.Font("BN Jinx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(866, 24);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(171, 40);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("BN Jinx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(24, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 40);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "BACK";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.Color.Transparent;
            this.datelabel.Font = new System.Drawing.Font("BN Jinx", 30.2F);
            this.datelabel.Location = new System.Drawing.Point(173, 398);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(369, 53);
            this.datelabel.TabIndex = 5;
            this.datelabel.Text = "JUNE 7th 2018";
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.BackColor = System.Drawing.Color.Transparent;
            this.clockLabel.Font = new System.Drawing.Font("BN Jinx", 90.2F);
            this.clockLabel.Location = new System.Drawing.Point(155, 198);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(657, 157);
            this.clockLabel.TabIndex = 4;
            this.clockLabel.Text = "12:06:36";
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 10;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // output24Hour
            // 
            this.output24Hour.AutoSize = true;
            this.output24Hour.Font = new System.Drawing.Font("BN Jinx", 20.2F);
            this.output24Hour.Location = new System.Drawing.Point(25, 595);
            this.output24Hour.Name = "output24Hour";
            this.output24Hour.Size = new System.Drawing.Size(315, 36);
            this.output24Hour.TabIndex = 8;
            this.output24Hour.Text = "24 HOUR MODE: ON";
            // 
            // amPmOutput
            // 
            this.amPmOutput.AutoSize = true;
            this.amPmOutput.BackColor = System.Drawing.Color.Transparent;
            this.amPmOutput.Font = new System.Drawing.Font("BN Jinx", 30.2F);
            this.amPmOutput.Location = new System.Drawing.Point(764, 398);
            this.amPmOutput.Name = "amPmOutput";
            this.amPmOutput.Size = new System.Drawing.Size(98, 53);
            this.amPmOutput.TabIndex = 9;
            this.amPmOutput.Text = "AM";
            // 
            // ClockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.amPmOutput);
            this.Controls.Add(this.output24Hour);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.clockLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ClockScreen";
            this.Size = new System.Drawing.Size(1059, 641);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsButton;
        private System.Windows.Forms.Label backButton;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label output24Hour;
        private System.Windows.Forms.Label amPmOutput;
    }
}
