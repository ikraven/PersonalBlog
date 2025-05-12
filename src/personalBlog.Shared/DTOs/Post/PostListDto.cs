namespace personalBlog.Shared.DTOs.Post;


/// <summary>
/// Dto con datos mínimos de post para listados
/// </summary>
public class PostListDto
{
    /// <summary>
    /// Nombre del Post
    /// </summary>
    public string PostName { get; set; }

    /// <summary>
    /// Fecha de publicación
    /// </summary>
    public DateTime PostPublishDate { get; set; }

    /// <summary>
    /// Estado del post
    /// </summary>
    public string Status { get; set; }
}