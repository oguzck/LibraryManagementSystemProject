
namespace LibraryManagementSystemProject
{
    partial class DeliverBook
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLibraryId = new System.Windows.Forms.TextBox();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.dateBorrowdate = new System.Windows.Forms.DateTimePicker();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblBorrowerSurname = new System.Windows.Forms.Label();
            this.txtBorrowerSurname = new System.Windows.Forms.TextBox();
            this.lblBorrowerName = new System.Windows.Forms.Label();
            this.txtBorrowerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObjectId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpPublishYear = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(226, 445);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(144, 25);
            this.btnReturn.TabIndex = 96;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 15);
            this.label14.TabIndex = 95;
            this.label14.Text = "Borrower Library Id : ";
            // 
            // txtLibraryId
            // 
            this.txtLibraryId.Location = new System.Drawing.Point(161, 390);
            this.txtLibraryId.Name = "txtLibraryId";
            this.txtLibraryId.ReadOnly = true;
            this.txtLibraryId.Size = new System.Drawing.Size(155, 23);
            this.txtLibraryId.TabIndex = 94;
            // 
            // btnDeliver
            // 
            this.btnDeliver.Location = new System.Drawing.Point(564, 445);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(144, 25);
            this.btnDeliver.TabIndex = 93;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // dateBorrowdate
            // 
            this.dateBorrowdate.Location = new System.Drawing.Point(445, 350);
            this.dateBorrowdate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateBorrowdate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateBorrowdate.Name = "dateBorrowdate";
            this.dateBorrowdate.Size = new System.Drawing.Size(149, 23);
            this.dateBorrowdate.TabIndex = 92;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(353, 355);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(75, 15);
            this.lblBorrowDate.TabIndex = 91;
            this.lblBorrowDate.Text = "Borrow Date:";
            // 
            // lblBorrowerSurname
            // 
            this.lblBorrowerSurname.AutoSize = true;
            this.lblBorrowerSurname.Location = new System.Drawing.Point(37, 352);
            this.lblBorrowerSurname.Name = "lblBorrowerSurname";
            this.lblBorrowerSurname.Size = new System.Drawing.Size(114, 15);
            this.lblBorrowerSurname.TabIndex = 90;
            this.lblBorrowerSurname.Text = "Borrower Surname : ";
            // 
            // txtBorrowerSurname
            // 
            this.txtBorrowerSurname.Location = new System.Drawing.Point(161, 352);
            this.txtBorrowerSurname.Name = "txtBorrowerSurname";
            this.txtBorrowerSurname.ReadOnly = true;
            this.txtBorrowerSurname.Size = new System.Drawing.Size(155, 23);
            this.txtBorrowerSurname.TabIndex = 89;
            // 
            // lblBorrowerName
            // 
            this.lblBorrowerName.AutoSize = true;
            this.lblBorrowerName.Location = new System.Drawing.Point(53, 316);
            this.lblBorrowerName.Name = "lblBorrowerName";
            this.lblBorrowerName.Size = new System.Drawing.Size(99, 15);
            this.lblBorrowerName.TabIndex = 88;
            this.lblBorrowerName.Text = "Borrower Name : ";
            // 
            // txtBorrowerName
            // 
            this.txtBorrowerName.Location = new System.Drawing.Point(161, 316);
            this.txtBorrowerName.Name = "txtBorrowerName";
            this.txtBorrowerName.ReadOnly = true;
            this.txtBorrowerName.Size = new System.Drawing.Size(155, 23);
            this.txtBorrowerName.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(361, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 29);
            this.label12.TabIndex = 86;
            this.label12.Text = "Deliver Book";
            // 
            // txtObjectId
            // 
            this.txtObjectId.Location = new System.Drawing.Point(161, 146);
            this.txtObjectId.Name = "txtObjectId";
            this.txtObjectId.ReadOnly = true;
            this.txtObjectId.Size = new System.Drawing.Size(155, 23);
            this.txtObjectId.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 15);
            this.label13.TabIndex = 84;
            this.label13.Text = "Id : ";
            // 
            // dtpPublishYear
            // 
            this.dtpPublishYear.Location = new System.Drawing.Point(708, 188);
            this.dtpPublishYear.Name = "dtpPublishYear";
            this.dtpPublishYear.Size = new System.Drawing.Size(149, 23);
            this.dtpPublishYear.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 82;
            this.label11.Text = "Publisher : ";
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(706, 229);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.ReadOnly = true;
            this.txtEdition.Size = new System.Drawing.Size(150, 23);
            this.txtEdition.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(624, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 80;
            this.label10.Text = "Publish Year :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(624, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 79;
            this.label9.Text = "Stock : ";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(706, 146);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(150, 23);
            this.txtStock.TabIndex = 78;
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(445, 230);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ReadOnly = true;
            this.txtEditor.Size = new System.Drawing.Size(144, 23);
            this.txtEditor.TabIndex = 77;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(445, 188);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.Size = new System.Drawing.Size(144, 23);
            this.txtLanguage.TabIndex = 76;
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(445, 146);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.ReadOnly = true;
            this.txtPageCount.Size = new System.Drawing.Size(144, 23);
            this.txtPageCount.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 74;
            this.label8.Text = "Edition : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "Editor : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 72;
            this.label6.Text = "Language : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Page Count : ";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(445, 272);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(144, 23);
            this.txtISBN.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 69;
            this.label4.Text = "ISBN : ";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(161, 272);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(155, 23);
            this.txtPublisher.TabIndex = 68;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(161, 230);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(155, 23);
            this.txtAuthor.TabIndex = 67;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(161, 188);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(155, 23);
            this.txtTitle.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 275);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 233);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "Author : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 191);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Title : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLibraryId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDeliver);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.dateBorrowdate);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.lblBorrowDate);
            this.panel1.Controls.Add(this.txtPublisher);
            this.panel1.Controls.Add(this.lblBorrowerSurname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBorrowerSurname);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.lblBorrowerName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBorrowerName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtObjectId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtPageCount);
            this.panel1.Controls.Add(this.dtpPublishYear);
            this.panel1.Controls.Add(this.txtLanguage);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtEditor);
            this.panel1.Controls.Add(this.txtEdition);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 499);
            this.panel1.TabIndex = 97;
            // 
            // DeliverBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeliverBook";
            this.Size = new System.Drawing.Size(881, 499);
            this.Load += new System.EventHandler(this.DeliverBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLibraryId;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.DateTimePicker dateBorrowdate;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblBorrowerSurname;
        private System.Windows.Forms.TextBox txtBorrowerSurname;
        private System.Windows.Forms.Label lblBorrowerName;
        private System.Windows.Forms.TextBox txtBorrowerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObjectId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpPublishYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}