
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
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(310, 707);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(206, 42);
            this.btnReturn.TabIndex = 96;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 618);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 25);
            this.label14.TabIndex = 95;
            this.label14.Text = "Borrower Library Id : ";
            // 
            // txtLibraryId
            // 
            this.txtLibraryId.Location = new System.Drawing.Point(217, 615);
            this.txtLibraryId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLibraryId.Name = "txtLibraryId";
            this.txtLibraryId.ReadOnly = true;
            this.txtLibraryId.Size = new System.Drawing.Size(220, 31);
            this.txtLibraryId.TabIndex = 94;
            // 
            // btnDeliver
            // 
            this.btnDeliver.Location = new System.Drawing.Point(793, 707);
            this.btnDeliver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(206, 42);
            this.btnDeliver.TabIndex = 93;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // dateBorrowdate
            // 
            this.dateBorrowdate.Location = new System.Drawing.Point(623, 549);
            this.dateBorrowdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateBorrowdate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateBorrowdate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateBorrowdate.Name = "dateBorrowdate";
            this.dateBorrowdate.Size = new System.Drawing.Size(211, 31);
            this.dateBorrowdate.TabIndex = 92;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(491, 557);
            this.lblBorrowDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(115, 25);
            this.lblBorrowDate.TabIndex = 91;
            this.lblBorrowDate.Text = "Borrow Date:";
            // 
            // lblBorrowerSurname
            // 
            this.lblBorrowerSurname.AutoSize = true;
            this.lblBorrowerSurname.Location = new System.Drawing.Point(40, 551);
            this.lblBorrowerSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowerSurname.Name = "lblBorrowerSurname";
            this.lblBorrowerSurname.Size = new System.Drawing.Size(173, 25);
            this.lblBorrowerSurname.TabIndex = 90;
            this.lblBorrowerSurname.Text = "Borrower Surname : ";
            // 
            // txtBorrowerSurname
            // 
            this.txtBorrowerSurname.Location = new System.Drawing.Point(217, 551);
            this.txtBorrowerSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBorrowerSurname.Name = "txtBorrowerSurname";
            this.txtBorrowerSurname.ReadOnly = true;
            this.txtBorrowerSurname.Size = new System.Drawing.Size(220, 31);
            this.txtBorrowerSurname.TabIndex = 89;
            // 
            // lblBorrowerName
            // 
            this.lblBorrowerName.AutoSize = true;
            this.lblBorrowerName.Location = new System.Drawing.Point(63, 491);
            this.lblBorrowerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowerName.Name = "lblBorrowerName";
            this.lblBorrowerName.Size = new System.Drawing.Size(150, 25);
            this.lblBorrowerName.TabIndex = 88;
            this.lblBorrowerName.Text = "Borrower Name : ";
            // 
            // txtBorrowerName
            // 
            this.txtBorrowerName.Location = new System.Drawing.Point(217, 491);
            this.txtBorrowerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBorrowerName.Name = "txtBorrowerName";
            this.txtBorrowerName.ReadOnly = true;
            this.txtBorrowerName.Size = new System.Drawing.Size(220, 31);
            this.txtBorrowerName.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(503, 77);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 43);
            this.label12.TabIndex = 86;
            this.label12.Text = "Deliver Book";
            // 
            // txtObjectId
            // 
            this.txtObjectId.Location = new System.Drawing.Point(217, 209);
            this.txtObjectId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObjectId.Name = "txtObjectId";
            this.txtObjectId.ReadOnly = true;
            this.txtObjectId.Size = new System.Drawing.Size(220, 31);
            this.txtObjectId.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(115, 214);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 25);
            this.label13.TabIndex = 84;
            this.label13.Text = "Id : ";
            // 
            // dtpPublishYear
            // 
            this.dtpPublishYear.Location = new System.Drawing.Point(998, 278);
            this.dtpPublishYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpPublishYear.Name = "dtpPublishYear";
            this.dtpPublishYear.Size = new System.Drawing.Size(211, 31);
            this.dtpPublishYear.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 423);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 25);
            this.label11.TabIndex = 82;
            this.label11.Text = "Publisher : ";
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(996, 347);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.ReadOnly = true;
            this.txtEdition.Size = new System.Drawing.Size(213, 31);
            this.txtEdition.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(878, 283);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 25);
            this.label10.TabIndex = 80;
            this.label10.Text = "Publish Year :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(878, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 79;
            this.label9.Text = "Stock : ";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(996, 208);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(213, 31);
            this.txtStock.TabIndex = 78;
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(623, 348);
            this.txtEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ReadOnly = true;
            this.txtEditor.Size = new System.Drawing.Size(204, 31);
            this.txtEditor.TabIndex = 77;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(623, 279);
            this.txtLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.Size = new System.Drawing.Size(204, 31);
            this.txtLanguage.TabIndex = 76;
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(623, 209);
            this.txtPageCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.ReadOnly = true;
            this.txtPageCount.Size = new System.Drawing.Size(204, 31);
            this.txtPageCount.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(878, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 74;
            this.label8.Text = "Edition : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 73;
            this.label7.Text = "Editor : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "Language : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 71;
            this.label5.Text = "Page Count : ";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(623, 418);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(204, 31);
            this.txtISBN.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "ISBN : ";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(217, 418);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(220, 31);
            this.txtPublisher.TabIndex = 68;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(217, 349);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(220, 31);
            this.txtAuthor.TabIndex = 67;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(217, 279);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(220, 31);
            this.txtTitle.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Author : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Title : ";
            // 
            // DeliverBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 831);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtLibraryId);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.dateBorrowdate);
            this.Controls.Add(this.lblBorrowDate);
            this.Controls.Add(this.lblBorrowerSurname);
            this.Controls.Add(this.txtBorrowerSurname);
            this.Controls.Add(this.lblBorrowerName);
            this.Controls.Add(this.txtBorrowerName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtObjectId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpPublishYear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.txtPageCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeliverBook";
            this.Text = "DeliverBook";
            this.Load += new System.EventHandler(this.DeliverBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}