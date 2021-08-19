using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;

namespace MN_Groop_A.P.S.Database
{
    public class MNGroupDBConktext : DbContext
    {
        public MNGroupDBConktext() {}
        public MNGroupDBConktext(DbContextOptions<MNGroupDBConktext> options):base(options)
        {

        }

        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Kunde> Kunde { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Order_detalise> order_Detalise { get; set; }
        public DbSet<Produkt> Produkt { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
    }
}   
