using iSoftEnterprise.BackEnd.Domain.Common;
using iSoftEnterprise.BackEnd.Infrastructure.Persistence;
using iSoftEnterpriseBackEnd.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace iSoftEnterprise.BackEnd.Infrastructure.Repositories
{
  public class EnterpriseRepositoryBase<T> : IAsyncRepository<T> where T : BaseDomainModel
  {
    protected readonly EnterpriseDbContext _context;

    public EnterpriseRepositoryBase(EnterpriseDbContext context)
    { _context = context; }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    { return await _context.Set<T>().ToListAsync(); }
  

    public virtual async Task<T> GetByIdAsync(int id)
    { return await _context.Set<T>().FindAsync(); }

    public async Task<T> AddAsync(T entity)
    {
      _context.Set<T>().Add(entity);
      await _context.SaveChangesAsync();
      return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
      _context.Set<T>().Attach(entity);
      _context.Entry(entity).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return entity;
    }

    public async Task DeleteAsync(T entity)
    {
      _context.Set<T>().Remove(entity);
      await _context.SaveChangesAsync();
    }

    public void AddEntity(T entity)
    { _context.Set<T>().Add(entity); }

    public void UpdateEntity(T entity)
    {
      _context.Set<T>().Attach(entity);
      _context.Entry(entity).State = EntityState.Modified;
    }

    public void DeleteEntity(T entity)
    { _context.Set<T>().Remove(entity); }

    public Task<T> GetByIdAsync(long Id_Index)
    {
      throw new NotImplementedException();
    }

    public Task<T> GetByFieldAsync(string NameField, string ValueField, bool IsLike)
    {
      throw new NotImplementedException();
    }

    public List<T> GetAll()
    {
      throw new NotImplementedException();
    }

    public List<T> GetById(long Id_Index)
    {
      throw new NotImplementedException();
    }

    public List<T> GetByField(string NameField, string ValueField, bool IsLike)
    {
      throw new NotImplementedException();
    }
  }

}
