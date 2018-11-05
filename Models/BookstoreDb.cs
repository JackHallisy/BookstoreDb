using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookstoreDB.Models
{
    public class BookstoreDb : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Books> Books { get; set; }
    }
}