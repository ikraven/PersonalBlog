namespace personalBlog.Data.Repositories.Tags;

public interface ITagRepository : IRepository<Domain.Models.Posts.Tags>
{
    /// <summary>
    /// Devuelve los tags activos
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>Id Nombre tags</returns>
    ValueTask<List<KeyValuePair<Guid,string>>> GetActiveTagsAsync(CancellationToken cancellationToken = default);
}