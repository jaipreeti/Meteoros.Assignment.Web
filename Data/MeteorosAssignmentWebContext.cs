using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Meteoros.Assignment.Web.Models;

namespace Meteoros.Assignment.Web.Data
{
    public class MeteorosAssignmentWebContext : DbContext
    {
        public MeteorosAssignmentWebContext (DbContextOptions<MeteorosAssignmentWebContext> options)
            : base(options)
        {
        }

        public DbSet<Meteoros.Assignment.Web.Models.Product> Product { get; set; } = default!;
    }
}
