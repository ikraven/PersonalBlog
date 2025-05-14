namespace personalBlog.Web.Client.ApiRoutes;

public  static class ApiRoutes
{
    #region Posts
    public static string PostCreate => "/api/blog/posts";
    #endregion
    
    #region Tags
    public static string TagCreate => "/api/blog/tags";
    public static string TagList => "/api/blog/tags";
    #endregion
}