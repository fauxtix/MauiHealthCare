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
                    points = CalculateTotalCholesterolPointsForMale(age, totalCholesterol);
                    break;
                case Gender.Female:
                    points = CalculateTotalCholesterolPointsForFemale(age, totalCholesterol);
                    break;
                default:
                    points = 0;
                    break;
            }

            return points;
        }

        private int CalculateTotalCholesterolPointsForFemale(int age, int totalCholesterol)
        {
            return age switch
            {
                _ when age >= 20 && age < 40 => CalculatePointsForTotalCholesterol(totalCholesterol, 160, 200, 240, 280),
                _ when age >= 40 && age < 50 => CalculatePointsForTotalCholesterol(totalCholesterol, 160, 200, 240, 280),
                _ when age >= 50 && age < 60 => CalculatePointsForTotalCholesterol(totalCholesterol, 160, 200, 240, 280),
                _ when age >= 60 && age < 70 => CalculatePointsForTotalCholesterol(totalCholesterol, 160, 200, 240, 280),
                _ when age >= 70 && age < 80 => CalculatePointsForTotalCholesterol(totalCholesterol, 160, 200, 240, 280),
                _ => 0,
            };
        }

        private int CalculateTotalCholesterolPointsForMale(int age, int totalCholesterol)
        {
            return age switch
            {
                _ when age >= 20 && age < 40 => CalculatePointsForTotalCholesterol(totalCholesterol, 160, 200, 240, 280),
                _ when age >= 40 && age < 50 => CalculatePointsForTotalCholesterol(totalCholesterol, 160, 200, 240, 280),
                _ when age >= 50 && age < 60 => CalculatePointsForTotalCholesterol(totalCholesterol, 160, 200, 240, 280),
                _ when age >= 60 && age < 70 => CalculatePointsForTotalCholesterol(totalCholesterol, 160, 200, 240, 280),
                _ when age >= 70 && age < 80 => CalculatePointsForTotalCholesterol(totalCholesterol, 160, 200, 240, 280),
                _ => 0,
            };
        }

        private int CalculatePointsForTotalCholesterol(int totalCholesterol, int range1, int range2, int range3, int range4)
        {
            return totalCholesterol switch
            {
                _ when totalCholesterol < range1 => 0,
                _ when totalCholesterol >= range1 && totalCholesterol < range2 => 4,
                _ when totalCholesterol >= range2 && totalCholesterol < range3 => 8,
                _ when totalCholesterol >= range3 && totalCholesterol < range4 => 11,
                _ when totalCholesterol >= range4 => 13,
                _ => 0,
            };
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
                    _ when systolicBloodPressure >= 130 && systolicBloodPressure < 140 => 1,
                    _ when systolicBloodPressure >= 140 && systolicBloodPressure < 160 => 2,
                    _ when systolicBloodPressure >= 160 => 3,
                    _ => 0,
                };
            }
        }

        private int CalculateSystolicPointsForMale(int systolicBloodPressure, bool isTreated)
        {
            // Untreated:

            // Under 120: 0 points.
            // 120-129: 0 points.
            // 130-139: 1 point. ??
            // 140-159: 1 point. ??
            // 160 or higher: 2 points.
            //
            // • Treated:
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
                    _ when systolicBloodPressure >= 140 && systolicBloodPressure < 160 => 2,
                    _ when systolicBloodPressure >= 160 => 3,
                    _ => 0,
                };
            }
        }
    }
}
