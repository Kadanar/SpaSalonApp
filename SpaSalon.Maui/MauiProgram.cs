using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SpaSalon.Application.Interfaces;
using SpaSalon.Infrastructure;
using SpaSalon.Infrastructure.Data;

namespace SpaSalon.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // EF Core + SQLite
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data Source=spa.db"));

        // UnitOfWork
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
