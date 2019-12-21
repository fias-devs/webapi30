using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WebApiCore30.Models;

namespace WebApiCore30.Repository
{


    public interface IStudentRepository
    {
        List<Studenti> GetAll();
        void AddNew(Studenti student);
    }
    public class StudentRepository : IStudentRepository
    {
        DLWMSContext _db;
        public StudentRepository()
        {

            var builder = new DbContextOptionsBuilder<DLWMSContext>();
            //var connectionString = configuration.GetConnectionString("FIADbConnection");
            builder.UseSqlServer("server=.;database=DLWMSFia;Integrated Security=True");
            //return new DLWMSContext(builder.Options);

            _db = new DLWMSContext(builder.Options);
        }

        public void AddNew(Studenti student)
        {
            throw new NotImplementedException();
        }

        public List<Studenti> GetAll()
        {
            throw new NotImplementedException();
        }
    }


    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DLWMSContext>
    {

        public DLWMSContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../WebApiCore30/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<DLWMSContext>();
            var connectionString = configuration.GetConnectionString("FIADbConnection");
            builder.UseSqlServer(connectionString);
            return new DLWMSContext(builder.Options);
        }
    }
}
