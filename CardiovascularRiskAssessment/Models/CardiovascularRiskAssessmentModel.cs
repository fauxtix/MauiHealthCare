namespace CardiovascularRiskAssessment.Models;
public class CardiovascularRiskAssessmentModel
{
    public double CalculatedRisk { get; set; }
    public int Age { get; set; }
    public int Sex { get; set; }
    public HumanRaceModel Race { get; set; }
    public double SystolicBloodPressure { get; set; }
    public int OnHypertensionMed { get; set; }
    public int Diabetes { get; set; }
    public int Smoker { get; set; }
    public double TotalCholesterol { get; set; }
    public double HDLCholesterol { get; set; }
}
