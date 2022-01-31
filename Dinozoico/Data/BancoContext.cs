using Dinozoico.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dinozoico.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<DinossauroModel> Dinossauro { get; set; }
    }
}
