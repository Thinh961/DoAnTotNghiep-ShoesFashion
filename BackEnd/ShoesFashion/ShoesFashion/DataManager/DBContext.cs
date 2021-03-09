using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShoesFashion.Models.Entities;

namespace ShoesFashion.DataManager
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Deliver> Deliver { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductDetail> ProductDetail { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                                               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                               .AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DBConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Tạo khóa phụ db ánh xạ Product với ProductDetail
            modelBuilder.Entity<Product>()
                .HasMany(i => i.Details)
                    .WithOne(x => x.Product)
                    .HasForeignKey(i => i.ProductId) //Khóa phụ
                    .HasPrincipalKey(x => x.ProductId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Admin với News
            modelBuilder.Entity<Admin>()
                .HasMany(i => i.News)
                    .WithOne(x => x.Admin)
                    .HasForeignKey(i => i.AdminId) //Khóa phụ
                    .HasPrincipalKey(x => x.AdminId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Customer với Order
            modelBuilder.Entity<Customer>()
                .HasMany(i => i.Order)
                    .WithOne(x => x.Customer)
                    .HasForeignKey(i => i.CustomerId) //Khóa phụ
                    .HasPrincipalKey(x => x.CustomerId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Payment với Order
            modelBuilder.Entity<Payment>()
                .HasMany(i => i.Order)
                    .WithOne(x => x.Payment)
                    .HasForeignKey(i => i.PayId) //Khóa phụ
                    .HasPrincipalKey(x => x.PayId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Deliver với Order
            modelBuilder.Entity<Deliver>()
                .HasMany(i => i.Order)
                    .WithOne(x => x.Deliver)
                    .HasForeignKey(i => i.DeliverId) //Khóa phụ
                    .HasPrincipalKey(x => x.DeliverId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Admin với Order
            modelBuilder.Entity<Admin>()
                .HasMany(i => i.Order)
                    .WithOne(x => x.Admin)
                    .HasForeignKey(i => i.AdminId) //Khóa phụ
                    .HasPrincipalKey(x => x.AdminId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Order với OrderDetail
            modelBuilder.Entity<Order>()
                .HasMany(i => i.OrderDetail)
                    .WithOne(x => x.Order)
                    .HasForeignKey(i => i.OrderId) //Khóa phụ
                    .HasPrincipalKey(x => x.OrderId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Product với OrderDetail
            modelBuilder.Entity<Product>()
                .HasMany(i => i.OrderDetail)
                    .WithOne(x => x.Product)
                    .HasForeignKey(i => i.ProductId) //Khóa phụ
                    .HasPrincipalKey(x => x.ProductId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Category với Product
            modelBuilder.Entity<Category>()
                .HasMany(i => i.Product)
                    .WithOne(x => x.Category)
                    .HasForeignKey(i => i.CategoryId) //Khóa phụ
                    .HasPrincipalKey(x => x.CategoryId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Supplier với Product
            modelBuilder.Entity<Supplier>()
                .HasMany(i => i.Product)
                    .WithOne(x => x.Supplier)
                    .HasForeignKey(i => i.SupplierId) //Khóa phụ
                    .HasPrincipalKey(x => x.SupplierId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Size với ProductDetail
            modelBuilder.Entity<Size>()
                .HasMany(i => i.ProductDetail)
                    .WithOne(x => x.Size)
                    .HasForeignKey(i => i.SizeId) //Khóa phụ
                    .HasPrincipalKey(x => x.SizeId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Color với ProductDetail
            modelBuilder.Entity<Color>()
                .HasMany(i => i.ProductDetail)
                    .WithOne(x => x.Color)
                    .HasForeignKey(i => i.ColorId) //Khóa phụ
                    .HasPrincipalKey(x => x.ColorId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Customer với Review
            modelBuilder.Entity<Customer>()
                .HasMany(i => i.Review)
                    .WithOne(x => x.Customer)
                    .HasForeignKey(i => i.CustomerId) //Khóa phụ
                    .HasPrincipalKey(x => x.CustomerId); //Khóa chính
            base.OnModelCreating(modelBuilder);

            //Tạo khóa phụ db ánh xạ Product với Review
            modelBuilder.Entity<Product>()
                .HasMany(i => i.Review)
                    .WithOne(x => x.Product)
                    .HasForeignKey(i => i.ProductId) //Khóa phụ
                    .HasPrincipalKey(x => x.ProductId); //Khóa chính
            base.OnModelCreating(modelBuilder);
        }
     

    }
}
