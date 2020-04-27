using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class MvcClienteContext : DbContext
    {
        public MvcClienteContext(DbContextOptions<MvcClienteContext> options)
    : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

    }
}
