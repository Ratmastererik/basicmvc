using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcBlog.Data
{
    public class MvcBlogContext : DbContext
    {
        public MvcBlogContext (DbContextOptions<MvcBlogContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
    }
}
