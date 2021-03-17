
namespace C969PA
{
    partial class CustReportPage
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
            this.CustReportGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Appointment Report";
            // 
            // CustReportGrid
            // 
            this.CustReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustReportGrid.Location = new System.Drawing.Point(12, 119);
            this.CustReportGrid.Name = "CustReportGrid";
            this.CustReportGrid.RowTemplate.Height = 25;
            this.CustReportGrid.Size = new System.Drawing.Size(621, 298);
            this.CustReportGrid.TabIndex = 1;
            // 
            // CustReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 471);
            this.Controls.Add(this.CustReportGrid);
            this.Controls.Add(this.label1);
            this.Name = "CustReportPage";
            this.Text = "CustReportPage";
            ((System.ComponentModel.ISupportInitialize)(this.CustReportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustReportGrid;
    }
}