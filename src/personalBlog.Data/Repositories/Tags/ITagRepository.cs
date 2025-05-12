namespace personalBlog.Data.Repositories.Tags;

public interface ITagRepository : IRepository<Domain.Models.Posts.Tags>
{
    ValueTask<List<int>> GetActiveTagsAsync(CancellationToken cancellationToken = default);
}