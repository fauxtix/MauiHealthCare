using static FraminghamRiskScore.Enums;

namespace FraminghamRiskScore.Services
{
    public interface IFRS_Service
    {
        int GetAgePoints(int age, Gender gender);
        int GetHDLCholesterolPoints(Gender gender, int hdlCholesterol);
        int GetSmokingPoints(Gender gender, bool isSmoker, int age);
        int GetSystolicBloodPressurePoints(int systolicBloodPressure, bool isTreated, Gender gender);
        int GetTotalCholesterolPoints(int age, Gender gender, int totalCholesterol);
    }
}