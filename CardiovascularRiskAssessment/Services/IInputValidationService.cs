using CardiovascularRiskAssessment.Models;

namespace CardiovascularRiskAssessment.Services
{
    public interface IInputValidationService
    {
        ValidationResult ValidateAge(string ageText);
        bool ValidateAll(string age, string systolicBP, string totalCholesterol, string hdlCholesterol);
        ValidationResult ValidateHDLCholesterol(string hdlCholesterolText);
        ValidationResult ValidateSystolicBloodPressure(string systolicBPText);
        ValidationResult ValidateTotalCholesterol(string totalCholesterolText);
    }
}