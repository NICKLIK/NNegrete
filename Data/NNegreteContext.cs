using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NNegrete.Models;

namespace NNegrete.Data
{
    public class NNegreteContext : DbContext
    {
        public NNegreteContext (DbContextOptions<NNegreteContext> options)
            : base(options)
        {
        }

        public DbSet<NNegrete.Models.Estudiante> Estudiante { get; set; } = default!;

        public DbSet<NNegrete.Models.Carrera>? Carrera { get; set; }
    }
}
