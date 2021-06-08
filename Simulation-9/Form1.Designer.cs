
namespace Simulation_9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Prob1 = new System.Windows.Forms.NumericUpDown();
            this.Prob2 = new System.Windows.Forms.NumericUpDown();
            this.Prob3 = new System.Windows.Forms.NumericUpDown();
            this.Prob4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startB = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.NExp = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Prob5 = new System.Windows.Forms.NumericUpDown();
            this.labAverage = new System.Windows.Forms.Label();
            this.labVariance = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labChiBool = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob5)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(346, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "P1";
            series2.YValuesPerPoint = 6;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(421, 347);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Prob1
            // 
            this.Prob1.DecimalPlaces = 2;
            this.Prob1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Prob1.Location = new System.Drawing.Point(129, 67);
            this.Prob1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Prob1.Name = "Prob1";
            this.Prob1.Size = new System.Drawing.Size(120, 22);
            this.Prob1.TabIndex = 1;
            this.Prob1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Prob2
            // 
            this.Prob2.DecimalPlaces = 2;
            this.Prob2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Prob2.Location = new System.Drawing.Point(129, 106);
            this.Prob2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Prob2.Name = "Prob2";
            this.Prob2.Size = new System.Drawing.Size(120, 22);
            this.Prob2.TabIndex = 1;
            this.Prob2.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // Prob3
            // 
            this.Prob3.DecimalPlaces = 2;
            this.Prob3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Prob3.Location = new System.Drawing.Point(129, 145);
            this.Prob3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Prob3.Name = "Prob3";
            this.Prob3.Size = new System.Drawing.Size(120, 22);
            this.Prob3.TabIndex = 1;
            this.Prob3.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // Prob4
            // 
            this.Prob4.DecimalPlaces = 2;
            this.Prob4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Prob4.Location = new System.Drawing.Point(129, 185);
            this.Prob4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Prob4.Name = "Prob4";
            this.Prob4.Size = new System.Drawing.Size(120, 22);
            this.Prob4.TabIndex = 1;
            this.Prob4.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prob1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prob2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prob3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prob4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prob5";
            // 
            // startB
            // 
            this.startB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startB.Location = new System.Drawing.Point(80, 321);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(169, 71);
            this.startB.TabIndex = 3;
            this.startB.Text = "Старт";
            this.startB.UseVisualStyleBackColor = false;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // NExp
            // 
            this.NExp.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NExp.Location = new System.Drawing.Point(205, 276);
            this.NExp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NExp.Name = "NExp";
            this.NExp.Size = new System.Drawing.Size(82, 22);
            this.NExp.TabIndex = 4;
            this.NExp.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Number of experiments";
            // 
            // Prob5
            // 
            this.Prob5.DecimalPlaces = 2;
            this.Prob5.Enabled = false;
            this.Prob5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Prob5.Location = new System.Drawing.Point(129, 224);
            this.Prob5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Prob5.Name = "Prob5";
            this.Prob5.Size = new System.Drawing.Size(120, 22);
            this.Prob5.TabIndex = 5;
            // 
            // labAverage
            // 
            this.labAverage.AutoSize = true;
            this.labAverage.Location = new System.Drawing.Point(343, 378);
            this.labAverage.Name = "labAverage";
            this.labAverage.Size = new System.Drawing.Size(27, 17);
            this.labAverage.TabIndex = 6;
            this.labAverage.Text = "lab";
            // 
            // labVariance
            // 
            this.labVariance.AutoSize = true;
            this.labVariance.Location = new System.Drawing.Point(565, 378);
            this.labVariance.Name = "labVariance";
            this.labVariance.Size = new System.Drawing.Size(27, 17);
            this.labVariance.TabIndex = 7;
            this.labVariance.Text = "lab";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Location = new System.Drawing.Point(343, 411);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(27, 17);
            this.labChi.TabIndex = 8;
            this.labChi.Text = "lab";
            // 
            // labChiBool
            // 
            this.labChiBool.AutoSize = true;
            this.labChiBool.Location = new System.Drawing.Point(511, 411);
            this.labChiBool.Name = "labChiBool";
            this.labChiBool.Size = new System.Drawing.Size(27, 17);
            this.labChiBool.TabIndex = 9;
            this.labChiBool.Text = "lab";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 444);
            this.Controls.Add(this.labChiBool);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.labVariance);
            this.Controls.Add(this.labAverage);
            this.Controls.Add(this.Prob5);
            this.Controls.Add(this.NExp);
            this.Controls.Add(this.startB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prob4);
            this.Controls.Add(this.Prob3);
            this.Controls.Add(this.Prob2);
            this.Controls.Add(this.Prob1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown Prob1;
        private System.Windows.Forms.NumericUpDown Prob2;
        private System.Windows.Forms.NumericUpDown Prob3;
        private System.Windows.Forms.NumericUpDown Prob4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown NExp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Prob5;
        private System.Windows.Forms.Label labAverage;
        private System.Windows.Forms.Label labVariance;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labChiBool;
    }
}

