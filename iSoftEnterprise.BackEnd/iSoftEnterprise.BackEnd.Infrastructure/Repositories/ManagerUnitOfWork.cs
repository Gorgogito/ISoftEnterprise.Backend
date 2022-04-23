using iSoftEnterprise.BackEnd.Domain.Common;
using iSoftEnterprise.BackEnd.Infrastructure.Persistence;
using iSoftEnterpriseBackEnd.Application.Contracts.Persistence;
using System.Collections;

namespace iSoftEnterprise.BackEnd.Infrastructure.Repositories
{
  public class ManagerUnitOfWork : IUnitOfWork
  {

    private Hashtable _repositories;
    private readonly ManagerDbContext _context;

    public ManagerUnitOfWork(ManagerDbContext context)
    { _context = context; }

    public async Task<int> Complete()
    { return await _context.SaveChangesAsync(); }

    public void Dispose()
    { _context.Dispose(); }

    public IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel
    {
      if (_repositories == null)
      { _repositories = new Hashtable(); }
      var type = typeof(TEntity);
      if (!_repositories.ContainsKey(type))
      {
        var repositoryType = typeof(ManagerRepositoryBase<>);
        var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)));
        _repositories.Add(type, repositoryInstance);
      }

      return (IAsyncRepository<TEntity>)_repositories[type];

    }
  }

}
