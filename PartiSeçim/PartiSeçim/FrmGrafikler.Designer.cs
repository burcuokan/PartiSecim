namespace PartiSeçim
{
    partial class FrmGrafikler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblD = new System.Windows.Forms.Label();
            this.LblE = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(796, 252);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblD);
            this.groupBox2.Controls.Add(this.LblE);
            this.groupBox2.Controls.Add(this.LblC);
            this.groupBox2.Controls.Add(this.LblB);
            this.groupBox2.Controls.Add(this.LblA);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(541, 194);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(17, 19);
            this.LblD.TabIndex = 17;
            this.LblD.Text = "0";
            // 
            // LblE
            // 
            this.LblE.AutoSize = true;
            this.LblE.Location = new System.Drawing.Point(541, 231);
            this.LblE.Name = "LblE";
            this.LblE.Size = new System.Drawing.Size(17, 19);
            this.LblE.TabIndex = 16;
            this.LblE.Text = "0";
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Location = new System.Drawing.Point(541, 157);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(17, 19);
            this.LblC.TabIndex = 15;
            this.LblC.Text = "0";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(541, 120);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(17, 19);
            this.LblB.TabIndex = 13;
            this.LblB.Text = "0";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(541, 83);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(17, 19);
            this.LblA.TabIndex = 12;
            this.LblA.Text = "0";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(153, 226);
            this.progressBar5.Maximum = 200;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(368, 31);
            this.progressBar5.TabIndex = 11;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(155, 189);
            this.progressBar4.Maximum = 200;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(366, 31);
            this.progressBar4.TabIndex = 10;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(155, 152);
            this.progressBar3.Maximum = 200;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(366, 31);
            this.progressBar3.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(155, 115);
            this.progressBar2.Maximum = 200;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(366, 31);
            this.progressBar2.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(155, 78);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(366, 31);
            this.progressBar1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 27);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "E PARTİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "A PARTİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "B PARTİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "C PARTİ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "D PARTİi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçim:";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(805, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim Grafiği";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label LblE;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblA;
    }
}