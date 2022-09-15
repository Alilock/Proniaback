using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.DAL
{
    public class ProniaContext : DbContext
    {
        public ProniaContext(DbContextOptions<ProniaContext> opt) : base(opt)
        {
        }
       public DbSet<Slider> Sliders { get; set; }
        public DbSet<Setting> Settings { get; set; }

    }
}
