using iSoftEnterprise.BackEnd.Domain.Common;
using iSoftEnterprise.BackEnd.Domain.Enterprise;
using Microsoft.EntityFrameworkCore;

namespace iSoftEnterprise.BackEnd.Infrastructure.Persistence
{
  public class EnterpriseDbContext : DbContext
  {

    public EnterpriseDbContext(DbContextOptions<ManagerDbContext> options) : base(options)
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

    public DbSet<Sucursal>? Sucursales { get; set; }

  }

}
