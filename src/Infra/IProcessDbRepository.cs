using CaseProcess.Core.Entities;

namespace CaseProcess.Infra.Context;

public interface IProcessDbRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll();
    Task<T?> GetByIdAsync(int id);
    Task InsertAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}