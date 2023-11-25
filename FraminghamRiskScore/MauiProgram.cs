using CommunityToolkit.Maui;
using FraminghamRiskScore.Pages;
using FraminghamRiskScore.Services;
using FraminghamRiskScore.ViewModels;
using Microsoft.Extensions.Logging;


namespace FraminghamRiskScore
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
                .UseMauiCommunityToolkit();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            //FormHandler.RemoveBorders();
            builder.Services.AddSingleton<FraminghamIntroPage>();
            builder.Services.AddSingleton<FraminghamRiskScorePage>();
            builder.Services.AddSingleton<FraminghamResultsPage>();

            builder.Services.AddSingleton<FraminghamRiskScoreViewModel>();
            builder.Services.AddSingleton<IFRS_Service, FRS_Service>();

            return builder.Build();
        }
    }
}
