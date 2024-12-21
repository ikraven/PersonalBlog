using MediatR;
using personalBlog.Data.Repositories.Posts;
using personalBlog.Shared.DTOs.Post;

namespace personalBlog.Logic.Queries.Posts;

public class GetPostByIdQuery : IRequest<PostViewDetailDTO>
{
  public Guid PostId { get; set; }

  public GetPostByIdQuery(Guid postId)
  {
    PostId = postId;
  }
  
  public class Handler : IRequestHandler<GetPostByIdQuery, PostViewDetailDTO>
  {
    private readonly IPostsRepository _postRepository;
    
    public Handler(IPostsRepository postRepository)
    {
      _postRepository = postRepository;
    }
    
    
    public Task<PostViewDetailDTO> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
    {
      
      throw new NotImplementedException();
    }
  }
}