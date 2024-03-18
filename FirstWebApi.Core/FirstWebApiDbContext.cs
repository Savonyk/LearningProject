using FirstWebApi.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApi.Core
{
    public class FirstWebApiDbContext :DbContext
    {
       public DbSet<User> Users { get; set; }

       public FirstWebApiDbContext(DbContextOptions<FirstWebApiDbContext> options) : base(options) { }
    }
}
