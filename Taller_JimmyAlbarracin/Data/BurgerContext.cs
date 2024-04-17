using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller_JimmyAlbarracin.Models;

    public class BurgerContext : DbContext
    {
        public BurgerContext (DbContextOptions<BurgerContext> options)
            : base(options)
        {
        }

        public DbSet<Taller_JimmyAlbarracin.Models.Burger> Burger { get; set; } = default!;
    }
