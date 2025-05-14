using personalBlog.Data.Repositories.Posts;
using personalBlog.Data.Repositories.Tags;

namespace personalBlog.Api.DependenciInjection;

public static class ServiceExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        // Ejemplo de registro de servicios
        services.AddScoped<IPostsRepository, PostsRepository>();
        services.AddScoped<ITagRepository, TagRepository>();
    }
}