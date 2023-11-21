using FraminghamRiskScore.Pages;

namespace FraminghamRiskScore
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
            Routes.Add(nameof(FraminghamIntroPage), typeof(FraminghamIntroPage));
            Routes.Add(nameof(FraminghamRiskScorePage), typeof(FraminghamRiskScorePage));
            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}
