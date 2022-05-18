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

        public void insertDeneme()
        {
            Book book = new Book();
            book.AuthorName = "Oguz";
            book.Edition = 2020;
            book.EditorName = "Hasan";
            book.ISBN = 20675;
            book.Language = "Turkish";
            book.PageCount = 241;
            book.PublisherName = "Yayınevi";
            book.PublishYear = new DateTime(2015, 12, 31);
            book.StockCount = 4;
            book.Title = "oğuzun hikayesi";
            m_Collection.InsertOne(book);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
