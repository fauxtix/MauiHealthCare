using CardiovascularRiskAssessment.Enums;

namespace CardiovascularRiskAssessment.Services;

public class CRA_Service : ICRA_Service
{
    const double CAge_BlackFemale = 17.114;
    const double CSqAge_BlackFemale = 0;
    const double CTotalChol_BlackFemale = 0.94;
    const double CAgeTotalChol_BlackFemale = 0;
    const double CHDLChol_BlackFemale = -18.92;
    const double CAgeHDLChol_BlackFemale = 4.475;
    const double COnHypertensionMeds_BlackFemale = 29.291;
    const double CAgeOnHypertensionMeds_BlackFemale = -6.432;
    const double COffHypertensionMeds_BlackFemale = 27.82;
    const double CAgeOffHypertensionMeds_BlackFemale = -6.087;
    const double CSmoker_BlackFemale = 0.691;
    const double CAgeSmoker_BlackFemale = 0;
    const double CDiabetes_BlackFemale = 0.874;
    const double S10_BlackFemale = 0.9533;
    const double MeanTerms_BlackFemale = 86.61;

    // Constants for White or other race female patients
    const double CAge_WhiteFemale = -29.799;
    const double CSqAge_WhiteFemale = 4.884;
    const double CTotalChol_WhiteFemale = 13.54;
    const double CAgeTotalChol_WhiteFemale = -3.114;
    const double CHDLChol_WhiteFemale = -13.578;
    const double CAgeHDLChol_WhiteFemale = 3.149;
    const double COnHypertensionMeds_WhiteFemale = 2.019;
    const double CAgeOnHypertensionMeds_WhiteFemale = 0;
    const double COffHypertensionMeds_WhiteFemale = 1.957;
    const double CAgeOffHypertensionMeds_WhiteFemale = 0;
    const double CSmoker_WhiteFemale = 7.574;
    const double CAgeSmoker_WhiteFemale = -1.665;
    const double CDiabetes_WhiteFemale = 0.661;
    const double S10_WhiteFemale = 0.9665;
    const double MeanTerms_WhiteFemale = -29.18;

    // Constants for Black or African American male patients
    const double CAge_BlackMale = 2.469;
    const double CSqAge_BlackMale = 0;
    const double CTotalChol_BlackMale = 0.302;
    const double CAgeTotalChol_BlackMale = 0;
    const double CHDLChol_BlackMale = -0.307;
    const double CAgeHDLChol_BlackMale = 0;
    const double COnHypertensionMeds_BlackMale = 1.916;
    const double CAgeOnHypertensionMeds_BlackMale = 0;
    const double COffHypertensionMeds_BlackMale = 1.809;
    const double CAgeOffHypertensionMeds_BlackMale = 0;
    const double CSmoker_BlackMale = 0.549;
    const double CAgeSmoker_BlackMale = 0;
    const double CDiabetes_BlackMale = 0.645;
    const double S10_BlackMale = 0.8954;
    const double MeanTerms_BlackMale = 19.54;

    // Constants for White or other race male patients
    const double CAge_WhiteMale = 12.344;
    const double CSqAge_WhiteMale = 0;
    const double CTotalChol_WhiteMale = 11.853;
    const double CAgeTotalChol_WhiteMale = -2.664;
    const double CHDLChol_WhiteMale = -7.99;
    const double CAgeHDLChol_WhiteMale = 1.769;
    const double COnHypertensionMeds_WhiteMale = 1.797;
    const double CAgeOnHypertensionMeds_WhiteMale = 0;
    const double COffHypertensionMeds_WhiteMale = 1.764;
    const double CAgeOffHypertensionMeds_WhiteMale = 0;
    const double CSmoker_WhiteMale = 7.837;
    const double CAgeSmoker_WhiteMale = -1.795;
    const double CDiabetes_WhiteMale = 0.658;
    const double S10_WhiteMale = 0.9144;
    const double MeanTerms_WhiteMale = 61.18;
    public double Calculate10YearRisk(int age, AppEnums.Gender sex, AppEnums.Race ethnicity, double systolicBloodPressure,
        bool isTakingBPmedication, bool hasDiabetes, bool isSmoker, double totalCholesterol, double hdlCholesterol)
    {
        double logit = CalculateRiskInternal(age, sex, ethnicity, systolicBloodPressure, isTakingBPmedication,
            hasDiabetes, isSmoker, totalCholesterol, hdlCholesterol);
        return logit;
//        return 100 / (1 + Math.Exp(-logit));
    }

    private double CalculateRiskInternal(int age, AppEnums.Gender gender, AppEnums.Race ethnicity,
                                             double systolicBloodPressure, bool isTakingBPmedication,
                                             bool hasDiabetes, bool isSmoker,
                                             double totalCholesterol, double hdlCholesterol)
    {
        double terms = 0.0;
        double meanTerms = 0.0;
        double s10 = 0.0;

        if (ethnicity == AppEnums.Race.Black && gender == AppEnums.Gender.Female)
        {
            terms = (CAge_BlackFemale * Math.Log(age)) +
                    (CSqAge_BlackFemale * Math.Pow(Math.Log(age), 2)) +
                    (CTotalChol_BlackFemale * Math.Log(totalCholesterol)) +
                    (CAgeTotalChol_BlackFemale * Math.Log(age) * Math.Log(totalCholesterol)) +
                    (CHDLChol_BlackFemale * Math.Log(hdlCholesterol)) +
                    (CAgeHDLChol_BlackFemale * Math.Log(age) * Math.Log(hdlCholesterol)) +
                    (isTakingBPmedication ? COnHypertensionMeds_BlackFemale * Math.Log(systolicBloodPressure) :
                        COffHypertensionMeds_BlackFemale * Math.Log(systolicBloodPressure)) +
                    (isTakingBPmedication ? CAgeOnHypertensionMeds_BlackFemale * Math.Log(age) * Math.Log(systolicBloodPressure) :
                        CAgeOffHypertensionMeds_BlackFemale * Math.Log(age) * Math.Log(systolicBloodPressure)) +
                    (isSmoker ? CSmoker_BlackFemale : 0) +
                    (isSmoker ? CAgeSmoker_BlackFemale * Math.Log(age) : 0) +
                    (hasDiabetes ? CDiabetes_BlackFemale : 0);

            meanTerms = MeanTerms_BlackFemale;
            s10 = S10_BlackFemale;
        }
        else if (ethnicity == AppEnums.Race.White && gender == AppEnums.Gender.Female)
        {
            terms = (CAge_WhiteFemale * Math.Log(age)) +
                    (CSqAge_WhiteFemale * Math.Pow(Math.Log(age), 2)) +
                    (CTotalChol_WhiteFemale * Math.Log(totalCholesterol)) +
                    (CAgeTotalChol_WhiteFemale * Math.Log(age) * Math.Log(totalCholesterol)) +
                    (CHDLChol_WhiteFemale * Math.Log(hdlCholesterol)) +
                    (CAgeHDLChol_WhiteFemale * Math.Log(age) * Math.Log(hdlCholesterol)) +
                    (isTakingBPmedication ? COnHypertensionMeds_WhiteFemale * Math.Log(systolicBloodPressure) :
                        COffHypertensionMeds_WhiteFemale * Math.Log(systolicBloodPressure)) +
                    (isTakingBPmedication ? CAgeOnHypertensionMeds_WhiteFemale * Math.Log(age) * Math.Log(systolicBloodPressure) :
                        CAgeOffHypertensionMeds_WhiteFemale * Math.Log(age) * Math.Log(systolicBloodPressure)) +
                    (isSmoker ? CSmoker_WhiteFemale : 0) +
                    (isSmoker ? CAgeSmoker_WhiteFemale * Math.Log(age) : 0) +
                    (hasDiabetes ? CDiabetes_WhiteFemale : 0);

            meanTerms = MeanTerms_WhiteFemale;
            s10 = S10_WhiteFemale;
        }
        else if (ethnicity == AppEnums.Race.Black && gender == AppEnums.Gender.Male)
        {
            terms = (CAge_BlackMale * Math.Log(age)) +
                    (CSqAge_BlackMale * Math.Pow(Math.Log(age), 2)) +
                    (CTotalChol_BlackMale * Math.Log(totalCholesterol)) +
                    (CAgeTotalChol_BlackMale * Math.Log(age) * Math.Log(totalCholesterol)) +
                    (CHDLChol_BlackMale * Math.Log(hdlCholesterol)) +
                    (CAgeHDLChol_BlackMale * Math.Log(age) * Math.Log(hdlCholesterol)) +
                    (isTakingBPmedication ? COnHypertensionMeds_BlackMale * Math.Log(systolicBloodPressure) :
                        COffHypertensionMeds_BlackMale * Math.Log(systolicBloodPressure)) +
                    (isTakingBPmedication ? CAgeOnHypertensionMeds_BlackMale * Math.Log(age) * Math.Log(systolicBloodPressure) :
                        CAgeOffHypertensionMeds_BlackMale * Math.Log(age) * Math.Log(systolicBloodPressure)) +
                    (isSmoker ? CSmoker_BlackMale : 0) +
                    (isSmoker ? CAgeSmoker_BlackMale * Math.Log(age) : 0) +
                    (hasDiabetes ? CDiabetes_BlackMale : 0);

            meanTerms = MeanTerms_BlackMale;
            s10 = S10_BlackMale;
        }
        else if (ethnicity == AppEnums.Race.White && gender == AppEnums.Gender.Male)
        {
            terms = (CAge_WhiteMale * Math.Log(age)) +
                    (CSqAge_WhiteMale * Math.Pow(Math.Log(age), 2)) +
                    (CTotalChol_WhiteMale * Math.Log(totalCholesterol)) +
                    (CAgeTotalChol_WhiteMale * Math.Log(age) * Math.Log(totalCholesterol)) +
                    (CHDLChol_WhiteMale * Math.Log(hdlCholesterol)) +
                    (CAgeHDLChol_WhiteMale * Math.Log(age) * Math.Log(hdlCholesterol)) +
                    (isTakingBPmedication ? COnHypertensionMeds_WhiteMale * Math.Log(systolicBloodPressure) :
                        COffHypertensionMeds_WhiteMale * Math.Log(systolicBloodPressure)) +
                    (isTakingBPmedication ? CAgeOnHypertensionMeds_WhiteMale * Math.Log(age) * Math.Log(systolicBloodPressure) :
                        CAgeOffHypertensionMeds_WhiteMale * Math.Log(age) * Math.Log(systolicBloodPressure)) +
                    (isSmoker ? CSmoker_WhiteMale : 0) +
                    (isSmoker ? CAgeSmoker_WhiteMale * Math.Log(age) : 0) +
                    (hasDiabetes ? CDiabetes_WhiteMale : 0);

            meanTerms = MeanTerms_WhiteMale;
            s10 = S10_WhiteMale;
        }
        // Add more conditions for other demographic groups as needed

        // Calculate Risk
        double result = 1 - Math.Pow(Math.E, (terms - meanTerms) * s10);
        double risk = 100 * result;

        return risk;
    }
}
