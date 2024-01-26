using App.Context.Migrations;
using App.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App.Context
{
	public class StoreContext :DbContext
	{
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-H2HR40I;Initial Catalog=Eclat;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
			optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Eclat;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
=========
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-H2HR40I;Initial Catalog=Eclat;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
>>>>>>>>> Temporary merge branch 2
			optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Eclat;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
=========
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-H2HR40I;Initial Catalog=Eclat;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
>>>>>>>>> Temporary merge branch 2
		}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.Entity<ProductOrder>()
		   .HasKey(po => new { po.ProductID, po.OrderID });

			modelBuilder.Entity<ProductOrder>()
				.HasOne(po => po.Product)
				.WithMany(p => p.OrderProducts)
				.HasForeignKey(po => po.ProductID);

			modelBuilder.Entity<ProductOrder>()
				.HasOne(po => po.Order)
				.WithMany(o => o.OrderProducts)
				.HasForeignKey(po => po.OrderID)
				.OnDelete(DeleteBehavior.Cascade);


			modelBuilder.Entity<Product>()
				.HasOne(p => p.Category)
				.WithMany(c => c.Products)
				.HasForeignKey(p => p.CategoryID)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder.Entity<Product>()
			  .Property(p => p.Price)
			  .HasColumnType("decimal(18,2)")
			  .IsRequired();

			modelBuilder.Entity<Order>()
				.HasOne(o => o.User)
				.WithMany(u => u.Orders)
				.HasForeignKey(o => o.UserID)
				.OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
                .HasOne(o => o.User)
                .WithMany(u => u.Categories)
                .HasForeignKey(o => o.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Cart>()
				.HasKey(c => c.ShoppingCartID);

			modelBuilder.Entity<Cart>()
				.HasOne(c => c.User)
				.WithOne(u => u.Cart)
				.HasForeignKey<Cart>(c => c.UserID);

            modelBuilder.Entity<CartProducts>()
           .HasKey(po => new { po.ProductID, po.CartID });

            modelBuilder.Entity<CartProducts>()
                .HasOne(po => po.Product)
                .WithMany(p => p.Carts)
                .HasForeignKey(po => po.ProductID);

            modelBuilder.Entity<CartProducts>()
                .HasOne(po => po.Cart)
                .WithMany(o => o.Products)
                .HasForeignKey(po => po.CartID)
                .OnDelete(DeleteBehavior.Cascade);




            base.OnModelCreating(modelBuilder);
		}
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<Category> Categorys { get; set; }
		public virtual DbSet<Cart> Carts { get; set; }
		public DbSet<ProductOrder> ProductOrders { get; set; }
		public DbSet<CartProducts> CartProducts { get; set; }
	}
}
