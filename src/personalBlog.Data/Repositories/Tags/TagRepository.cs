using Microsoft.EntityFrameworkCore;
using personalBlog.DAta.DbContext;
using personalBlog.domain.Models;

namespace personalBlog.Data.Repositories.Tags;

public class TagRepository : Repository<Domain.Models.Posts.Tags>, ITagRepository
{
    public TagRepository(BlogDbContext context) : base(context)
    {
    }

    ///<inheritdoc />
    public async ValueTask<List<KeyValuePair<Guid,string>>> GetActiveTagsAsync(CancellationToken cancellationToken = default)
    {
        var tags = await GetQueryable().
            Where(q => q.Status == Common.BaseStatus.Active)
            .Select(s => new KeyValuePair<Guid,string>(s.Id, s.Title))
            .ToListAsync(cancellationToken);
        return tags; 
    }
}