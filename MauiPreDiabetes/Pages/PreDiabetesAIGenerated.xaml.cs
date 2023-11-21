namespace MauiPreDiabetes;

public partial class PreDiabetesAIGenerated : ContentPage
{
    public PreDiabetesAIGenerated()
    {
        InitializeComponent();
    }
    private void CalculateButton_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(AgeEntry.Text, out int age) && double.TryParse(BMIEntry.Text, out double bmi))
        {
            bool familyHistory = FamilyHistorySwitch.IsToggled;
            bool activeLifestyle = ActiveLifestyleSwitch.IsToggled;

            double riskScore = CalculateRiskScore(age, bmi, familyHistory, activeLifestyle);
            DisplayRiskResult(riskScore);
        }
        else
        {
            ResultLabel.Text = "Invalid input. Please enter valid age and BMI.";
        }
    }

    private double CalculateRiskScore(int age, double bmi, bool familyHistory, bool activeLifestyle)
    {
        double ageFactor = age * 0.02;
        double bmiFactor = bmi * 0.1;

        // Additional factors
        double familyHistoryFactor = familyHistory ? 0.3 : 0;
        double activityFactor = activeLifestyle ? -0.2 : 0;

        // Combine factors
        double riskScore = ageFactor + bmiFactor + familyHistoryFactor + activityFactor;

        return riskScore;
    }

    private void DisplayRiskResult(double riskScore)
    {
        // Your logic for displaying the pre-diabetes risk result.
        // This is a simple example; you can customize it based on your needs.

        ResultLabel.Text = $"Your Pre-Diabetes Risk Score: {riskScore:F2}";
    }
}