using Microsoft.EntityFrameworkCore;
using NuCaIoMaSinucid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCaIoMaSinucid.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Book> Carti { get; set; }
        public DbSet<Client> Clienti { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; Initial Catalog=Biblioteca; Integrated Security=True");
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Book>()
                .HasOne<Client>()
                .WithMany(c => c.CartiImprumutate);
        }*/
    }
}
