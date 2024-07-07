using CaseProcess.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CaseProcess.Infra.Context;

public abstract class ProcessDbRepository<T> : IProcessDbRepository<T> where T : BaseEntity
{
    private readonly ProcessDbContext _dbContext;
    protected readonly DbSet<T> Table;

    protected ProcessDbRepository(ProcessDbContext dbContext)
    {
        _dbContext = dbContext;
        Table = dbContext.Set<T>();
    }

    public virtual IQueryable<T> GetAll()
    {
        return _dbContext
            .Set<T>()
            .AsQueryable();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _dbContext.Set<T>()
            .FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task InsertAsync(T entity)
    {
        await _dbContext
            .Set<T>()
            .AddAsync(entity);

        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _dbContext
            .Set<T>()
            .Update(entity);

        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _dbContext
            .Set<T>()
            .Remove(entity);

        await _dbContext .SaveChangesAsync();
    }
}