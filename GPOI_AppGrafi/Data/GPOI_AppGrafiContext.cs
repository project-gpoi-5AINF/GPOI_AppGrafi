using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GPOI_AppGrafi.Models;

namespace GPOI_AppGrafi.Data
{
    public class GPOI_AppGrafiContext : DbContext
    {
        public GPOI_AppGrafiContext (DbContextOptions<GPOI_AppGrafiContext> options)
            : base(options)
        {
        }

        public DbSet<GPOI_AppGrafi.Models.Edge> Edge { get; set; } = default!;

        public DbSet<GPOI_AppGrafi.Models.NodeSQL>? NodeSQL { get; set; }
    }
}
