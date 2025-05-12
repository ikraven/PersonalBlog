using MediatR;

namespace personalBlog.Logic.Queries.Tags;

public class GetTagsQuery : IRequest<List<string>>
{


    public class Handler : IRequestHandler<GetTagsQuery, List<string>>
    {
        public Handler()
        {
            
        }
        public Task<List<string>> Handle(GetTagsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}