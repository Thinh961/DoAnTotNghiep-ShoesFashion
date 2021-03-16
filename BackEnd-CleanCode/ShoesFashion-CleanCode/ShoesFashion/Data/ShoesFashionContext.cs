using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoesFashion.Models.Entities;

namespace ShoesFashion.Data
{
    public class ShoesFashionContext : DbContext
    {
        public ShoesFashionContext (DbContextOptions<ShoesFashionContext> options)
            : base(options)
        {
        }

        public DbSet<ShoesFashion.Models.Entities.Supplier> Supplier { get; set; }
    }
}
