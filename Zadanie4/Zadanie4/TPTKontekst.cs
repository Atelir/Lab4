using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Zadanie4
{
    class TPTKontekst : DbContext
    {
        public DbSet<Osoba> Osoby { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pracownik>().ToTable("Workers");
            modelBuilder.Entity<Klient>().ToTable("Clients");
        }


    }
}
