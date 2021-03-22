
namespace C969PA
{
    partial class DelAppPage
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
            this.DelAppStartLabel = new System.Windows.Forms.Label();
            this.DelAppTypeLabel = new System.Windows.Forms.Label();
            this.DelAppCIDLabel = new System.Windows.Forms.Label();
            this.DelAppEndLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DelAppIDBox = new System.Windows.Forms.TextBox();
            this.DelAppSearchButton = new System.Windows.Forms.Button();
            this.DelAppDeleteButton = new System.Windows.Forms.Button();
            this.DelAppCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Appointment";
            // 
            // DelAppStartLabel
            // 
            this.DelAppStartLabel.AutoSize = true;
            this.DelAppStartLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelAppStartLabel.Location = new System.Drawing.Point(254, 165);
            this.DelAppStartLabel.Name = "DelAppStartLabel";
            this.DelAppStartLabel.Size = new System.Drawing.Size(92, 15);
            this.DelAppStartLabel.TabIndex = 1;
            this.DelAppStartLabel.Text = "Start Date/Time:";
            // 
            // DelAppTypeLabel
            // 
            this.DelAppTypeLabel.AutoSize = true;
            this.DelAppTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelAppTypeLabel.Location = new System.Drawing.Point(12, 165);
            this.DelAppTypeLabel.Name = "DelAppTypeLabel";
            this.DelAppTypeLabel.Size = new System.Drawing.Size(108, 15);
            this.DelAppTypeLabel.TabIndex = 2;
            this.DelAppTypeLabel.Text = "Appointment Type:";
            // 
            // DelAppCIDLabel
            // 
            this.DelAppCIDLabel.AutoSize = true;
            this.DelAppCIDLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelAppCIDLabel.Location = new System.Drawing.Point(44, 269);
            this.DelAppCIDLabel.Name = "DelAppCIDLabel";
            this.DelAppCIDLabel.Size = new System.Drawing.Size(76, 15);
            this.DelAppCIDLabel.TabIndex = 3;
            this.DelAppCIDLabel.Text = "Customer ID:";
            // 
            // DelAppEndLabel
            // 
            this.DelAppEndLabel.AutoSize = true;
            this.DelAppEndLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelAppEndLabel.Location = new System.Drawing.Point(254, 269);
            this.DelAppEndLabel.Name = "DelAppEndLabel";
            this.DelAppEndLabel.Size = new System.Drawing.Size(88, 15);
            this.DelAppEndLabel.TabIndex = 4;
            this.DelAppEndLabel.Text = "End Date/Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(61, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search by Appoointment ID:";
            // 
            // DelAppIDBox
            // 
            this.DelAppIDBox.Location = new System.Drawing.Point(223, 88);
            this.DelAppIDBox.Name = "DelAppIDBox";
            this.DelAppIDBox.Size = new System.Drawing.Size(100, 23);
            this.DelAppIDBox.TabIndex = 6;
            this.DelAppIDBox.TextChanged += new System.EventHandler(this.DelAppIDBox_TextChanged);
            // 
            // DelAppSearchButton
            // 
            this.DelAppSearchButton.Location = new System.Drawing.Point(329, 87);
            this.DelAppSearchButton.Name = "DelAppSearchButton";
            this.DelAppSearchButton.Size = new System.Drawing.Size(75, 23);
            this.DelAppSearchButton.TabIndex = 7;
            this.DelAppSearchButton.Text = "Search";
            this.DelAppSearchButton.UseVisualStyleBackColor = true;
            this.DelAppSearchButton.Click += new System.EventHandler(this.DelAppSearchButton_Click);
            // 
            // DelAppDeleteButton
            // 
            this.DelAppDeleteButton.Location = new System.Drawing.Point(122, 341);
            this.DelAppDeleteButton.Name = "DelAppDeleteButton";
            this.DelAppDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DelAppDeleteButton.TabIndex = 8;
            this.DelAppDeleteButton.Text = "Delete";
            this.DelAppDeleteButton.UseVisualStyleBackColor = true;
            this.DelAppDeleteButton.Click += new System.EventHandler(this.DelAppDeleteButton_Click);
            // 
            // DelAppCancelButton
            // 
            this.DelAppCancelButton.Location = new System.Drawing.Point(277, 341);
            this.DelAppCancelButton.Name = "DelAppCancelButton";
            this.DelAppCancelButton.Size = new System.Drawing.Size(75, 23);
            this.DelAppCancelButton.TabIndex = 9;
            this.DelAppCancelButton.Text = "Cancel";
            this.DelAppCancelButton.UseVisualStyleBackColor = true;
            this.DelAppCancelButton.Click += new System.EventHandler(this.DelAppCancelButton_Click);
            // 
            // DelAppPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 400);
            this.Controls.Add(this.DelAppCancelButton);
            this.Controls.Add(this.DelAppDeleteButton);
            this.Controls.Add(this.DelAppSearchButton);
            this.Controls.Add(this.DelAppIDBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DelAppEndLabel);
            this.Controls.Add(this.DelAppCIDLabel);
            this.Controls.Add(this.DelAppTypeLabel);
            this.Controls.Add(this.DelAppStartLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DelAppPage";
            this.Text = "Delete Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DelAppStartLabel;
        private System.Windows.Forms.Label DelAppTypeLabel;
        private System.Windows.Forms.Label DelAppCIDLabel;
        private System.Windows.Forms.Label DelAppEndLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DelAppIDBox;
        private System.Windows.Forms.Button DelAppSearchButton;
        private System.Windows.Forms.Button DelAppDeleteButton;
        private System.Windows.Forms.Button DelAppCancelButton;
    }
}