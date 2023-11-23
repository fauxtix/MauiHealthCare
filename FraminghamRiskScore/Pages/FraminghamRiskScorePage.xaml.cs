using FraminghamRiskScore.Formatters;
using FraminghamRiskScore.Services;
using System.Text;
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
        StringBuilder sb = new StringBuilder();
        var output = ValidateEntries();
        if (output.Count > 0)
        {
            foreach (var entry in output)
            {
                sb.AppendLine(entry);
            }

            Shell.Current.DisplayAlert("Validação", sb.ToString(), "Ok");
            return;

        }
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

    private List<string> ValidateEntries()
    {
        bool entryOk = true;
        var errorMessages = new List<string>();
        if (string.IsNullOrEmpty(AgeEntry.Text))
        {
            errorMessages.Add("Preencha idade");
            entryOk = false;
        }
        else if (string.IsNullOrEmpty(TotalCholesterolEntry.Text))
        {
            errorMessages.Add("Preencha Cloresterol Total");
            entryOk = false;
        }
        else if (string.IsNullOrEmpty(HDLCholesterolEntry.Text))
        {
            errorMessages.Add("Preencha Cloresterol HDLl");
            entryOk = false;
        }

        if (!DataFormat.IsNumeric(AgeEntry.Text))
        {
            errorMessages.Add("Idade não é um valor numérico");
            entryOk = false;
        }
        if (!DataFormat.IsNumeric(TotalCholesterolEntry.Text))
        {
            errorMessages.Add("Colesterol total não é um valor numérico");
            entryOk = false;
        }
        if (!DataFormat.IsNumeric(HDLCholesterolEntry.Text))
        {
            errorMessages.Add("Colesterol HDL não é um valor numérico");
            entryOk = false;
        }

        if (entryOk)
        {
            int idade = int.Parse(AgeEntry.Text);
            int cloresterolTotal = int.Parse(TotalCholesterolEntry.Text);
            int cloresterolHDL = int.Parse(HDLCholesterolEntry.Text);

            if (idade < 20 || idade > 79)
            {
                errorMessages.Add("idade entre 20 e 79 anos");
            }
            if (cloresterolTotal < 1)
            {
                errorMessages.Add("Cloresterol Total > 0");
            }
            if (cloresterolHDL < 1)
            {
                errorMessages.Add("Cloresterol HDL > 0");
            }
        }

        return errorMessages;
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