using schedule_api.routes;

namespace schedule_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateSlimBuilder(args);
          
            var app = builder.Build();

            app.AddUserRoutes();

            app.Run();
        }
    }

   
}
