using FraminghamRiskScore.Services;
using static FraminghamRiskScore.Enums;

namespace FraminghamRiskScore.Pages;

public partial class FraminghamRiskScorePage : ContentPage
{
    int Age = 0;
    bool IsFemale = false;
    bool IsMale = false;
    bool IsSmoker = false;
    bool IsTreated = false;
    int TotalCholesterol = 0;
    int HDLCholesterol = 0;
    int SystolicBloodPressure = 0;

    Gender gender;

    IFRS_Service service;
    public FraminghamRiskScorePage(IFRS_Service service)
    {
        InitializeComponent();

        this.service = service;

        gender = Gender.Male;
        GenderPicker.SelectedIndex = 0;
    }



    private int CalculateFraminghamRiskScore()
    {
        int agePoints = service.GetAgePoints(Age, gender);
        int totalCholesterolPoints = service.GetTotalCholesterolPoints(Age, gender,TotalCholesterol);
        int hdlCholesterolPoints = service.GetHDLCholesterolPoints(gender, HDLCholesterol);
        int systolicBloodPressurePoints = service.GetSystolicBloodPressurePoints(SystolicBloodPressure, IsTreated, gender);
        int smokingPoints = service.GetSmokingPoints(gender, IsSmoker, Age);

        int totalPoints = agePoints + totalCholesterolPoints + hdlCholesterolPoints +
                          systolicBloodPressurePoints + smokingPoints;

        return totalPoints;
    }

    private void Calcular_Clicked(object sender, EventArgs e)
    {
        // Set values for Age, Gender, IsSmoker, TotalCholesterol, HDLCholesterol, and SystolicBloodPressure
        // based on your app's UI input. For example:

        Age = int.Parse(AgeEntry.Text);
        IsSmoker = SmokerSwitch.IsToggled;
        TotalCholesterol = int.Parse(TotalCholesterolEntry.Text);
        HDLCholesterol = int.Parse(HDLCholesterolEntry.Text);
        SystolicBloodPressure = int.Parse(SystolicBloodPressureEntry.Text);

        int riskScore = CalculateFraminghamRiskScore();
        string riskCategory = GetRiskCategory(riskScore);

        string resultMsg = $"Framingham Risk Score: {riskScore}\nClassificação do risco: {riskCategory}";
        Shell.Current.DisplayAlert("Avaliação do risco: ", resultMsg, "Ok");
    }

    private string GetRiskCategory(int riskScore)
    {
        // Adjust accordingly based on your specific categories
        if (riskScore < 9) return "Baixo";
        else if (riskScore >= 9 && riskScore <= 12) return "Moderado";
        else if (riskScore >= 13 && riskScore <= 14) return "Alto";
        else return "Muito alto";
    }


    private void BllodPressureTreated_Toggled(object sender, ToggledEventArgs e)
    {
        IsTreated = BllodPressureTreated.IsToggled;
    }

    private void Gender_SelectedIndexChanged(object sender, EventArgs e)
    {
        var genderSelected = GenderPicker.SelectedIndex;
        IsFemale = genderSelected == 0;
        IsMale = genderSelected == 1;

        gender = IsMale ? Gender.Male : Gender.Female;

    }

    private void SmokerSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        IsSmoker = SmokerSwitch.IsToggled;
    }

    private void ShowResult(string message)
    {
        Shell.Current.DisplayAlert("Resultado", message, "Ok");
    }

}