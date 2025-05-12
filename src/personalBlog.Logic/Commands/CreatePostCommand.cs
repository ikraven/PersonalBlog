using MediatR;
using personalBlog.Data.Repositories.Posts;
using personalBlog.Domain.Models.Posts;
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
        private readonly TimeProvider _timeProvider;
        private readonly IPostsRepository _postsRepository;

        public Handler(TimeProvider timeProvider, IPostsRepository postsRepository)
        {
            _timeProvider = timeProvider;
            _postsRepository = postsRepository;
        }

        public async Task<PostViewDetailDTO> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var postView = request.ViewDetailDto;

            ValidateData(postView);

            var postId = Guid.NewGuid();

            // Creamos las tags
            var tags = postView.PostTags.Select(s => new Tags(s)).ToList();

            var content = new PostContent(request.ViewDetailDto.PostContent, postId);

            var postToCreate = new Post()
            {
                Id = postId,
                Status = Post.PostStatus.Draft,
                CreateDate = _timeProvider.GetLocalNow().DateTime,
                PostTags = tags,
                PostContent = content,
                PostTitle = request.ViewDetailDto.PostTitle,
            };

            _postsRepository.Add(postToCreate);

            await _postsRepository.SaveChangesAsync(cancellationToken);

            postView.Id = postToCreate.Id;
            postView.CreateDate = postToCreate.CreateDate;
            
            return postView;
        }
    }

    /// <summary>
    /// Validamos los datos del post
    /// </summary>
    /// <param name="viewDetailDto">Datos post</param>
        private static void ValidateData(PostViewDetailDTO viewDetailDto)
        {
            ArgumentNullException.ThrowIfNull(viewDetailDto);

            if (viewDetailDto is null)
                throw new Exception("No puede haber post sin contenido");
            
            if(viewDetailDto.PostTags is null || viewDetailDto.PostTags.Count == 0)
                throw new Exception("No puede haber post sin tags");
            
           
            
        }
 }
