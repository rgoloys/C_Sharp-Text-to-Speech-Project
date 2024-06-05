namespace TextToSpeech
{
    partial class MainForm
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
            this.MaintextBox = new System.Windows.Forms.TextBox();
            this.SpeakBtn = new System.Windows.Forms.Button();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.VoiceOptionLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.PersonComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MaintextBox
            // 
            this.MaintextBox.BackColor = System.Drawing.Color.White;
            this.MaintextBox.Location = new System.Drawing.Point(13, 12);
            this.MaintextBox.Multiline = true;
            this.MaintextBox.Name = "MaintextBox";
            this.MaintextBox.Size = new System.Drawing.Size(272, 144);
            this.MaintextBox.TabIndex = 0;
            // 
            // SpeakBtn
            // 
            this.SpeakBtn.BackColor = System.Drawing.SystemColors.MenuText;
            this.SpeakBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeakBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpeakBtn.Location = new System.Drawing.Point(11, 168);
            this.SpeakBtn.Name = "SpeakBtn";
            this.SpeakBtn.Size = new System.Drawing.Size(551, 49);
            this.SpeakBtn.TabIndex = 1;
            this.SpeakBtn.Text = "Speak";
            this.SpeakBtn.UseVisualStyleBackColor = false;
            this.SpeakBtn.Click += new System.EventHandler(this.SpeakBtn_Click);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Location = new System.Drawing.Point(342, 18);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(221, 45);
            this.VolumeTrackBar.TabIndex = 2;
            this.VolumeTrackBar.Value = 50;
            // 
            // VoiceOptionLabel
            // 
            this.VoiceOptionLabel.AutoSize = true;
            this.VoiceOptionLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.VoiceOptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VoiceOptionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VoiceOptionLabel.Location = new System.Drawing.Point(288, 120);
            this.VoiceOptionLabel.Name = "VoiceOptionLabel";
            this.VoiceOptionLabel.Size = new System.Drawing.Size(76, 15);
            this.VoiceOptionLabel.TabIndex = 4;
            this.VoiceOptionLabel.Text = "Voice Option: ";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(291, 21);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(45, 13);
            this.VolumeLabel.TabIndex = 5;
            this.VolumeLabel.Text = "Volume:";
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Location = new System.Drawing.Point(342, 69);
            this.SpeedTrackBar.Minimum = -10;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(221, 45);
            this.SpeedTrackBar.TabIndex = 8;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(291, 75);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(41, 13);
            this.SpeedLabel.TabIndex = 9;
            this.SpeedLabel.Text = "Speed:";
            // 
            // PersonComboBox
            // 
            this.PersonComboBox.FormattingEnabled = true;
            this.PersonComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PersonComboBox.Location = new System.Drawing.Point(370, 119);
            this.PersonComboBox.Name = "PersonComboBox";
            this.PersonComboBox.Size = new System.Drawing.Size(188, 21);
            this.PersonComboBox.TabIndex = 11;
            this.PersonComboBox.Text = "Male";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(570, 229);
            this.Controls.Add(this.PersonComboBox);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.SpeedTrackBar);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.VoiceOptionLabel);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.SpeakBtn);
            this.Controls.Add(this.MaintextBox);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hello Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaintextBox;
        private System.Windows.Forms.Button SpeakBtn;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Label VoiceOptionLabel;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.ComboBox PersonComboBox;
    }
}

