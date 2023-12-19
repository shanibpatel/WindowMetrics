using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WindowMetrics.Models;

namespace WindowMetrics.Data
{
    public class WindowMetricsContext : DbContext
    {
        public WindowMetricsContext (DbContextOptions<WindowMetricsContext> options)
            : base(options)
        {
        }

        public DbSet<WindowMetrics.Models.Client> Client { get; set; } = default!;
    }
}
