using AndroidX.Lifecycle;
using CardiovascularRiskAssessment.Models;
using CardiovascularRiskAssessment.ViewModels;

namespace CardiovascularRiskAssessment.Pages;

public partial class CardioRiskAsessmentPage : ContentPage
{
    CardiovascularRiskAssessmentViewModel _viewmodel;

    public CardioRiskAsessmentPage(CardiovascularRiskAssessmentViewModel viewmodel)
    {
        InitializeComponent();
        _viewmodel = viewmodel;
        BindingContext = _viewmodel;
    }

    private void OnMaleClicked(object sender, EventArgs e)
    {
        _viewmodel.Sex = 2; // Assuming 2 represents Male
    }

    private void OnFemaleClicked(object sender, EventArgs e)
    {
        _viewmodel.Sex = 1; // Assuming 1 represents Female
    }

    private void OnSmokerYesClicked(object sender, EventArgs e)
    {
        _viewmodel.Smoker = 1; // Assuming 1 represents "Yes"
    }

    private void OnSmokerNoClicked(object sender, EventArgs e)
    {
        _viewmodel.Smoker = 0; // Assuming 0 represents "No"
    }
    private void OnDiabetesYesClicked(object sender, EventArgs e)
    {
        _viewmodel.Diabetes = 1; // Assuming 1 represents "Yes"
    }

    private void OnDiabetesNoClicked(object sender, EventArgs e)
    {
        _viewmodel.Diabetes = 0; // Assuming 0 represents "No"
    }

}