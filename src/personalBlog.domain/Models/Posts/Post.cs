using System;
using personalBlog.domain.Models;

namespace personalBlog.Domain.Models.Posts;

public class Post : IEntityBase
{
    /// <summary>
    /// Id del post
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Nombre del post
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
    public required PostContent PostContent { get; set; }
    /// <summary>
    /// Media del post
    /// </summary>
    public List<Media> PostMedia { get; set; } = [];
    /// <summary>
    /// Categorías del Post
    /// </summary>
    public List<Tags> PostTags { get; set; } = [];
    
    /// <summary>
    /// Estado del post
    /// </summary>
    public required PostStatus Status { get; set; }
    
    /// <summary>
    /// Estado del post
    /// </summary>
    public enum PostStatus
    {
        Published,
        Draft,
    }

}
