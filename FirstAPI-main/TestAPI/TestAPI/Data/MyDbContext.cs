using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Data
{
    public class MyDbContext:DbContext
    {
        //public MyDbContext()
        //{
        //    Database.EnsureCreated();
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-C0H3C8Q\SQLEXPRESS;Database=APIDB;Trusted_Connection=True;");
        }

        public DbSet<Event> Events { get; set; }
    }
}
