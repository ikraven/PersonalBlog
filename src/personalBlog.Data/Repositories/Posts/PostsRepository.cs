using Microsoft.EntityFrameworkCore;
using personalBlog.DAta.DbContext;
using personalBlog.Domain.Models.Posts;
using personalBlog.Shared.DTOs;
using personalBlog.Shared.DTOs.Post;

namespace personalBlog.Data.Repositories.Posts;

public class PostsRepository : Repository<Post>, IPostsRepository
{
    public PostsRepository(BlogDbContext dbContext): base(dbContext) { }
    
    public async ValueTask<List<Post>> GetAllPostsAsync(CancellationToken cancellationToken = default)
    {
        var data = await GetQueryable().AsNoTracking().ToListAsync(cancellationToken);
        
        return data;
    }

    public async ValueTask<PostViewDetailDTO> GetViewPostByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var data = await GetQueryable().AsNoTracking()
            .Include(q => q.PostTags)
            .Include(q => q.PostContent)
            .Select(s => new PostViewDetailDTO()
            {
                Id = s.Id,
                PostTitle = s.PostTitle,
                PostContent = s.PostContent.Content,
                PostTags = s.PostTags.Count > 0 ? s.PostTags.Select(t => t.Title).ToList() : new List<string> { },
                CreateDate = s.CreateDate,
                ReadingTime = s.ReadingTime,
                PublishDate = s.PublishDate,
                
            }).FirstOrDefaultAsync(cancellationToken);
        
        return data;
    }

    public async ValueTask<ListPaged<PostListDto>> GetPostsByCategoryIdAsync(int startRow, int size, CancellationToken cancellationToken = default)
    {
        var query = GetQueryable()
            .AsNoTracking()
            .OrderByDescending(o => o.PublishDate)
            .Select(s => new PostListDto()
            {
                PostName = s.PostTitle,
                PostPublishDate = s.PublishDate,
                Status = s.Status.ToString(),
            });
        var count = await query.CountAsync(cancellationToken);
        var list = await query.Skip(startRow).Take(size).ToListAsync(cancellationToken);

        return new ListPaged<PostListDto>(list, count);
    }
}