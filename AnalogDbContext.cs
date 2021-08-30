using System;
using System.Data.Entity;

namespace TradesoftTestTask
{
    public class AnalogDbContext : DbContext
    {
        public AnalogDbContext():base("DbConntectionString")
        {}

        public DbSet<Analog> Analogs { get; set; }
    }
}
