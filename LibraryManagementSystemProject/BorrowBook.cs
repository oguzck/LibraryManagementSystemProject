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
    public partial class BorrowBook : Form
    {
        public string ISBN;
        public BorrowBook(string isbn)
        {
            ISBN = isbn;
            InitializeComponent();
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {

        }
    }
}
