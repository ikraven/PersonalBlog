using Microsoft.EntityFrameworkCore;
using personalBlog.DAta.DbContext;
using personalBlog.domain.Models;

namespace personalBlog.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class , IEntityBase
{
    /// <summary>
    /// Acceso al contexto a clases que hereden
    /// </summary>
    private readonly BlogDbContext _context;

    /// <summary>Constructor</summary>
    protected Repository(BlogDbContext context) => _context = context;
    
    /// <inheritdoc/>
    protected IQueryable<TEntity> GetQueryable()
    {
        return _context.Set<TEntity>().AsQueryable();
    }
    /// <inheritdoc/>
    public Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return GetQueryable().FirstAsync(q => q.Id.Equals(id), cancellationToken );
    }
    /// <inheritdoc/>
    public Task<TEntity> GetByIdNoTrackingAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return GetQueryable().AsNoTracking().FirstAsync(q => q.Id.Equals(id), cancellationToken );

    }
}