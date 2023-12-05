using static CardiovascularRiskAssessment.Enums.AppEnums;

namespace CardiovascularRiskAssessment.Models;
public class CardiovascularRiskAssessmentModel
{
    public double CalculatedRisk { get; set; }
    public int Age { get; set; }
    public Gender Sex { get; set; }
    public Race Race { get; set; }
    public double SystolicBloodPressure { get; set; }
    public bool OnHypertensionMed { get; set; }
    public bool Diabetes { get; set; }
    public bool Smoker { get; set; }
    public Gender Gender { get; set; }
    public double TotalCholesterol { get; set; }
    public double HDLCholesterol { get; set; }
}
