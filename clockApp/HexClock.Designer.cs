namespace clockApp
{
    partial class HexClock
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
            this.hexLabel = new System.Windows.Forms.Label();
            this.hexTimer = new System.Windows.Forms.Timer(this.components);
            this.backButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("BN Jinx", 95.2F);
            this.hexLabel.Location = new System.Drawing.Point(178, 242);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(704, 166);
            this.hexLabel.TabIndex = 5;
            this.hexLabel.Text = "#125636";
            // 
            // hexTimer
            // 
            this.hexTimer.Interval = 10;
            this.hexTimer.Tick += new System.EventHandler(this.hexTimer_Tick);
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
            // HexClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.hexLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "HexClock";
            this.Size = new System.Drawing.Size(1059, 641);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Timer hexTimer;
        private System.Windows.Forms.Label backButton;
    }
}
