
namespace LibraryManagementSystemProject
{
    partial class Welcome
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
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBookInsUpdDlt = new System.Windows.Forms.Button();
            this.btnBorrowedBooks = new System.Windows.Forms.Button();
            this.pnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSideBar.Controls.Add(this.btnBorrowedBooks);
            this.pnlSideBar.Controls.Add(this.btnBookInsUpdDlt);
            this.pnlSideBar.Controls.Add(this.btnSearch);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(156, 499);
            this.pnlSideBar.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(156, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(775, 499);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.BackColor = System.Drawing.Color.Salmon;
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.Location = new System.Drawing.Point(156, 0);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.Size = new System.Drawing.Size(775, 60);
            this.pnlTopbar.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnBookInsUpdDlt
            // 
            this.btnBookInsUpdDlt.Location = new System.Drawing.Point(12, 208);
            this.btnBookInsUpdDlt.Name = "btnBookInsUpdDlt";
            this.btnBookInsUpdDlt.Size = new System.Drawing.Size(125, 23);
            this.btnBookInsUpdDlt.TabIndex = 1;
            this.btnBookInsUpdDlt.Text = "BookRegister";
            this.btnBookInsUpdDlt.UseVisualStyleBackColor = true;
            // 
            // btnBorrowedBooks
            // 
            this.btnBorrowedBooks.Location = new System.Drawing.Point(12, 303);
            this.btnBorrowedBooks.Name = "btnBorrowedBooks";
            this.btnBorrowedBooks.Size = new System.Drawing.Size(125, 23);
            this.btnBorrowedBooks.TabIndex = 2;
            this.btnBorrowedBooks.Text = "Barrowed Books";
            this.btnBorrowedBooks.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 499);
            this.Controls.Add(this.pnlTopbar);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "Welcome";
            this.Text = "Form1";
            this.pnlSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Button btnBorrowedBooks;
        private System.Windows.Forms.Button btnBookInsUpdDlt;
        private System.Windows.Forms.Button btnSearch;
    }
}

