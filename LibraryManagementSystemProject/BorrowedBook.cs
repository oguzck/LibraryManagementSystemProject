using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemProject
{
    class BorrowedBook
    {
        public ObjectId _id { get; set; }
        public ObjectId BorrowedBookId { get; set; }
        public String BorrowerName { get; set; }
        public String BorrowerSurname { get; set; }
        public String BorrowerLibraryId { get; set; }
        public DateTime BorrowDate { get; set; }

    }
}
