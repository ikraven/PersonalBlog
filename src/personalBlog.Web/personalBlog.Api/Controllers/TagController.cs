using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using personalBlog.Data.Repositories.Posts;
using personalBlog.Domain.Models.Posts;
using personalBlog.Logic.Commands;
using personalBlog.Shared.DTOs.Post;

namespace personalBlog.Api.Controllers;

[ApiController]
/// <summary>Endpoints utilizados para gestionar los convenios de los periodos.</summary>
[Route("api/blog/tags")]
public class TagController(IMediator mediator) : BlogBaseController(mediator)
{
    private readonly IMediator _mediator = mediator;

    /// <summary>Devuelve los tags</summary>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Post>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetTags(CancellationToken cancellationToken = default)
    {
        return Ok();
    }
    /// <summary>Crea un post</summary>
    [HttpPost]
    [ProducesResponseType(typeof(PostViewDetailDTO), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> CreatePost([FromBody] PostViewDetailDTO postViewDetailDto,CancellationToken cancellationToken = default)
    {
        var response = await _mediator.Send(new CreatePostCommand(postViewDetailDto), cancellationToken);   
        return Ok(response);
    }
}