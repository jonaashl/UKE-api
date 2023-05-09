using Microsoft.EntityFrameworkCore;
using UKE_api.Models;

namespace UKE_api.Data
{
    public class NumeralDbContext : DbContext
    {
        public NumeralDbContext(DbContextOptions<NumeralDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ConversionHistory>? ConversionHistory { get; set; }
    }
}
