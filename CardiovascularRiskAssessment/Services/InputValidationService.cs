using CardiovascularRiskAssessment.Models;

namespace CardiovascularRiskAssessment.Services
{
    public class InputValidationService : IInputValidationService
    {
        public ValidationResult ValidateAge(string ageText)
        {
            if (!int.TryParse(ageText, out int age) || age < 40 || age > 79)
            {
                return ValidationResult.Error("Intervalo de idades entre 40 e 79 anos.");
            }

            return ValidationResult.Success();
        }

        public ValidationResult ValidateSystolicBloodPressure(string systolicBPText)
        {
            if (!double.TryParse(systolicBPText, out double systolicBP))
            {
                return ValidationResult.Error("T.A. Sistólica deve ter um valor numérico.");
            }

            if (systolicBP < 0)
            {
                return ValidationResult.Error("\"T.A. Sistólica não pode ser negativa.");
            }
            else if (systolicBP < 40)
            {
                return ValidationResult.Warning("\"T.A. Sistólica deve ter um valor numérico está abaixo do valor mínimo (40).");
            }

            return ValidationResult.Success();
        }

        public ValidationResult ValidateTotalCholesterol(string totalCholesterolText)
        {
            if (!double.TryParse(totalCholesterolText, out double totalCholesterol) || totalCholesterol < 0)
            {
                return ValidationResult.Error("Please enter a valid positive number for total cholesterol.");
            }
            else if (totalCholesterol > 240) // Modify this upper limit based on your application's requirements
            {
                return ValidationResult.Warning("Total cholesterol value is above the typical range.");
            }

            return ValidationResult.Success();
        }

        public ValidationResult ValidateHDLCholesterol(string hdlCholesterolText)
        {
            if (!double.TryParse(hdlCholesterolText, out double hdlCholesterol) || hdlCholesterol < 0)
            {
                return ValidationResult.Error("Please enter a valid positive number for HDL cholesterol.");
            }
            else if (hdlCholesterol < 40) // Modify this lower limit based on your application's requirements
            {
                return ValidationResult.Warning("HDL cholesterol value is below the typical range.");
            }

            return ValidationResult.Success();
        }

        // Additional validation methods for other input fields...

        // You can also add a method to perform overall validation, if needed.
        public bool ValidateAll(string age, string systolicBP, string totalCholesterol, string hdlCholesterol)
        {
            // Perform validation for all input fields
            ValidationResult ageValidation = ValidateAge(age);
            ValidationResult systolicBPValidation = ValidateSystolicBloodPressure(systolicBP);
            ValidationResult totalCholesterolValidation = ValidateTotalCholesterol(totalCholesterol);
            ValidationResult hdlCholesterolValidation = ValidateHDLCholesterol(hdlCholesterol);

            // Check if any validation failed
            return ageValidation.IsValid && systolicBPValidation.IsValid &&
                   totalCholesterolValidation.IsValid && hdlCholesterolValidation.IsValid;
        }
    }
}
