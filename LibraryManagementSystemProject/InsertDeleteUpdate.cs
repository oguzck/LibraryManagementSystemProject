
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemProject
{
    public partial class InsertDeleteUpdate : UserControl
    {
        static MongoClient m_Client = new MongoClient("mongodb+srv://ozikill123:4584@maincluster.kfxqf.mongodb.net/?retryWrites=true&w=majority");
        static IMongoDatabase m_Database = m_Client.GetDatabase("LibraryInformation");
        static IMongoCollection<Book> m_Collection = m_Database.GetCollection<Book>("Book");
        public InsertDeleteUpdate()
        {
            InitializeComponent();
            //insertDeneme();
            ReadAllDocuments();
           


        }
        public void ReadAllDocuments()
        {
            List<Book> list = m_Collection.AsQueryable().ToList<Book>();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtObjectId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtISBN.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEdition.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPageCount.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpPublishYear.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value); 
            txtTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtLanguage.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPublisher.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtEditor.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtStock.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }
        public void ClearComponent()
        {
            txtAuthor.Clear();
            txtEdition.Clear();
            txtEditor.Clear();
            txtISBN.Clear();
            txtLanguage.Clear();
            txtObjectId.Clear();
            txtPageCount.Clear();
            txtPublisher.Clear();
            txtStock.Clear();
            txtTitle.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearComponent();  
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.AuthorName = txtAuthor.Text;
            book.Edition = Convert.ToInt32(txtEdition.Text);
            book.EditorName = txtEditor.Text;
            book.ISBN = Convert.ToInt32(txtISBN.Text);
            book.Language = txtLanguage.Text;
            book.PageCount = Convert.ToInt32(txtPageCount.Text);
            book.PublisherName = txtPublisher.Text;
            book.PublishYear = dtpPublishYear.Value;
            book.StockCount = Convert.ToInt32(txtStock.Text);
            book.Title = txtTitle.Text;
            m_Collection.InsertOne(book);
            ReadAllDocuments();
            ClearComponent();
            MessageBox.Show("Data Inserted");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<Book>.Update.Set("AuthorName", txtAuthor.Text)
                                                 .Set("Edition", txtEdition.Text)
                                                 .Set("EditorName", txtEditor.Text)
                                                 .Set("ISBN", Convert.ToInt32(txtISBN.Text))
                                                 .Set("Language", txtLanguage.Text)
                                                 .Set("PageCount", Convert.ToInt32(txtPageCount.Text))
                                                 .Set("PublisherName", txtPublisher.Text)
                                                 .Set("PublishYear", dtpPublishYear.Value)
                                                 .Set("StockCount", Convert.ToInt32(txtStock.Text))
                                                 .Set("Title", txtTitle.Text);
            m_Collection.UpdateOne(b => b._id == ObjectId.Parse(txtObjectId.Text), updateDef);
            ReadAllDocuments();
            ClearComponent();
            MessageBox.Show("Data Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            m_Collection.DeleteOne(b => b._id == ObjectId.Parse(txtObjectId.Text));
            ReadAllDocuments();
            ClearComponent();
            MessageBox.Show("Data Deleted");
        }
    }
}
