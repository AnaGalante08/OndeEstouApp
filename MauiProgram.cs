using Microsoft.Extensions.Logging;
using OndeEstouApp.Services;
using OndeEstouApp.ViewModel;
using OndeEstouApp.Views;

namespace OndeEstouApp
{
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

#if DEBUG
    		builder.Logging.AddDebug();


#endif    //Registrar Views
            builder.Services.AddTransient<LocalViewModel>();
            builder.Services.AddTransient<LocalPage>();

            //Registrar Services
            builder.Services.AddSingleton<IGeoService, GeoService>();


            return builder.Build();
        }
    }
}
