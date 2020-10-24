using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CardApplication.DataAccess
{
    class DesignTimeDbContextImplementation
    {
        public class DesignTimeServiceDeskDbContextFactory : IDesignTimeDbContextFactory<CardApplicationDbContext>
        {
            public CardApplicationDbContext CreateDbContext(string[] args)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var builder = new DbContextOptionsBuilder<CardApplicationDbContext>();

                builder.UseSqlServer(configuration["ConnectionStrings:CardAppCOnnect"]);

                return new CardApplicationDbContext(builder.Options);
            }
        }
    }
}
