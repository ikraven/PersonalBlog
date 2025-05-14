namespace personalBlog.Web.Client.Services.Tags;

public interface ITagService
{
    /// <summary>
    /// Devuelve las tags
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>Guid String tags</returns>
    ValueTask<List<KeyValuePair<Guid,string>>> GetTagsAsync(CancellationToken cancellationToken);
}