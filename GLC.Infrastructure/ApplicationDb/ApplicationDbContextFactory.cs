using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace GLC.Infrastructure.ApplicationDb
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Use your SQL Server connection string here
            optionsBuilder.UseSqlServer(
                "Server=.;Initial Catalog=GLC;User ID=sa;Password=YourStrongPassword;Encrypt=True;TrustServerCertificate=True"
            );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
