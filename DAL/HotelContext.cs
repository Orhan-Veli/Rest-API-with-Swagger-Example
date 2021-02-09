using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class HotelContext:DbContext
    {
        public HotelContext()
        {

        }
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=ORHAN\TEW_SQLEXPRESS; Database=HotelDbTekrar; Trusted_Connection=true;";
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
