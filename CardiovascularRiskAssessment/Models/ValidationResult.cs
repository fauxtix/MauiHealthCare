using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardiovascularRiskAssessment.Models
{
    public  class ValidationResult
    {
        public bool IsValid { get; }
        public string Message { get; }
        public bool IsWarning { get; }

        private ValidationResult(bool isValid, string message, bool isWarning = false)
        {
            IsValid = isValid;
            Message = message;
            IsWarning = isWarning;
        }

        public static ValidationResult Success()
        {
            return new ValidationResult(true, string.Empty);
        }

        public static ValidationResult Error(string message)
        {
            return new ValidationResult(false, message);
        }

        public static ValidationResult Warning(string message)
        {
            return new ValidationResult(false, message, true);
        }
    }
}
