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
    public partial class DeliverBook : UserControl
    {
        Book selectedBook = new Book();
        BorrowedBook borrowedBook = new BorrowedBook();
        public string ID;
        static MongoClient m_Client = new MongoClient("mongodb+srv://ozikill123:4584@maincluster.kfxqf.mongodb.net/?retryWrites=true&w=majority");
        static IMongoDatabase m_Database = m_Client.GetDatabase("LibraryInformation");
        static IMongoCollection<BorrowedBook> m_Collection = m_Database.GetCollection<BorrowedBook>("BorrowedBooks");
        static IMongoCollection<Book> m_Collection_book = m_Database.GetCollection<Book>("Book");

        public DeliverBook(string id)
        {
            ID = id;
            InitializeComponent();
        }

        public async Task FillWithMatchingRecords()
        {
            ObjectId bookId = new ObjectId();
            var documents = await m_Collection.Find(_ => true).ToListAsync();
            foreach (var BorrowedBook in documents)
            {

                if (BorrowedBook._id.ToString() == ID)
                {
                    borrowedBook = BorrowedBook;
                    bookId = BorrowedBook.BorrowedBookId;
                    txtBorrowerName.Text = BorrowedBook.BorrowerName.ToString();
                    txtBorrowerSurname.Text = BorrowedBook.BorrowerSurname.ToString();
                    txtLibraryId.Text = BorrowedBook.BorrowerLibraryId.ToString();
                    dateBorrowdate.Value = Convert.ToDateTime(BorrowedBook.BorrowDate);

                }

            }


            var documents2 = await m_Collection_book.Find(_ => true).ToListAsync();
            foreach (var book in documents2)
            {
                
                if (book._id == bookId)
                {
                    selectedBook = book;
                    txtObjectId.Text = ID;
                    txtISBN.Text = book.ISBN.ToString();
                    txtEdition.Text = book.Edition.ToString();
                    txtPageCount.Text = book.Edition.ToString();
                    dtpPublishYear.Value = Convert.ToDateTime(book.PublishYear);
                    txtTitle.Text = book.Title.ToString();
                    txtLanguage.Text = book.Language.ToString();
                    txtPublisher.Text = book.PublisherName.ToString();
                    txtAuthor.Text = book.AuthorName.ToString();
                    txtEditor.Text = book.EditorName.ToString();
                    txtStock.Text = book.StockCount.ToString();
                }

            }

        }

        private void DeliverBook_Load(object sender, EventArgs e)
        {
            FillWithMatchingRecords();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
           
            selectedBook.StockCount += 1;
            var updateDef = Builders<Book>.Update.Set("AuthorName", selectedBook.AuthorName)
                                                .Set("Edition", selectedBook.Edition)
                                                .Set("EditorName", selectedBook.EditorName)
                                                .Set("ISBN", selectedBook.ISBN)
                                                .Set("Language", selectedBook.Language)
                                                .Set("PageCount", selectedBook.PageCount)
                                                .Set("PublisherName", selectedBook.PublisherName)
                                                .Set("PublishYear", selectedBook.PublishYear)
                                                .Set("StockCount", Convert.ToInt32(selectedBook.StockCount))
                                                .Set("Title", selectedBook.Title);
            m_Collection_book.UpdateOne(b => b._id == selectedBook._id, updateDef);

            m_Collection.DeleteOne(b => b._id == borrowedBook._id);
            MessageBox.Show("Book delivered");
            this.Hide();
            
        }
        public void loadForm(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            loadForm(new BorrowedBooks());
        }
    }
}
