using Microsoft.EntityFrameworkCore;
using SecondApp.Models;

namespace SecondApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

    public DbSet<Value> Values { get; set; }

    public DbSet<User> Users { get; set; }
    }
}