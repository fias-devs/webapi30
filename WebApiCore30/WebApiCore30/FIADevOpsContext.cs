using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiCore30.Models;

namespace WebApiCore30
{
    public class FIADevOpsContext : DbContext
    {

        public FIADevOpsContext(DbContextOptions<FIADevOpsContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zaposlenici>().HasData(
                new Zaposlenici() { Id = 1, Ime = "Denis", Prezime = "Music", JMBG = "13256465489789"},
                new Zaposlenici() { Id = 2, Ime = "Jasmin", Prezime = "Azemovic", JMBG = "13256465489788" }
            );
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Zaposlenici> Zaposlenici { get; set; }
    }
}
