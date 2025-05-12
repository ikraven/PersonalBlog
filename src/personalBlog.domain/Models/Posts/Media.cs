namespace personalBlog.Domain.Models.Posts;

public class Media
{
    
    public Guid PostId { get; set; }
    
    public Post Post { get; set; }
    
    /// <summary>Id de media</summary>
    public Guid Id { get; set; }
    /// <summary>Tipo de fichero</summary>
    public MediaType FileMediaType { get; set; }
    /// <summary>Contenido del fichero</summary>
    public required byte[] FileContent { get; set; }

    

/// <summary>Tipo de fichero</summary>
    public enum MediaType
    {
        Image = 0,
        Video = 1,
        File = 3    
    }
}

