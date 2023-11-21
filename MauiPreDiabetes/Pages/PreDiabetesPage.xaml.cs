using System.Text;

namespace MauiPreDiabetes
{
    public partial class PreDiabetesPage : ContentPage
    {
        int PontosIdade = 0;
        int PontosSexo = 0;
        int PontosParentesco = 0;
        int PontosGlucose = 0;
        int PontosHipertensao = 0;
        int PontosFumador = 0;
        int PontosVegetais = 0;
        int PontosActividade = 0;
        int PontosLarguraAnca = 0;
        int SomaPontos = 0;

        public PreDiabetesPage()
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

            PontosIdade = GetAgePoints(idadeEscolhida);
        }

        private void GenderGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var genero = Gender.SelectedIndex;
            PontosSexo = genero == 0 ? 0 : 3;
            ManWaistPicker.IsVisible = genero == 1;
            WomanWaistPicker.IsVisible = genero == 0;
        }

        private void Medicacao_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            PontosHipertensao = HipertensaoMedication.IsToggled ? 2 : 0;
        }
        private void Actividade_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            PontosActividade = AtividadeFisica.IsToggled ? 0 : 2;
        }
        private void FrequenciaVegetais_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var content = (sender as RadioButton).Content.ToString();
            var todosOsDias = content.ToLower().Contains("dias");

            PontosVegetais = todosOsDias ? 0 : 1;
        }
        private void ManWaist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ManWaistPicker.IsVisible)
            {
                var selectedOption = ManWaistPicker.SelectedIndex;
                PontosLarguraAnca = selectedOption == 0 ? 0 : selectedOption == 1 ? 4 : 7;
            }
        }
        private void WomanWaist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WomanWaistPicker.IsVisible)
            {
                var selectedOption = WomanWaistPicker.SelectedIndex;
                PontosLarguraAnca = selectedOption == 0 ? 0 : selectedOption == 1 ? 4 : 7;
            }

        }

        private void Smoker_Toggled(object sender, ToggledEventArgs e)
        {
            PontosFumador = Smoker.IsToggled ? 2 : 0;
        }


        private void Glucose_Toggled(object sender, ToggledEventArgs e)
        {
            PontosGlucose = GlucoseInTests.IsToggled ? 6 : 0;
        }

        private void HipertensaoMedication_Toggled(object sender, ToggledEventArgs e)
        {
            PontosHipertensao = HipertensaoMedication.IsToggled ? 2 : 0;
        }

        private void ParenteDiabetes_Toggled(object sender, ToggledEventArgs e)
        {
            PontosParentesco = ParenteDiabetes.IsToggled ? 3 : 0;
        }

        private void AtividadeFisica_Toggled(object sender, ToggledEventArgs e)
        {
            PontosActividade = AtividadeFisica.IsToggled ? 0 : 2;
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            SomaPontos = GetResultsInPoints();
            var output = GetMessageResults(SomaPontos);

            string resultMessages = $"Pontos: {SomaPontos}\nRisco: {output.RiskFactor}\n\n{output.MessageResult} ";

            ShowResult(resultMessages);
        }

        private int GetResultsInPoints()
        {
            return PontosIdade + PontosSexo + PontosParentesco + PontosGlucose + PontosHipertensao + PontosFumador + PontosVegetais + PontosActividade + PontosLarguraAnca;
        }
        private static (string MessageResult, string RiskFactor) GetMessageResults(int sumOfPoints)
        {
            // TODO - localize text
            StringBuilder sb = new StringBuilder();
            string riskFactor;
            string resultMsg;

            switch (sumOfPoints)
            {
                case int soma when soma <= 5:
                    riskFactor = "Baixo";
                    resultMsg = "Aproximadamente 1 pessoa em cada 100 vai desenvolver diabetes.";
                    break;
                case int soma when soma <= 10:
                    riskFactor = "Intermédio";
                    sb.AppendLine("Para valores entre 4-6, uma pessoa em cada 50 vai desenvolver diabetes;");
                    sb.AppendLine("\nPara valores entre 7-10, 1 em cada 30 pessoas (aprox.) vai desenvolver diabetes.");
                    resultMsg = sb.ToString();
                    break;
                default:
                    riskFactor = "Elevado";
                    sb.AppendLine("Para valores entre 11-14, uma pessoa em cada 14 vai desenvolver Diabetes;");
                    sb.AppendLine("\nPara valores entre 15-18, 1 em cada 7 pessoas vai desenvolver Diabetes;");
                    sb.AppendLine("\nPara valores de 19 ou mais, 1 em cada 3 pessoas vai desenvolver Diabetes.");
                    resultMsg = sb.ToString();
                    break;
            }

            return (resultMsg, riskFactor); 
        }

        private int GetAgePoints(int selectedAgeGroup)
        {
            if (selectedAgeGroup < 0) return 0;

            //int agePoints = 0;
            //switch (selectedAgeGroup)
            //{
            //    case 0:
            //        agePoints = 0;
            //        break;
            //    case 1:
            //        agePoints = 2;
            //        break;
            //    case 2:
            //        agePoints = 4;
            //        break;
            //    case 3:
            //        agePoints = 6;
            //        break;
            //    case 4:
            //        agePoints = 8;
            //        break;
            //}

            return selectedAgeGroup * 2;
        }
        private void ShowResult(string message)
        {
            Shell.Current.DisplayAlert("Resultado", message, "Ok");
        }
    }

}
