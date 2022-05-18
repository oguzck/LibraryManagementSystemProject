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
        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            if (txtKey.Text != null )
            {
                FillWithMatchingRecords();
            }
        }
        public async Task FillWithMatchingRecords()
        {
            var keyType = txtKey.GetType();
            var bsonQuery = "{'Details.a':{$elemMatch:{$elemMatch:{DeviceName :"''txtKey.Text" /.*Name0.*/}}}}";
            var bsonQuer2 = "{'LibraryInformation.Book':{$elemMatch:{$elemMatch:{Title: /.*Dev.*/}}}}";
            var filter = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(bsonQuery);

            
        

        var result = m_Collection.FindSync(filter).ToList();

            var documents = await m_Collection.Find(_ => true).ToListAsync();
            foreach (var book in documents)
            {
                
                    if (book.ISBN.ToString() == txtKey.Text || book.Edition.ToString() == txtKey.Text || book.PageCount.ToString() == txtKey.Text)
                {
                    MessageBox.Show("giriş başarılı");
                }


                else
                {
                    MessageBox.Show("giriş başarısız");
                }
            }
            //public int ISBN { get; set; }
            //public int Edition { get; set; }
            //public int PageCount { get; set; }
            //public DateTime PublishYear { get; set; }
            //public String Title { get; set; }
            //public String Language { get; set; }
            //public String PublisherName { get; set; }
            //public String AuthorName { get; set; }
            //public String EditorName { get; set; }
            //public int StockCount { get; set; }
        }
      
        
    }
}
