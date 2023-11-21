namespace MauiPreDiabetes.Pages;

public partial class PreDiabetesIntroPage : ContentPage
{
	public PreDiabetesIntroPage()
	{
		InitializeComponent();
	}

    private void SimulationBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync($"{nameof(PreDiabetesPage)}", true);
    }
}