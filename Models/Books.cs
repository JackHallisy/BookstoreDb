using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookstoreDB.Models
{
    public class Books
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string author { get; set; }
        public virtual string ISBN { get; set; }
        public virtual string Category { get; set; }
        public virtual int Cost { get; set; }
    }
}