
namespace C969PA
{
    partial class DashboardPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DashboardAppGrid = new System.Windows.Forms.DataGridView();
            this.DashboardCustReportButton = new System.Windows.Forms.Button();
            this.DashboardConReportButton = new System.Windows.Forms.Button();
            this.DashboardAppReportButton = new System.Windows.Forms.Button();
            this.DashboardDelCustButton = new System.Windows.Forms.Button();
            this.DashboardModCustButton = new System.Windows.Forms.Button();
            this.DashboardAddCustButton = new System.Windows.Forms.Button();
            this.DashboardAddAppButton = new System.Windows.Forms.Button();
            this.DashboardModAppButton = new System.Windows.Forms.Button();
            this.DashboardDelAppButton = new System.Windows.Forms.Button();
            this.DashboardWeekRadio = new System.Windows.Forms.RadioButton();
            this.DashboardMonthRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardAppGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(371, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Actions";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(218, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Generate Reports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(588, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointment Calendar:";
            // 
            // DashboardAppGrid
            // 
            this.DashboardAppGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DashboardAppGrid.Location = new System.Drawing.Point(424, 168);
            this.DashboardAppGrid.Name = "DashboardAppGrid";
            this.DashboardAppGrid.RowTemplate.Height = 25;
            this.DashboardAppGrid.Size = new System.Drawing.Size(461, 278);
            this.DashboardAppGrid.TabIndex = 4;
            // 
            // DashboardCustReportButton
            // 
            this.DashboardCustReportButton.Location = new System.Drawing.Point(218, 294);
            this.DashboardCustReportButton.Name = "DashboardCustReportButton";
            this.DashboardCustReportButton.Size = new System.Drawing.Size(107, 23);
            this.DashboardCustReportButton.TabIndex = 5;
            this.DashboardCustReportButton.Text = "Customers";
            this.DashboardCustReportButton.UseVisualStyleBackColor = true;
            this.DashboardCustReportButton.Click += new System.EventHandler(this.DashboardCustReportButton_Click);
            // 
            // DashboardConReportButton
            // 
            this.DashboardConReportButton.Location = new System.Drawing.Point(218, 233);
            this.DashboardConReportButton.Name = "DashboardConReportButton";
            this.DashboardConReportButton.Size = new System.Drawing.Size(107, 23);
            this.DashboardConReportButton.TabIndex = 6;
            this.DashboardConReportButton.Text = "Consultants";
            this.DashboardConReportButton.UseVisualStyleBackColor = true;
            this.DashboardConReportButton.Click += new System.EventHandler(this.DashboardConReportButton_Click);
            // 
            // DashboardAppReportButton
            // 
            this.DashboardAppReportButton.Location = new System.Drawing.Point(218, 168);
            this.DashboardAppReportButton.Name = "DashboardAppReportButton";
            this.DashboardAppReportButton.Size = new System.Drawing.Size(107, 23);
            this.DashboardAppReportButton.TabIndex = 7;
            this.DashboardAppReportButton.Text = "Appointments";
            this.DashboardAppReportButton.UseVisualStyleBackColor = true;
            this.DashboardAppReportButton.Click += new System.EventHandler(this.DashboardAppReportButton_Click);
            // 
            // DashboardDelCustButton
            // 
            this.DashboardDelCustButton.Location = new System.Drawing.Point(23, 294);
            this.DashboardDelCustButton.Name = "DashboardDelCustButton";
            this.DashboardDelCustButton.Size = new System.Drawing.Size(108, 23);
            this.DashboardDelCustButton.TabIndex = 8;
            this.DashboardDelCustButton.Text = "Delete Customer";
            this.DashboardDelCustButton.UseVisualStyleBackColor = true;
            this.DashboardDelCustButton.Click += new System.EventHandler(this.DashboardDelCustButton_Click);
            // 
            // DashboardModCustButton
            // 
            this.DashboardModCustButton.Location = new System.Drawing.Point(23, 233);
            this.DashboardModCustButton.Name = "DashboardModCustButton";
            this.DashboardModCustButton.Size = new System.Drawing.Size(108, 23);
            this.DashboardModCustButton.TabIndex = 9;
            this.DashboardModCustButton.Text = "Modify Customer";
            this.DashboardModCustButton.UseVisualStyleBackColor = true;
            this.DashboardModCustButton.Click += new System.EventHandler(this.DashboardModCustButton_Click);
            // 
            // DashboardAddCustButton
            // 
            this.DashboardAddCustButton.Location = new System.Drawing.Point(23, 168);
            this.DashboardAddCustButton.Name = "DashboardAddCustButton";
            this.DashboardAddCustButton.Size = new System.Drawing.Size(108, 23);
            this.DashboardAddCustButton.TabIndex = 10;
            this.DashboardAddCustButton.Text = "Add Customer";
            this.DashboardAddCustButton.UseVisualStyleBackColor = true;
            this.DashboardAddCustButton.Click += new System.EventHandler(this.DashboardAddCustButton_Click);
            // 
            // DashboardAddAppButton
            // 
            this.DashboardAddAppButton.Location = new System.Drawing.Point(424, 468);
            this.DashboardAddAppButton.Name = "DashboardAddAppButton";
            this.DashboardAddAppButton.Size = new System.Drawing.Size(113, 23);
            this.DashboardAddAppButton.TabIndex = 11;
            this.DashboardAddAppButton.Text = "Add Appointment";
            this.DashboardAddAppButton.UseVisualStyleBackColor = true;
            this.DashboardAddAppButton.Click += new System.EventHandler(this.DashboardAddAppButton_Click);
            // 
            // DashboardModAppButton
            // 
            this.DashboardModAppButton.Location = new System.Drawing.Point(588, 468);
            this.DashboardModAppButton.Name = "DashboardModAppButton";
            this.DashboardModAppButton.Size = new System.Drawing.Size(128, 23);
            this.DashboardModAppButton.TabIndex = 12;
            this.DashboardModAppButton.Text = "Modify Appointment";
            this.DashboardModAppButton.UseVisualStyleBackColor = true;
            this.DashboardModAppButton.Click += new System.EventHandler(this.DashboardModAppButton_Click);
            // 
            // DashboardDelAppButton
            // 
            this.DashboardDelAppButton.Location = new System.Drawing.Point(763, 468);
            this.DashboardDelAppButton.Name = "DashboardDelAppButton";
            this.DashboardDelAppButton.Size = new System.Drawing.Size(122, 23);
            this.DashboardDelAppButton.TabIndex = 13;
            this.DashboardDelAppButton.Text = "Delete Appointment";
            this.DashboardDelAppButton.UseVisualStyleBackColor = true;
            this.DashboardDelAppButton.Click += new System.EventHandler(this.DashboardDelAppButton_Click);
            // 
            // DashboardWeekRadio
            // 
            this.DashboardWeekRadio.AutoSize = true;
            this.DashboardWeekRadio.Location = new System.Drawing.Point(515, 143);
            this.DashboardWeekRadio.Name = "DashboardWeekRadio";
            this.DashboardWeekRadio.Size = new System.Drawing.Size(98, 19);
            this.DashboardWeekRadio.TabIndex = 14;
            this.DashboardWeekRadio.TabStop = true;
            this.DashboardWeekRadio.Text = "View By Week";
            this.DashboardWeekRadio.UseVisualStyleBackColor = true;
            this.DashboardWeekRadio.CheckedChanged += new System.EventHandler(this.DashboardWeekRadio_CheckedChanged);
            // 
            // DashboardMonthRadio
            // 
            this.DashboardMonthRadio.AutoSize = true;
            this.DashboardMonthRadio.Location = new System.Drawing.Point(709, 143);
            this.DashboardMonthRadio.Name = "DashboardMonthRadio";
            this.DashboardMonthRadio.Size = new System.Drawing.Size(105, 19);
            this.DashboardMonthRadio.TabIndex = 15;
            this.DashboardMonthRadio.TabStop = true;
            this.DashboardMonthRadio.Text = "View By Month";
            this.DashboardMonthRadio.UseVisualStyleBackColor = true;
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 513);
            this.Controls.Add(this.DashboardMonthRadio);
            this.Controls.Add(this.DashboardWeekRadio);
            this.Controls.Add(this.DashboardDelAppButton);
            this.Controls.Add(this.DashboardModAppButton);
            this.Controls.Add(this.DashboardAddAppButton);
            this.Controls.Add(this.DashboardAddCustButton);
            this.Controls.Add(this.DashboardModCustButton);
            this.Controls.Add(this.DashboardDelCustButton);
            this.Controls.Add(this.DashboardAppReportButton);
            this.Controls.Add(this.DashboardConReportButton);
            this.Controls.Add(this.DashboardCustReportButton);
            this.Controls.Add(this.DashboardAppGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DashboardPage";
            this.Text = "DashboardPage";
            ((System.ComponentModel.ISupportInitialize)(this.DashboardAppGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DashboardAppGrid;
        private System.Windows.Forms.Button DashboardCustReportButton;
        private System.Windows.Forms.Button DashboardConReportButton;
        private System.Windows.Forms.Button DashboardAppReportButton;
        private System.Windows.Forms.Button DashboardDelCustButton;
        private System.Windows.Forms.Button DashboardModCustButton;
        private System.Windows.Forms.Button DashboardAddCustButton;
        private System.Windows.Forms.Button DashboardAddAppButton;
        private System.Windows.Forms.Button DashboardModAppButton;
        private System.Windows.Forms.Button DashboardDelAppButton;
        private System.Windows.Forms.RadioButton DashboardWeekRadio;
        private System.Windows.Forms.RadioButton DashboardMonthRadio;
    }
}