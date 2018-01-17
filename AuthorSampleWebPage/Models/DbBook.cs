using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuthorSampleWebPage.Models
{
    public class DbBook: DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}