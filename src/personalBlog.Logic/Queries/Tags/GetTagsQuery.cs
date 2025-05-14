using MediatR;
using personalBlog.Data.Repositories.Tags;

namespace personalBlog.Logic.Queries.Tags;

/// <summary>
/// Devuelve un listado de tags disponibles
/// </summary>
public class GetTagsQuery : IRequest<List<string>>
{


    public class Handler : IRequestHandler<GetTagsQuery, List<string>>
    {
        private readonly ITagRepository _tagRepository;
        public Handler(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        
        public Task<List<string>> Handle(GetTagsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}