using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagementProject.Models
{
    
    public class BooksDbContext : DbContext
    {
        // avr Sql Cooncetion
        SqlConnection Connection = new SqlConnection();
        SqlCommand commandd = new SqlCommand();


        public DbSet<Books> books { get; set; }
        public DbSet<Authers> authers { get; set; }

        public DbSet<Categories> categories { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<CustomersBooks> customersBooks { get; set; }
        public DbSet<Users> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BooStorge;Trusted_Connection=True;");
            //"Server=(localdb)\\MSSQLLocalDB;Database=NewSchoolDB;Trusted_Connection=True;"
            //    options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\30698\source\repos\EntityFrameWorkCore\EntityFrameWorkCore\NewShcoolDB.mdf;Integrated Security=True");
        }
            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Authers>(entity =>
            {
                entity.HasKey(e => e.AutherId);
                // Other configurations if needed
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.HasOne(e => e.categorie)
                    .WithMany(c => c.books)
                    .HasForeignKey(e => e.CategorieId);

                entity.HasOne(e => e.authers)
                    .WithMany(a => a.books)
                    .HasForeignKey(e => e.AutherId);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategorieId);
                // Other configurations if needed
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);
                // Other configurations if needed
            });

            modelBuilder.Entity<CustomersBooks>(entity =>
            {
                entity.HasKey(e => e.CustomersBookId);

                entity.HasOne(e => e.books)
                    .WithMany(b => b.customersBooks)
                    .HasForeignKey(e => e.BookId);

                entity.HasOne(e => e.customers)
                    .WithMany(c => c.customersBooks)
                    .HasForeignKey(e => e.CustomerId);
            });

         //   modelBuilder.Entity<Books>().Property(b => b.ImagePath).HasColumnType("varbinary(max)");
        }
    }
}











