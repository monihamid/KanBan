namespace WorkstationAndon
{
    partial class WorkstationAndon
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWS = new System.Windows.Forms.ComboBox();
            this.buttSubmit = new System.Windows.Forms.Button();
            this.progressBarharness = new System.Windows.Forms.ProgressBar();
            this.progressBarReflector = new System.Windows.Forms.ProgressBar();
            this.progressBarHousing = new System.Windows.Forms.ProgressBar();
            this.progressBarLens = new System.Windows.Forms.ProgressBar();
            this.progressBarBulb = new System.Windows.Forms.ProgressBar();
            this.progressBarBezel = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttClose = new System.Windows.Forms.Button();
            this.labHarnes = new System.Windows.Forms.Label();
            this.labReflector = new System.Windows.Forms.Label();
            this.labHousing = new System.Windows.Forms.Label();
            this.labLens = new System.Windows.Forms.Label();
            this.labBulb = new System.Windows.Forms.Label();
            this.labBezel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which works station would you like to display ?";
            // 
            // comboBoxWS
            // 
            this.comboBoxWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWS.FormattingEnabled = true;
            this.comboBoxWS.Location = new System.Drawing.Point(419, 22);
            this.comboBoxWS.Name = "comboBoxWS";
            this.comboBoxWS.Size = new System.Drawing.Size(173, 28);
            this.comboBoxWS.TabIndex = 1;
            this.comboBoxWS.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttSubmit
            // 
            this.buttSubmit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSubmit.Location = new System.Drawing.Point(645, 27);
            this.buttSubmit.Name = "buttSubmit";
            this.buttSubmit.Size = new System.Drawing.Size(98, 32);
            this.buttSubmit.TabIndex = 2;
            this.buttSubmit.Text = "Start";
            this.buttSubmit.UseVisualStyleBackColor = false;
            this.buttSubmit.Click += new System.EventHandler(this.buttSubmit_Click);
            // 
            // progressBarharness
            // 
            this.progressBarharness.Location = new System.Drawing.Point(233, 89);
            this.progressBarharness.Maximum = 60;
            this.progressBarharness.Name = "progressBarharness";
            this.progressBarharness.Size = new System.Drawing.Size(494, 23);
            this.progressBarharness.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarharness.TabIndex = 3;
            // 
            // progressBarReflector
            // 
            this.progressBarReflector.Location = new System.Drawing.Point(233, 127);
            this.progressBarReflector.Maximum = 40;
            this.progressBarReflector.Name = "progressBarReflector";
            this.progressBarReflector.Size = new System.Drawing.Size(494, 23);
            this.progressBarReflector.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarReflector.TabIndex = 4;
            // 
            // progressBarHousing
            // 
            this.progressBarHousing.Location = new System.Drawing.Point(233, 173);
            this.progressBarHousing.Maximum = 29;
            this.progressBarHousing.Name = "progressBarHousing";
            this.progressBarHousing.Size = new System.Drawing.Size(494, 23);
            this.progressBarHousing.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarHousing.TabIndex = 5;
            // 
            // progressBarLens
            // 
            this.progressBarLens.Location = new System.Drawing.Point(233, 211);
            this.progressBarLens.Maximum = 45;
            this.progressBarLens.Name = "progressBarLens";
            this.progressBarLens.Size = new System.Drawing.Size(494, 23);
            this.progressBarLens.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarLens.TabIndex = 6;
            // 
            // progressBarBulb
            // 
            this.progressBarBulb.Location = new System.Drawing.Point(233, 250);
            this.progressBarBulb.Maximum = 65;
            this.progressBarBulb.Name = "progressBarBulb";
            this.progressBarBulb.Size = new System.Drawing.Size(494, 23);
            this.progressBarBulb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarBulb.TabIndex = 7;
            // 
            // progressBarBezel
            // 
            this.progressBarBezel.Location = new System.Drawing.Point(233, 291);
            this.progressBarBezel.Maximum = 80;
            this.progressBarBezel.Name = "progressBarBezel";
            this.progressBarBezel.Size = new System.Drawing.Size(494, 23);
            this.progressBarBezel.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarBezel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Harnes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Reflector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Housing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lens";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bulb";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bezel";
            // 
            // buttClose
            // 
            this.buttClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClose.Location = new System.Drawing.Point(645, 372);
            this.buttClose.Name = "buttClose";
            this.buttClose.Size = new System.Drawing.Size(116, 33);
            this.buttClose.TabIndex = 15;
            this.buttClose.Text = "Stop";
            this.buttClose.UseVisualStyleBackColor = false;
            this.buttClose.Click += new System.EventHandler(this.buttClose_Click);
            // 
            // labHarnes
            // 
            this.labHarnes.AutoSize = true;
            this.labHarnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHarnes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labHarnes.Location = new System.Drawing.Point(176, 89);
            this.labHarnes.Name = "labHarnes";
            this.labHarnes.Size = new System.Drawing.Size(0, 20);
            this.labHarnes.TabIndex = 16;
            // 
            // labReflector
            // 
            this.labReflector.AutoSize = true;
            this.labReflector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labReflector.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labReflector.Location = new System.Drawing.Point(177, 127);
            this.labReflector.Name = "labReflector";
            this.labReflector.Size = new System.Drawing.Size(0, 20);
            this.labReflector.TabIndex = 17;
            // 
            // labHousing
            // 
            this.labHousing.AutoSize = true;
            this.labHousing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHousing.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labHousing.Location = new System.Drawing.Point(172, 169);
            this.labHousing.Name = "labHousing";
            this.labHousing.Size = new System.Drawing.Size(0, 20);
            this.labHousing.TabIndex = 18;
            // 
            // labLens
            // 
            this.labLens.AutoSize = true;
            this.labLens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLens.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labLens.Location = new System.Drawing.Point(163, 214);
            this.labLens.Name = "labLens";
            this.labLens.Size = new System.Drawing.Size(0, 20);
            this.labLens.TabIndex = 19;
            // 
            // labBulb
            // 
            this.labBulb.AutoSize = true;
            this.labBulb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBulb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labBulb.Location = new System.Drawing.Point(163, 250);
            this.labBulb.Name = "labBulb";
            this.labBulb.Size = new System.Drawing.Size(0, 20);
            this.labBulb.TabIndex = 20;
            // 
            // labBezel
            // 
            this.labBezel.AutoSize = true;
            this.labBezel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBezel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labBezel.Location = new System.Drawing.Point(163, 291);
            this.labBezel.Name = "labBezel";
            this.labBezel.Size = new System.Drawing.Size(0, 20);
            this.labBezel.TabIndex = 21;
            // 
            // WorkstationAndon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 461);
            this.Controls.Add(this.labBezel);
            this.Controls.Add(this.labBulb);
            this.Controls.Add(this.labLens);
            this.Controls.Add(this.labHousing);
            this.Controls.Add(this.labReflector);
            this.Controls.Add(this.labHarnes);
            this.Controls.Add(this.buttClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarBezel);
            this.Controls.Add(this.progressBarBulb);
            this.Controls.Add(this.progressBarLens);
            this.Controls.Add(this.progressBarHousing);
            this.Controls.Add(this.progressBarReflector);
            this.Controls.Add(this.progressBarharness);
            this.Controls.Add(this.buttSubmit);
            this.Controls.Add(this.comboBoxWS);
            this.Controls.Add(this.label1);
            this.Name = "WorkstationAndon";
            this.Text = "Workstation Andon";
            this.Load += new System.EventHandler(this.WorkstationAndon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWS;
        private System.Windows.Forms.Button buttSubmit;
        private System.Windows.Forms.ProgressBar progressBarharness;
        private System.Windows.Forms.ProgressBar progressBarReflector;
        private System.Windows.Forms.ProgressBar progressBarHousing;
        private System.Windows.Forms.ProgressBar progressBarLens;
        private System.Windows.Forms.ProgressBar progressBarBulb;
        private System.Windows.Forms.ProgressBar progressBarBezel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttClose;
        private System.Windows.Forms.Label labHarnes;
        private System.Windows.Forms.Label labReflector;
        private System.Windows.Forms.Label labHousing;
        private System.Windows.Forms.Label labLens;
        private System.Windows.Forms.Label labBulb;
        private System.Windows.Forms.Label labBezel;
    }
}

