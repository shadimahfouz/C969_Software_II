
namespace C969PA
{
    partial class ModAppPage
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
            this.ModAppSaveButton = new System.Windows.Forms.Button();
            this.ModAppCancelButton = new System.Windows.Forms.Button();
            this.ModAppTypeBox = new System.Windows.Forms.TextBox();
            this.ModAppIDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModAppEndBox = new System.Windows.Forms.DateTimePicker();
            this.ModAppStartBox = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ModAppSearchBox = new System.Windows.Forms.TextBox();
            this.ModAppSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModAppSaveButton
            // 
            this.ModAppSaveButton.Location = new System.Drawing.Point(174, 374);
            this.ModAppSaveButton.Name = "ModAppSaveButton";
            this.ModAppSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ModAppSaveButton.TabIndex = 21;
            this.ModAppSaveButton.Text = "Save";
            this.ModAppSaveButton.UseVisualStyleBackColor = true;
            this.ModAppSaveButton.Click += new System.EventHandler(this.ModAppSaveButton_Click);
            // 
            // ModAppCancelButton
            // 
            this.ModAppCancelButton.Location = new System.Drawing.Point(299, 374);
            this.ModAppCancelButton.Name = "ModAppCancelButton";
            this.ModAppCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ModAppCancelButton.TabIndex = 20;
            this.ModAppCancelButton.Text = "Cancel";
            this.ModAppCancelButton.UseVisualStyleBackColor = true;
            this.ModAppCancelButton.Click += new System.EventHandler(this.ModAppCancelButton_Click);
            // 
            // ModAppTypeBox
            // 
            this.ModAppTypeBox.Location = new System.Drawing.Point(174, 184);
            this.ModAppTypeBox.Name = "ModAppTypeBox";
            this.ModAppTypeBox.Size = new System.Drawing.Size(200, 23);
            this.ModAppTypeBox.TabIndex = 19;
            // 
            // ModAppIDBox
            // 
            this.ModAppIDBox.Location = new System.Drawing.Point(174, 133);
            this.ModAppIDBox.Name = "ModAppIDBox";
            this.ModAppIDBox.Size = new System.Drawing.Size(94, 23);
            this.ModAppIDBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Appointment Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "End Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Start Time:";
            // 
            // ModAppEndBox
            // 
            this.ModAppEndBox.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.ModAppEndBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ModAppEndBox.Location = new System.Drawing.Point(174, 290);
            this.ModAppEndBox.Name = "ModAppEndBox";
            this.ModAppEndBox.Size = new System.Drawing.Size(200, 23);
            this.ModAppEndBox.TabIndex = 13;
            // 
            // ModAppStartBox
            // 
            this.ModAppStartBox.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.ModAppStartBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ModAppStartBox.Location = new System.Drawing.Point(174, 234);
            this.ModAppStartBox.Name = "ModAppStartBox";
            this.ModAppStartBox.Size = new System.Drawing.Size(200, 23);
            this.ModAppStartBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(119, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Modify Appointment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Search By Appointment ID:";
            // 
            // ModAppSearchBox
            // 
            this.ModAppSearchBox.Location = new System.Drawing.Point(174, 82);
            this.ModAppSearchBox.Name = "ModAppSearchBox";
            this.ModAppSearchBox.Size = new System.Drawing.Size(100, 23);
            this.ModAppSearchBox.TabIndex = 25;
            // 
            // ModAppSearchButton
            // 
            this.ModAppSearchButton.Location = new System.Drawing.Point(280, 81);
            this.ModAppSearchButton.Name = "ModAppSearchButton";
            this.ModAppSearchButton.Size = new System.Drawing.Size(75, 23);
            this.ModAppSearchButton.TabIndex = 26;
            this.ModAppSearchButton.Text = "Search";
            this.ModAppSearchButton.UseVisualStyleBackColor = true;
            this.ModAppSearchButton.Click += new System.EventHandler(this.ModAppSearchButton_Click);
            // 
            // ModAppPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 440);
            this.Controls.Add(this.ModAppSearchButton);
            this.Controls.Add(this.ModAppSearchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ModAppSaveButton);
            this.Controls.Add(this.ModAppCancelButton);
            this.Controls.Add(this.ModAppTypeBox);
            this.Controls.Add(this.ModAppIDBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModAppEndBox);
            this.Controls.Add(this.ModAppStartBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModAppPage";
            this.Text = "Modify Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModAppSaveButton;
        private System.Windows.Forms.Button ModAppCancelButton;
        private System.Windows.Forms.TextBox ModAppTypeBox;
        private System.Windows.Forms.TextBox ModAppIDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ModAppEndBox;
        private System.Windows.Forms.DateTimePicker ModAppStartBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ModAppSearchBox;
        private System.Windows.Forms.Button ModAppSearchButton;
    }
}