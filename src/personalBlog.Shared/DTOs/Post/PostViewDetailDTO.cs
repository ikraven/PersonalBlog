namespace personalBlog.Shared.DTOs.Post;

/// <summary>
/// Dto de vista de un post, para la pantalla general
/// </summary>
public class PostViewDetailDTO
{
    /// <summary>
    /// Id del post
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Id del post
    /// </summary>
    public required string PostTitle { get; set; }
    /// <summary>
    /// Fecha de publicación del post
    /// </summary>
    public DateTime PublishDate { get; set; }
    /// <summary>
    /// Fecha de creación del post
    /// </summary>
    public DateTime CreateDate { get; set; }
    /// <summary>
    /// Tiempo estimado de lectura del post
    /// </summary>
    public int ReadingTime { get; set; }
    /// <summary>
    /// Contenido del post.
    /// Markdown
    /// </summary>
    public required string PostContent { get; set; }
    /// <summary>
    /// Categorías del Post
    /// </summary>
    public List<string> PostTags { get; set; } = [];

}