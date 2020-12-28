using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_7lab.Models
{
    public partial class EFDbcontext : DbContext
    {
        public EFDbcontext(DbContextOptions<EFDbcontext> options) : base(options)
        {

        }

        
        public virtual DbSet<Actors> Actors { get; set; }
        public virtual DbSet<Films> Films { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }

    }
}
