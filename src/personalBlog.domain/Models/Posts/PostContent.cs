namespace personalBlog.Domain.Models.Posts;

/// <summary>
/// Contenido del post
/// </summary>
/// <param name="content"></param>
public class PostContent
{
    public PostContent(string content, Guid postId)
    {
        if (content == null || string.IsNullOrWhiteSpace(content))
            throw new Exception("No puede haber contenido vacío");
        Content = content;
        PostId = postId;
    }
    
    public Guid Id { get; set; }
    public Guid PostId { get; set; }
    public Post? Post { get; set; }
    public string Content { get; init; }
}
