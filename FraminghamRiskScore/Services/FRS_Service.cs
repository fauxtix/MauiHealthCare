using static FraminghamRiskScore.Enums;

namespace FraminghamRiskScore.Services
{
    public class FRS_Service : IFRS_Service
    {
        public int GetAgePoints(int age, Gender gender)
        {
            int points;

            switch (gender)
            {
                case Gender.Male:
                    points = CalculateAgePointsForMale(age);
                    break;
                case Gender.Female:
                    points = CalculateAgePointsForFemale(age);
                    break;
                default:
                    points = 0;
                    break;
            }

            return points;
        }

        private int CalculateAgePointsForFemale(int age)
        {
            return age switch
            {
                _ when age >= 20 && age < 35 => -7,
                _ when age >= 35 && age < 40 => -3,
                _ when age >= 40 && age < 45 => 0,
                _ when age >= 45 && age < 50 => 3,
                _ when age >= 50 && age < 55 => 6,
                _ when age >= 55 && age < 60 => 8,
                _ when age >= 60 && age < 65 => 10,
                _ when age >= 65 && age < 70 => 12,
                _ when age >= 70 && age < 75 => 14,
                _ when age >= 75 && age < 80 => 16,
                _ => 0,
            };
        }

        private int CalculateAgePointsForMale(int age)
        {
            return age switch
            {
                _ when age >= 20 && age < 35 => -9,
                _ when age >= 35 && age < 40 => -4,
                _ when age >= 40 && age < 45 => 0,
                _ when age >= 45 && age < 50 => 3,
                _ when age >= 50 && age < 55 => 6,
                _ when age >= 55 && age < 60 => 8,
                _ when age >= 60 && age < 65 => 10,
                _ when age >= 65 && age < 70 => 11,
                _ when age >= 70 && age < 75 => 12,
                _ when age >= 75 && age < 80 => 13,
                _ => 0,
            };
        }

        public int GetSmokingPoints(Gender gender, bool isSmoker, int age)
        {
            return gender switch
            {
                Gender.Male => CalculatePointsForMaleSmoking(isSmoker, age),
                Gender.Female => CalculatePointsForFemaleSmoking(isSmoker, age),
                _ => 0,
            };
        }

        private int CalculatePointsForFemaleSmoking(bool isSmoker, int age)
        {
            return isSmoker ? GetPointsForSmokerFemale(age) : 0;
        }

        private int CalculatePointsForMaleSmoking(bool isSmoker, int age)
        {
            return isSmoker ? GetPointsForSmokerMale(age) : 0;
        }

        private int GetPointsForSmokerFemale(int age)
        {
            return age switch
            {
                _ when age >= 20 && age < 40 => 9,
                _ when age >= 40 && age < 50 => 7,
                _ when age >= 50 && age < 60 => 4,
                _ when age >= 60 && age < 70 => 2,
                _ when age >= 70 && age < 80 => 1,
                _ => 0,
            };
        }

        private int GetPointsForSmokerMale(int age)
        {
            return age switch
            {
                _ when age >= 20 && age < 40 => 8,
                _ when age >= 40 && age < 50 => 5,
                _ when age >= 50 && age < 60 => 3,
                _ when age >= 60 && age < 70 => 1,
                _ when age >= 70 && age < 80 => 1,
                _ => 0,
            };
        }
        public int GetTotalCholesterolPoints(int age, Gender gender, int totalCholesterol)
        {
            int points;

            switch (gender)
            {
                case Gender.Male:
                    points = GetPointsForTotalCholesterolMale(age, totalCholesterol);
                    break;
                case Gender.Female:
                    points = GetPointsForTotalCholesterolFemale(age, totalCholesterol);
                    break;
                default:
                    points = 0;
                    break;
            }

            return points;
        }


        // Age 20–39 years: Under 160: 0 points. 160-199: 4 points. 200-239: 8 points. 240-279: 11 points. 280 or higher: 13 points.
        //Age 40–49 years: Under 160: 0 points. 160-199: 3 points. 200-239: 6 points. 240-279: 8 points. 280 or higher: 10 points.
        //Age 50–59 years: Under 160: 0 points. 160-199: 2 points. 200-239: 4 points. 240-279: 5 points. 280 or higher: 7 points.
        //Age 60–69 years: Under 160: 0 points. 160-199: 1 point. 200-239: 2 points. 240-279: 3 points. 280 or higher: 4 points.
        //Age 70–79 years: Under 160: 0 points. 160-199: 1 point. 200-239: 1 point. 240-279: 2 points. 280 or higher: 2 points.

        private int GetPointsForTotalCholesterolMale(int age, int totalCholesterol)
        {
            switch (age)
            {
                case int n when (n >= 20 && n < 40):
                    switch (totalCholesterol)
                    {
                        case int m when (m < 160): return 0;
                        case int m when (m <= 199): return 4;
                        case int m when (m <= 239): return 7;
                        case int m when (m <= 279): return 9;
                        case int m when (m >= 280): return 11;
                        default: return 0;
                    }
                case int n when (n >= 40 && n < 50):
                    switch (totalCholesterol)
                    {
                        case int m when (m < 160): return 0;
                        case int m when (m <= 199): return 3;
                        case int m when (m <= 239): return 5;
                        case int m when (m <= 279): return 6;
                        case int m when (m >= 280): return 8;
                        default: return 0; 
                    }
                case int n when (n >= 50 && n < 60):
                    switch (totalCholesterol)
                    {
                        case int m when (m < 160): return 0;
                        case int m when (m <= 199): return 2;
                        case int m when (m <= 239): return 3;
                        case int m when (m <= 279): return 4;
                        case int m when (m >= 280): return 5;
                        default: return 0; 
                    }
                case int n when (n >= 60 && n < 70):
                    switch (totalCholesterol)
                    {
                        case int m when (m < 160): return 0;
                        case int m when (m <= 199): return 1;
                        case int m when (m <= 239): return 1;
                        case int m when (m <= 279): return 2;
                        case int m when (m >= 280): return 3;
                        default: return 0; 
                    }
                case int n when (n >= 70 && n < 80):
                    switch (totalCholesterol)
                    {
                        case int m when (m < 160): return 0;
                        case int m when (m <= 199): return 0;
                        case int m when (m <= 239): return 0;
                        case int m when (m <= 279): return 1;
                        case int m when (m >= 280): return 1;
                        default: return 0; 
                    }
                default:
                    return 0; 
            }
        }

        private int GetPointsForTotalCholesterolFemale(int age, int totalCholesterol)
        {
            switch (age)
            {
                case int n when (n >= 20 && n < 40):
                    switch (totalCholesterol)
                    {
                        case int m when (m < 160): return 0;
                        case int m when (m <= 199): return 4;
                        case int m when (m <= 239): return 8;
                        case int m when (m <= 279): return 11;
                        case int m when (m >= 280): return 13;
                        default: return 0; 
                    }
                case int n when (n >= 40 && n < 50):
                    switch (totalCholesterol)
                    {
                        case int m when (m < 160): return 0;
                        case int m when (m <= 199): return 3;
                        case int m when (m <= 239): return 6;
                        case int m when (m <= 279): return 8;
                        case int m when (m >= 280): return 10;
                        default: return 0; 
                    }
                case int n when (n >= 50 && n < 60):
                    switch (totalCholesterol)
                    {
                        case int m when (m < 160): return 0;
                        case int m when (m <= 199): return 2;
                        case int m when (m <= 239): return 4;
                        case int m when (m <= 279): return 5;
                        case int m when (m >= 280): return 7;
                        default: return 0; 
                    }
                case int n when (n >= 60 && n < 70):
                    switch (totalCholesterol)
                    {
                        case int m when (m < 160):
                            return 0;
                        case int m when (m <= 199): return 1;
                        case int m when (m <= 239): return 2;
                        case int m when (m <= 279): return 3;
                        case int m when (m >= 280): return 4;
                        default: return 0; 
                    }
                case int n when (n >= 70 && n < 80):
                    switch (totalCholesterol)
                    {
                        case int m when (m < 160): return 0;
                        case int m when (m <= 199): return 1;
                        case int m when (m <= 239): return 1;
                        case int m when (m <= 279): return 2;
                        case int m when (m >= 280): return 2;
                        default: return 0; 
                    }
                default:
                    return 0; 
            }
        }
        public int GetHDLCholesterolPoints(Gender gender, int hdlCholesterol)
        {
            return gender switch
            {
                Gender.Male => CalculatePointsForMaleHDLCholesterol(hdlCholesterol),
                Gender.Female => CalculatePointsForFemaleHDLCholesterol(hdlCholesterol),
                _ => 0,
            };
        }

        private int CalculatePointsForFemaleHDLCholesterol(int hdlCholesterol)
        {
            return hdlCholesterol switch
            {
                _ when hdlCholesterol >= 60 => -1,
                _ when hdlCholesterol >= 50 && hdlCholesterol < 60 => 0,
                _ when hdlCholesterol >= 40 && hdlCholesterol < 50 => 1,
                _ when hdlCholesterol < 40 => 2,
                _ => 0,
            };
        }

        private int CalculatePointsForMaleHDLCholesterol(int hdlCholesterol)
        {
            return hdlCholesterol switch
            {
                _ when hdlCholesterol >= 60 => -1,
                _ when hdlCholesterol >= 50 && hdlCholesterol < 60 => 0,
                _ when hdlCholesterol >= 40 && hdlCholesterol < 50 => 1,
                _ when hdlCholesterol < 40 => 2,
                _ => 0,
            };
        }
        public int GetSystolicBloodPressurePoints(int systolicBloodPressure, bool isTreated, Gender gender)
        {
            int points;

            switch (gender)
            {
                case Gender.Male:
                    points = CalculateSystolicPointsForMale(systolicBloodPressure, isTreated);
                    break;
                case Gender.Female:
                    points = CalculateSystolicPointsForFemale(systolicBloodPressure, isTreated);
                    break;
                default:
                    points = 0;
                    break;
            }

            return points;
        }

        private int CalculateSystolicPointsForFemale(int systolicBloodPressure, bool isTreated)
        {
            if (isTreated)
            {
                return systolicBloodPressure switch
                {
                    _ when systolicBloodPressure < 120 => 0,
                    _ when systolicBloodPressure >= 120 && systolicBloodPressure < 130 => 3,
                    _ when systolicBloodPressure >= 130 && systolicBloodPressure < 140 => 4,
                    _ when systolicBloodPressure >= 140 && systolicBloodPressure < 160 => 5,
                    _ when systolicBloodPressure >= 160 => 6,
                    _ => 0,
                };
            }
            else
            {
                return systolicBloodPressure switch
                {
                    _ when systolicBloodPressure < 120 => 0,
                    _ when systolicBloodPressure >= 120 && systolicBloodPressure < 130 => 1,
                    _ when systolicBloodPressure >= 130 && systolicBloodPressure < 140 => 2,
                    _ when systolicBloodPressure >= 140 && systolicBloodPressure < 160 => 3,
                    _ when systolicBloodPressure >= 160 => 4,
                    _ => 0,
                };
            }
        }

        private int CalculateSystolicPointsForMale(int systolicBloodPressure, bool isTreated)
        {
            // TODO (maybe) these values don't seem to be correct, as there are different ranges with same pontuaction.
            // Should investigate further

            // *Untreated*

            // Under 120: 0 points.??
            // 120-129: 0 points.??
            // 130-139: 1 point. ??
            // 140-159: 1 point. ??
            // 160 or higher: 2 points.

            //
            // *Treated*
            //

            // Under 120: 0 points.
            // 120-129: 1 point.
            // 130-139: 2 points. ??
            // 140-159: 2 points. ??
            // 160 or higher: 3 points

            if (isTreated)
            {
                return systolicBloodPressure switch
                {
                    _ when systolicBloodPressure < 120 => 0,
                    _ when systolicBloodPressure >= 120 && systolicBloodPressure < 130 => 1,
                    _ when systolicBloodPressure >= 130 && systolicBloodPressure < 140 => 2,
                    _ when systolicBloodPressure >= 140 && systolicBloodPressure < 160 => 2,
                    _ when systolicBloodPressure >= 160 => 3,
                    _ => 0,
                };
            }
            else
            {
                return systolicBloodPressure switch
                {
                    _ when systolicBloodPressure < 120 => 0,
                    _ when systolicBloodPressure >= 120 && systolicBloodPressure < 130 => 0,
                    _ when systolicBloodPressure >= 130 && systolicBloodPressure < 140 => 1,
                    _ when systolicBloodPressure >= 140 && systolicBloodPressure < 160 => 1,
                    _ when systolicBloodPressure >= 160 => 2,
                    _ => 0,
                };
            }
        }
    }
}
