using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FraminghamRiskScore.Formatters;
using FraminghamRiskScore.Models;
using FraminghamRiskScore.Pages;
using FraminghamRiskScore.Services;
using System.Collections.ObjectModel;
using System.Text;
using static FraminghamRiskScore.Enums;

namespace FraminghamRiskScore.ViewModels;

public partial class FraminghamRiskScoreViewModel : ObservableObject
{
    [ObservableProperty]
    FraminghamModel _model;

    [ObservableProperty]
    private int age = 0;
    [ObservableProperty]
    bool isSmoker = false;
    [ObservableProperty]
    bool isTreated = false;
    [ObservableProperty]
    int totalCholesterol = 0;
    [ObservableProperty]
    int hDLCholesterol = 0;
    [ObservableProperty]
    int systolicBloodPressure = 0;
    [ObservableProperty]
    Gender gender;

    [ObservableProperty]
    private int agePoints;
    [ObservableProperty]
    private int smokerPoints;
    [ObservableProperty]
    private int totalCholesterolPoints;
    [ObservableProperty]
    private int hDLCholesterolPoints;
    [ObservableProperty]
    private int systolicBloodPressurePoints;
    [ObservableProperty]
    private string riskCategory;
    [ObservableProperty]
    private int riskScore;

    [ObservableProperty]
    private bool isMale;
    [ObservableProperty]
    private bool isFemale;

    [ObservableProperty]
    private Color riskColor;

    public ObservableCollection<Scores> MaleScores { get; set; } = new();
    public ObservableCollection<Scores> FemaleScores { get; set; } = new();

    IFRS_Service _service;
    public FraminghamRiskScoreViewModel(IFRS_Service service)
    {
        _service = service;

        MaleScores = new ObservableCollection<Scores>(ListOfMaleScores());
        FemaleScores = new ObservableCollection<Scores>(ListOfFemaleScores());
    }

    public List<Scores> ListOfFemaleScores()
    {
        List<Scores> womanScores = new()
        {
            new Scores{ Points = "Abaixo de 9", Percentage = "< 1"},
            new Scores{ Points = "9 - 12", Percentage = "1"},
            new Scores{ Points = "13 - 14", Percentage = "2"},
            new Scores{ Points = "15", Percentage = "3"},
            new Scores{ Points = "16", Percentage = "4"},
            new Scores{ Points = "17", Percentage = "5"},
            new Scores{ Points = "18", Percentage = "6"},
            new Scores{ Points = "19", Percentage = "8"},
            new Scores{ Points = "20", Percentage = "11"},
            new Scores{ Points = "21", Percentage = "14"},
            new Scores{ Points = "22", Percentage = "17"},
            new Scores{ Points = "23", Percentage = "22"},
            new Scores{ Points = "24", Percentage = "27"},
            new Scores{ Points = ">= 25", Percentage = "Mais de 30"},
        };

        return womanScores;
    }

    public List<Scores> ListOfMaleScores()
    {
        List<Scores> manScores = new()
        {
            new Scores{ Points = "0", Percentage = "< 1"},
            new Scores{ Points = "1 - 4", Percentage = "1"},
            new Scores{ Points = "5 - 6", Percentage = "2"},
            new Scores{ Points = "7", Percentage = "3"},
            new Scores{ Points = "8", Percentage = "4"},
            new Scores{ Points = "9", Percentage = "5"},
            new Scores{ Points = "10", Percentage = "6"},
            new Scores{ Points = "11", Percentage = "8"},
            new Scores{ Points = "12", Percentage = "10"},
            new Scores{ Points = "13", Percentage = "12"},
            new Scores{ Points = "14", Percentage = "16"},
            new Scores{ Points = "15", Percentage = "20"},
            new Scores{ Points = "16", Percentage = "25"},
            new Scores{ Points = ">= 17", Percentage = "Mais de 30"},
        };

        return manScores;
    }


    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync($"//{nameof(FraminghamRiskScorePage)}");
    }

    [RelayCommand]
    public void Calculate()
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

        RiskScore = CalculateFraminghamRiskScore();
        RiskCategory = GetRiskCategory(RiskScore);

        RiskColor = RiskCategory == "Baixo" ? Colors.DarkGreen : RiskCategory == "Intermédio" ? Colors.DarkOrange: Colors.DarkRed;

        FraminghamModel resultModel = new()
        {
            Age = Age,
            Gender = Gender,
            TotalCholeterol = TotalCholesterol,
            HDLCholesterol = HDLCholesterol,
            BloodPressureTreated = IsTreated,
            Smoker = IsSmoker,
            SystolicBloodPressure = SystolicBloodPressure,
            AgePoints = AgePoints,
            SmokerPoints = SmokerPoints,
            TotalCholesterolPoints = TotalCholesterolPoints,
            HDLCholesterolPoints = HDLCholesterolPoints,
            SystolicBloodPressurePoints = SystolicBloodPressurePoints,
            RiskScore = RiskScore,
            RiskCategory = RiskCategory,
            RiskColor = RiskColor            
        };

        IsMale = Gender.Equals(Gender.Male);
        IsFemale = Gender.Equals(Gender.Female);

        var navigationParameter = new Dictionary<string, object>
        {
            {
                "FraminghamModel", resultModel
            }
        };

        Shell.Current.GoToAsync($"{nameof(FraminghamResultsPage)}",
            true,
            navigationParameter);

        //string resultMsg = $"Framingham Risk Score: {riskScore}\nClassificação do risco: {riskCategory}";
        //Shell.Current.DisplayAlert("Avaliação do risco: ", resultMsg, "Ok");


    }

    private int CalculateFraminghamRiskScore()
    {
        AgePoints = _service.GetAgePoints(Age, Gender);
        TotalCholesterolPoints = _service.GetTotalCholesterolPoints(Age, Gender, TotalCholesterol);
        HDLCholesterolPoints = _service.GetHDLCholesterolPoints(Gender, HDLCholesterol);
        SystolicBloodPressurePoints = _service.GetSystolicBloodPressurePoints(SystolicBloodPressure, IsTreated, Gender);
        SmokerPoints = _service.GetSmokingPoints(Gender, IsSmoker, Age);

        return AgePoints + TotalCholesterolPoints + HDLCholesterolPoints +
                          SystolicBloodPressurePoints + SmokerPoints;

    }

    private string GetRiskCategory(int riskScore)
    {
        // Adjust accordingly based on your specific categories
        if (riskScore <= 10) return "Baixo";
        else if (riskScore <= 20) return "Intermédio";
        else return "Muito alto";
    }


    private List<string> ValidateEntries()
    {
        bool entryOk = true;
        var errorMessages = new List<string>();
        var genderSelected = Gender;
        if (!DataFormat.IsNumeric(Age))
        {
            errorMessages.Add("Preencha idade");
            entryOk = false;
        }
        else if (!DataFormat.IsNumeric(TotalCholesterol))
        {
            errorMessages.Add("Preencha Cloresterol Total");
            entryOk = false;
        }
        else if (!DataFormat.IsNumeric(HDLCholesterol))
        {
            errorMessages.Add("Preencha Cloresterol HDL");
            entryOk = false;
        }
        else if (!DataFormat.IsNumeric(SystolicBloodPressure))
        {
            errorMessages.Add("Preencha T.A. Sistólica");
            entryOk = false;
        }

        if (!DataFormat.IsNumeric(Age))
        {
            errorMessages.Add("Idade não é um valor numérico");
            entryOk = false;
        }
        if (!DataFormat.IsNumeric(TotalCholesterol))
        {
            errorMessages.Add("Colesterol total não é um valor numérico");
            entryOk = false;
        }

        if (entryOk)
        {
            if (Age < 20 || Age > 79)
            {
                errorMessages.Add("idade entre 20 e 79 anos");
            }
            if (TotalCholesterol < 1)
            {
                errorMessages.Add("Cloresterol Total > 0");
            }
            if (HDLCholesterol < 1)
            {
                errorMessages.Add("Cloresterol HDL > 0");
            }
            if (SystolicBloodPressure < 1)
            {
                errorMessages.Add("T.A. Sistólica > 0");
            }
        }

        return errorMessages;
    }

}
