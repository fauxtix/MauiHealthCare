using System.Text;

namespace PreDiabetes
{
    public partial class frmPreDiabetes : Form
    {
        public frmPreDiabetes()
        {
            InitializeComponent();
            if (Sexo_F.Checked)
            {
                LarguraAncaMulheres.Enabled = true;
                LarguraAncaHomens.Enabled = false;
            }
            else
            {
                LarguraAncaMulheres.Enabled = false;
                LarguraAncaHomens.Enabled = true;
            }

        }

        void Calcular()
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
            string txtCor;
            txtCor = "Black";
            if (this.optIdade1.Checked)
                Idade = 0;
            else if (this.optIdade2.Checked)
                Idade = 2;
            else if (this.optIdade3.Checked)
                Idade = 4;
            else if (this.optIdade4.Checked)
                Idade = 6;
            else if (this.optIdade5.Checked)
                Idade = 8;

            if (this.Sexo_F.Checked)
                Sexo = 0;
            else if (this.Sexo_M.Checked)
                Sexo = 3;

            if (this.Parente_N.Checked)
                Parentesco = 0;
            else if (this.Parente_S.Checked)
                Parentesco = 3;

            if (this.Glucose_N.Checked)
                Glucose = 0;
            else if (this.Glucose_S.Checked)
                Glucose = 6;

            if (this.Hipertensao_N.Checked)
                Hipertensao = 0;
            else if (this.Hipertensao_S.Checked)
                Hipertensao = 2;

            if (this.Fumador_N.Checked)
                Fumador = 0;
            else if (this.Fumador_S.Checked)
                Fumador = 2;

            if (this.optVegetais_1.Checked)
                Vegetais = 0;
            else if (this.optVegetais_2.Checked)
                Vegetais = 1;

            if (this.ActividadeFisica_N.Checked)
                Actividade = 0;
            else if (this.ActividadeFisica_S.Checked)
                Actividade = 2;

            if (this.optLarguraAncaH_1.Checked || this.optLarguraAncaM_1.Checked)
                LarguraAnca = 0;
            else if (this.optLarguraAncaH_2.Checked || this.optLarguraAncaM_2.Checked)
                LarguraAnca = 4;
            else if (this.optLarguraAncaH_3.Checked || this.optLarguraAncaM_3.Checked)
                LarguraAnca = 7;


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
                sb.AppendLine("Para valores entre 7-10, 1 em cada 30 pessoas (aprox.) vai desenvolver diabetes.");
                txtResultado = sb.ToString();
            }
            else
            {
                txtRisco = "Elevado";
                sb.AppendLine("Para valores entre 11-14, uma pessoa em cada 14 vai desenvolver Diabetes;");
                sb.AppendLine("Para valores entre 15-18, 1 em cada 7 pessoas vai desenvolver Diabetes;");
                sb.AppendLine("Para valores de 19 ou mais, 1 em cada 3 pessoas vai desenvolver Diabetes.");
                txtResultado = sb.ToString();
                txtCor = "Red";
            }

            this.lblRisco.Text = txtRisco;
            this.lblRisco.ForeColor = Color.FromName(txtCor);
            this.txtResultado.Text = txtResultado;
            this.txtPontos.Text = SomaPontos.ToString();
            this.Invalidate();

        }

        private void Sexo_F_CheckedChanged(object sender, EventArgs e)
        {
            LarguraAncaMulheres.Enabled = true;
            optLarguraAncaM_1.Checked = true;

            optLarguraAncaH_1.Checked = false;
            optLarguraAncaH_2.Checked = false;
            optLarguraAncaH_3.Checked = false;

            LarguraAncaHomens.Enabled = false;

        }

        private void Sexo_M_CheckedChanged(object sender, EventArgs e)
        {
            LarguraAncaMulheres.Enabled = false;
            optLarguraAncaH_1.Checked = true;

            optLarguraAncaM_1.Checked = false;
            optLarguraAncaM_2.Checked = false;
            optLarguraAncaM_3.Checked = false;

            LarguraAncaHomens.Enabled = true;

        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            Risco.Visible = true;
            Calcular();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPontos.Clear();
            txtResultado.Clear();
        }

    }
}
