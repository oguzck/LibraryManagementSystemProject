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
    public partial class BorrowBook : UserControl
    {
        static Book selectedBook = new Book();
        static MongoClient m_Client = new MongoClient("mongodb+srv://ozikill123:4584@maincluster.kfxqf.mongodb.net/?retryWrites=true&w=majority");
        static IMongoDatabase m_Database = m_Client.GetDatabase("LibraryInformation");
        static IMongoCollection<Book> m_Collection = m_Database.GetCollection<Book>("Book");
        static IMongoCollection<BorrowedBook> m_Collection_borrowed = m_Database.GetCollection<BorrowedBook>("BorrowedBooks");
        public string ID;
        
        public BorrowBook(string id)
        {
            ID = id;
            InitializeComponent();
        }

        public async Task FillWithMatchingRecords()
        {

            var documents = await m_Collection.Find(_ => true).ToListAsync();
            foreach (var book in documents)
            {
                  
                if (book._id.ToString() == ID)
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

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            FillWithMatchingRecords();

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (txtBorrowerName.Text == "" || txtBorrowerSurname.Text == "" || txtLibraryId.Text == "")
            {
                MessageBox.Show("Please fill empty boxes");
            }
            else
            {

                BorrowedBook borrowedBook = new BorrowedBook();
                borrowedBook.BorrowedBookId = ObjectId.Parse(txtObjectId.Text);
                borrowedBook.BorrowerName = txtBorrowerName.Text;
                borrowedBook.BorrowerSurname = txtBorrowerSurname.Text;
                borrowedBook.BorrowerLibraryId = txtLibraryId.Text;
                borrowedBook.BorrowDate = dateBorrowdate.Value;

                selectedBook.StockCount -= 1;
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
                m_Collection.UpdateOne(b => b._id == selectedBook._id, updateDef);

                m_Collection_borrowed.InsertOne(borrowedBook);
                MessageBox.Show("Book borrowed");
                
            }
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
            loadForm(new SearchInterface());
        }
    }
}
