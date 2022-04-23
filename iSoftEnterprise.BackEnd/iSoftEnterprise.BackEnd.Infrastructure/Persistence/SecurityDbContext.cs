using iSoftEnterprise.BackEnd.Domain.Common;
using iSoftEnterprise.BackEnd.Domain.Security;
using Microsoft.EntityFrameworkCore;

namespace iSoftEnterprise.BackEnd.Infrastructure.Persistence
{
  public class SecurityDbContext : DbContext
  {

    public SecurityDbContext(DbContextOptions<ManagerDbContext> options) : base(options)
    {
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
      foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
      {
        switch (entry.State)
        {
          case EntityState.Added:
            entry.Entity.FechaHoraRegistro = DateTime.Now;
            entry.Entity.Index_UserRegistro = 0;
            break;

          case EntityState.Modified:
            entry.Entity.FechaHoraModificacion = DateTime.Now;
            entry.Entity.Index_UserModificacion = 0;
            break;
        }
      }

      return base.SaveChangesAsync(cancellationToken);
    }

    public DbSet<Role>? Roles { get; set; }
    public DbSet<User>? Users { get; set; }

  }

}
