using CTVoicer.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTVoicer.Negocio.Context
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
