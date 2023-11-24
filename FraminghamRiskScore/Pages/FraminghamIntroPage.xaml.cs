namespace FraminghamRiskScore.Pages;

public partial class FraminghamIntroPage : ContentPage
{
	public FraminghamIntroPage()
	{
		InitializeComponent();
	}

    private void SimulationBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(FraminghamRiskScorePage)}", true);
    }

}