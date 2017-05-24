namespace KanBan
{
    partial class NewConfig
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
            this.textBoxSimuFact = new System.Windows.Forms.TextBox();
            this.textBoxCurrentV = new System.Windows.Forms.TextBox();
            this.buttCreate = new System.Windows.Forms.Button();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.buttCancel = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSimuFact
            // 
            this.textBoxSimuFact.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSimuFact.Location = new System.Drawing.Point(21, 57);
            this.textBoxSimuFact.Name = "textBoxSimuFact";
            this.textBoxSimuFact.Size = new System.Drawing.Size(132, 26);
            this.textBoxSimuFact.TabIndex = 0;
            // 
            // textBoxCurrentV
            // 
            this.textBoxCurrentV.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentV.Location = new System.Drawing.Point(187, 57);
            this.textBoxCurrentV.Name = "textBoxCurrentV";
            this.textBoxCurrentV.Size = new System.Drawing.Size(100, 26);
            this.textBoxCurrentV.TabIndex = 1;
            // 
            // buttCreate
            // 
            this.buttCreate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttCreate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCreate.Location = new System.Drawing.Point(66, 152);
            this.buttCreate.Name = "buttCreate";
            this.buttCreate.Size = new System.Drawing.Size(87, 33);
            this.buttCreate.TabIndex = 3;
            this.buttCreate.Text = "Create";
            this.buttCreate.UseVisualStyleBackColor = false;
            this.buttCreate.Click += new System.EventHandler(this.buttCreate_Click);
            // 
            // comboBoxDataType
            // 
            this.comboBoxDataType.AllowDrop = true;
            this.comboBoxDataType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDataType.FormattingEnabled = true;
            this.comboBoxDataType.Items.AddRange(new object[] {
            "VARCHAR(50)",
            "INTEGER",
            "FLOAT",
            "DATETIME"});
            this.comboBoxDataType.Location = new System.Drawing.Point(330, 57);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(136, 28);
            this.comboBoxDataType.TabIndex = 4;
            // 
            // buttCancel
            // 
            this.buttCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCancel.Location = new System.Drawing.Point(247, 152);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(88, 33);
            this.buttCancel.TabIndex = 5;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = false;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // buttExit
            // 
            this.buttExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(386, 239);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(80, 31);
            this.buttExit.TabIndex = 6;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = false;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Simulation Factor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Current Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Data Type";
            // 
            // NewConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 333);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttCancel);
            this.Controls.Add(this.comboBoxDataType);
            this.Controls.Add(this.buttCreate);
            this.Controls.Add(this.textBoxCurrentV);
            this.Controls.Add(this.textBoxSimuFact);
            this.Name = "NewConfig";
            this.Text = "Add New Configuration Factor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSimuFact;
        private System.Windows.Forms.TextBox textBoxCurrentV;
        private System.Windows.Forms.Button buttCreate;
        private System.Windows.Forms.ComboBox comboBoxDataType;
        private System.Windows.Forms.Button buttCancel;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}