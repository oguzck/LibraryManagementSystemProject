﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
namespace LibraryManagementSystemProject
{
    class Editor
    {
        public ObjectId _id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public int Phone { get; set; }

    }
}