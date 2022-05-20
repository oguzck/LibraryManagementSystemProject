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
using MongoDB.Bson;

namespace LibraryManagementSystemProject
{
    public partial class BorrowedBooks : Form
    {
        static MongoClient m_Client = new MongoClient("mongodb+srv://ozikill123:4584@maincluster.kfxqf.mongodb.net/?retryWrites=true&w=majority");
        static IMongoDatabase m_Database = m_Client.GetDatabase("LibraryInformation");
        static IMongoCollection<BorrowedBook> m_Collection = m_Database.GetCollection<BorrowedBook>("BorrowedBooks");
        public void ReadAllDocuments()
        {
            List<BorrowedBook> list = m_Collection.AsQueryable().ToList<BorrowedBook>();
            dataGridView1.DataSource = list;
        }
        public BorrowedBooks()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        public async Task FillWithMatchingRecords()
        {
            List<BorrowedBook> bookList = new List<BorrowedBook>();
            var documents = await m_Collection.Find(_ => true).ToListAsync();
            foreach (var book in documents)
            {
                if (txtKey.Text == "")
                {
                    bookList = m_Collection.AsQueryable().ToList<BorrowedBook>();
                    dataGridView1.DataSource = bookList;
                }
                else
                {
                    if (book.BorrowerName.ToString() == txtKey.Text || book.BorrowerSurname.ToString() == txtKey.Text || book.BorrowerLibraryId.ToString() == txtKey.Text || 
                        book.BorrowedBookId.ToString() == txtKey.Text || book.BorrowDate.Year.ToString() == txtKey.Text  )
                    {
                        bookList.Add(book);
                    }
                }

            }
            dataGridView1.DataSource = bookList;

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            if (txtKey.Text != null)
            {
                FillWithMatchingRecords();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();

            DeliverBook deliverBook = new DeliverBook(id);
            deliverBook.Show();
            this.Hide();
        }
    }
}
