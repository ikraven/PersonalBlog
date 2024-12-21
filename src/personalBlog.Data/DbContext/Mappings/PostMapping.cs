using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlog.Domain.Models.Posts;

namespace personalBlog.DAta.DbContext.Mappings;

public class PostMapping: IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(u => u.Id); 
        builder.HasOne(u => u.PostContent)
            .WithOne(p => p.Post)
            .HasForeignKey<PostContent>(p => p.PostID);
    }
}