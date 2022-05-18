using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemProject
{
    class Admin
    {
        public ObjectId _id { get; set; }
        //public String Name { get; set; }
        //public String Surname { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

    }
}
