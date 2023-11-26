using CardiovascularRiskAssessment.Pages;
using CardiovascularRiskAssessment.Services;
using CardiovascularRiskAssessment.ViewModels;
using Microsoft.Extensions.Logging;

namespace CardiovascularRiskAssessment
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

            builder.Services.AddSingleton<CardioRiskAsessmentPage>();

            builder.Services.AddSingleton<CardiovascularRiskAssessmentViewModel>();
            builder.Services.AddSingleton<ICRA_Service, CRA_Service>();

            return builder.Build();
        }
    }
}
