using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class CTVoicerContext : DbContext
    {
        public CTVoicerContext(DbContextOptions<CTVoicerContext> options) : base(options)
        {
        }

        public DbSet<Frota> Frotas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
