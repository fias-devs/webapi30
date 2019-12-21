using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiCore30.Models;

namespace WebApiCore30
{
    public class DLWMSContext : DbContext
    {

        public DLWMSContext(DbContextOptions<DLWMSContext> options) : base(options)
        {

        }
        public DbSet<Studenti> Studentis { get; set; }
    }
}
