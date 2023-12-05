using CardiovascularRiskAssessment.Enums;

namespace CardiovascularRiskAssessment.Services;
public interface ICRA_Service
{
    double Calculate10YearRisk(int age, AppEnums.Gender sex, AppEnums.Race ethnicity, double systolicBloodPressure,
        bool isTakingBPmedication, bool hasDiabetes, bool isSmoker, double totalCholesterol, double hdlCholesterol);
}