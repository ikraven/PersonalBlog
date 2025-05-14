using System.Net.Http.Json;

namespace personalBlog.Web.Client.Services.Tags;

public class TagService : ITagService
{
    private readonly HttpClient _httpClient;
    public TagService(HttpClient httpClient)
    {
     _httpClient = httpClient;     
    }
    public async ValueTask<List<KeyValuePair<Guid, string>>> GetTagsAsync(CancellationToken cancellationToken)
    {
        var response = await _httpClient.GetFromJsonAsync<List<KeyValuePair<Guid, string>>>(ApiRoutes.ApiRoutes.TagList, cancellationToken: cancellationToken);
        
        return response ?? [];
    }
}