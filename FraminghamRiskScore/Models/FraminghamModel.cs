using static FraminghamRiskScore.Enums;

namespace FraminghamRiskScore.Models;

public class FraminghamModel
{
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public bool Smoker { get; set; }
    public bool BloodPressureTreated { get; set; }
    public int TotalCholeterol { get; set; }
    public int HDLCholesterol { get; set; }
    public int SystolicBloodPressure { get; set; }

    public int AgePoints { get; set; }
    public int SmokerPoints { get; set; }
    public int TotalCholesterolPoints { get; set; }
    public int HDLCholesterolPoints { get; set; }
    public int SystolicBloodPressurePoints { get; set; }
    public string RiskCategory { get; set; }
    public int RiskScore { get; set; }
    public Color RiskColor { get; set; }
}
