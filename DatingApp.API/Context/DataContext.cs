using DatingApp.API.Model;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Context
{
    public class DataContext: DbContext
    {
        public DbSet<Value> Values { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }
    }
}