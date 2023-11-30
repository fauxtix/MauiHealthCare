namespace CardiovascularRiskAssessment.Services;

public class CRA_Service : ICRA_Service
{

    private const double C_Age_Black_Female = 17.114;
    private const double C_Sq_Age_Black_Female = 0;
    private const double C_Total_Chol_Black_Female = 0.94;
    private const double C_Age_Total_Chol_Black_Female = 0;
    private const double C_HDL_Chol_Black_Female = -18.92;
    private const double C_Age_HDL_Chol_Black_Female = 4.475;
    private const double C_On_Hypertension_Meds_Black_Female = 29.291;
    private const double C_Age_On_Hypertension_Meds_Black_Female = -6.432;
    private const double C_Off_Hypertension_Meds_Black_Female = 27.82;
    private const double C_Age_Off_Hypertension_Meds_Black_Female = -6.087;
    private const double C_Smoker_Black_Female = 0.691;
    private const double C_Age_Smoker_Black_Female = 0;
    private const double C_Diabetes_Black_Female = 0.874;
    private const double S10_Black_Female = 0.9533;
    private const double Mean_Terms_Black_Female = 86.61;

    // Coefficients for White or other race female patients
    private const double C_Age_White_Female = -29.799;
    private const double C_Sq_Age_White_Female = 4.884;
    private const double C_Total_Chol_White_Female = 13.54;
    private const double C_Age_Total_Chol_White_Female = -3.114;
    private const double C_HDL_Chol_White_Female = -13.578;
    private const double C_Age_HDL_Chol_White_Female = 3.149;
    private const double C_On_Hypertension_Meds_White_Female = 2.019;
    private const double C_Age_On_Hypertension_Meds_White_Female = 0;
    private const double C_Off_Hypertension_Meds_White_Female = 1.957;
    private const double C_Age_Off_Hypertension_Meds_White_Female = 0;
    private const double C_Smoker_White_Female = 7.574;
    private const double C_Age_Smoker_White_Female = -1.665;
    private const double C_Diabetes_White_Female = 0.661;
    private const double S10_White_Female = 0.9665;
    private const double Mean_Terms_White_Female = -29.18;

    // Coefficients for Black or African American male patients
    private const double C_Age_Black_Male = 2.469;
    private const double C_Sq_Age_Black_Male = 0;
    private const double C_Total_Chol_Black_Male = 0.302;
    private const double C_Age_Total_Chol_Black_Male = 0;
    private const double C_HDL_Chol_Black_Male = -0.307;
    private const double C_Age_HDL_Chol_Black_Male = 0;
    private const double C_On_Hypertension_Meds_Black_Male = 1.916;
    private const double C_Age_On_Hypertension_Meds_Black_Male = 0;
    private const double C_Off_Hypertension_Meds_Black_Male = 1.809;
    private const double C_Age_Off_Hypertension_Meds_Black_Male = 0;
    private const double C_Smoker_Black_Male = 0.549;
    private const double C_Age_Smoker_Black_Male = 0;
    private const double C_Diabetes_Black_Male = 0.645;
    private const double S10_Black_Male = 0.8954;
    private const double Mean_Terms_Black_Male = 19.54;

    // Coefficients for White or other race male patients
    private const double C_Age_White_Male = 12.344;
    private const double C_Sq_Age_White_Male = 0;
    private const double C_Total_Chol_White_Male = 11.853;
    private const double C_Age_Total_Chol_White_Male = -2.664;
    private const double C_HDL_Chol_White_Male = -7.99;
    private const double C_Age_HDL_Chol_White_Male = 1.769;
    private const double C_On_Hypertension_Meds_White_Male = 1.797;
    private const double C_Age_On_Hypertension_Meds_White_Male = 0;
    private const double C_Off_Hypertension_Meds_White_Male = 1.764;
    private const double C_Age_Off_Hypertension_Meds_White_Male = 0;
    private const double C_Smoker_White_Male = 7.837;
    private const double C_Age_Smoker_White_Male = -1.795;
    private const double C_Diabetes_White_Male = 0.658;
    private const double S10_White_Male = 0.9144;
    private const double Mean_Terms_White_Male = 61.18;

    public double Calculate10YearRisk(int age, int sex, int race, double systolicBloodPressure, int onHypertensionMed, int diabetes, int smoker, double totalCholesterol, double hdlCholesterol)
    {
        double logit = CalculateRiskInternal(age, sex, race, systolicBloodPressure, onHypertensionMed, diabetes, smoker, totalCholesterol, hdlCholesterol);
        return 100 / (1 + Math.Exp(-logit));
    }

    private double CalculateRiskInternal(int age, int sex, int race, double systolicBloodPressure, int onHypertensionMed, int diabetes, int smoker, double totalCholesterol, double hdlCholesterol)
    {
        double terms, risk = 0;

        if (race == 1 && sex == 1) // Black or African American male
        {
            terms = (C_Age_Black_Male * Math.Log(age)) +
                    (C_Sq_Age_Black_Male * Math.Pow(Math.Log(age), 2)) +
                    (C_Total_Chol_Black_Male * Math.Log(totalCholesterol)) +
                    (C_Age_Total_Chol_Black_Male * Math.Log(age) * Math.Log(totalCholesterol)) +
                    (C_HDL_Chol_Black_Male * Math.Log(hdlCholesterol)) +
                    (C_Age_HDL_Chol_Black_Male * Math.Log(age) * Math.Log(hdlCholesterol)) +
                    (onHypertensionMed * C_On_Hypertension_Meds_Black_Male * Math.Log(systolicBloodPressure)) +
                    (onHypertensionMed * C_Age_On_Hypertension_Meds_Black_Male * Math.Log(age) * Math.Log(systolicBloodPressure)) +
                    (onHypertensionMed == 1 ? C_Off_Hypertension_Meds_Black_Male * Math.Log(systolicBloodPressure) : 0) +
                    (onHypertensionMed == 1 ? C_Age_Off_Hypertension_Meds_Black_Male * Math.Log(age) * Math.Log(systolicBloodPressure) : 0) +
                    (smoker * C_Smoker_Black_Male * smoker) +
                    (smoker * C_Age_Smoker_Black_Male * Math.Log(age) * smoker) +
                    (diabetes * C_Diabetes_Black_Male * diabetes);
            risk = 1 - Math.Pow(S10_Black_Male, Math.Exp(terms - Mean_Terms_Black_Male));
        }
        else if (race == 1 && sex == 2) // Black or African American female
        {
            terms = (C_Age_Black_Female * Math.Log(age)) +
                    (C_Sq_Age_Black_Female * Math.Pow(Math.Log(age), 2)) +
                    (C_Total_Chol_Black_Female * Math.Log(totalCholesterol)) +
                    (C_Age_Total_Chol_Black_Female * Math.Log(age) * Math.Log(totalCholesterol)) +
                    (C_HDL_Chol_Black_Female * Math.Log(hdlCholesterol)) +
                    (C_Age_HDL_Chol_Black_Female * Math.Log(age) * Math.Log(hdlCholesterol)) +
                    (onHypertensionMed * C_On_Hypertension_Meds_Black_Female * Math.Log(systolicBloodPressure)) +
                    (onHypertensionMed * C_Age_On_Hypertension_Meds_Black_Female * Math.Log(age) * Math.Log(systolicBloodPressure)) +
                    (onHypertensionMed == 1 ? C_Off_Hypertension_Meds_Black_Female * Math.Log(systolicBloodPressure) : 0) +
                    (onHypertensionMed == 1 ? C_Age_Off_Hypertension_Meds_Black_Female * Math.Log(age) * Math.Log(systolicBloodPressure) : 0) +
                    (smoker * C_Smoker_Black_Female * smoker) +
                    (smoker * C_Age_Smoker_Black_Female * Math.Log(age) * smoker) +
                    (diabetes * C_Diabetes_Black_Female * diabetes);
            risk = 1 - Math.Pow(S10_Black_Female, Math.Exp(terms - Mean_Terms_Black_Female));
        }
        else if (race == 2 && sex == 1) // White or other race male
        {
            terms = (C_Age_White_Male * Math.Log(age)) +
                    (C_Sq_Age_White_Male * Math.Pow(Math.Log(age), 2)) +
                    (C_Total_Chol_White_Male * Math.Log(totalCholesterol)) +
                    (C_Age_Total_Chol_White_Male * Math.Log(age) * Math.Log(totalCholesterol)) +
                    (C_HDL_Chol_White_Male * Math.Log(hdlCholesterol)) +
                    (C_Age_HDL_Chol_White_Male * Math.Log(age) * Math.Log(hdlCholesterol)) +
                    (onHypertensionMed * C_On_Hypertension_Meds_White_Male * Math.Log(systolicBloodPressure)) +
                    (onHypertensionMed * C_Age_On_Hypertension_Meds_White_Male * Math.Log(age) * Math.Log(systolicBloodPressure)) +
                    (onHypertensionMed == 1 ? C_Off_Hypertension_Meds_White_Male * Math.Log(systolicBloodPressure) : 0) +
                    (onHypertensionMed == 1 ? C_Age_Off_Hypertension_Meds_White_Male * Math.Log(age) * Math.Log(systolicBloodPressure) : 0) +
                    (smoker * C_Smoker_White_Male * smoker) +
                    (smoker * C_Age_Smoker_White_Male * Math.Log(age) * smoker) +
                    (diabetes * C_Diabetes_White_Male * diabetes);
            risk = 1 - Math.Pow(S10_White_Male, Math.Exp(terms - Mean_Terms_White_Male));
        }
        else if (race == 2 && sex == 2) // White or other race female
        {
            terms = (C_Age_White_Female * Math.Log(age)) +
                    (C_Sq_Age_White_Female * Math.Pow(Math.Log(age), 2)) +
                    (C_Total_Chol_White_Female * Math.Log(totalCholesterol)) +
                    (C_Age_Total_Chol_White_Female * Math.Log(age) * Math.Log(totalCholesterol)) +
                    (C_HDL_Chol_White_Female * Math.Log(hdlCholesterol)) +
                    (C_Age_HDL_Chol_White_Female * Math.Log(age) * Math.Log(hdlCholesterol)) +
                    (onHypertensionMed * C_On_Hypertension_Meds_White_Female * Math.Log(systolicBloodPressure)) +
                    (onHypertensionMed * C_Age_On_Hypertension_Meds_White_Female * Math.Log(age) * Math.Log(systolicBloodPressure)) +
                    (onHypertensionMed == 1 ? C_Off_Hypertension_Meds_White_Female * Math.Log(systolicBloodPressure) : 0) +
                    (onHypertensionMed == 1 ? C_Age_Off_Hypertension_Meds_White_Female * Math.Log(age) * Math.Log(systolicBloodPressure) : 0) +
                    (smoker * C_Smoker_White_Female * smoker) +
                    (smoker * C_Age_Smoker_White_Female * Math.Log(age) * smoker) +
                    (diabetes * C_Diabetes_White_Female * diabetes);
            risk = 1 - Math.Pow(S10_White_Female, Math.Exp(terms - Mean_Terms_White_Female));
        }

        return risk;
    }
}
