using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OrgAE.NexusCrafter.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class NexusCrafterDbContextFactory : IDesignTimeDbContextFactory<NexusCrafterDbContext>
{
    public NexusCrafterDbContext CreateDbContext(string[] args)
    {
        NexusCrafterEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<NexusCrafterDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new NexusCrafterDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../OrgAE.NexusCrafter.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
