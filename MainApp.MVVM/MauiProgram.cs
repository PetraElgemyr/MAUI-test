using MainApp.MVVM.Pages;
using MainApp.MVVM.ViewModels;
using Microsoft.Extensions.Logging;

namespace MainApp.MVVM
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
#endif
            // Glöm ej att registrera mina services!!! 
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();


            return builder.Build();
        }
    }
}
