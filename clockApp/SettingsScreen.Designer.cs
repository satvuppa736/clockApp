namespace clockApp
{
    partial class SettingsScreen
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
            this.timeModeLabel = new System.Windows.Forms.Label();
            this.colourLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Label();
            this.colourSelecter = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.onBtn = new System.Windows.Forms.RadioButton();
            this.offBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeModeLabel
            // 
            this.timeModeLabel.AutoSize = true;
            this.timeModeLabel.Font = new System.Drawing.Font("BN Jinx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeModeLabel.Location = new System.Drawing.Point(54, 305);
            this.timeModeLabel.Name = "timeModeLabel";
            this.timeModeLabel.Size = new System.Drawing.Size(278, 40);
            this.timeModeLabel.TabIndex = 9;
            this.timeModeLabel.Text = "24-HOUR MODE";
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Font = new System.Drawing.Font("BN Jinx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourLabel.Location = new System.Drawing.Point(54, 172);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(271, 40);
            this.colourLabel.TabIndex = 12;
            this.colourLabel.Text = "CLOCK COLOUR";
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("BN Jinx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(24, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 40);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "BACK";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // colourSelecter
            // 
            this.colourSelecter.Font = new System.Drawing.Font("BN Jinx", 20.2F);
            this.colourSelecter.FormattingEnabled = true;
            this.colourSelecter.Items.AddRange(new object[] {
            "DEFAULT",
            "BLUE",
            "GREEN",
            "PURPLE",
            "RED",
            "YELLOW"});
            this.colourSelecter.Location = new System.Drawing.Point(408, 171);
            this.colourSelecter.Name = "colourSelecter";
            this.colourSelecter.Size = new System.Drawing.Size(195, 44);
            this.colourSelecter.TabIndex = 14;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("BN Jinx", 11.2F);
            this.saveBtn.Location = new System.Drawing.Point(408, 435);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(168, 50);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // onBtn
            // 
            this.onBtn.AutoSize = true;
            this.onBtn.Font = new System.Drawing.Font("BN Jinx", 20.2F);
            this.onBtn.Location = new System.Drawing.Point(6, 15);
            this.onBtn.Name = "onBtn";
            this.onBtn.Size = new System.Drawing.Size(76, 40);
            this.onBtn.TabIndex = 15;
            this.onBtn.Text = "ON";
            this.onBtn.UseVisualStyleBackColor = true;
            // 
            // offBtn
            // 
            this.offBtn.AutoSize = true;
            this.offBtn.Font = new System.Drawing.Font("BN Jinx", 20.2F);
            this.offBtn.Location = new System.Drawing.Point(88, 15);
            this.offBtn.Name = "offBtn";
            this.offBtn.Size = new System.Drawing.Size(94, 40);
            this.offBtn.TabIndex = 17;
            this.offBtn.Text = "OFF";
            this.offBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.offBtn);
            this.groupBox1.Controls.Add(this.onBtn);
            this.groupBox1.Location = new System.Drawing.Point(408, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 64);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.colourSelecter);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.timeModeLabel);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SettingsScreen";
            this.Size = new System.Drawing.Size(1059, 641);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label timeModeLabel;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.Label backButton;
        private System.Windows.Forms.ComboBox colourSelecter;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RadioButton onBtn;
        private System.Windows.Forms.RadioButton offBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
