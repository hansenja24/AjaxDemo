using System;
using Microsoft.EntityFrameworkCore;

namespace AjaxDemo.Models
{
    public class AjaxDemoContext : DbContext
    {
        public AjaxDemoContext()
        {
        }

        public DbSet<Destination> Destination { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=AjaxDemo;uid=root;pwd=root;");
        }

        public AjaxDemoContext(DbContextOptions<AjaxDemoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
