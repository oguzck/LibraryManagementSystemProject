using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace LibraryManagementSystemProject
{
    public partial class AdminPage : Form
    {

        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<Admin> m_Collection;

        public AdminPage()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb+srv://atakanDengiz:123@cluster0.rxufi.mongodb.net/?retryWrites=true&w=majority");
            m_Database = m_Client.GetDatabase("LibraryInformation");
            m_Collection = m_Database.GetCollection<Admin>("Admins");

            //Admin admin = new Admin();
            //admin.Name = "OğuzCan";
            //admin.Surname = "Kılıçkaya";
            //admin.Username = "ozikill";
            //admin.Password = "123";
            //admin._id = new ObjectId();
            //m_Collection.InsertOne(admin);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == ""){
                return;
            }
           
           

        }
    }
}
