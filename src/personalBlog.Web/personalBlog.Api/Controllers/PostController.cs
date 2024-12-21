using System.Net;
using Microsoft.AspNetCore.Mvc;
using personalBlog.Data.Repositories.Posts;
using personalBlog.Domain.Models.Posts;

namespace personalBlog.Api.Controllers;

[ApiController]
/// <summary>Endpoints utilizados para gestionar los convenios de los periodos.</summary>
[Route("api/blog/posts")]
public class PostController : ControllerBase
{
    private readonly IPostsRepository _postsRepositorty;
    
    public PostController(IPostsRepository postsRepositorty)
    {
        _postsRepositorty = postsRepositorty;
    }
    
    /// <summary>Listado de convenios y tipos de ausencias para el periodo</summary>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Post>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetPosts(CancellationToken cancellationToken = default)
    {
        IEnumerable<Post> posts = await _postsRepositorty.GetAllPostsAsync(cancellationToken);
        return Ok(posts);
    }
}