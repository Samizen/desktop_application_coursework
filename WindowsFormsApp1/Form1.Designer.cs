
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.labelTicketId = new System.Windows.Forms.Label();
            this.labelEntryTime = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.labelExitTime = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelsearch = new System.Windows.Forms.Label();
            this.comboBoxGroupOf = new System.Windows.Forms.ComboBox();
            this.labelGroupOf = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAgeDisplay = new System.Windows.Forms.Label();
            this.labelGroupOfDisplay = new System.Windows.Forms.Label();
            this.labelTimeSpent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxisHolidayDisplay = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridVisitor = new System.Windows.Forms.DataGridView();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxIsHoliday = new System.Windows.Forms.CheckBox();
            this.comboBoxEntryHour = new System.Windows.Forms.ComboBox();
            this.comboBoxEntryMinute = new System.Windows.Forms.ComboBox();
            this.comboBoxExitMinute = new System.Windows.Forms.ComboBox();
            this.comboBoxExitHour = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.labelTicketIdDisplay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTicketId
            // 
            this.labelTicketId.AutoSize = true;
            this.labelTicketId.Location = new System.Drawing.Point(68, 105);
            this.labelTicketId.Name = "labelTicketId";
            this.labelTicketId.Size = new System.Drawing.Size(63, 16);
            this.labelTicketId.TabIndex = 0;
            this.labelTicketId.Text = "Ticket ID:";
            // 
            // labelEntryTime
            // 
            this.labelEntryTime.AutoSize = true;
            this.labelEntryTime.Location = new System.Drawing.Point(69, 220);
            this.labelEntryTime.Name = "labelEntryTime";
            this.labelEntryTime.Size = new System.Drawing.Size(71, 16);
            this.labelEntryTime.TabIndex = 5;
            this.labelEntryTime.Text = "Entry Time";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(141, 71);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(256, 22);
            this.datePicker.TabIndex = 8;
            this.datePicker.Value = new System.DateTime(2021, 12, 10, 0, 0, 0, 0);
            // 
            // labelExitTime
            // 
            this.labelExitTime.AutoSize = true;
            this.labelExitTime.Location = new System.Drawing.Point(68, 257);
            this.labelExitTime.Name = "labelExitTime";
            this.labelExitTime.Size = new System.Drawing.Size(62, 16);
            this.labelExitTime.TabIndex = 7;
            this.labelExitTime.Text = "Exit Time";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(141, 142);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(137, 22);
            this.textBoxName.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(69, 145);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 16);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(801, 384);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(128, 22);
            this.textBoxSearch.TabIndex = 13;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(233, 315);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(523, 377);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Location = new System.Drawing.Point(743, 388);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(50, 16);
            this.labelsearch.TabIndex = 16;
            this.labelsearch.Text = "Search";
            // 
            // comboBoxGroupOf
            // 
            this.comboBoxGroupOf.FormattingEnabled = true;
            this.comboBoxGroupOf.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20"});
            this.comboBoxGroupOf.Location = new System.Drawing.Point(141, 178);
            this.comboBoxGroupOf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGroupOf.Name = "comboBoxGroupOf";
            this.comboBoxGroupOf.Size = new System.Drawing.Size(88, 24);
            this.comboBoxGroupOf.TabIndex = 21;
            this.comboBoxGroupOf.Text = "0";
            // 
            // labelGroupOf
            // 
            this.labelGroupOf.AutoSize = true;
            this.labelGroupOf.Location = new System.Drawing.Point(68, 181);
            this.labelGroupOf.Name = "labelGroupOf";
            this.labelGroupOf.Size = new System.Drawing.Size(63, 16);
            this.labelGroupOf.TabIndex = 22;
            this.labelGroupOf.Text = "Group Of:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(291, 145);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 16);
            this.labelAge.TabIndex = 23;
            this.labelAge.Text = "Age";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(329, 142);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(65, 22);
            this.textBoxAge.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAgeDisplay);
            this.groupBox1.Controls.Add(this.labelGroupOfDisplay);
            this.groupBox1.Controls.Add(this.labelTimeSpent);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelTotalPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkBoxisHolidayDisplay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(438, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(355, 207);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // labelAgeDisplay
            // 
            this.labelAgeDisplay.AutoSize = true;
            this.labelAgeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgeDisplay.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelAgeDisplay.Location = new System.Drawing.Point(66, 55);
            this.labelAgeDisplay.Name = "labelAgeDisplay";
            this.labelAgeDisplay.Size = new System.Drawing.Size(0, 31);
            this.labelAgeDisplay.TabIndex = 42;
            // 
            // labelGroupOfDisplay
            // 
            this.labelGroupOfDisplay.AutoSize = true;
            this.labelGroupOfDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupOfDisplay.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelGroupOfDisplay.Location = new System.Drawing.Point(286, 24);
            this.labelGroupOfDisplay.Name = "labelGroupOfDisplay";
            this.labelGroupOfDisplay.Size = new System.Drawing.Size(0, 31);
            this.labelGroupOfDisplay.TabIndex = 41;
            // 
            // labelTimeSpent
            // 
            this.labelTimeSpent.AutoSize = true;
            this.labelTimeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeSpent.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTimeSpent.Location = new System.Drawing.Point(126, 23);
            this.labelTimeSpent.Name = "labelTimeSpent";
            this.labelTimeSpent.Size = new System.Drawing.Size(0, 31);
            this.labelTimeSpent.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Age";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTotalPrice.Location = new System.Drawing.Point(101, 134);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(0, 31);
            this.labelTotalPrice.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Total Price:";
            // 
            // checkBoxisHolidayDisplay
            // 
            this.checkBoxisHolidayDisplay.AutoSize = true;
            this.checkBoxisHolidayDisplay.Location = new System.Drawing.Point(163, 105);
            this.checkBoxisHolidayDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxisHolidayDisplay.Name = "checkBoxisHolidayDisplay";
            this.checkBoxisHolidayDisplay.Size = new System.Drawing.Size(96, 20);
            this.checkBoxisHolidayDisplay.TabIndex = 32;
            this.checkBoxisHolidayDisplay.Text = "Is Holiday?";
            this.checkBoxisHolidayDisplay.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Group of ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Discount Categories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hrs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Time Spent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 54);
            this.label5.TabIndex = 26;
            this.label5.Text = "Visitor Data Entry";
            // 
            // dataGridVisitor
            // 
            this.dataGridVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVisitor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridVisitor.Location = new System.Drawing.Point(11, 422);
            this.dataGridVisitor.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridVisitor.Name = "dataGridVisitor";
            this.dataGridVisitor.RowHeadersWidth = 51;
            this.dataGridVisitor.Size = new System.Drawing.Size(933, 185);
            this.dataGridVisitor.TabIndex = 27;
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(417, 377);
            this.buttonShowData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(100, 36);
            this.buttonShowData.TabIndex = 28;
            this.buttonShowData.Text = "Show Data";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxIsHoliday
            // 
            this.checkBoxIsHoliday.AutoSize = true;
            this.checkBoxIsHoliday.Location = new System.Drawing.Point(298, 106);
            this.checkBoxIsHoliday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIsHoliday.Name = "checkBoxIsHoliday";
            this.checkBoxIsHoliday.Size = new System.Drawing.Size(96, 20);
            this.checkBoxIsHoliday.TabIndex = 29;
            this.checkBoxIsHoliday.Text = "Is Holiday?";
            this.checkBoxIsHoliday.UseVisualStyleBackColor = true;
            // 
            // comboBoxEntryHour
            // 
            this.comboBoxEntryHour.FormattingEnabled = true;
            this.comboBoxEntryHour.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBoxEntryHour.Location = new System.Drawing.Point(141, 217);
            this.comboBoxEntryHour.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEntryHour.Name = "comboBoxEntryHour";
            this.comboBoxEntryHour.Size = new System.Drawing.Size(75, 24);
            this.comboBoxEntryHour.TabIndex = 30;
            this.comboBoxEntryHour.Text = "10";
            // 
            // comboBoxEntryMinute
            // 
            this.comboBoxEntryMinute.FormattingEnabled = true;
            this.comboBoxEntryMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxEntryMinute.Location = new System.Drawing.Point(233, 217);
            this.comboBoxEntryMinute.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEntryMinute.Name = "comboBoxEntryMinute";
            this.comboBoxEntryMinute.Size = new System.Drawing.Size(75, 24);
            this.comboBoxEntryMinute.TabIndex = 31;
            this.comboBoxEntryMinute.Text = "00";
            // 
            // comboBoxExitMinute
            // 
            this.comboBoxExitMinute.FormattingEnabled = true;
            this.comboBoxExitMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxExitMinute.Location = new System.Drawing.Point(233, 252);
            this.comboBoxExitMinute.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxExitMinute.Name = "comboBoxExitMinute";
            this.comboBoxExitMinute.Size = new System.Drawing.Size(75, 24);
            this.comboBoxExitMinute.TabIndex = 33;
            this.comboBoxExitMinute.Text = "00";
            // 
            // comboBoxExitHour
            // 
            this.comboBoxExitHour.FormattingEnabled = true;
            this.comboBoxExitHour.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.comboBoxExitHour.Location = new System.Drawing.Point(141, 254);
            this.comboBoxExitHour.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxExitHour.Name = "comboBoxExitHour";
            this.comboBoxExitHour.Size = new System.Drawing.Size(75, 24);
            this.comboBoxExitHour.TabIndex = 32;
            this.comboBoxExitHour.Text = "11";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(316, 217);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 35;
            this.label10.Text = "upto 4:59 PM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.IndianRed;
            this.label11.Location = new System.Drawing.Point(319, 254);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 18);
            this.label11.TabIndex = 36;
            this.label11.Text = "upto 6:00 PM";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(148, 315);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 36);
            this.buttonNew.TabIndex = 38;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // labelTicketIdDisplay
            // 
            this.labelTicketIdDisplay.AutoSize = true;
            this.labelTicketIdDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketIdDisplay.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTicketIdDisplay.Location = new System.Drawing.Point(144, 105);
            this.labelTicketIdDisplay.Name = "labelTicketIdDisplay";
            this.labelTicketIdDisplay.Size = new System.Drawing.Size(109, 20);
            this.labelTicketIdDisplay.TabIndex = 43;
            this.labelTicketIdDisplay.Text = "T0129344569";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 623);
            this.Controls.Add(this.labelTicketIdDisplay);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxExitMinute);
            this.Controls.Add(this.comboBoxExitHour);
            this.Controls.Add(this.comboBoxEntryMinute);
            this.Controls.Add(this.comboBoxEntryHour);
            this.Controls.Add(this.checkBoxIsHoliday);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.dataGridVisitor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelGroupOf);
            this.Controls.Add(this.comboBoxGroupOf);
            this.Controls.Add(this.labelsearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.labelExitTime);
            this.Controls.Add(this.labelEntryTime);
            this.Controls.Add(this.labelTicketId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTicketId;
        private System.Windows.Forms.Label labelEntryTime;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label labelExitTime;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.ComboBox comboBoxGroupOf;
        private System.Windows.Forms.Label labelGroupOf;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxisHolidayDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridVisitor;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxIsHoliday;
        private System.Windows.Forms.ComboBox comboBoxEntryHour;
        private System.Windows.Forms.ComboBox comboBoxEntryMinute;
        private System.Windows.Forms.ComboBox comboBoxExitMinute;
        private System.Windows.Forms.ComboBox comboBoxExitHour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label labelTimeSpent;
        private System.Windows.Forms.Label labelGroupOfDisplay;
        private System.Windows.Forms.Label labelAgeDisplay;
        private System.Windows.Forms.Label labelTicketIdDisplay;
    }
}

