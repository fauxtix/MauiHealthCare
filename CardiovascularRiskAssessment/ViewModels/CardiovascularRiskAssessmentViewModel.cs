using CardiovascularRiskAssessment.Enums;
using CardiovascularRiskAssessment.Models;
using CardiovascularRiskAssessment.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Text;

namespace CardiovascularRiskAssessment.ViewModels;
public partial class CardiovascularRiskAssessmentViewModel : ObservableObject
{
    [ObservableProperty]
    private double _calculatedRisk;
    [ObservableProperty]
    private int _age;
    [ObservableProperty]
    private AppEnums.Gender _gender;
    [ObservableProperty]
    private AppEnums.Race _race;
    [ObservableProperty]
    private double _systolicBloodPressure;
    [ObservableProperty]
    private bool _onHypertensionMed;
    [ObservableProperty]
    private bool _diabetes;
    [ObservableProperty]
    private bool _smoker;
    [ObservableProperty]
    private double _totalCholesterol;
    [ObservableProperty]
    private double _hDLCholesterol;
    [ObservableProperty]
    private int _caucasian;

    [ObservableProperty]
    private bool hasValidationErrors;

    [ObservableProperty]
    CardiovascularRiskAssessmentModel cardioVascularRiskAssessmentModel;

    private readonly ICRA_Service _service;
    private readonly IInputValidationService _validationService;
    public CardiovascularRiskAssessmentViewModel(ICRA_Service service, IInputValidationService validationService)
    {
        _service = service;
        _validationService = validationService;
    }

    [RelayCommand]
    public void CalculateCRA()
    {
        var validationResult = _validationService.ValidateAll(Age.ToString(),
            SystolicBloodPressure.ToString(),
            TotalCholesterol.ToString(),
            HDLCholesterol.ToString());
        if (validationResult.Count > 0)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in validationResult)
            {
                sb.AppendLine(item.Message.ToString());
            }
            Shell.Current.DisplayAlert("Validação", sb.ToString(), "Voltar");
            return;
        }

        var result = _service.Calculate10YearRisk(Age,
                                                  Gender,
                                                  Race,
                                                  SystolicBloodPressure,
                                                  OnHypertensionMed,
                                                  Diabetes,
                                                  Smoker,
                                                  TotalCholesterol,
                                                  HDLCholesterol);

        Shell.Current.DisplayAlert("Resultado", $"{result}", "Ok");
    }

    public List<HumanRaceModel> ListOfHumanRaces()
    {
        List<HumanRaceModel> list = new()
        {
          new HumanRaceModel() { Description = "American Indian or Alaska Native"},
          new HumanRaceModel() { Description = "Asian"},
          new HumanRaceModel() { Description = "Black or African American"},
          new HumanRaceModel() { Description = "Native Hawaiian or Other Pacific Islander"},
          new HumanRaceModel() { Description = "White"},
        };

        return list;
    }

}
