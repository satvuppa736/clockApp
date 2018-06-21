namespace clockApp
{
    partial class HomeScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.stopWatchBox = new System.Windows.Forms.PictureBox();
            this.hexBox = new System.Windows.Forms.PictureBox();
            this.clockBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stopWatchBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hexBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("BN Jinx", 48F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(27, 153);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(939, 83);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "CHOOSE AN APPLICATION";
            // 
            // stopWatchBox
            // 
            this.stopWatchBox.Image = global::clockApp.Properties.Resources.stopwatch;
            this.stopWatchBox.Location = new System.Drawing.Point(745, 341);
            this.stopWatchBox.Name = "stopWatchBox";
            this.stopWatchBox.Size = new System.Drawing.Size(250, 231);
            this.stopWatchBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stopWatchBox.TabIndex = 7;
            this.stopWatchBox.TabStop = false;
            this.stopWatchBox.Click += new System.EventHandler(this.stopWatchBox_Click);
            // 
            // hexBox
            // 
            this.hexBox.Image = global::clockApp.Properties.Resources.hashtag;
            this.hexBox.Location = new System.Drawing.Point(410, 341);
            this.hexBox.Name = "hexBox";
            this.hexBox.Size = new System.Drawing.Size(250, 231);
            this.hexBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hexBox.TabIndex = 6;
            this.hexBox.TabStop = false;
            this.hexBox.Click += new System.EventHandler(this.hexBox_Click);
            // 
            // clockBox
            // 
            this.clockBox.Image = global::clockApp.Properties.Resources.clock;
            this.clockBox.Location = new System.Drawing.Point(70, 341);
            this.clockBox.Name = "clockBox";
            this.clockBox.Size = new System.Drawing.Size(250, 231);
            this.clockBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clockBox.TabIndex = 5;
            this.clockBox.TabStop = false;
            this.clockBox.Click += new System.EventHandler(this.clockBox_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.stopWatchBox);
            this.Controls.Add(this.hexBox);
            this.Controls.Add(this.clockBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(1059, 641);
            ((System.ComponentModel.ISupportInitialize)(this.stopWatchBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hexBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox stopWatchBox;
        private System.Windows.Forms.PictureBox hexBox;
        private System.Windows.Forms.PictureBox clockBox;
        private System.Windows.Forms.Label titleLabel;
    }
}
