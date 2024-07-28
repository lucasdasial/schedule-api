namespace schedule_api.routes
{
    public static class UserRoutes
    {
       public static void AddUserRoutes( this WebApplication app)
        {
            app.MapGet("/", () => "hello world");
        }
    }
}
