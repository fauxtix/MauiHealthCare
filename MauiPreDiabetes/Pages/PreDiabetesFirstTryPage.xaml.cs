using System.Text;

namespace MauiPreDiabetes
{
    public partial class MainPage : ContentPage
    {
        int Idade = 0;
        int Sexo = 0;
        int Parentesco = 0;
        int Glucose = 0;
        int Hipertensao = 0;
        int Fumador = 0;
        int Vegetais = 0;
        int Actividade = 0;
        int LarguraAnca = 0;
        int SomaPontos = 0;
        string txtResultado = "";
        string txtRisco = "";
        public MainPage()
        {
            InitializeComponent();
            GroupOfAges.SelectedIndex = 0;
            Gender.SelectedIndex = 0;
            ManWaistPicker.SelectedIndex = 0;
            WomanWaistPicker.SelectedIndex = 0;
        }

        private void GroupOfAges_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idadeEscolhida = GroupOfAges.SelectedIndex;
            
            if (idadeEscolhida < 0) return;

            switch (idadeEscolhida)
            {
                case 0:
                    Idade = 0;
                    break;
                case 1:
                    Idade = 2;
                    break;
                case 2:
                    Idade = 4;
                    break;
                case 3:
                    Idade = 6;
                    break;
                case 4:
                    Idade = 8;
                    break;
            }
        }

        private void GenderGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var genero = Gender.SelectedIndex;
            Sexo = genero == 0 ? 0 : 3;
            ManWaistPicker.IsVisible = genero == 1;
            WomanWaistPicker.IsVisible = genero == 0;
        }

        private void Medicacao_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            Hipertensao = HipertensaoMedication.IsToggled ? 2 : 0;
        }
        private void Actividade_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            Actividade = AtividadeFisica.IsToggled ? 0 : 2;
        }
        private void FrequenciaVegetais_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var content = (sender as RadioButton).Content.ToString();
            var todosOsDias = content.ToLower().Contains("dias");
            var sempre = content.ToLower().Contains("sempre");

            Vegetais = sempre ? 0 : 1;
        }
        private void ManWaist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ManWaistPicker.IsVisible)
            {
                var selectedOption = ManWaistPicker.SelectedIndex;
                LarguraAnca = selectedOption == 0 ? 0 : selectedOption == 1 ? 4 : 7;
            }
        }
        private void WomanWaist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WomanWaistPicker.IsVisible)
            {
                var selectedOption = WomanWaistPicker.SelectedIndex;
                LarguraAnca = selectedOption == 0 ? 0 : selectedOption == 1 ? 4 : 7;
            }

        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private void Smoker_Toggled(object sender, ToggledEventArgs e)
        {
            Fumador = Smoker.IsToggled ? 2 : 0;
        }


        private void Glucose_Toggled(object sender, ToggledEventArgs e)
        {
            Glucose = GlucoseInTests.IsToggled ? 6 : 0;
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            SomaPontos = Idade + Sexo + Parentesco + Glucose + Hipertensao + Fumador + Vegetais + Actividade + LarguraAnca;
            if (SomaPontos <= 5)
            {
                txtRisco = "Baixo";
                txtResultado = "Aproximadamente 1 pessoa em cada 100 vai desenvolver diabetes.";
            }
            else if (SomaPontos > 5 && SomaPontos <= 10)
            {
                txtRisco = "Intermédio";
                sb.AppendLine("Para valores entre 4-6, uma pessoa em cada 50 vai desenvolver diabetes;");
                sb.AppendLine("\nPara valores entre 7-10, 1 em cada 30 pessoas (aprox.) vai desenvolver diabetes.");
                txtResultado = sb.ToString();
            }
            else
            {
                txtRisco = "Elevado";
                sb.AppendLine("Para valores entre 11-14, uma pessoa em cada 14 vai desenvolver Diabetes;");
                sb.AppendLine("\nPara valores entre 15-18, 1 em cada 7 pessoas vai desenvolver Diabetes;");
                sb.AppendLine("\nPara valores de 19 ou mais, 1 em cada 3 pessoas vai desenvolver Diabetes.");
                txtResultado = sb.ToString();
            }

            string resultMsg = $"Pontos: {SomaPontos}\nRisco: {txtRisco}\n\n{txtResultado} ";
            Shell.Current.DisplayAlert("Resultado", resultMsg, "Ok");
        }

        private void HipertensaoMedication_Toggled(object sender, ToggledEventArgs e)
        {
            Hipertensao = HipertensaoMedication.IsToggled ? 2 : 0;
        }

        private void ParenteDiabetes_Toggled(object sender, ToggledEventArgs e)
        {
            Parentesco = ParenteDiabetes.IsToggled ? 3 : 0;
        }

        private void AtividadeFisica_Toggled(object sender, ToggledEventArgs e)
        {
            Actividade = AtividadeFisica.IsToggled ? 0 : 2;
        }
    }

}
