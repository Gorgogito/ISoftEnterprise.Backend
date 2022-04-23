using iSoftEnterprise.BackEnd.Domain.Common;

namespace iSoftEnterpriseBackEnd.Application.Contracts.Persistence
{
  public interface IUnitOfWork : IDisposable
  {

    IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel;

    Task<int> Complete();
  }
}
