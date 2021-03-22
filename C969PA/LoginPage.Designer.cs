
namespace C969PA
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserText = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(38, 122);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(63, 15);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Username:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(38, 181);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(60, 15);
            this.PassLabel.TabIndex = 1;
            this.PassLabel.Text = "Password:";
            this.PassLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(102, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome!";
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(112, 120);
            this.UserText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(110, 23);
            this.UserText.TabIndex = 3;
            this.UserText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(112, 178);
            this.PassText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassText.Name = "PassText";
            this.PassText.PasswordChar = '*';
            this.PassText.Size = new System.Drawing.Size(110, 23);
            this.PassText.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(38, 273);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(82, 22);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginCancelButton
            // 
            this.LoginCancelButton.Location = new System.Drawing.Point(181, 273);
            this.LoginCancelButton.Name = "LoginCancelButton";
            this.LoginCancelButton.Size = new System.Drawing.Size(75, 23);
            this.LoginCancelButton.TabIndex = 6;
            this.LoginCancelButton.Text = "Cancel";
            this.LoginCancelButton.UseVisualStyleBackColor = true;
            this.LoginCancelButton.Click += new System.EventHandler(this.LoginCancelButton_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 372);
            this.Controls.Add(this.LoginCancelButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UserLabel);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button LoginCancelButton;
    }
}

