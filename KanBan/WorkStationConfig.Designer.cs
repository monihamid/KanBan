namespace KanBan
{
    partial class WorkStationConfig
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
            this.comboBoxWS = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpSkill = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttSubmit = new System.Windows.Forms.Button();
            this.buttChangeSettings = new System.Windows.Forms.Button();
            this.buttClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxWS
            // 
            this.comboBoxWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWS.FormattingEnabled = true;
            this.comboBoxWS.Location = new System.Drawing.Point(40, 45);
            this.comboBoxWS.Name = "comboBoxWS";
            this.comboBoxWS.Size = new System.Drawing.Size(163, 28);
            this.comboBoxWS.TabIndex = 0;
            // 
            // comboBoxEmpSkill
            // 
            this.comboBoxEmpSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpSkill.FormattingEnabled = true;
            this.comboBoxEmpSkill.Items.AddRange(new object[] {
            "New/Rookie",
            "Experienced/Normal",
            "V.Experienced/Super"});
            this.comboBoxEmpSkill.Location = new System.Drawing.Point(291, 44);
            this.comboBoxEmpSkill.Name = "comboBoxEmpSkill";
            this.comboBoxEmpSkill.Size = new System.Drawing.Size(167, 28);
            this.comboBoxEmpSkill.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a workStation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Employee Skill";
            // 
            // buttSubmit
            // 
            this.buttSubmit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSubmit.Location = new System.Drawing.Point(136, 169);
            this.buttSubmit.Name = "buttSubmit";
            this.buttSubmit.Size = new System.Drawing.Size(187, 30);
            this.buttSubmit.TabIndex = 4;
            this.buttSubmit.Text = "Add New WorkStation";
            this.buttSubmit.UseVisualStyleBackColor = false;
            this.buttSubmit.Click += new System.EventHandler(this.buttSubmit_Click);
            // 
            // buttChangeSettings
            // 
            this.buttChangeSettings.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttChangeSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttChangeSettings.Location = new System.Drawing.Point(429, 129);
            this.buttChangeSettings.Name = "buttChangeSettings";
            this.buttChangeSettings.Size = new System.Drawing.Size(99, 31);
            this.buttChangeSettings.TabIndex = 5;
            this.buttChangeSettings.Text = "OK";
            this.buttChangeSettings.UseVisualStyleBackColor = false;
            this.buttChangeSettings.Click += new System.EventHandler(this.buttChangeSettings_Click);
            // 
            // buttClose
            // 
            this.buttClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClose.Location = new System.Drawing.Point(429, 180);
            this.buttClose.Name = "buttClose";
            this.buttClose.Size = new System.Drawing.Size(99, 32);
            this.buttClose.TabIndex = 6;
            this.buttClose.Text = "Cancel";
            this.buttClose.UseVisualStyleBackColor = false;
            this.buttClose.Click += new System.EventHandler(this.buttClose_Click);
            // 
            // WorkStationConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 224);
            this.Controls.Add(this.buttClose);
            this.Controls.Add(this.buttChangeSettings);
            this.Controls.Add(this.buttSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEmpSkill);
            this.Controls.Add(this.comboBoxWS);
            this.Name = "WorkStationConfig";
            this.Text = "WorkStationConfig";
            this.Load += new System.EventHandler(this.WorkStationConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWS;
        private System.Windows.Forms.ComboBox comboBoxEmpSkill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttSubmit;
        private System.Windows.Forms.Button buttChangeSettings;
        private System.Windows.Forms.Button buttClose;
    }
}