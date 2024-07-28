namespace schedule_api.routes
{
    public static class UserEndpoint
    {
       public static void AddUserRoutes( this WebApplication app)
        {
            app.MapGet("/", () => "hello world");
        }
    }
}
