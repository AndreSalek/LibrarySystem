namespace BookRentingUI
{
    partial class UserControlLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWarning = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWarning
            // 
            this.labelWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(160, 235);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(120, 19);
            this.labelWarning.TabIndex = 18;
            this.labelWarning.Text = "Notification text";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(160, 177);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(152, 32);
            this.buttonLogin.TabIndex = 17;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textboxPassword
            // 
            this.textboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxPassword.Location = new System.Drawing.Point(79, 142);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.PlaceholderText = "Password";
            this.textboxPassword.Size = new System.Drawing.Size(320, 27);
            this.textboxPassword.TabIndex = 16;
            this.textboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxPassword.UseSystemPasswordChar = true;
            // 
            // textboxEmail
            // 
            this.textboxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxEmail.Location = new System.Drawing.Point(79, 106);
            this.textboxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.PlaceholderText = "Email";
            this.textboxEmail.Size = new System.Drawing.Size(320, 27);
            this.textboxEmail.TabIndex = 15;
            this.textboxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserControlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxEmail);
            this.Name = "UserControlLogin";
            this.Size = new System.Drawing.Size(495, 444);
            this.VisibleChanged += new System.EventHandler(this.UserControlLogin_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelWarning;
        private Button buttonLogin;
        private TextBox textboxPassword;
        private TextBox textboxEmail;
    }
}
