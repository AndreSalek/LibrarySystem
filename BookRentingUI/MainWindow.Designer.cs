namespace BookRentingUI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegisterForm = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLoginForm = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAvailableBooks = new System.Windows.Forms.Button();
            this.btnRentedBooks = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.userControlLogin1 = new BookRentingUI.UserControlLogin();
            this.userControlRegister1 = new BookRentingUI.UserControlRegister();
            this.userControlProfile1 = new BookRentingUI.UserControlProfile();
            this.userControlSettings1 = new BookRentingUI.UserControlSettings();
            this.userControlAdmin1 = new BookRentingUI.UserControlAdmin();
            this.userControlRentedBooks1 = new BookRentingUI.UserControlRentedBooks();
            this.userControlAvailableBooks1 = new BookRentingUI.UserControlAvailableBooks();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(200, 63);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "     Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            this.btnProfile.Leave += new System.EventHandler(this.BtnProfile_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnRegisterForm);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnLoginForm);
            this.panel1.Controls.Add(this.btnAdminPanel);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnAvailableBooks);
            this.panel1.Controls.Add(this.btnRentedBooks);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 561);
            this.panel1.TabIndex = 0;
            // 
            // btnRegisterForm
            // 
            this.btnRegisterForm.FlatAppearance.BorderSize = 0;
            this.btnRegisterForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterForm.ForeColor = System.Drawing.Color.White;
            this.btnRegisterForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterForm.Location = new System.Drawing.Point(0, 390);
            this.btnRegisterForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterForm.Name = "btnRegisterForm";
            this.btnRegisterForm.Size = new System.Drawing.Size(200, 51);
            this.btnRegisterForm.TabIndex = 18;
            this.btnRegisterForm.Text = "Register";
            this.btnRegisterForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterForm.UseVisualStyleBackColor = true;
            this.btnRegisterForm.Click += new System.EventHandler(this.BtnRegisterForm_Click);
            this.btnRegisterForm.Leave += new System.EventHandler(this.BtnRegisterForm_Leave);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 390);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 51);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            this.btnLogout.Leave += new System.EventHandler(this.BtnLogout_Leave);
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.FlatAppearance.BorderSize = 0;
            this.btnLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoginForm.ForeColor = System.Drawing.Color.White;
            this.btnLoginForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginForm.Location = new System.Drawing.Point(0, 390);
            this.btnLoginForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(200, 51);
            this.btnLoginForm.TabIndex = 16;
            this.btnLoginForm.Text = "Login";
            this.btnLoginForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginForm.UseVisualStyleBackColor = true;
            this.btnLoginForm.Click += new System.EventHandler(this.BtnLoginForm_Click);
            this.btnLoginForm.Leave += new System.EventHandler(this.BtnLoginForm_Leave);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminPanel.FlatAppearance.BorderSize = 0;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminPanel.ForeColor = System.Drawing.Color.White;
            this.btnAdminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPanel.Location = new System.Drawing.Point(0, 252);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(200, 63);
            this.btnAdminPanel.TabIndex = 15;
            this.btnAdminPanel.Text = "             AdminPanel";
            this.btnAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.BtnAdminPanel_Click);
            this.btnAdminPanel.Leave += new System.EventHandler(this.BtnAdminPanel_Leave);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 189);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 63);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "      Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.BtnSettings_Leave);
            // 
            // btnAvailableBooks
            // 
            this.btnAvailableBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAvailableBooks.FlatAppearance.BorderSize = 0;
            this.btnAvailableBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailableBooks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAvailableBooks.ForeColor = System.Drawing.Color.White;
            this.btnAvailableBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnAvailableBooks.Image")));
            this.btnAvailableBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailableBooks.Location = new System.Drawing.Point(0, 126);
            this.btnAvailableBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvailableBooks.Name = "btnAvailableBooks";
            this.btnAvailableBooks.Size = new System.Drawing.Size(200, 63);
            this.btnAvailableBooks.TabIndex = 8;
            this.btnAvailableBooks.Text = "     Available Books";
            this.btnAvailableBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailableBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAvailableBooks.UseVisualStyleBackColor = true;
            this.btnAvailableBooks.Click += new System.EventHandler(this.BtnAvailableBooks_Click);
            this.btnAvailableBooks.Leave += new System.EventHandler(this.BtnAvailableBooks_Leave);
            // 
            // btnRentedBooks
            // 
            this.btnRentedBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRentedBooks.FlatAppearance.BorderSize = 0;
            this.btnRentedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentedBooks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRentedBooks.ForeColor = System.Drawing.Color.White;
            this.btnRentedBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnRentedBooks.Image")));
            this.btnRentedBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentedBooks.Location = new System.Drawing.Point(0, 63);
            this.btnRentedBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnRentedBooks.Name = "btnRentedBooks";
            this.btnRentedBooks.Size = new System.Drawing.Size(200, 63);
            this.btnRentedBooks.TabIndex = 7;
            this.btnRentedBooks.Text = "     Rented Books";
            this.btnRentedBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentedBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRentedBooks.UseVisualStyleBackColor = true;
            this.btnRentedBooks.Click += new System.EventHandler(this.BtnRentedBooks_Click);
            this.btnRentedBooks.Leave += new System.EventHandler(this.BtnRentedBooks_Leave);
            // 
            // userControlLogin1
            // 
            this.userControlLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlLogin1.Location = new System.Drawing.Point(200, 0);
            this.userControlLogin1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlLogin1.Name = "userControlLogin1";
            this.userControlLogin1.Size = new System.Drawing.Size(829, 561);
            this.userControlLogin1.TabIndex = 1;
            // 
            // userControlRegister1
            // 
            this.userControlRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRegister1.Location = new System.Drawing.Point(200, 0);
            this.userControlRegister1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlRegister1.Name = "userControlRegister1";
            this.userControlRegister1.Size = new System.Drawing.Size(829, 561);
            this.userControlRegister1.TabIndex = 2;
            // 
            // userControlProfile1
            // 
            this.userControlProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlProfile1.Location = new System.Drawing.Point(200, 0);
            this.userControlProfile1.LoggedPerson = null;
            this.userControlProfile1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlProfile1.Name = "userControlProfile1";
            this.userControlProfile1.Size = new System.Drawing.Size(829, 561);
            this.userControlProfile1.TabIndex = 3;
            // 
            // userControlSettings1
            // 
            this.userControlSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSettings1.Location = new System.Drawing.Point(200, 0);
            this.userControlSettings1.LoggedPerson = null;
            this.userControlSettings1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSettings1.Name = "userControlSettings1";
            this.userControlSettings1.Size = new System.Drawing.Size(829, 561);
            this.userControlSettings1.TabIndex = 4;
            // 
            // userControlAdmin1
            // 
            this.userControlAdmin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAdmin1.Location = new System.Drawing.Point(200, 0);
            this.userControlAdmin1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAdmin1.Name = "userControlAdmin1";
            this.userControlAdmin1.Size = new System.Drawing.Size(829, 561);
            this.userControlAdmin1.TabIndex = 5;
            // 
            // userControlRentedBooks1
            // 
            this.userControlRentedBooks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRentedBooks1.Location = new System.Drawing.Point(200, 0);
            this.userControlRentedBooks1.LoggedPerson = null;
            this.userControlRentedBooks1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlRentedBooks1.Name = "userControlRentedBooks1";
            this.userControlRentedBooks1.Size = new System.Drawing.Size(829, 561);
            this.userControlRentedBooks1.TabIndex = 6;
            // 
            // userControlAvailableBooks1
            // 
            this.userControlAvailableBooks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAvailableBooks1.Location = new System.Drawing.Point(200, 0);
            this.userControlAvailableBooks1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControlAvailableBooks1.Name = "userControlAvailableBooks1";
            this.userControlAvailableBooks1.Size = new System.Drawing.Size(829, 561);
            this.userControlAvailableBooks1.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.userControlAvailableBooks1);
            this.Controls.Add(this.userControlRentedBooks1);
            this.Controls.Add(this.userControlAdmin1);
            this.Controls.Add(this.userControlSettings1);
            this.Controls.Add(this.userControlProfile1);
            this.Controls.Add(this.userControlRegister1);
            this.Controls.Add(this.userControlLogin1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "MainWindow";
            this.Text = "Library system";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnProfile;
        private Panel panel1;
        private Button btnRegisterForm;
        private Button btnLogout;
        private Button btnLoginForm;
        private Button btnAdminPanel;
        private Button btnSettings;
        private Button btnAvailableBooks;
        private Button btnRentedBooks;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private UserControlLogin userControlLogin1;
        private UserControlRegister userControlRegister1;
        private UserControlProfile userControlProfile1;
        private UserControlSettings userControlSettings1;
        private UserControlAdmin userControlAdmin1;
        private UserControlRentedBooks userControlRentedBooks1;
        private UserControlAvailableBooks userControlAvailableBooks1;
    }
}