namespace WindowsFormsApp1
{
    partial class Form4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.labelReport = new System.Windows.Forms.Label();
            this.labelDailyReport = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelNoChild = new System.Windows.Forms.Label();
            this.labelAdultNo = new System.Windows.Forms.Label();
            this.labelNoGroup5 = new System.Windows.Forms.Label();
            this.labelNoGroup10 = new System.Windows.Forms.Label();
            this.labelNoGroup15 = new System.Windows.Forms.Label();
            this.labelNoGroup20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chartNoOfVisitors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTotalEarning = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridWeeklyReport = new System.Windows.Forms.DataGridView();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.comboBoxSortCriteria = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerSelection = new System.Windows.Forms.DateTimePicker();
            this.buttonChooseDate = new System.Windows.Forms.Button();
            this.buttonSelectSort = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.labelNoGroup = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoOfVisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalEarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWeeklyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReport.Location = new System.Drawing.Point(188, 26);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(92, 29);
            this.labelReport.TabIndex = 0;
            this.labelReport.Text = "Report";
            // 
            // labelDailyReport
            // 
            this.labelDailyReport.AutoSize = true;
            this.labelDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDailyReport.Location = new System.Drawing.Point(43, 83);
            this.labelDailyReport.Name = "labelDailyReport";
            this.labelDailyReport.Size = new System.Drawing.Size(117, 25);
            this.labelDailyReport.TabIndex = 1;
            this.labelDailyReport.Text = "Daily Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total no. of visitors:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Child";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adult";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Group:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "15";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(340, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "20";
            // 
            // labelNoChild
            // 
            this.labelNoChild.AutoSize = true;
            this.labelNoChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoChild.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNoChild.Location = new System.Drawing.Point(217, 157);
            this.labelNoChild.Name = "labelNoChild";
            this.labelNoChild.Size = new System.Drawing.Size(47, 20);
            this.labelNoChild.TabIndex = 11;
            this.labelNoChild.Text = "Child";
            // 
            // labelAdultNo
            // 
            this.labelAdultNo.AutoSize = true;
            this.labelAdultNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdultNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAdultNo.Location = new System.Drawing.Point(217, 185);
            this.labelAdultNo.Name = "labelAdultNo";
            this.labelAdultNo.Size = new System.Drawing.Size(47, 20);
            this.labelAdultNo.TabIndex = 12;
            this.labelAdultNo.Text = "Adult";
            // 
            // labelNoGroup5
            // 
            this.labelNoGroup5.AutoSize = true;
            this.labelNoGroup5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoGroup5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNoGroup5.Location = new System.Drawing.Point(385, 156);
            this.labelNoGroup5.Name = "labelNoGroup5";
            this.labelNoGroup5.Size = new System.Drawing.Size(18, 20);
            this.labelNoGroup5.TabIndex = 13;
            this.labelNoGroup5.Text = "5";
            // 
            // labelNoGroup10
            // 
            this.labelNoGroup10.AutoSize = true;
            this.labelNoGroup10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoGroup10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNoGroup10.Location = new System.Drawing.Point(385, 185);
            this.labelNoGroup10.Name = "labelNoGroup10";
            this.labelNoGroup10.Size = new System.Drawing.Size(27, 20);
            this.labelNoGroup10.TabIndex = 14;
            this.labelNoGroup10.Text = "10";
            // 
            // labelNoGroup15
            // 
            this.labelNoGroup15.AutoSize = true;
            this.labelNoGroup15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoGroup15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNoGroup15.Location = new System.Drawing.Point(385, 216);
            this.labelNoGroup15.Name = "labelNoGroup15";
            this.labelNoGroup15.Size = new System.Drawing.Size(27, 20);
            this.labelNoGroup15.TabIndex = 15;
            this.labelNoGroup15.Text = "15";
            // 
            // labelNoGroup20
            // 
            this.labelNoGroup20.AutoSize = true;
            this.labelNoGroup20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoGroup20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNoGroup20.Location = new System.Drawing.Point(385, 248);
            this.labelNoGroup20.Name = "labelNoGroup20";
            this.labelNoGroup20.Size = new System.Drawing.Size(27, 20);
            this.labelNoGroup20.TabIndex = 16;
            this.labelNoGroup20.Text = "20";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Weekly Report";
            // 
            // chartNoOfVisitors
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNoOfVisitors.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNoOfVisitors.Legends.Add(legend1);
            this.chartNoOfVisitors.Location = new System.Drawing.Point(671, 361);
            this.chartNoOfVisitors.Name = "chartNoOfVisitors";
            this.chartNoOfVisitors.Size = new System.Drawing.Size(611, 401);
            this.chartNoOfVisitors.TabIndex = 18;
            this.chartNoOfVisitors.Text = "chart1";
            // 
            // chartTotalEarning
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTotalEarning.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTotalEarning.Legends.Add(legend2);
            this.chartTotalEarning.Location = new System.Drawing.Point(37, 361);
            this.chartTotalEarning.Name = "chartTotalEarning";
            this.chartTotalEarning.Size = new System.Drawing.Size(611, 401);
            this.chartTotalEarning.TabIndex = 19;
            this.chartTotalEarning.Text = "chart2";
            // 
            // dataGridWeeklyReport
            // 
            this.dataGridWeeklyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWeeklyReport.Location = new System.Drawing.Point(677, 114);
            this.dataGridWeeklyReport.Name = "dataGridWeeklyReport";
            this.dataGridWeeklyReport.RowHeadersWidth = 51;
            this.dataGridWeeklyReport.RowTemplate.Height = 24;
            this.dataGridWeeklyReport.Size = new System.Drawing.Size(605, 227);
            this.dataGridWeeklyReport.TabIndex = 20;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateReport.Location = new System.Drawing.Point(202, 285);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(156, 44);
            this.buttonGenerateReport.TabIndex = 21;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // comboBoxSortCriteria
            // 
            this.comboBoxSortCriteria.FormattingEnabled = true;
            this.comboBoxSortCriteria.Items.AddRange(new object[] {
            "Number of Visitors",
            "Total Earnings"});
            this.comboBoxSortCriteria.Location = new System.Drawing.Point(933, 68);
            this.comboBoxSortCriteria.Name = "comboBoxSortCriteria";
            this.comboBoxSortCriteria.Size = new System.Drawing.Size(155, 24);
            this.comboBoxSortCriteria.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(865, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Sort by:";
            // 
            // dateTimePickerSelection
            // 
            this.dateTimePickerSelection.Location = new System.Drawing.Point(179, 85);
            this.dateTimePickerSelection.Name = "dateTimePickerSelection";
            this.dateTimePickerSelection.Size = new System.Drawing.Size(234, 22);
            this.dateTimePickerSelection.TabIndex = 25;
            // 
            // buttonChooseDate
            // 
            this.buttonChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseDate.Location = new System.Drawing.Point(438, 80);
            this.buttonChooseDate.Name = "buttonChooseDate";
            this.buttonChooseDate.Size = new System.Drawing.Size(111, 36);
            this.buttonChooseDate.TabIndex = 26;
            this.buttonChooseDate.Text = "Choose File";
            this.buttonChooseDate.UseVisualStyleBackColor = true;
            this.buttonChooseDate.Click += new System.EventHandler(this.buttonChooseDate_Click);
            // 
            // buttonSelectSort
            // 
            this.buttonSelectSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectSort.Location = new System.Drawing.Point(1118, 61);
            this.buttonSelectSort.Name = "buttonSelectSort";
            this.buttonSelectSort.Size = new System.Drawing.Size(92, 36);
            this.buttonSelectSort.TabIndex = 27;
            this.buttonSelectSort.Text = "Select";
            this.buttonSelectSort.UseVisualStyleBackColor = true;
            this.buttonSelectSort.Click += new System.EventHandler(this.buttonSelectSort_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // labelNoGroup
            // 
            this.labelNoGroup.AutoSize = true;
            this.labelNoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoGroup.Location = new System.Drawing.Point(435, 157);
            this.labelNoGroup.Name = "labelNoGroup";
            this.labelNoGroup.Size = new System.Drawing.Size(68, 16);
            this.labelNoGroup.TabIndex = 28;
            this.labelNoGroup.Text = "No Group:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(516, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "5";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 783);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelNoGroup);
            this.Controls.Add(this.buttonSelectSort);
            this.Controls.Add(this.buttonChooseDate);
            this.Controls.Add(this.dateTimePickerSelection);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxSortCriteria);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.dataGridWeeklyReport);
            this.Controls.Add(this.chartTotalEarning);
            this.Controls.Add(this.chartNoOfVisitors);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelNoGroup20);
            this.Controls.Add(this.labelNoGroup15);
            this.Controls.Add(this.labelNoGroup10);
            this.Controls.Add(this.labelNoGroup5);
            this.Controls.Add(this.labelAdultNo);
            this.Controls.Add(this.labelNoChild);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDailyReport);
            this.Controls.Add(this.labelReport);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.chartNoOfVisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalEarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWeeklyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReport;
        private System.Windows.Forms.Label labelDailyReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelNoChild;
        private System.Windows.Forms.Label labelAdultNo;
        private System.Windows.Forms.Label labelNoGroup5;
        private System.Windows.Forms.Label labelNoGroup10;
        private System.Windows.Forms.Label labelNoGroup15;
        private System.Windows.Forms.Label labelNoGroup20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNoOfVisitors;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalEarning;
        private System.Windows.Forms.DataGridView dataGridWeeklyReport;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.ComboBox comboBoxSortCriteria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerSelection;
        private System.Windows.Forms.Button buttonChooseDate;
        private System.Windows.Forms.Button buttonSelectSort;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label labelNoGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}