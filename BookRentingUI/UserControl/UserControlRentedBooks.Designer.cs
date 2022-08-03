namespace BookRentingUI
{
    partial class UserControlRentedBooks
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
            this.dgvRentedBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRentedBooks
            // 
            this.dgvRentedBooks.AllowUserToAddRows = false;
            this.dgvRentedBooks.AllowUserToDeleteRows = false;
            this.dgvRentedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentedBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvRentedBooks.Name = "dgvRentedBooks";
            this.dgvRentedBooks.ReadOnly = true;
            this.dgvRentedBooks.RowTemplate.Height = 25;
            this.dgvRentedBooks.Size = new System.Drawing.Size(546, 464);
            this.dgvRentedBooks.TabIndex = 0;
            this.dgvRentedBooks.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dgvRentedBooks.VisibleChanged += new System.EventHandler(this.dgvRentedBooks_VisibleChanged);
            // 
            // UserControlRentedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRentedBooks);
            this.Name = "UserControlRentedBooks";
            this.Size = new System.Drawing.Size(546, 464);
            this.Load += new System.EventHandler(this.UserControlRentedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvRentedBooks;
    }
}
