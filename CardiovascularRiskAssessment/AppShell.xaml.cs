using CardiovascularRiskAssessment.Models;

namespace CardiovascularRiskAssessment
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
            Routes.Add(nameof(CardiovascularRiskAssessmentModel), typeof(CardiovascularRiskAssessmentModel));
            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

    }
}
