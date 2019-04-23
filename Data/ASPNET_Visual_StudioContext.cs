using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNET_Visual_Studio.Models;

namespace ASPNET_Visual_Studio.Models
{
    public class ASPNET_Visual_StudioContext : DbContext
    {
        public ASPNET_Visual_StudioContext (DbContextOptions<ASPNET_Visual_StudioContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNET_Visual_Studio.Models.Movie> Movie { get; set; }

        public DbSet<ASPNET_Visual_Studio.Models.Genre> Genre { get; set; }
    }
}
