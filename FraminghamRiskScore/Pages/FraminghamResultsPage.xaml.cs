using FraminghamRiskScore.ViewModels;

namespace FraminghamRiskScore.Pages;


public partial class FraminghamResultsPage : ContentPage
{
    FraminghamRiskScoreViewModel _viewmodel;
    public FraminghamResultsPage(FraminghamRiskScoreViewModel viewmodel)
    {
        InitializeComponent();
        _viewmodel = viewmodel;
        BindingContext = _viewmodel;
    }

}