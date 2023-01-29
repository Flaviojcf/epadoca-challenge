using epadoca_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace epadoca_challenge.Data
{
    public class BakeryDbContext : DbContext
    {
        public BakeryDbContext(DbContextOptions<BakeryDbContext> options) : base(options) { 
        }

        public DbSet<BakeryModel> Bakeries { get; set; }
    }
}
