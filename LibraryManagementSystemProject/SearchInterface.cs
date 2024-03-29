﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;

namespace LibraryManagementSystemProject
{
    public partial class SearchInterface : Form
    {
        static MongoClient m_Client = new MongoClient("mongodb+srv://ozikill123:4584@maincluster.kfxqf.mongodb.net/?retryWrites=true&w=majority");
        static IMongoDatabase m_Database = m_Client.GetDatabase("LibraryInformation");
        static IMongoCollection <Book> m_Collection = m_Database.GetCollection<Book>("Book");
        public SearchInterface()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        public void ReadAllDocuments()
        {
            List<Book> list = m_Collection.AsQueryable().ToList<Book>();
            dataGridView1.DataSource = list;
        }

        public async Task FillWithMatchingRecords()
        {
            List<Book> bookList = new List<Book>();
            var documents = await m_Collection.Find(_ => true).ToListAsync();
            foreach (var book in documents)
            {
                if (txtKey.Text == "")
                {
                    bookList = m_Collection.AsQueryable().ToList<Book>();
                    dataGridView1.DataSource = bookList;
                }
                else
                {
                    if (book.ISBN.ToString() == txtKey.Text || book.Edition.ToString() == txtKey.Text || book.PageCount.ToString() == txtKey.Text || book.Title.ToString() == txtKey.Text ||
                   book.PublishYear.Year.ToString() == txtKey.Text || book.Language.ToString() == txtKey.Text || book.PublisherName.ToString() == txtKey.Text ||
                   book.AuthorName.ToString() == txtKey.Text || book.EditorName.ToString() == txtKey.Text || book.StockCount.ToString() == txtKey.Text)
                    {
                        bookList.Add(book);
                    }
                }

            }
            dataGridView1.DataSource = bookList;

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            if (txtKey.Text != null )
            {
                FillWithMatchingRecords();
            }
        }
        public void loadForm(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[rowindex].Cells[10].Value.ToString() == "0")
            {
                btnBorrow.Enabled = false;
                
            }
            else
            {
                btnBorrow.Enabled = true;
            }
            
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell is not null) { 
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();

            loadForm(new BorrowBook(id));
            }
            else
            {
                MessageBox.Show("Please Select a Book to Borrow");
            }
        }
    }
}
