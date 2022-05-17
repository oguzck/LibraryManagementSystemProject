using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemProject
{
    class Book
    {
        public ObjectId _id { get; set; }
        public int ISBN { get; set; }
        public int Edition { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishYear { get; set; }
        public String Title { get; set; }
        public String Language { get; set; }
        public ObjectId Publisher_Id { get; set; }
        public ObjectId Author_Id { get; set; }
        public ObjectId Editor_Id { get; set; }
        public int StockCount { get; set; }
    }
}
