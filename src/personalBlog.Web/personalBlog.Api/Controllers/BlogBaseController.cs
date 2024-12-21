using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace personalBlog.Api.Controllers;

public abstract class BlogBaseController  : ControllerBase
{
    
    /// <summary>Mediator</summary>
    protected readonly IMediator _mediator;

    /// <summary>Constructor</summary>
    protected BlogBaseController(IMediator mediator)
    {
        _mediator = mediator;
    }
}