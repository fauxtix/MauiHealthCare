namespace CardiovascularRiskAssessment.Services;

public class CRA_Service : ICRA_Service
{
    public double Calculate10YearRisk(int age, int sex, int race, double systolicBloodPressure, int onHypertensionMed, int diabetes, int smoker, double totalCholesterol, double hdlCholesterol)
    {
        double logit = CalculateRisk(age, sex, race, systolicBloodPressure, onHypertensionMed, diabetes, smoker, totalCholesterol, hdlCholesterol);
        return 100 / (1 + Math.Exp(-logit));
    }

    private double CalculateRisk(int age, int sex, int race, double systolicBloodPressure, int onHypertensionMed, int diabetes, int smoker, double totalCholesterol, double hdlCholesterol)
    {
        double logit;

        if (sex == 1) // Female
        {
            logit = -12.823110 +
                    (0.106501 * age) +
                    (0.432440) + // race
                    (0.000056 * Math.Pow(systolicBloodPressure, 2)) +
                    (0.017666 * systolicBloodPressure) +
                    (0.731678 * onHypertensionMed) +
                    (0.943970 * diabetes) +
                    (1.009790 * smoker) +
                    (0.151318 * (totalCholesterol / hdlCholesterol)) +
                    (-0.008580 * age * race) +
                    (-0.003647 * systolicBloodPressure * onHypertensionMed) +
                    (0.006208 * systolicBloodPressure * race) +
                    (0.152968 * race * onHypertensionMed) +
                    (-0.000153 * age * systolicBloodPressure) +
                    (0.115232 * race * diabetes) +
                    (-0.092231 * race * smoker) +
                    (0.070498 * race * (totalCholesterol / hdlCholesterol)) +
                    (-0.000173 * race * systolicBloodPressure * onHypertensionMed) +
                    (-0.000094 * age * systolicBloodPressure * race);
        }
        else // Male
        {
            logit = -11.679980 +
                    (0.064200 * age) +
                    (0.482835) + // race
                    (-0.000061 * Math.Pow(systolicBloodPressure, 2)) +
                    (0.038950 * systolicBloodPressure) +
                    (2.055533 * onHypertensionMed) +
                    (0.842209 * diabetes) +
                    (0.895589 * smoker) +
                    (0.193307 * (totalCholesterol / hdlCholesterol)) +
                    (-0.014207 * systolicBloodPressure * onHypertensionMed) +
                    (0.011609 * systolicBloodPressure * race) +
                    (-0.119460 * onHypertensionMed * race) +
                    (0.000025 * age * systolicBloodPressure) +
                    (-0.077214 * race * diabetes) +
                    (-0.226771 * race * smoker) +
                    (-0.117749 * race * (totalCholesterol / hdlCholesterol)) +
                    (0.004190 * race * onHypertensionMed * systolicBloodPressure) +
                    (-0.000199 * race * age * systolicBloodPressure);
        }

        return logit;
    }
}
