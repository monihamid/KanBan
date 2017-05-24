namespace AssemblyLine
{
    partial class AssemblyLine
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttClose = new System.Windows.Forms.Button();
            this.labtotalOrder = new System.Windows.Forms.Label();
            this.labtotalProduce = new System.Windows.Forms.Label();
            this.labtotalYield = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChart
            // 
            this.pieChart.BackColor = System.Drawing.Color.Transparent;
            this.pieChart.BorderlineColor = System.Drawing.Color.Maroon;
            this.pieChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.pieChart.BorderlineWidth = 2;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.TitleForeColor = System.Drawing.Color.CornflowerBlue;
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(22, 26);
            this.pieChart.Name = "pieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(390, 380);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "chart1";
            // 
            // buttClose
            // 
            this.buttClose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttClose.Location = new System.Drawing.Point(568, 371);
            this.buttClose.Name = "buttClose";
            this.buttClose.Size = new System.Drawing.Size(89, 35);
            this.buttClose.TabIndex = 1;
            this.buttClose.Text = "Close";
            this.buttClose.UseVisualStyleBackColor = false;
            this.buttClose.Click += new System.EventHandler(this.buttClose_Click);
            // 
            // labtotalOrder
            // 
            this.labtotalOrder.AutoSize = true;
            this.labtotalOrder.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labtotalOrder.Location = new System.Drawing.Point(457, 52);
            this.labtotalOrder.Name = "labtotalOrder";
            this.labtotalOrder.Size = new System.Drawing.Size(56, 23);
            this.labtotalOrder.TabIndex = 2;
            this.labtotalOrder.Text = "label1";
            // 
            // labtotalProduce
            // 
            this.labtotalProduce.AutoSize = true;
            this.labtotalProduce.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labtotalProduce.Location = new System.Drawing.Point(457, 161);
            this.labtotalProduce.Name = "labtotalProduce";
            this.labtotalProduce.Size = new System.Drawing.Size(56, 23);
            this.labtotalProduce.TabIndex = 3;
            this.labtotalProduce.Text = "label2";
            // 
            // labtotalYield
            // 
            this.labtotalYield.AutoSize = true;
            this.labtotalYield.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labtotalYield.Location = new System.Drawing.Point(457, 106);
            this.labtotalYield.Name = "labtotalYield";
            this.labtotalYield.Size = new System.Drawing.Size(56, 23);
            this.labtotalYield.TabIndex = 4;
            this.labtotalYield.Text = "label3";
            // 
            // AssemblyLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labtotalYield);
            this.Controls.Add(this.labtotalProduce);
            this.Controls.Add(this.labtotalOrder);
            this.Controls.Add(this.buttClose);
            this.Controls.Add(this.pieChart);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AssemblyLine";
            this.Text = "Assembly Line KanBan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.Button buttClose;
        private System.Windows.Forms.Label labtotalOrder;
        private System.Windows.Forms.Label labtotalProduce;
        private System.Windows.Forms.Label labtotalYield;
    }
}

