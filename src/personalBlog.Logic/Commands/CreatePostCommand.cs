using MediatR;
using personalBlog.Shared.DTOs.Post;

namespace personalBlog.Logic.Commands;
/// <summary>
/// Comando para crear un post
/// </summary>
public class CreatePostCommand : IRequest<PostViewDetailDTO>
{
    public PostViewDetailDTO ViewDetailDto { get; set; }
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="viewDetailDto">Detalle del post</param>
    public CreatePostCommand(PostViewDetailDTO viewDetailDto)
    {
        ViewDetailDto = viewDetailDto;
    }
    
    public class Handler : IRequestHandler<CreatePostCommand, PostViewDetailDTO>
    {
        
        public Task<PostViewDetailDTO> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}