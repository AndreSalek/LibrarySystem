namespace BookRentingUI
{
    partial class UserControlSettings
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
            this.btnChange = new System.Windows.Forms.Button();
            this.textboxPasswordRepeat = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChange.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChange.Location = new System.Drawing.Point(168, 171);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(152, 32);
            this.btnChange.TabIndex = 20;
            this.btnChange.Text = "Change password";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // textboxPasswordRepeat
            // 
            this.textboxPasswordRepeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxPasswordRepeat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxPasswordRepeat.Location = new System.Drawing.Point(87, 136);
            this.textboxPasswordRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPasswordRepeat.Name = "textboxPasswordRepeat";
            this.textboxPasswordRepeat.PasswordChar = '*';
            this.textboxPasswordRepeat.PlaceholderText = "Repeat password";
            this.textboxPasswordRepeat.Size = new System.Drawing.Size(320, 27);
            this.textboxPasswordRepeat.TabIndex = 19;
            this.textboxPasswordRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxPasswordRepeat.UseSystemPasswordChar = true;
            // 
            // textboxPassword
            // 
            this.textboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxPassword.Location = new System.Drawing.Point(87, 101);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.PlaceholderText = "Password";
            this.textboxPassword.Size = new System.Drawing.Size(320, 27);
            this.textboxPassword.TabIndex = 21;
            this.textboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxPassword.UseSystemPasswordChar = true;
            // 
            // UserControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.textboxPasswordRepeat);
            this.Name = "UserControlSettings";
            this.Size = new System.Drawing.Size(492, 444);
            this.VisibleChanged += new System.EventHandler(this.UserControlSettings_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChange;
        private TextBox textboxPasswordRepeat;
        private TextBox textboxPassword;
    }
}
