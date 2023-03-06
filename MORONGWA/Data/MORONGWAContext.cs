using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MORONGWA.Models;

namespace MORONGWA.Data
{
    public class MORONGWAContext : DbContext
    {
        public MORONGWAContext (DbContextOptions<MORONGWAContext> options)
            : base(options)
        {
        }

        public DbSet<MORONGWA.Models.Learners> Learners { get; set; } = default!;

        public DbSet<MORONGWA.Models.Facilitators> Facilitators { get; set; } = default!;

        public DbSet<MORONGWA.Models.Courses> Courses { get; set; } = default!;
    }
}
