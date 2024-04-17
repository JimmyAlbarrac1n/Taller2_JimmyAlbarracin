using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller_JimmyAlbarracin.Models;

namespace Taller_JimmyAlbarracin.Data
{
    public class Taller_JimmyAlbarracinContext : DbContext
    {
        public Taller_JimmyAlbarracinContext (DbContextOptions<Taller_JimmyAlbarracinContext> options)
            : base(options)
        {
        }

        public DbSet<Taller_JimmyAlbarracin.Models.Promo> Promo { get; set; } = default!;
        public DbSet<Taller_JimmyAlbarracin.Models.Burger> Burger { get; set; } = default!;
    }
}
