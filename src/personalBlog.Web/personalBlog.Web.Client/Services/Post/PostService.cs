using System.Net.Http.Json;
using personalBlog.Shared.DTOs;
using personalBlog.Shared.DTOs.Post;

namespace personalBlog.Web.Client.Services.Post;

public class PostService : IPostService
{
    private readonly HttpClient _httpClient;

    public PostService(HttpClient httpClient)
    {
        _httpClient = httpClient;   
        
    }
    public ValueTask<PostViewDetailDTO> GetPostByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ListPaged<PostListDto>> GetPostsAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<PostViewDetailDTO?> CreatePostAsync(PostViewDetailDTO post, CancellationToken cancellationToken)
    {
        // Ejemplo POST
        var response = await _httpClient.PostAsJsonAsync<PostViewDetailDTO>(ApiRoutes.ApiRoutes.PostCreate, post, cancellationToken: cancellationToken);
        
        if(!response.IsSuccessStatusCode)
            return null;
        
        return await response.Content.ReadFromJsonAsync<PostViewDetailDTO>(cancellationToken: cancellationToken);
    }
}