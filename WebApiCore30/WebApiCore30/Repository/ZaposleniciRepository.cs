using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WebApiCore30.Models;
using System.Linq;

namespace WebApiCore30.Repository
{


    public interface IZaposleniciRepository
    {
        List<Zaposlenici> GetAll();
        void AddNew(Zaposlenici student);
    }
    public class ZaposleniciRepository : IZaposleniciRepository
    {
        FIADevOpsContext _db;
        public ZaposleniciRepository()
        {

            var builder = new DbContextOptionsBuilder<FIADevOpsContext>();
            //var connectionString = configuration.GetConnectionString("FIADbConnection");
            builder.UseSqlServer("server=.;database=FIADevOPS;Integrated Security=True");
            //return new DLWMSContext(builder.Options);

            _db = new FIADevOpsContext(builder.Options);
        }

        public void AddNew(Zaposlenici zaposlenik)
        {
            throw new NotImplementedException();
        }

        public List<Zaposlenici> GetAll()
        {
            return _db.Zaposlenici.ToList();
        }
    }


    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<FIADevOpsContext>
    {

        public FIADevOpsContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../WebApiCore30/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<FIADevOpsContext>();
            var connectionString = configuration.GetConnectionString("webapicore.dev.db.connectionstring");
            builder.UseSqlServer(connectionString);
            return new FIADevOpsContext(builder.Options);
        }
    }
}
