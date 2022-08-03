namespace BookRentingUI
{
    partial class UserControlAdmin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textboxDescription = new System.Windows.Forms.TextBox();
            this.textboxLanguage = new System.Windows.Forms.TextBox();
            this.textboxAuthor = new System.Windows.Forms.TextBox();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(201, 282);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(152, 32);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "Add book";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textboxDescription
            // 
            this.textboxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxDescription.Location = new System.Drawing.Point(120, 238);
            this.textboxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.PlaceholderText = "Description";
            this.textboxDescription.Size = new System.Drawing.Size(320, 27);
            this.textboxDescription.TabIndex = 9;
            this.textboxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxLanguage
            // 
            this.textboxLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxLanguage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxLanguage.Location = new System.Drawing.Point(120, 194);
            this.textboxLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.textboxLanguage.Name = "textboxLanguage";
            this.textboxLanguage.PlaceholderText = "Language";
            this.textboxLanguage.Size = new System.Drawing.Size(320, 27);
            this.textboxLanguage.TabIndex = 8;
            this.textboxLanguage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxAuthor
            // 
            this.textboxAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxAuthor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxAuthor.Location = new System.Drawing.Point(120, 151);
            this.textboxAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.textboxAuthor.Name = "textboxAuthor";
            this.textboxAuthor.PlaceholderText = "Author";
            this.textboxAuthor.Size = new System.Drawing.Size(320, 27);
            this.textboxAuthor.TabIndex = 7;
            this.textboxAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxTitle
            // 
            this.textboxTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxTitle.Location = new System.Drawing.Point(120, 107);
            this.textboxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.PlaceholderText = "Title";
            this.textboxTitle.Size = new System.Drawing.Size(320, 27);
            this.textboxTitle.TabIndex = 6;
            this.textboxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserControlAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textboxDescription);
            this.Controls.Add(this.textboxLanguage);
            this.Controls.Add(this.textboxAuthor);
            this.Controls.Add(this.textboxTitle);
            this.Name = "UserControlAdmin";
            this.Size = new System.Drawing.Size(575, 496);
            this.VisibleChanged += new System.EventHandler(this.UserControlAdmin_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLogin;
        private TextBox textboxDescription;
        private TextBox textboxLanguage;
        private TextBox textboxAuthor;
        private TextBox textboxTitle;
    }
}
