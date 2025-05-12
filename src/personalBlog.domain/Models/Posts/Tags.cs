using System;

namespace personalBlog.Domain.Models.Posts;

/// <summary>Categorías de los posts</summary>
public class Tags(string title)
{
    /// <summary>Id del tag</summary>
    public Guid Id { get; set; }
    /// <summary>Título de el tag</summary>
    public string Title { get; set; } = title;
}
