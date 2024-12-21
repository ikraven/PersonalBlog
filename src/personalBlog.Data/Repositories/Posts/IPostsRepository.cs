using personalBlog.Domain.Models.Posts;
using personalBlog.Shared.DTOs.Post;

namespace personalBlog.Data.Repositories.Posts;

public interface IPostsRepository : IRepository<Post>
{
    ValueTask<List<Post>> GetAllPostsAsync(CancellationToken cancellationToken = default);
    
    ValueTask<PostViewDetailDTO> GetViewPostByIdAsync(int id, CancellationToken cancellationToken = default);
}