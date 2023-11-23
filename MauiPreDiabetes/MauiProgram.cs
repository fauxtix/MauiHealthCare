using MauiPreDiabetes.Handlers;
using MauiPreDiabetes.Pages;
using Microsoft.Extensions.Logging;




namespace MauiPreDiabetes
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
            FormHandler.RemoveBorders();
            builder.Services.AddSingleton<PreDiabetesIntroPage>();
            builder.Services.AddSingleton<PreDiabetesPage>();
            return builder.Build();
        }
    }
}
