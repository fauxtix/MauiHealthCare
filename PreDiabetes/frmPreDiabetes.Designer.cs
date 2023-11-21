namespace PreDiabetes
{
    partial class frmPreDiabetes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreDiabetes));
            Idades = new GroupBox();
            optIdade5 = new RadioButton();
            optIdade4 = new RadioButton();
            optIdade3 = new RadioButton();
            optIdade2 = new RadioButton();
            optIdade1 = new RadioButton();
            ActividadeFisica = new GroupBox();
            ActividadeFisica_S = new RadioButton();
            ActividadeFisica_N = new RadioButton();
            Sexo = new GroupBox();
            Sexo_M = new RadioButton();
            Sexo_F = new RadioButton();
            Fumador = new GroupBox();
            Fumador_S = new RadioButton();
            Fumador_N = new RadioButton();
            Glucose = new GroupBox();
            Glucose_S = new RadioButton();
            Glucose_N = new RadioButton();
            Hipertensao = new GroupBox();
            Hipertensao_S = new RadioButton();
            Hipertensao_N = new RadioButton();
            Parentesco = new GroupBox();
            Parente_S = new RadioButton();
            Parente_N = new RadioButton();
            VegetaisFruta = new GroupBox();
            optVegetais_2 = new RadioButton();
            optVegetais_1 = new RadioButton();
            LarguraAnca = new GroupBox();
            LarguraAncaMulheres = new GroupBox();
            optLarguraAncaM_3 = new RadioButton();
            optLarguraAncaM_1 = new RadioButton();
            optLarguraAncaM_2 = new RadioButton();
            LarguraAncaHomens = new GroupBox();
            optLarguraAncaH_3 = new RadioButton();
            optLarguraAncaH_1 = new RadioButton();
            optLarguraAncaH_2 = new RadioButton();
            Risco = new GroupBox();
            lblRisco = new Label();
            label2 = new Label();
            txtResultado = new TextBox();
            txtPontos = new TextBox();
            label1 = new Label();
            ToolbarOptions = new ToolStrip();
            btnCalculate = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnClear = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnSair = new ToolStripButton();
            Idades.SuspendLayout();
            ActividadeFisica.SuspendLayout();
            Sexo.SuspendLayout();
            Fumador.SuspendLayout();
            Glucose.SuspendLayout();
            Hipertensao.SuspendLayout();
            Parentesco.SuspendLayout();
            VegetaisFruta.SuspendLayout();
            LarguraAnca.SuspendLayout();
            LarguraAncaMulheres.SuspendLayout();
            LarguraAncaHomens.SuspendLayout();
            Risco.SuspendLayout();
            ToolbarOptions.SuspendLayout();
            SuspendLayout();
            // 
            // Idades
            // 
            Idades.Controls.Add(optIdade5);
            Idades.Controls.Add(optIdade4);
            Idades.Controls.Add(optIdade3);
            Idades.Controls.Add(optIdade2);
            Idades.Controls.Add(optIdade1);
            Idades.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Idades.Location = new Point(20, 54);
            Idades.Margin = new Padding(4);
            Idades.Name = "Idades";
            Idades.Padding = new Padding(4);
            Idades.Size = new Size(275, 148);
            Idades.TabIndex = 0;
            Idades.TabStop = false;
            Idades.Text = "Grupo de idades";
            // 
            // optIdade5
            // 
            optIdade5.AutoSize = true;
            optIdade5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            optIdade5.Location = new Point(16, 121);
            optIdade5.Margin = new Padding(4);
            optIdade5.Name = "optIdade5";
            optIdade5.Size = new Size(122, 21);
            optIdade5.TabIndex = 4;
            optIdade5.Text = "65 anos ou mais";
            optIdade5.UseVisualStyleBackColor = true;
            // 
            // optIdade4
            // 
            optIdade4.AutoSize = true;
            optIdade4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            optIdade4.Location = new Point(16, 98);
            optIdade4.Margin = new Padding(4);
            optIdade4.Name = "optIdade4";
            optIdade4.Size = new Size(91, 21);
            optIdade4.TabIndex = 3;
            optIdade4.Text = "55-64 anos";
            optIdade4.UseVisualStyleBackColor = true;
            // 
            // optIdade3
            // 
            optIdade3.AutoSize = true;
            optIdade3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            optIdade3.Location = new Point(16, 75);
            optIdade3.Margin = new Padding(4);
            optIdade3.Name = "optIdade3";
            optIdade3.Size = new Size(91, 21);
            optIdade3.TabIndex = 2;
            optIdade3.Text = "45-54 anos";
            optIdade3.UseVisualStyleBackColor = true;
            // 
            // optIdade2
            // 
            optIdade2.AutoSize = true;
            optIdade2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            optIdade2.Location = new Point(16, 52);
            optIdade2.Margin = new Padding(4);
            optIdade2.Name = "optIdade2";
            optIdade2.Size = new Size(91, 21);
            optIdade2.TabIndex = 1;
            optIdade2.Text = "35-44 anos";
            optIdade2.UseVisualStyleBackColor = true;
            // 
            // optIdade1
            // 
            optIdade1.AutoSize = true;
            optIdade1.Checked = true;
            optIdade1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            optIdade1.Location = new Point(16, 29);
            optIdade1.Margin = new Padding(4);
            optIdade1.Name = "optIdade1";
            optIdade1.Size = new Size(135, 21);
            optIdade1.TabIndex = 0;
            optIdade1.TabStop = true;
            optIdade1.Text = "Menos de 35 anos";
            optIdade1.UseVisualStyleBackColor = true;
            // 
            // ActividadeFisica
            // 
            ActividadeFisica.Controls.Add(ActividadeFisica_S);
            ActividadeFisica.Controls.Add(ActividadeFisica_N);
            ActividadeFisica.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ActividadeFisica.Location = new Point(421, 54);
            ActividadeFisica.Margin = new Padding(4);
            ActividadeFisica.Name = "ActividadeFisica";
            ActividadeFisica.Padding = new Padding(4);
            ActividadeFisica.Size = new Size(317, 79);
            ActividadeFisica.TabIndex = 1;
            ActividadeFisica.TabStop = false;
            ActividadeFisica.Text = "Dispensa 30 min/dia para actividade física?";
            // 
            // ActividadeFisica_S
            // 
            ActividadeFisica_S.AutoSize = true;
            ActividadeFisica_S.Checked = true;
            ActividadeFisica_S.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ActividadeFisica_S.Location = new Point(16, 52);
            ActividadeFisica_S.Margin = new Padding(4);
            ActividadeFisica_S.Name = "ActividadeFisica_S";
            ActividadeFisica_S.Size = new Size(47, 19);
            ActividadeFisica_S.TabIndex = 11;
            ActividadeFisica_S.TabStop = true;
            ActividadeFisica_S.Text = "Não";
            ActividadeFisica_S.UseVisualStyleBackColor = true;
            // 
            // ActividadeFisica_N
            // 
            ActividadeFisica_N.AutoSize = true;
            ActividadeFisica_N.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ActividadeFisica_N.Location = new Point(16, 29);
            ActividadeFisica_N.Margin = new Padding(4);
            ActividadeFisica_N.Name = "ActividadeFisica_N";
            ActividadeFisica_N.Size = new Size(45, 19);
            ActividadeFisica_N.TabIndex = 10;
            ActividadeFisica_N.Text = "Sim";
            ActividadeFisica_N.UseVisualStyleBackColor = true;
            // 
            // Sexo
            // 
            Sexo.Controls.Add(Sexo_M);
            Sexo.Controls.Add(Sexo_F);
            Sexo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Sexo.Location = new Point(20, 208);
            Sexo.Margin = new Padding(4);
            Sexo.Name = "Sexo";
            Sexo.Padding = new Padding(4);
            Sexo.Size = new Size(117, 71);
            Sexo.TabIndex = 2;
            Sexo.TabStop = false;
            Sexo.Text = "Género";
            // 
            // Sexo_M
            // 
            Sexo_M.AutoSize = true;
            Sexo_M.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Sexo_M.Location = new Point(16, 44);
            Sexo_M.Margin = new Padding(4);
            Sexo_M.Name = "Sexo_M";
            Sexo_M.Size = new Size(85, 21);
            Sexo_M.TabIndex = 6;
            Sexo_M.Text = "Masculino";
            Sexo_M.UseVisualStyleBackColor = true;
            Sexo_M.CheckedChanged += Sexo_M_CheckedChanged;
            // 
            // Sexo_F
            // 
            Sexo_F.AutoSize = true;
            Sexo_F.Checked = true;
            Sexo_F.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Sexo_F.Location = new Point(16, 23);
            Sexo_F.Margin = new Padding(4);
            Sexo_F.Name = "Sexo_F";
            Sexo_F.Size = new Size(78, 21);
            Sexo_F.TabIndex = 5;
            Sexo_F.TabStop = true;
            Sexo_F.Text = "Feminino";
            Sexo_F.UseVisualStyleBackColor = true;
            Sexo_F.CheckedChanged += Sexo_F_CheckedChanged;
            // 
            // Fumador
            // 
            Fumador.Controls.Add(Fumador_S);
            Fumador.Controls.Add(Fumador_N);
            Fumador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Fumador.Location = new Point(211, 208);
            Fumador.Margin = new Padding(4);
            Fumador.Name = "Fumador";
            Fumador.Padding = new Padding(4);
            Fumador.Size = new Size(84, 71);
            Fumador.TabIndex = 3;
            Fumador.TabStop = false;
            Fumador.Text = "Fumador";
            // 
            // Fumador_S
            // 
            Fumador_S.AutoSize = true;
            Fumador_S.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Fumador_S.Location = new Point(16, 44);
            Fumador_S.Margin = new Padding(4);
            Fumador_S.Name = "Fumador_S";
            Fumador_S.Size = new Size(45, 19);
            Fumador_S.TabIndex = 7;
            Fumador_S.Text = "Sim";
            Fumador_S.UseVisualStyleBackColor = true;
            // 
            // Fumador_N
            // 
            Fumador_N.AutoSize = true;
            Fumador_N.Checked = true;
            Fumador_N.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Fumador_N.Location = new Point(16, 23);
            Fumador_N.Margin = new Padding(4);
            Fumador_N.Name = "Fumador_N";
            Fumador_N.Size = new Size(47, 19);
            Fumador_N.TabIndex = 6;
            Fumador_N.TabStop = true;
            Fumador_N.Text = "Não";
            Fumador_N.UseVisualStyleBackColor = true;
            // 
            // Glucose
            // 
            Glucose.Controls.Add(Glucose_S);
            Glucose.Controls.Add(Glucose_N);
            Glucose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Glucose.Location = new Point(20, 287);
            Glucose.Margin = new Padding(4);
            Glucose.Name = "Glucose";
            Glucose.Padding = new Padding(4);
            Glucose.Size = new Size(275, 76);
            Glucose.TabIndex = 4;
            Glucose.TabStop = false;
            Glucose.Text = "Detectou glucose elevada em análises?";
            // 
            // Glucose_S
            // 
            Glucose_S.AutoSize = true;
            Glucose_S.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Glucose_S.Location = new Point(15, 46);
            Glucose_S.Margin = new Padding(4);
            Glucose_S.Name = "Glucose_S";
            Glucose_S.Size = new Size(47, 21);
            Glucose_S.TabIndex = 9;
            Glucose_S.Text = "Sim";
            Glucose_S.UseVisualStyleBackColor = true;
            // 
            // Glucose_N
            // 
            Glucose_N.AutoSize = true;
            Glucose_N.Checked = true;
            Glucose_N.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Glucose_N.Location = new Point(15, 25);
            Glucose_N.Margin = new Padding(4);
            Glucose_N.Name = "Glucose_N";
            Glucose_N.Size = new Size(51, 21);
            Glucose_N.TabIndex = 8;
            Glucose_N.TabStop = true;
            Glucose_N.Text = "Não";
            Glucose_N.UseVisualStyleBackColor = true;
            // 
            // Hipertensao
            // 
            Hipertensao.Controls.Add(Hipertensao_S);
            Hipertensao.Controls.Add(Hipertensao_N);
            Hipertensao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Hipertensao.Location = new Point(20, 368);
            Hipertensao.Margin = new Padding(4);
            Hipertensao.Name = "Hipertensao";
            Hipertensao.Padding = new Padding(4);
            Hipertensao.Size = new Size(275, 75);
            Hipertensao.TabIndex = 5;
            Hipertensao.TabStop = false;
            Hipertensao.Text = "Toma medicação para a hipertensão?";
            // 
            // Hipertensao_S
            // 
            Hipertensao_S.AutoSize = true;
            Hipertensao_S.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Hipertensao_S.Location = new Point(16, 46);
            Hipertensao_S.Margin = new Padding(4);
            Hipertensao_S.Name = "Hipertensao_S";
            Hipertensao_S.Size = new Size(47, 21);
            Hipertensao_S.TabIndex = 11;
            Hipertensao_S.Text = "Sim";
            Hipertensao_S.UseVisualStyleBackColor = true;
            // 
            // Hipertensao_N
            // 
            Hipertensao_N.AutoSize = true;
            Hipertensao_N.Checked = true;
            Hipertensao_N.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Hipertensao_N.Location = new Point(16, 25);
            Hipertensao_N.Margin = new Padding(4);
            Hipertensao_N.Name = "Hipertensao_N";
            Hipertensao_N.Size = new Size(51, 21);
            Hipertensao_N.TabIndex = 10;
            Hipertensao_N.TabStop = true;
            Hipertensao_N.Text = "Não";
            Hipertensao_N.UseVisualStyleBackColor = true;
            // 
            // Parentesco
            // 
            Parentesco.Controls.Add(Parente_S);
            Parentesco.Controls.Add(Parente_N);
            Parentesco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Parentesco.Location = new Point(29, 629);
            Parentesco.Margin = new Padding(4);
            Parentesco.Name = "Parentesco";
            Parentesco.Padding = new Padding(4);
            Parentesco.Size = new Size(393, 105);
            Parentesco.TabIndex = 6;
            Parentesco.TabStop = false;
            Parentesco.Text = "Parente próximo com diabetes?";
            // 
            // Parente_S
            // 
            Parente_S.AutoSize = true;
            Parente_S.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Parente_S.Location = new Point(21, 69);
            Parente_S.Margin = new Padding(4);
            Parente_S.Name = "Parente_S";
            Parente_S.Size = new Size(45, 19);
            Parente_S.TabIndex = 13;
            Parente_S.Text = "Sim";
            Parente_S.UseVisualStyleBackColor = true;
            // 
            // Parente_N
            // 
            Parente_N.AutoSize = true;
            Parente_N.Checked = true;
            Parente_N.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Parente_N.Location = new Point(23, 36);
            Parente_N.Margin = new Padding(4);
            Parente_N.Name = "Parente_N";
            Parente_N.Size = new Size(47, 19);
            Parente_N.TabIndex = 12;
            Parente_N.TabStop = true;
            Parente_N.Text = "Não";
            Parente_N.UseVisualStyleBackColor = true;
            // 
            // VegetaisFruta
            // 
            VegetaisFruta.Controls.Add(optVegetais_2);
            VegetaisFruta.Controls.Add(optVegetais_1);
            VegetaisFruta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            VegetaisFruta.Location = new Point(421, 139);
            VegetaisFruta.Margin = new Padding(4);
            VegetaisFruta.Name = "VegetaisFruta";
            VegetaisFruta.Padding = new Padding(4);
            VegetaisFruta.Size = new Size(317, 79);
            VegetaisFruta.TabIndex = 7;
            VegetaisFruta.TabStop = false;
            VegetaisFruta.Text = "Com que frequência come vegetais ou fruta?";
            // 
            // optVegetais_2
            // 
            optVegetais_2.AutoSize = true;
            optVegetais_2.Checked = true;
            optVegetais_2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            optVegetais_2.Location = new Point(16, 52);
            optVegetais_2.Margin = new Padding(4);
            optVegetais_2.Name = "optVegetais_2";
            optVegetais_2.Size = new Size(102, 21);
            optVegetais_2.TabIndex = 13;
            optVegetais_2.TabStop = true;
            optVegetais_2.Text = "Nem sempre";
            optVegetais_2.UseVisualStyleBackColor = true;
            // 
            // optVegetais_1
            // 
            optVegetais_1.AutoSize = true;
            optVegetais_1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            optVegetais_1.Location = new Point(16, 29);
            optVegetais_1.Margin = new Padding(4);
            optVegetais_1.Name = "optVegetais_1";
            optVegetais_1.Size = new Size(108, 21);
            optVegetais_1.TabIndex = 12;
            optVegetais_1.Text = "Todos os dias";
            optVegetais_1.UseVisualStyleBackColor = true;
            // 
            // LarguraAnca
            // 
            LarguraAnca.Controls.Add(LarguraAncaMulheres);
            LarguraAnca.Controls.Add(LarguraAncaHomens);
            LarguraAnca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LarguraAnca.Location = new Point(421, 229);
            LarguraAnca.Margin = new Padding(4);
            LarguraAnca.Name = "LarguraAnca";
            LarguraAnca.Padding = new Padding(4);
            LarguraAnca.Size = new Size(317, 133);
            LarguraAnca.TabIndex = 8;
            LarguraAnca.TabStop = false;
            LarguraAnca.Text = "Largura de anca";
            // 
            // LarguraAncaMulheres
            // 
            LarguraAncaMulheres.Controls.Add(optLarguraAncaM_3);
            LarguraAncaMulheres.Controls.Add(optLarguraAncaM_1);
            LarguraAncaMulheres.Controls.Add(optLarguraAncaM_2);
            LarguraAncaMulheres.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LarguraAncaMulheres.Location = new Point(160, 31);
            LarguraAncaMulheres.Margin = new Padding(4);
            LarguraAncaMulheres.Name = "LarguraAncaMulheres";
            LarguraAncaMulheres.Padding = new Padding(4);
            LarguraAncaMulheres.Size = new Size(144, 91);
            LarguraAncaMulheres.TabIndex = 1;
            LarguraAncaMulheres.TabStop = false;
            LarguraAncaMulheres.Text = "Mulheres";
            // 
            // optLarguraAncaM_3
            // 
            optLarguraAncaM_3.AutoSize = true;
            optLarguraAncaM_3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            optLarguraAncaM_3.Location = new Point(19, 68);
            optLarguraAncaM_3.Margin = new Padding(4);
            optLarguraAncaM_3.Name = "optLarguraAncaM_3";
            optLarguraAncaM_3.Size = new Size(107, 19);
            optLarguraAncaM_3.TabIndex = 18;
            optLarguraAncaM_3.Text = "Mais de 100 cm";
            optLarguraAncaM_3.UseVisualStyleBackColor = true;
            // 
            // optLarguraAncaM_1
            // 
            optLarguraAncaM_1.AutoSize = true;
            optLarguraAncaM_1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            optLarguraAncaM_1.Location = new Point(19, 23);
            optLarguraAncaM_1.Margin = new Padding(4);
            optLarguraAncaM_1.Name = "optLarguraAncaM_1";
            optLarguraAncaM_1.Size = new Size(99, 19);
            optLarguraAncaM_1.TabIndex = 17;
            optLarguraAncaM_1.Text = "Menos 88 cm ";
            optLarguraAncaM_1.UseVisualStyleBackColor = true;
            // 
            // optLarguraAncaM_2
            // 
            optLarguraAncaM_2.AutoSize = true;
            optLarguraAncaM_2.Checked = true;
            optLarguraAncaM_2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            optLarguraAncaM_2.Location = new Point(19, 45);
            optLarguraAncaM_2.Margin = new Padding(4);
            optLarguraAncaM_2.Name = "optLarguraAncaM_2";
            optLarguraAncaM_2.Size = new Size(86, 19);
            optLarguraAncaM_2.TabIndex = 16;
            optLarguraAncaM_2.TabStop = true;
            optLarguraAncaM_2.Text = "88 - 100 cm";
            optLarguraAncaM_2.UseVisualStyleBackColor = true;
            // 
            // LarguraAncaHomens
            // 
            LarguraAncaHomens.Controls.Add(optLarguraAncaH_3);
            LarguraAncaHomens.Controls.Add(optLarguraAncaH_1);
            LarguraAncaHomens.Controls.Add(optLarguraAncaH_2);
            LarguraAncaHomens.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LarguraAncaHomens.Location = new Point(11, 31);
            LarguraAncaHomens.Margin = new Padding(4);
            LarguraAncaHomens.Name = "LarguraAncaHomens";
            LarguraAncaHomens.Padding = new Padding(4);
            LarguraAncaHomens.Size = new Size(143, 91);
            LarguraAncaHomens.TabIndex = 0;
            LarguraAncaHomens.TabStop = false;
            LarguraAncaHomens.Text = "Homens";
            // 
            // optLarguraAncaH_3
            // 
            optLarguraAncaH_3.AutoSize = true;
            optLarguraAncaH_3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            optLarguraAncaH_3.Location = new Point(19, 68);
            optLarguraAncaH_3.Margin = new Padding(4);
            optLarguraAncaH_3.Name = "optLarguraAncaH_3";
            optLarguraAncaH_3.Size = new Size(107, 19);
            optLarguraAncaH_3.TabIndex = 15;
            optLarguraAncaH_3.Text = "Mais de 110 cm";
            optLarguraAncaH_3.UseVisualStyleBackColor = true;
            // 
            // optLarguraAncaH_1
            // 
            optLarguraAncaH_1.AutoSize = true;
            optLarguraAncaH_1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            optLarguraAncaH_1.Location = new Point(19, 23);
            optLarguraAncaH_1.Margin = new Padding(4);
            optLarguraAncaH_1.Name = "optLarguraAncaH_1";
            optLarguraAncaH_1.Size = new Size(105, 19);
            optLarguraAncaH_1.TabIndex = 14;
            optLarguraAncaH_1.Text = "Menos 102 cm ";
            optLarguraAncaH_1.UseVisualStyleBackColor = true;
            // 
            // optLarguraAncaH_2
            // 
            optLarguraAncaH_2.AutoSize = true;
            optLarguraAncaH_2.Checked = true;
            optLarguraAncaH_2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            optLarguraAncaH_2.Location = new Point(19, 45);
            optLarguraAncaH_2.Margin = new Padding(4);
            optLarguraAncaH_2.Name = "optLarguraAncaH_2";
            optLarguraAncaH_2.Size = new Size(92, 19);
            optLarguraAncaH_2.TabIndex = 13;
            optLarguraAncaH_2.TabStop = true;
            optLarguraAncaH_2.Text = "102 - 110 cm";
            optLarguraAncaH_2.UseVisualStyleBackColor = true;
            // 
            // Risco
            // 
            Risco.BackColor = SystemColors.ActiveCaption;
            Risco.Controls.Add(lblRisco);
            Risco.Controls.Add(label2);
            Risco.Controls.Add(txtResultado);
            Risco.Controls.Add(txtPontos);
            Risco.Controls.Add(label1);
            Risco.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Risco.Location = new Point(314, 376);
            Risco.Margin = new Padding(4);
            Risco.Name = "Risco";
            Risco.Padding = new Padding(4);
            Risco.Size = new Size(547, 148);
            Risco.TabIndex = 9;
            Risco.TabStop = false;
            Risco.Text = "Resultado";
            Risco.Visible = false;
            // 
            // lblRisco
            // 
            lblRisco.AutoSize = true;
            lblRisco.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRisco.Location = new Point(54, 37);
            lblRisco.Margin = new Padding(4, 0, 4, 0);
            lblRisco.Name = "lblRisco";
            lblRisco.Size = new Size(0, 17);
            lblRisco.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 3;
            label2.Text = "Risco: ";
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            txtResultado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.ForeColor = Color.Black;
            txtResultado.Location = new Point(12, 56);
            txtResultado.Margin = new Padding(4);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(517, 87);
            txtResultado.TabIndex = 2;
            // 
            // txtPontos
            // 
            txtPontos.BackColor = Color.Khaki;
            txtPontos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPontos.Location = new Point(485, 20);
            txtPontos.Margin = new Padding(4);
            txtPontos.Name = "txtPontos";
            txtPontos.Size = new Size(44, 27);
            txtPontos.TabIndex = 1;
            txtPontos.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(365, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 0;
            label1.Text = "A sua pontuação:";
            // 
            // ToolbarOptions
            // 
            ToolbarOptions.AutoSize = false;
            ToolbarOptions.ImageScalingSize = new Size(40, 40);
            ToolbarOptions.Items.AddRange(new ToolStripItem[] { btnCalculate, toolStripSeparator1, btnClear, toolStripSeparator2, btnSair });
            ToolbarOptions.Location = new Point(0, 0);
            ToolbarOptions.Name = "ToolbarOptions";
            ToolbarOptions.Size = new Size(869, 40);
            ToolbarOptions.TabIndex = 10;
            ToolbarOptions.Text = "toolStrip1";
            // 
            // btnCalculate
            // 
            btnCalculate.AutoSize = false;
            btnCalculate.Checked = true;
            btnCalculate.CheckState = CheckState.Checked;
            btnCalculate.Image = (Image)resources.GetObject("btnCalculate.Image");
            btnCalculate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalculate.ImageScaling = ToolStripItemImageScaling.None;
            btnCalculate.ImageTransparentColor = Color.Magenta;
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 37);
            btnCalculate.Text = "Calcular";
            btnCalculate.Click += btnExportCSV_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 40);
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 37);
            btnClear.Text = "Limpar";
            btnClear.Click += btnClear_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 40);
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageTransparentColor = Color.Magenta;
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(70, 37);
            btnSair.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // frmPreDiabetes
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(869, 545);
            Controls.Add(ToolbarOptions);
            Controls.Add(Risco);
            Controls.Add(LarguraAnca);
            Controls.Add(VegetaisFruta);
            Controls.Add(Parentesco);
            Controls.Add(Hipertensao);
            Controls.Add(Glucose);
            Controls.Add(Fumador);
            Controls.Add(Sexo);
            Controls.Add(ActividadeFisica);
            Controls.Add(Idades);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Location = new Point(20, 54);
            Margin = new Padding(4);
            Name = "frmPreDiabetes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Pré-diabetes";
            Idades.ResumeLayout(false);
            Idades.PerformLayout();
            ActividadeFisica.ResumeLayout(false);
            ActividadeFisica.PerformLayout();
            Sexo.ResumeLayout(false);
            Sexo.PerformLayout();
            Fumador.ResumeLayout(false);
            Fumador.PerformLayout();
            Glucose.ResumeLayout(false);
            Glucose.PerformLayout();
            Hipertensao.ResumeLayout(false);
            Hipertensao.PerformLayout();
            Parentesco.ResumeLayout(false);
            Parentesco.PerformLayout();
            VegetaisFruta.ResumeLayout(false);
            VegetaisFruta.PerformLayout();
            LarguraAnca.ResumeLayout(false);
            LarguraAncaMulheres.ResumeLayout(false);
            LarguraAncaMulheres.PerformLayout();
            LarguraAncaHomens.ResumeLayout(false);
            LarguraAncaHomens.PerformLayout();
            Risco.ResumeLayout(false);
            Risco.PerformLayout();
            ToolbarOptions.ResumeLayout(false);
            ToolbarOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Idades;
        private GroupBox ActividadeFisica;
        private GroupBox Sexo;
        private GroupBox Fumador;
        private GroupBox Glucose;
        private GroupBox Hipertensao;
        private GroupBox Parentesco;
        private RadioButton optIdade1;
        private GroupBox VegetaisFruta;
        private GroupBox LarguraAnca;
        private GroupBox Risco;
        private RadioButton optIdade5;
        private RadioButton optIdade4;
        private RadioButton optIdade3;
        private RadioButton optIdade2;
        private RadioButton Sexo_M;
        private RadioButton Sexo_F;
        private RadioButton Fumador_S;
        private RadioButton Fumador_N;
        private RadioButton Glucose_S;
        private RadioButton Glucose_N;
        private RadioButton ActividadeFisica_S;
        private RadioButton ActividadeFisica_N;
        private RadioButton Hipertensao_S;
        private RadioButton Hipertensao_N;
        private RadioButton Parente_S;
        private RadioButton Parente_N;
        private RadioButton optVegetais_2;
        private RadioButton optVegetais_1;
        private GroupBox LarguraAncaHomens;
        private GroupBox LarguraAncaMulheres;
        private RadioButton optLarguraAncaM_3;
        private RadioButton optLarguraAncaM_1;
        private RadioButton optLarguraAncaM_2;
        private RadioButton optLarguraAncaH_3;
        private RadioButton optLarguraAncaH_1;
        private RadioButton optLarguraAncaH_2;
        private TextBox txtPontos;
        private Label label1;
        private Label label2;
        private TextBox txtResultado;
        private Label lblRisco;
        private ToolStrip ToolbarOptions;
        private ToolStripButton btnCalculate;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnClear;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnSair;
    }
}
