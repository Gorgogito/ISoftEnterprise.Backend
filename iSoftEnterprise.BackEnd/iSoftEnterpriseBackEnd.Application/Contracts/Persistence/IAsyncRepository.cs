using iSoftEnterprise.BackEnd.Domain.Common;
using System.Linq.Expressions;

namespace iSoftEnterpriseBackEnd.Application.Contracts.Persistence
{
  public interface IAsyncRepository<T> where T : BaseDomainModel
  {

    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> GetByIdAsync(long Id_Index);
    Task<T> GetByFieldAsync(string NameField, string ValueField, bool IsLike);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);

    List<T> GetAll();
    List<T> GetById(long Id_Index);
    List<T> GetByField(string NameField, string ValueField, bool IsLike);
    void AddEntity(T Entity);
    void UpdateEntity(T Entity);
    void DeleteEntity(T Entity);

  }
}
