
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
using CardiovascularRiskAssessment.Enums;
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
        _viewmodel.Gender = AppEnums.Gender.Male; 
        MaleButton.BackgroundColor = Colors.SteelBlue;
        FemaleButton.BackgroundColor = Colors.Green; 
    }

    private void OnFemaleClicked(object sender, EventArgs e)
    {
        _viewmodel.Gender = AppEnums.Gender.Female; 
        FemaleButton.BackgroundColor = Colors.Yellow; 
        MaleButton.BackgroundColor = Colors.Red; 
    }
    private void OnSmokerYesClicked(object sender, EventArgs e)
    {
        _viewmodel.Smoker = true; 
    }
    private void OnSmokerNoClicked(object sender, EventArgs e)
    {
        _viewmodel.Smoker = false; 
    }
    private void OnHipertensionMedicatedYesClicked(object sender, EventArgs e)
    {
        _viewmodel.OnHypertensionMed = true; 
    }
    private void OnHipertensionMedicatedNoClicked(object sender, EventArgs e)
    {
        _viewmodel.OnHypertensionMed = false; 
    }
    private void OnDiabetesYesClicked(object sender, EventArgs e)
    {
        _viewmodel.Diabetes = true; 
    }
    private void OnDiabetesNoClicked(object sender, EventArgs e)
    {
        _viewmodel.Diabetes = false;
    }
    private void CaucasianSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        _viewmodel.Race = CaucasianSwitch.IsToggled ? AppEnums.Race.White  : AppEnums.Race.Black;
    }

    private void SmokerSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        _viewmodel.Smoker = SmokerSwitch.IsToggled ? true : false;

    }

    private void DiabetesSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        _viewmodel.Diabetes = DiabetesSwitch.IsToggled ? true : false;

    }

    private void OnHypertensionMedSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        _viewmodel.OnHypertensionMed = OnHypertensionMedSwitch.IsToggled ? true : false;

    }
}