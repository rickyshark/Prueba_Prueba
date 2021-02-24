using ApiSitio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSitio.Contexts
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario1> Usuario1 { get; set; }
        public DbSet<Correo> Correo { get; set; }
        public DbSet<Report_Offer> Report_Offer { get; set; }
    }
}
