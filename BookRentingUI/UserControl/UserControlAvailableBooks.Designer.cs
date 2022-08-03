namespace BookRentingUI
{
    partial class UserControlAvailableBooks
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
            this.dgvAvailableBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableBooks
            // 
            this.dgvAvailableBooks.AllowUserToAddRows = false;
            this.dgvAvailableBooks.AllowUserToDeleteRows = false;
            this.dgvAvailableBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvailableBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvAvailableBooks.Name = "dgvAvailableBooks";
            this.dgvAvailableBooks.ReadOnly = true;
            this.dgvAvailableBooks.RowTemplate.Height = 25;
            this.dgvAvailableBooks.Size = new System.Drawing.Size(550, 472);
            this.dgvAvailableBooks.TabIndex = 1;
            this.dgvAvailableBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableBooks_CellContentClick);
            this.dgvAvailableBooks.SelectionChanged += new System.EventHandler(this.dgvAvailableBooks_SelectionChanged);
            this.dgvAvailableBooks.VisibleChanged += new System.EventHandler(this.dgvAvailableBooks_VisibleChanged);
            // 
            // UserControlAvailableBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAvailableBooks);
            this.Name = "UserControlAvailableBooks";
            this.Size = new System.Drawing.Size(550, 472);
            this.Load += new System.EventHandler(this.UserControlAvailableBooks_Load);
            this.SizeChanged += new System.EventHandler(this.UserControlAvailableBooks_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvAvailableBooks;
    }
}
