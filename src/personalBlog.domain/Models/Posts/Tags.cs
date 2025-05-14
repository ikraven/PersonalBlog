using System;
using personalBlog.domain.Models;

namespace personalBlog.Domain.Models.Posts;

/// <summary>Categorías de los posts</summary>
public class Tags(string title) : IEntityBase
{
    /// <summary>Id del tag</summary>
    public Guid Id { get; set; }
    /// <summary>Título de el tag</summary>
    public string Title { get; set; } = title;
    
    public List<PostTag> PostTags { get; set; } = [];

    /// <summary>Estado de la categoría</summary>
    public Common.BaseStatus Status { get; set; }
}
