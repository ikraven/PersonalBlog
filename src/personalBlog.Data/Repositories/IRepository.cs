namespace personalBlog.Data.Repositories;

public interface IRepository<IEntityBase> where IEntityBase : class
{
    /// <summary>
    /// Obtiene un elemento por clave, trackeable
    /// </summary>
    /// <param name="id">Id a buscar</param>
    /// <param name="cancellationToken">Token de cancelación</param>
    /// <returns></returns>
    Task<IEntityBase> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Obtiene un elemento por clave, no trackeable
    /// </summary>
    /// <param name="id">Id a buscar</param>
    /// <param name="cancellationToken">Token de cancelación</param>
    /// <returns></returns>
    Task<IEntityBase> GetByIdNoTrackingAsync(Guid id, CancellationToken cancellationToken = default);
    
}