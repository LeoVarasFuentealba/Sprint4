
namespace Sprint4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "gol",
            "hols"}, -1);
            this.graficaTempTiem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tiempoTemperatura25 = new System.Windows.Forms.ListView();
            this.Tiempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temperatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calibrationBtn = new System.Windows.Forms.Button();
            this.timerTemp = new System.Windows.Forms.Timer(this.components);
            this.tiempoTemperatura1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.graficaTempTiem)).BeginInit();
            this.SuspendLayout();
            // 
            // graficaTempTiem
            // 
            this.graficaTempTiem.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 1000D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 25000D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.graficaTempTiem.ChartAreas.Add(chartArea1);
            this.graficaTempTiem.Location = new System.Drawing.Point(35, 77);
            this.graficaTempTiem.Name = "graficaTempTiem";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficaTempTiem.Series.Add(series1);
            this.graficaTempTiem.Size = new System.Drawing.Size(754, 452);
            this.graficaTempTiem.TabIndex = 2;
            this.graficaTempTiem.Text = "chart1";
            // 
            // tiempoTemperatura25
            // 
            this.tiempoTemperatura25.BackColor = System.Drawing.SystemColors.Menu;
            this.tiempoTemperatura25.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tiempo,
            this.Temperatura});
            this.tiempoTemperatura25.HideSelection = false;
            this.tiempoTemperatura25.Location = new System.Drawing.Point(795, 77);
            this.tiempoTemperatura25.Name = "tiempoTemperatura25";
            this.tiempoTemperatura25.Size = new System.Drawing.Size(173, 300);
            this.tiempoTemperatura25.TabIndex = 1;
            this.tiempoTemperatura25.UseCompatibleStateImageBehavior = false;
            this.tiempoTemperatura25.View = System.Windows.Forms.View.Details;
            // 
            // Tiempo
            // 
            this.Tiempo.Text = "Tiempo";
            this.Tiempo.Width = 64;
            // 
            // Temperatura
            // 
            this.Temperatura.Text = "Temperatura";
            this.Temperatura.Width = 118;
            // 
            // calibrationBtn
            // 
            this.calibrationBtn.Location = new System.Drawing.Point(35, 39);
            this.calibrationBtn.Name = "calibrationBtn";
            this.calibrationBtn.Size = new System.Drawing.Size(129, 23);
            this.calibrationBtn.TabIndex = 2;
            this.calibrationBtn.Text = "Start Calibration";
            this.calibrationBtn.UseVisualStyleBackColor = true;
            this.calibrationBtn.Click += new System.EventHandler(this.calibrationBtn_Click);
            // 
            // timerTemp
            // 
            this.timerTemp.Interval = 10;
            this.timerTemp.Tick += new System.EventHandler(this.timerTemp_Tick);
            // 
            // tiempoTemperatura1
            // 
            this.tiempoTemperatura1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.tiempoTemperatura1.HideSelection = false;
            this.tiempoTemperatura1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.tiempoTemperatura1.Location = new System.Drawing.Point(990, 77);
            this.tiempoTemperatura1.Name = "tiempoTemperatura1";
            this.tiempoTemperatura1.Size = new System.Drawing.Size(173, 300);
            this.tiempoTemperatura1.TabIndex = 3;
            this.tiempoTemperatura1.UseCompatibleStateImageBehavior = false;
            this.tiempoTemperatura1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tiempo";
            this.columnHeader1.Width = 64;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Temperatura";
            this.columnHeader2.Width = 118;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 586);
            this.Controls.Add(this.tiempoTemperatura1);
            this.Controls.Add(this.calibrationBtn);
            this.Controls.Add(this.tiempoTemperatura25);
            this.Controls.Add(this.graficaTempTiem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graficaTempTiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficaTempTiem;
        private System.Windows.Forms.ListView tiempoTemperatura25;
        private System.Windows.Forms.ColumnHeader Tiempo;
        private System.Windows.Forms.ColumnHeader Temperatura;
        private System.Windows.Forms.Button calibrationBtn;
        private System.Windows.Forms.Timer timerTemp;
        private System.Windows.Forms.ListView tiempoTemperatura1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

