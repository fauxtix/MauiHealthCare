
/*
Black or African American Male:

    Age: [Your desired age]
    Sex: 1 (Male)
    Smoker: 1 ("Yes")
    OnHypertensionMed: 1 ("Yes")
    Diabetes: 0 ("No")
    Systolic Blood Pressure: [Your desired value]
    Total Cholesterol: [Your desired value]
    HDL Cholesterol: [Your desired value]

Black or African American Female:

    Age: [Your desired age]
    Sex: 2 (Female)
    Smoker: 1 ("Yes")
    OnHypertensionMed: 0 ("No")
    Diabetes: 1 ("Yes")
    Systolic Blood Pressure: [Your desired value]
    Total Cholesterol: [Your desired value]
    HDL Cholesterol: [Your desired value]

White or Other Race Male:

    Age: [Your desired age]
    Sex: 1 (Male)
    Smoker: 0 ("No")
    OnHypertensionMed: 1 ("Yes")
    Diabetes: 0 ("No")
    Systolic Blood Pressure: [Your desired value]
    Total Cholesterol: [Your desired value]
    HDL Cholesterol: [Your desired value]

White or Other Race Female:

    Age: [Your desired age]
    Sex: 2 (Female)
    Smoker: 0 ("No")
    OnHypertensionMed: 0 ("No")
    Diabetes: 1 ("Yes")
    Systolic Blood Pressure: [Your desired value]
    Total Cholesterol: [Your desired value]
    HDL Cholesterol: [Your desired value]
*/
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
        _viewmodel.Sex = 1; 
        MaleButton.BackgroundColor = Colors.SteelBlue;
        FemaleButton.BackgroundColor = Colors.Green; 
    }

    private void OnFemaleClicked(object sender, EventArgs e)
    {
        _viewmodel.Sex = 2; 
        FemaleButton.BackgroundColor = Colors.Yellow; 
        MaleButton.BackgroundColor = Colors.Red; 
    }
    private void OnSmokerYesClicked(object sender, EventArgs e)
    {
        _viewmodel.Smoker = 1; // Assuming 1 represents "Yes"
    }
    private void OnSmokerNoClicked(object sender, EventArgs e)
    {
        _viewmodel.Smoker = 0; // Assuming 0 represents "No"
    }
    private void OnHipertensionMedicatedYesClicked(object sender, EventArgs e)
    {
        _viewmodel.OnHypertensionMed = 1; // Assuming 1 represents "Yes"
    }
    private void OnHipertensionMedicatedNoClicked(object sender, EventArgs e)
    {
        _viewmodel.OnHypertensionMed = 0; // Assuming 0 represents "No"
    }
    private void OnDiabetesYesClicked(object sender, EventArgs e)
    {
        _viewmodel.Diabetes = 1; // Assuming 1 represents "Yes"
    }
    private void OnDiabetesNoClicked(object sender, EventArgs e)
    {
        _viewmodel.Diabetes = 0; // Assuming 0 represents "No"
    }
    private void CaucasianSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        _viewmodel.Caucasian = CaucasianSwitch.IsToggled ? 1 : 0;
    }

    private void SmokerSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        _viewmodel.Smoker = SmokerSwitch.IsToggled ? 1 : 0;

    }

    private void DiabetesSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        _viewmodel.Diabetes = DiabetesSwitch.IsToggled ? 1 : 0;

    }

    private void OnHypertensionMedSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        _viewmodel.OnHypertensionMed = OnHypertensionMedSwitch.IsToggled ? 1 : 0;

    }
}