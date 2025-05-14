using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using personalBlog.Domain.Models.Posts;

namespace personalBlog.DAta.DbContext.Mappings;

public class PostTagMapping: IEntityTypeConfiguration<PostTag>
{
    public void Configure(EntityTypeBuilder<PostTag> modelBuilder)
    {
        modelBuilder.HasKey(pt => new { pt.PostId, pt.TagId });

        modelBuilder
            .HasOne(pt => pt.Post)
            .WithMany(p => p.PostTags)
            .HasForeignKey(pt => pt.PostId);

        modelBuilder
            .HasOne(pt => pt.Tag)
            .WithMany(t => t.PostTags)
            .HasForeignKey(pt => pt.TagId);
    }
}