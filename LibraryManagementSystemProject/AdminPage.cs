﻿using System;
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

        static MongoClient m_Client = new MongoClient("mongodb+srv://ozikill123:4584@maincluster.kfxqf.mongodb.net/?retryWrites=true&w=majority");
        static IMongoDatabase m_Database = m_Client.GetDatabase("LibraryInformation");
        static IMongoCollection<Admin> m_Collection = m_Database.GetCollection<Admin>("Admins");

        public AdminPage()
        {
            InitializeComponent();
           
           // Admin admin = new Admin();
               //admin.Name = "OğuzCan";
                //admin.Surname = "Kılıçkaya";
              //admin.Username = "ozikill";
              //admin.Password = "123";
             //admin._id = new ObjectId();
           // m_Collection.InsertOne(admin);
        }
        public void loadForm(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront();


        }

        public async Task LoginAsync()
        {
            var documents = await m_Collection.Find(_ => true).ToListAsync();
            foreach (var admname in documents)
            {
                if (admname.Password == txtPassword.Text && admname.Username == txtUsername.Text)
                {
                    MessageBox.Show("giriş başarılı");
                    loadForm(new InsertDeleteUpdate());
                }
                    
                    
                else
                {
                    MessageBox.Show("giriş başarısız");
                }
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            LoginAsync();
        }
    }
}
