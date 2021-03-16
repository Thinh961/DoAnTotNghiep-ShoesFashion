using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NCT_Fashion.Models.Entities;

namespace NCT_Fashion.Data
{
    public class NCT_FashionContext : IdentityDbContext
    {
        public NCT_FashionContext (DbContextOptions<NCT_FashionContext> options)
            : base(options)
        {
        }

        public DbSet<NCT_Fashion.Models.Entities.Admin> Admin { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.Category> Category { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.Color> Color { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.Customer> Customer { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.Deliver> Deliver { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.News> News { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.Order> Order { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.OrderDetail> OrderDetail { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.Payment> Payment { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.Product> Product { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.ProductDetail> ProductDetail { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.Review> Review { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.Size> Size { get; set; }

        public DbSet<NCT_Fashion.Models.Entities.Supplier> Supplier { get; set; }
    }
}
