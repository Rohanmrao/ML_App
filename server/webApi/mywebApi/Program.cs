using myRoutesNS;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        // Routing 
        myRoutesNS.myRoutes.MapImg(app);
        myRoutesNS.myRoutes.MapPrediction(app);

        app.Run();
    }
}