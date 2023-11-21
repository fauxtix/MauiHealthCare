using FraminghamRiskScore.Pages;
using Microsoft.Extensions.Logging;
using FraminghamRiskScore.Handlers;


namespace FraminghamRiskScore
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
            builder.Services.AddSingleton<FraminghamIntroPage>();
            builder.Services.AddSingleton<FraminghamRiskScorePage>();

            return builder.Build();
        }
    }
}
