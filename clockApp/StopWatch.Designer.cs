namespace clockApp
{
    partial class StopWatch
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
            this.backButton = new System.Windows.Forms.Label();
            this.stopWatchTimer = new System.Windows.Forms.Timer(this.components);
            this.clockLabel = new System.Windows.Forms.Label();
            this.resetLapBtn = new System.Windows.Forms.Button();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.lapTimeOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("BN Jinx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(24, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 40);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "BACK";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // stopWatchTimer
            // 
            this.stopWatchTimer.Interval = 1;
            this.stopWatchTimer.Tick += new System.EventHandler(this.stopWatchTimer_Tick);
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("BN Jinx", 75.2F);
            this.clockLabel.Location = new System.Drawing.Point(97, 115);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(859, 131);
            this.clockLabel.TabIndex = 8;
            this.clockLabel.Text = "00:00:00.000";
            // 
            // resetLapBtn
            // 
            this.resetLapBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetLapBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.resetLapBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.resetLapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetLapBtn.Font = new System.Drawing.Font("BN Jinx", 11.2F);
            this.resetLapBtn.ForeColor = System.Drawing.Color.Red;
            this.resetLapBtn.Location = new System.Drawing.Point(788, 319);
            this.resetLapBtn.Name = "resetLapBtn";
            this.resetLapBtn.Size = new System.Drawing.Size(168, 50);
            this.resetLapBtn.TabIndex = 17;
            this.resetLapBtn.Text = "RESET";
            this.resetLapBtn.UseVisualStyleBackColor = false;
            this.resetLapBtn.Click += new System.EventHandler(this.resetLapBtn_Click);
            // 
            // startStopBtn
            // 
            this.startStopBtn.BackColor = System.Drawing.Color.Transparent;
            this.startStopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.startStopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.startStopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startStopBtn.Font = new System.Drawing.Font("BN Jinx", 11.2F);
            this.startStopBtn.ForeColor = System.Drawing.Color.Lime;
            this.startStopBtn.Location = new System.Drawing.Point(119, 319);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(168, 50);
            this.startStopBtn.TabIndex = 18;
            this.startStopBtn.Text = "START";
            this.startStopBtn.UseVisualStyleBackColor = false;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // lapTimeOutput
            // 
            this.lapTimeOutput.BackColor = System.Drawing.Color.Black;
            this.lapTimeOutput.Font = new System.Drawing.Font("PenultimateLightItal", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapTimeOutput.ForeColor = System.Drawing.Color.White;
            this.lapTimeOutput.FormattingEnabled = true;
            this.lapTimeOutput.ItemHeight = 38;
            this.lapTimeOutput.Location = new System.Drawing.Point(283, 375);
            this.lapTimeOutput.Name = "lapTimeOutput";
            this.lapTimeOutput.Size = new System.Drawing.Size(506, 232);
            this.lapTimeOutput.TabIndex = 19;
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lapTimeOutput);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.resetLapBtn);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.backButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "StopWatch";
            this.Size = new System.Drawing.Size(1059, 641);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backButton;
        private System.Windows.Forms.Timer stopWatchTimer;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Button resetLapBtn;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.ListBox lapTimeOutput;
    }
}
