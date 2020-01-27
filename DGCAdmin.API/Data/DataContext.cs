using DGCAdmin.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DGCAdmin.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }

}