using System;
using Microsoft.EntityFrameworkCore;
using Webapp.Model;

namespace Webapp.Data
{
    public class WebappContext : DbContext
    {
        public WebappContext(DbContextOptions<WebappContext> options)
            :base(options)
        {

        }

        public DbSet<JsonEditor> JsonEditor { get; set; }
    }
}
