namespace KanBan
{
    partial class Kanban
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
            this.dataGridViewConfig = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttExit = new System.Windows.Forms.Button();
            this.buttSaveChange = new System.Windows.Forms.Button();
            this.buttAddConfig = new System.Windows.Forms.Button();
            this.buttWorkSt = new System.Windows.Forms.Button();
            this.dataGridViewWStation = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWStation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConfig
            // 
            this.dataGridViewConfig.AllowUserToAddRows = false;
            this.dataGridViewConfig.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConfig.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewConfig.Location = new System.Drawing.Point(27, 125);
            this.dataGridViewConfig.Name = "dataGridViewConfig";
            this.dataGridViewConfig.Size = new System.Drawing.Size(341, 215);
            this.dataGridViewConfig.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Display Current Configuration Values";
            // 
            // buttExit
            // 
            this.buttExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(639, 379);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(88, 31);
            this.buttExit.TabIndex = 3;
            this.buttExit.Text = "Close";
            this.buttExit.UseVisualStyleBackColor = false;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // buttSaveChange
            // 
            this.buttSaveChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttSaveChange.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSaveChange.Location = new System.Drawing.Point(27, 357);
            this.buttSaveChange.Name = "buttSaveChange";
            this.buttSaveChange.Size = new System.Drawing.Size(110, 31);
            this.buttSaveChange.TabIndex = 4;
            this.buttSaveChange.Text = "Save Changes";
            this.buttSaveChange.UseVisualStyleBackColor = false;
            this.buttSaveChange.Click += new System.EventHandler(this.buttSaveChange_Click);
            // 
            // buttAddConfig
            // 
            this.buttAddConfig.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttAddConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttAddConfig.Location = new System.Drawing.Point(31, 39);
            this.buttAddConfig.Name = "buttAddConfig";
            this.buttAddConfig.Size = new System.Drawing.Size(219, 31);
            this.buttAddConfig.TabIndex = 5;
            this.buttAddConfig.Text = "Add a new configuration";
            this.buttAddConfig.UseVisualStyleBackColor = false;
            this.buttAddConfig.Click += new System.EventHandler(this.buttAddConfig_Click);
            // 
            // buttWorkSt
            // 
            this.buttWorkSt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttWorkSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttWorkSt.Location = new System.Drawing.Point(453, 40);
            this.buttWorkSt.Name = "buttWorkSt";
            this.buttWorkSt.Size = new System.Drawing.Size(324, 30);
            this.buttWorkSt.TabIndex = 6;
            this.buttWorkSt.Text = "Add or change Work Station Configaration";
            this.buttWorkSt.UseVisualStyleBackColor = false;
            this.buttWorkSt.Click += new System.EventHandler(this.buttWorkSt_Click);
            // 
            // dataGridViewWStation
            // 
            this.dataGridViewWStation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewWStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWStation.Location = new System.Drawing.Point(484, 125);
            this.dataGridViewWStation.Name = "dataGridViewWStation";
            this.dataGridViewWStation.Size = new System.Drawing.Size(293, 150);
            this.dataGridViewWStation.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current workstations settings";
            // 
            // Kanban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewWStation);
            this.Controls.Add(this.buttWorkSt);
            this.Controls.Add(this.buttAddConfig);
            this.Controls.Add(this.buttSaveChange);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewConfig);
            this.Name = "Kanban";
            this.Text = "Kanban for Fog Lamps";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Button buttSaveChange;
        private System.Windows.Forms.Button buttAddConfig;
        private System.Windows.Forms.Button buttWorkSt;
        private System.Windows.Forms.DataGridView dataGridViewWStation;
        private System.Windows.Forms.Label label2;
    }
}

