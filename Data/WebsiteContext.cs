using Microsoft.EntityFrameworkCore;
using Website.Models;

namespace Website.Data
{
    public class WebsiteContext : DbContext
    {
        public WebsiteContext (DbContextOptions<WebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<Content> Content { get; set; }
    }
}