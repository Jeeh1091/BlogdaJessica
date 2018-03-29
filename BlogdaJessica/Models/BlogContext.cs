using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogdaJessica.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Post { get; set; }


        public BlogContext() : base("DefaultConnection")
        {
        }
    }
}