using personalBlog.Shared.DTOs;
using personalBlog.Shared.DTOs.Post;

namespace personalBlog.Web.Client.Services.Post;

public interface IPostService
{
    /// <summary>
    /// Devuelve los detalles de un post dado su ID
    /// </summary>
    /// <param name="id">Id a buscar</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<PostViewDetailDTO> GetPostByIdAsync(Guid id, CancellationToken cancellationToken);
    /// <summary>
    /// Devuelve los post creados paginado
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<ListPaged<PostListDto>> GetPostsAsync(CancellationToken cancellationToken);
    /// <summary>
    /// Crea un post
    /// </summary>
    /// <param name="post">Post a crear</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Devuelve el post creado</returns>
    ValueTask<PostViewDetailDTO?> CreatePostAsync(PostViewDetailDTO post, CancellationToken cancellationToken);
}