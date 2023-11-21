using MauiPreDiabetes.Pages;

namespace MauiPreDiabetes
{
    public partial class AppShell : Shell
    {
        public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        void RegisterRoutes()
        {
            Routes.Add(nameof(PreDiabetesIntroPage), typeof(PreDiabetesIntroPage));
            Routes.Add(nameof(PreDiabetesPage), typeof(PreDiabetesPage));
            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}
