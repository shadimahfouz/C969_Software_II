
namespace C969PA
{
    partial class AddAppPage
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
            this.AddAppStartBox = new System.Windows.Forms.DateTimePicker();
            this.AddAppEndBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddAppIDBox = new System.Windows.Forms.TextBox();
            this.AppTypeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CancelAddApp = new System.Windows.Forms.Button();
            this.AddApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAppStartBox
            // 
            this.AddAppStartBox.Location = new System.Drawing.Point(131, 206);
            this.AddAppStartBox.Name = "AddAppStartBox";
            this.AddAppStartBox.Size = new System.Drawing.Size(200, 23);
            this.AddAppStartBox.TabIndex = 0;
            this.AddAppStartBox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AddAppEndBox
            // 
            this.AddAppEndBox.Location = new System.Drawing.Point(131, 262);
            this.AddAppEndBox.Name = "AddAppEndBox";
            this.AddAppEndBox.Size = new System.Drawing.Size(200, 23);
            this.AddAppEndBox.TabIndex = 1;
            this.AddAppEndBox.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Time:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Appointment Type:";
            // 
            // AddAppIDBox
            // 
            this.AddAppIDBox.Location = new System.Drawing.Point(131, 105);
            this.AddAppIDBox.Name = "AddAppIDBox";
            this.AddAppIDBox.Size = new System.Drawing.Size(94, 23);
            this.AddAppIDBox.TabIndex = 6;
            this.AddAppIDBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AppTypeBox
            // 
            this.AppTypeBox.Location = new System.Drawing.Point(131, 156);
            this.AppTypeBox.Name = "AppTypeBox";
            this.AppTypeBox.Size = new System.Drawing.Size(200, 23);
            this.AppTypeBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(131, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add Appointment";
            // 
            // CancelAddApp
            // 
            this.CancelAddApp.Location = new System.Drawing.Point(256, 346);
            this.CancelAddApp.Name = "CancelAddApp";
            this.CancelAddApp.Size = new System.Drawing.Size(75, 23);
            this.CancelAddApp.TabIndex = 10;
            this.CancelAddApp.Text = "Cancel";
            this.CancelAddApp.UseVisualStyleBackColor = true;
            this.CancelAddApp.Click += new System.EventHandler(this.CancelAddApp_Click);
            // 
            // AddApp
            // 
            this.AddApp.Location = new System.Drawing.Point(131, 346);
            this.AddApp.Name = "AddApp";
            this.AddApp.Size = new System.Drawing.Size(75, 23);
            this.AddApp.TabIndex = 11;
            this.AddApp.Text = "Add";
            this.AddApp.UseVisualStyleBackColor = true;
            this.AddApp.Click += new System.EventHandler(this.AddApp_Click_1);
            // 
            // AddAppPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 438);
            this.Controls.Add(this.AddApp);
            this.Controls.Add(this.CancelAddApp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AppTypeBox);
            this.Controls.Add(this.AddAppIDBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddAppEndBox);
            this.Controls.Add(this.AddAppStartBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAppPage";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker AddAppStartBox;
        private System.Windows.Forms.DateTimePicker AddAppEndBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddAppIDBox;
        private System.Windows.Forms.TextBox AppTypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CancelAddApp;
        private System.Windows.Forms.Button AddApp;
    }
}