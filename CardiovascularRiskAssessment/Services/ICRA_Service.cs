namespace CardiovascularRiskAssessment.Services;
public interface ICRA_Service
{
    double Calculate10YearRisk(int age, int sex, int race, double systolicBloodPressure, int onHypertensionMed, int diabetes, int smoker, double totalCholesterol, double hdlCholesterol);
}