using personalBlog.domain.Models;

namespace personalBlog.Domain.Models.Posts;

public class PostTag: IEntityBase
{
    /// <summary>
    /// Id entidad
    /// </summary>
    public Guid Id { get; set; }
    public Guid PostId { get; set; }
    public Post Post { get; set; }

    public Guid TagId { get; set; }
    public Tags Tag { get; set; }
}