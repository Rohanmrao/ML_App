namespace myRoutes
{
    public static class myRoutes
    {
        public static void MapHome(IEndpointRouteBuilder app)
        {
            app.MapGet("/", () => {

                const string tempStr = "Home page goes here";
                return tempStr;
            });
        }
    }
}