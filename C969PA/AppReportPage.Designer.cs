
namespace C969PA
{
    partial class AppReportPage
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
            this.AppReportGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AppReportGrid
            // 
            this.AppReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppReportGrid.Location = new System.Drawing.Point(71, 81);
            this.AppReportGrid.Name = "AppReportGrid";
            this.AppReportGrid.RowTemplate.Height = 25;
            this.AppReportGrid.Size = new System.Drawing.Size(471, 347);
            this.AppReportGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(225, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment Report";
            // 
            // AppReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppReportGrid);
            this.Name = "AppReportPage";
            this.Text = "AppReportPage";
            ((System.ComponentModel.ISupportInitialize)(this.AppReportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppReportGrid;
        private System.Windows.Forms.Label label1;
    }
}