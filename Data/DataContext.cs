using Microsoft.EntityFrameworkCore;
using DateMatchApp.API.Models;
namespace DateMatchApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Value> Values {get;set;}
    }
}