
namespace ECommerceAPI.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Projenin environment deðerine bakarak canlý-test çalýþma sürecinin ayrýþtýrýlmasý.
            var env = builder.Environment; // LaunchSettings.json'daki ASPNETCORE_ENVIRONMENT deðerini alýr. Bu deðer OpenContainin Folder deyince açýlan dosya yoludur.

            builder.Configuration
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}