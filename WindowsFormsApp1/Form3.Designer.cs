namespace WindowsFormsApp1
{
    partial class Form3
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
            this.buttonVisitorEntry = new System.Windows.Forms.Button();
            this.buttonTicketRate = new System.Windows.Forms.Button();
            this.buttonViewReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVisitorEntry
            // 
            this.buttonVisitorEntry.Location = new System.Drawing.Point(47, 41);
            this.buttonVisitorEntry.Name = "buttonVisitorEntry";
            this.buttonVisitorEntry.Size = new System.Drawing.Size(174, 23);
            this.buttonVisitorEntry.TabIndex = 0;
            this.buttonVisitorEntry.Text = "Visitor\'s Detail Entry";
            this.buttonVisitorEntry.UseVisualStyleBackColor = true;
            this.buttonVisitorEntry.Click += new System.EventHandler(this.buttonVisitorEntry_Click);
            // 
            // buttonTicketRate
            // 
            this.buttonTicketRate.Location = new System.Drawing.Point(47, 85);
            this.buttonTicketRate.Name = "buttonTicketRate";
            this.buttonTicketRate.Size = new System.Drawing.Size(174, 23);
            this.buttonTicketRate.TabIndex = 1;
            this.buttonTicketRate.Text = "Ticket Rate Entry";
            this.buttonTicketRate.UseVisualStyleBackColor = true;
            this.buttonTicketRate.Click += new System.EventHandler(this.buttonTicketRate_Click);
            // 
            // buttonViewReport
            // 
            this.buttonViewReport.Location = new System.Drawing.Point(47, 132);
            this.buttonViewReport.Name = "buttonViewReport";
            this.buttonViewReport.Size = new System.Drawing.Size(174, 23);
            this.buttonViewReport.TabIndex = 2;
            this.buttonViewReport.Text = "View Reports";
            this.buttonViewReport.UseVisualStyleBackColor = true;
            this.buttonViewReport.Click += new System.EventHandler(this.buttonViewReport_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 195);
            this.Controls.Add(this.buttonViewReport);
            this.Controls.Add(this.buttonTicketRate);
            this.Controls.Add(this.buttonVisitorEntry);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVisitorEntry;
        private System.Windows.Forms.Button buttonTicketRate;
        private System.Windows.Forms.Button buttonViewReport;
    }
}