using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcBlog.Data
{
    public class MvcBlogContext : DbContext
    {
        public DbSet<User> User { get; set; } = default!;
        public DbSet<Blog> Blog { get; set; } = default!;
        public DbSet<Post> Post { get; set; } = default!;

        public MvcBlogContext (DbContextOptions<MvcBlogContext> options)
            : base(options)
        {
        }
    }
}
