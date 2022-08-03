namespace BookRentingUI
{
    partial class UserControlRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textboxPwdRepeat = new System.Windows.Forms.TextBox();
            this.textboxPwd = new System.Windows.Forms.TextBox();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.textboxLastName = new System.Windows.Forms.TextBox();
            this.textboxFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWarning
            // 
            this.labelWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(127, 352);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(120, 19);
            this.labelWarning.TabIndex = 21;
            this.labelWarning.Text = "Notification text";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "All boxes must contain at least 4 characters";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegister.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.Location = new System.Drawing.Point(170, 304);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(152, 31);
            this.buttonRegister.TabIndex = 19;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textboxPwdRepeat
            // 
            this.textboxPwdRepeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxPwdRepeat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxPwdRepeat.Location = new System.Drawing.Point(87, 268);
            this.textboxPwdRepeat.Name = "textboxPwdRepeat";
            this.textboxPwdRepeat.PasswordChar = '*';
            this.textboxPwdRepeat.PlaceholderText = "Repeat password";
            this.textboxPwdRepeat.Size = new System.Drawing.Size(320, 27);
            this.textboxPwdRepeat.TabIndex = 18;
            this.textboxPwdRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxPwdRepeat.UseSystemPasswordChar = true;
            // 
            // textboxPwd
            // 
            this.textboxPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxPwd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxPwd.Location = new System.Drawing.Point(87, 232);
            this.textboxPwd.Name = "textboxPwd";
            this.textboxPwd.PasswordChar = '*';
            this.textboxPwd.PlaceholderText = "Password";
            this.textboxPwd.Size = new System.Drawing.Size(320, 27);
            this.textboxPwd.TabIndex = 17;
            this.textboxPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxPwd.UseSystemPasswordChar = true;
            // 
            // textboxEmail
            // 
            this.textboxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxEmail.Location = new System.Drawing.Point(87, 196);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.PlaceholderText = "Email";
            this.textboxEmail.Size = new System.Drawing.Size(320, 27);
            this.textboxEmail.TabIndex = 16;
            this.textboxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxLastName
            // 
            this.textboxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxLastName.Location = new System.Drawing.Point(87, 160);
            this.textboxLastName.Name = "textboxLastName";
            this.textboxLastName.PlaceholderText = "Last Name";
            this.textboxLastName.Size = new System.Drawing.Size(320, 27);
            this.textboxLastName.TabIndex = 15;
            this.textboxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxFirstName
            // 
            this.textboxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxFirstName.Location = new System.Drawing.Point(87, 124);
            this.textboxFirstName.Name = "textboxFirstName";
            this.textboxFirstName.PlaceholderText = "First Name";
            this.textboxFirstName.Size = new System.Drawing.Size(320, 27);
            this.textboxFirstName.TabIndex = 14;
            this.textboxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserControlRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textboxPwdRepeat);
            this.Controls.Add(this.textboxPwd);
            this.Controls.Add(this.textboxEmail);
            this.Controls.Add(this.textboxLastName);
            this.Controls.Add(this.textboxFirstName);
            this.Name = "UserControlRegister";
            this.Size = new System.Drawing.Size(570, 510);
            this.VisibleChanged += new System.EventHandler(this.UserControlRegister_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelWarning;
        private Label label1;
        private Button buttonRegister;
        private TextBox textboxPwdRepeat;
        private TextBox textboxPwd;
        private TextBox textboxEmail;
        private TextBox textboxLastName;
        private TextBox textboxFirstName;
    }
}
