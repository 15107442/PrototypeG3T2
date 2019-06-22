using Microsoft.EntityFrameworkCore;
using PrototypeG3T2.Models;

namespace PrototypeG3T2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SensorData> SensorDatas { get; set; }
    }
}