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
    int TotPontos = 0;

    public FraminghamRiskScorePage()
    {
        InitializeComponent();
    }

    private int GetAgePoints(int age)
    {
        int points = 0;

        if (IsMale)
        {
            if (age >= 20 && age <= 34) points = -9;
            else if (age >= 35 && age <= 39) points = -4;
            else if (age >= 40 && age <= 44) points = 0;
            else if (age >= 45 && age <= 49) points = 3;
            else if (age >= 50 && age <= 54) points = 6;
            else if (age >= 55 && age <= 59) points = 8;
            else if (age >= 60 && age <= 64) points = 10;
            else if (age >= 65 && age <= 69) points = 11;
            else if (age >= 70 && age <= 74) points = 12;
            else if (age >= 75 && age <= 79) points = 13;
        }
        else if (IsFemale)
        {
            if (age >= 20 && age <= 34) points = -7;
            else if (age >= 35 && age <= 39) points = -3;
            else if (age >= 40 && age <= 44) points = 0;
            else if (age >= 45 && age <= 49) points = 3;
            else if (age >= 50 && age <= 54) points = 6;
            else if (age >= 55 && age <= 59) points = 8;
            else if (age >= 60 && age <= 64) points = 10;
            else if (age >= 65 && age <= 69) points = 12;
            else if (age >= 70 && age <= 74) points = 14;
            else if (age >= 75 && age <= 79) points = 16;
        }

        return points;
    }

    private int GetTotalCholesterolPoints(int totalCholesterol)
    {
        int points = 0;

        if (IsMale)
        {
            if (totalCholesterol < 160) points = 0;
            else if (totalCholesterol >= 160 && totalCholesterol < 200) points = 4;
            else if (totalCholesterol >= 200 && totalCholesterol < 240) points = 7;
            else if (totalCholesterol >= 240 && totalCholesterol < 280) points = 9;
            else if (totalCholesterol >= 280) points = 11;
        }
        else if (IsFemale)
        {
            if (totalCholesterol < 160) points = 0;
            else if (totalCholesterol >= 160 && totalCholesterol < 200) points = 4;
            else if (totalCholesterol >= 200 && totalCholesterol < 240) points = 8;
            else if (totalCholesterol >= 240 && totalCholesterol < 280) points = 11;
            else if (totalCholesterol >= 280) points = 13;
        }

        return points;
    }

    private int GetHDLCholesterolPoints(int hdlCholesterol)
    {
        int points = 0;

        if (hdlCholesterol >= 60) points = -1;
        else if (hdlCholesterol >= 50 && hdlCholesterol < 60) points = 0;
        else if (hdlCholesterol >= 40 && hdlCholesterol < 50) points = 1;
        else if (hdlCholesterol < 40) points = 2;

        return points;
    }

    private int GetSystolicBloodPressurePoints(int systolicBloodPressure, bool isTreated)
    {
        int points = 0;

        if (!isTreated)
        {
            if (systolicBloodPressure < 120) points = 0;
            else if (systolicBloodPressure >= 120 && systolicBloodPressure < 130) points = 1;
            else if (systolicBloodPressure >= 130 && systolicBloodPressure < 140) points = 2;
            else if (systolicBloodPressure >= 140 && systolicBloodPressure < 160) points = 3;
            else if (systolicBloodPressure >= 160) points = 4;
        }
        else
        {
            if (systolicBloodPressure < 120) points = 0;
            else if (systolicBloodPressure >= 120 && systolicBloodPressure < 130) points = 3;
            else if (systolicBloodPressure >= 130 && systolicBloodPressure < 140) points = 4;
            else if (systolicBloodPressure >= 140 && systolicBloodPressure < 160) points = 5;
            else if (systolicBloodPressure >= 160) points = 6;
        }

        return points;
    }

    private int GetSmokingPoints(bool isSmoker, int age)
    {
        int points = 0;

        if (isSmoker)
        {
            if (IsMale)
            {
                if (age >= 20 && age <= 39) points = 9;
                else if (age >= 40 && age <= 49) points = 7;
                else if (age >= 50 && age <= 59) points = 4;
                else if (age >= 60 && age <= 69) points = 2;
                else if (age >= 70 && age <= 79) points = 1;
            }
            else if (IsFemale)
            {
                if (age >= 20 && age <= 39) points = 9;
                else if (age >= 40 && age <= 49) points = 7;
                else if (age >= 50 && age <= 59) points = 4;
                else if (age >= 60 && age <= 69) points = 2;
                else if (age >= 70 && age <= 79) points = 1;
            }
            // Add more conditions for other genders if needed
        }
        else
        {
            points = 0;
        }

        return points;
    }

    private int CalculateFraminghamRiskScore()
    {
        int agePoints = GetAgePoints(Age);
        int totalCholesterolPoints = GetTotalCholesterolPoints(TotalCholesterol);
        int hdlCholesterolPoints = GetHDLCholesterolPoints(HDLCholesterol);
        int systolicBloodPressurePoints = GetSystolicBloodPressurePoints(SystolicBloodPressure, IsTreated);
        int smokingPoints = GetSmokingPoints(IsSmoker, Age);

        int totalPoints = agePoints + totalCholesterolPoints + hdlCholesterolPoints +
                          systolicBloodPressurePoints + smokingPoints;

        return totalPoints;
    }

    private void Calcular_Clicked(object sender, EventArgs e)
    {
        // Set values for Age, Gender, IsSmoker, TotalCholesterol, HDLCholesterol, and SystolicBloodPressure
        // based on your app's UI input. For example:
        Age = int.Parse(AgeEntry.Text);
        //Gender = GenderPicker.SelectedItem.ToString();
        IsSmoker = SmokerSwitch.IsToggled;
        TotalCholesterol = int.Parse(TotalCholesterolEntry.Text);
        HDLCholesterol = int.Parse(HDLCholesterolEntry.Text);
        SystolicBloodPressure = int.Parse(SystolicBloodPressureEntry.Text);

        int riskScore = CalculateFraminghamRiskScore();
        string riskCategory = GetRiskCategory(riskScore);

        string resultMsg = $"Framingham Risk Score: {riskScore}\nRisk Category: {riskCategory}";
        Shell.Current.DisplayAlert("Risk Assessment", resultMsg, "Ok");
    }

    private string GetRiskCategory(int riskScore)
    {
        // Adjust accordingly based on your specific categories
        if (riskScore < 9) return "Low";
        else if (riskScore >= 9 && riskScore <= 12) return "Moderate";
        else if (riskScore >= 13 && riskScore <= 14) return "High";
        else return "Very High";
    }

    private void ShowResult(string message)
    {
        Shell.Current.DisplayAlert("Resultado", message, "Ok");
    }

    private void BllodPressureTreated_Toggled(object sender, ToggledEventArgs e)
    {
        IsTreated = BllodPressureTreated.IsToggled;
    }

    private void Gender_SelectedIndexChanged(object sender, EventArgs e)
    {
        var genero = GenderPicker.SelectedIndex;
        IsMale = genero == 1;
        IsFemale= genero == 0;
    }

    private void SmokerSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        IsSmoker = SmokerSwitch.IsToggled;
    }
}