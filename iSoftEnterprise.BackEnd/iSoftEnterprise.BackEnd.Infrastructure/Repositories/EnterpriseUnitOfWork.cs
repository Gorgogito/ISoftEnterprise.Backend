using iSoftEnterprise.BackEnd.Domain.Common;
using iSoftEnterprise.BackEnd.Infrastructure.Persistence;
using iSoftEnterpriseBackEnd.Application.Contracts.Persistence;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSoftEnterprise.BackEnd.Infrastructure.Repositories
{
  public class EnterpriseUnitOfWork : IUnitOfWork
  {

    private Hashtable _repositories;
    private readonly EnterpriseDbContext _context;

    public EnterpriseUnitOfWork(EnterpriseDbContext context)
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
