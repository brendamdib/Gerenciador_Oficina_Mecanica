namespace Gerenciador_Oficina_Mecanica
{
    partial class frm_Cad_Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_CadCliente = new System.Windows.Forms.Panel();
            this.grp_PessoaFisica = new System.Windows.Forms.GroupBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.lbl_Complemento = new System.Windows.Forms.Label();
            this.txt_EndComplemento = new System.Windows.Forms.TextBox();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_Cep = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Cep = new System.Windows.Forms.Label();
            this.cbo_Operadora = new System.Windows.Forms.ComboBox();
            this.lbl_Operadora = new System.Windows.Forms.Label();
            this.txt_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_TelCelular = new System.Windows.Forms.MaskedTextBox();
            this.txt_TelComercial = new System.Windows.Forms.MaskedTextBox();
            this.txt_telResidencial = new System.Windows.Forms.MaskedTextBox();
            this.lbl_TelCelular = new System.Windows.Forms.Label();
            this.lbl_TelComercial = new System.Windows.Forms.Label();
            this.lbl_TelResidencial = new System.Windows.Forms.Label();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.cbo_Sexo = new System.Windows.Forms.ComboBox();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_DataNasc = new System.Windows.Forms.Label();
            this.txt_DataNasc = new System.Windows.Forms.DateTimePicker();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.grp_TipoCliente = new System.Windows.Forms.GroupBox();
            this.rdo_PessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rdo_PessoaFisica = new System.Windows.Forms.RadioButton();
            this.grp_PessoaJuridica = new System.Windows.Forms.GroupBox();
            this.pnl_CadCliente.SuspendLayout();
            this.grp_PessoaFisica.SuspendLayout();
            this.grp_TipoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_CadCliente
            // 
            this.pnl_CadCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_CadCliente.AutoSize = true;
            this.pnl_CadCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_CadCliente.Controls.Add(this.grp_PessoaFisica);
            this.pnl_CadCliente.Controls.Add(this.grp_TipoCliente);
            this.pnl_CadCliente.Controls.Add(this.grp_PessoaJuridica);
            this.pnl_CadCliente.Location = new System.Drawing.Point(13, 13);
            this.pnl_CadCliente.Name = "pnl_CadCliente";
            this.pnl_CadCliente.Size = new System.Drawing.Size(1013, 603);
            this.pnl_CadCliente.TabIndex = 0;
            // 
            // grp_PessoaFisica
            // 
            this.grp_PessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_PessoaFisica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grp_PessoaFisica.Controls.Add(this.lbl_Estado);
            this.grp_PessoaFisica.Controls.Add(this.label2);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Bairro);
            this.grp_PessoaFisica.Controls.Add(this.txt_Bairro);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Complemento);
            this.grp_PessoaFisica.Controls.Add(this.txt_EndComplemento);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Endereco);
            this.grp_PessoaFisica.Controls.Add(this.txt_Endereco);
            this.grp_PessoaFisica.Controls.Add(this.txt_Cep);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Cep);
            this.grp_PessoaFisica.Controls.Add(this.cbo_Operadora);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Operadora);
            this.grp_PessoaFisica.Controls.Add(this.txt_Cpf);
            this.grp_PessoaFisica.Controls.Add(this.txt_TelCelular);
            this.grp_PessoaFisica.Controls.Add(this.txt_TelComercial);
            this.grp_PessoaFisica.Controls.Add(this.txt_telResidencial);
            this.grp_PessoaFisica.Controls.Add(this.lbl_TelCelular);
            this.grp_PessoaFisica.Controls.Add(this.lbl_TelComercial);
            this.grp_PessoaFisica.Controls.Add(this.lbl_TelResidencial);
            this.grp_PessoaFisica.Controls.Add(this.lbl_rg);
            this.grp_PessoaFisica.Controls.Add(this.txt_rg);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Cpf);
            this.grp_PessoaFisica.Controls.Add(this.cbo_Sexo);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Sexo);
            this.grp_PessoaFisica.Controls.Add(this.lbl_DataNasc);
            this.grp_PessoaFisica.Controls.Add(this.txt_DataNasc);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Email);
            this.grp_PessoaFisica.Controls.Add(this.txt_email);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Nome);
            this.grp_PessoaFisica.Controls.Add(this.txt_nome);
            this.grp_PessoaFisica.Location = new System.Drawing.Point(14, 55);
            this.grp_PessoaFisica.Name = "grp_PessoaFisica";
            this.grp_PessoaFisica.Size = new System.Drawing.Size(982, 543);
            this.grp_PessoaFisica.TabIndex = 1;
            this.grp_PessoaFisica.TabStop = false;
            this.grp_PessoaFisica.Text = "Pessoa Física";
            this.grp_PessoaFisica.Visible = false;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(719, 98);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_Estado.TabIndex = 26;
            this.lbl_Estado.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(842, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Bairro:";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Location = new System.Drawing.Point(591, 98);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(37, 13);
            this.lbl_Bairro.TabIndex = 24;
            this.lbl_Bairro.Text = "Bairro:";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(594, 114);
            this.txt_Bairro.MaxLength = 50;
            this.txt_Bairro.Multiline = true;
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(122, 20);
            this.txt_Bairro.TabIndex = 15;
            // 
            // lbl_Complemento
            // 
            this.lbl_Complemento.AutoSize = true;
            this.lbl_Complemento.Location = new System.Drawing.Point(444, 98);
            this.lbl_Complemento.Name = "lbl_Complemento";
            this.lbl_Complemento.Size = new System.Drawing.Size(144, 13);
            this.lbl_Complemento.TabIndex = 22;
            this.lbl_Complemento.Text = "Complemento (loja, apto ....): ";
            // 
            // txt_EndComplemento
            // 
            this.txt_EndComplemento.Location = new System.Drawing.Point(447, 114);
            this.txt_EndComplemento.Multiline = true;
            this.txt_EndComplemento.Name = "txt_EndComplemento";
            this.txt_EndComplemento.Size = new System.Drawing.Size(141, 20);
            this.txt_EndComplemento.TabIndex = 14;
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Location = new System.Drawing.Point(84, 98);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(56, 13);
            this.lbl_Endereco.TabIndex = 20;
            this.lbl_Endereco.Text = "Endereço:";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(87, 114);
            this.txt_Endereco.Multiline = true;
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(354, 20);
            this.txt_Endereco.TabIndex = 13;
            // 
            // txt_Cep
            // 
            this.txt_Cep.Location = new System.Drawing.Point(10, 114);
            this.txt_Cep.Mask = "00,000-000";
            this.txt_Cep.Name = "txt_Cep";
            this.txt_Cep.Size = new System.Drawing.Size(71, 20);
            this.txt_Cep.TabIndex = 12;
            // 
            // lbl_Cep
            // 
            this.lbl_Cep.AutoSize = true;
            this.lbl_Cep.Location = new System.Drawing.Point(7, 98);
            this.lbl_Cep.Name = "lbl_Cep";
            this.lbl_Cep.Size = new System.Drawing.Size(31, 13);
            this.lbl_Cep.TabIndex = 19;
            this.lbl_Cep.Text = "CEP:";
            // 
            // cbo_Operadora
            // 
            this.cbo_Operadora.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Feminino"});
            this.cbo_Operadora.FormattingEnabled = true;
            this.cbo_Operadora.Items.AddRange(new object[] {
            "CLARO",
            "NEXTEL",
            "OI",
            "TIM",
            "VIVO",
            "CTBC",
            "ALGAR",
            ""});
            this.cbo_Operadora.Location = new System.Drawing.Point(700, 74);
            this.cbo_Operadora.Name = "cbo_Operadora";
            this.cbo_Operadora.Size = new System.Drawing.Size(121, 21);
            this.cbo_Operadora.TabIndex = 11;
            // 
            // lbl_Operadora
            // 
            this.lbl_Operadora.AutoSize = true;
            this.lbl_Operadora.Location = new System.Drawing.Point(697, 59);
            this.lbl_Operadora.Name = "lbl_Operadora";
            this.lbl_Operadora.Size = new System.Drawing.Size(60, 13);
            this.lbl_Operadora.TabIndex = 18;
            this.lbl_Operadora.Text = "Operadora:";
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Location = new System.Drawing.Point(721, 36);
            this.txt_Cpf.Mask = "000,000,000-00";
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(118, 20);
            this.txt_Cpf.TabIndex = 5;
            // 
            // txt_TelCelular
            // 
            this.txt_TelCelular.Location = new System.Drawing.Point(590, 75);
            this.txt_TelCelular.Mask = "(99) 00000-0000";
            this.txt_TelCelular.Name = "txt_TelCelular";
            this.txt_TelCelular.Size = new System.Drawing.Size(104, 20);
            this.txt_TelCelular.TabIndex = 10;
            // 
            // txt_TelComercial
            // 
            this.txt_TelComercial.Location = new System.Drawing.Point(480, 75);
            this.txt_TelComercial.Mask = "(99) 0000-0000";
            this.txt_TelComercial.Name = "txt_TelComercial";
            this.txt_TelComercial.Size = new System.Drawing.Size(104, 20);
            this.txt_TelComercial.TabIndex = 9;
            // 
            // txt_telResidencial
            // 
            this.txt_telResidencial.Location = new System.Drawing.Point(370, 75);
            this.txt_telResidencial.Mask = "(99) 0000-0000";
            this.txt_telResidencial.Name = "txt_telResidencial";
            this.txt_telResidencial.Size = new System.Drawing.Size(104, 20);
            this.txt_telResidencial.TabIndex = 8;
            // 
            // lbl_TelCelular
            // 
            this.lbl_TelCelular.AutoSize = true;
            this.lbl_TelCelular.Location = new System.Drawing.Point(587, 59);
            this.lbl_TelCelular.Name = "lbl_TelCelular";
            this.lbl_TelCelular.Size = new System.Drawing.Size(87, 13);
            this.lbl_TelCelular.TabIndex = 16;
            this.lbl_TelCelular.Text = "Telefone Celular:";
            // 
            // lbl_TelComercial
            // 
            this.lbl_TelComercial.AutoSize = true;
            this.lbl_TelComercial.Location = new System.Drawing.Point(477, 59);
            this.lbl_TelComercial.Name = "lbl_TelComercial";
            this.lbl_TelComercial.Size = new System.Drawing.Size(101, 13);
            this.lbl_TelComercial.TabIndex = 14;
            this.lbl_TelComercial.Text = "Telefone Comercial:";
            // 
            // lbl_TelResidencial
            // 
            this.lbl_TelResidencial.AutoSize = true;
            this.lbl_TelResidencial.Location = new System.Drawing.Point(367, 59);
            this.lbl_TelResidencial.Name = "lbl_TelResidencial";
            this.lbl_TelResidencial.Size = new System.Drawing.Size(110, 13);
            this.lbl_TelResidencial.TabIndex = 12;
            this.lbl_TelResidencial.Text = "Telefone Residencial:";
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(841, 20);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(26, 13);
            this.lbl_rg.TabIndex = 11;
            this.lbl_rg.Text = "RG:";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(845, 36);
            this.txt_rg.MaxLength = 15;
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(131, 20);
            this.txt_rg.TabIndex = 6;
            this.txt_rg.WordWrap = false;
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Location = new System.Drawing.Point(719, 20);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(30, 13);
            this.lbl_Cpf.TabIndex = 9;
            this.lbl_Cpf.Text = "CPF:";
            // 
            // cbo_Sexo
            // 
            this.cbo_Sexo.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Feminino"});
            this.cbo_Sexo.FormattingEnabled = true;
            this.cbo_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbo_Sexo.Location = new System.Drawing.Point(595, 35);
            this.cbo_Sexo.Name = "cbo_Sexo";
            this.cbo_Sexo.Size = new System.Drawing.Size(121, 21);
            this.cbo_Sexo.TabIndex = 4;
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Location = new System.Drawing.Point(592, 20);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(34, 13);
            this.lbl_Sexo.TabIndex = 6;
            this.lbl_Sexo.Text = "Sexo:";
            // 
            // lbl_DataNasc
            // 
            this.lbl_DataNasc.AutoSize = true;
            this.lbl_DataNasc.Location = new System.Drawing.Point(367, 20);
            this.lbl_DataNasc.Name = "lbl_DataNasc";
            this.lbl_DataNasc.Size = new System.Drawing.Size(107, 13);
            this.lbl_DataNasc.TabIndex = 5;
            this.lbl_DataNasc.Text = "Data de Nascimento:";
            // 
            // txt_DataNasc
            // 
            this.txt_DataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_DataNasc.Location = new System.Drawing.Point(370, 36);
            this.txt_DataNasc.Name = "txt_DataNasc";
            this.txt_DataNasc.Size = new System.Drawing.Size(219, 20);
            this.txt_DataNasc.TabIndex = 3;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(7, 59);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(38, 13);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(10, 75);
            this.txt_email.MaxLength = 60;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(354, 20);
            this.txt_email.TabIndex = 7;
            this.txt_email.WordWrap = false;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(7, 20);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(10, 36);
            this.txt_nome.MaxLength = 60;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(354, 20);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.WordWrap = false;
            // 
            // grp_TipoCliente
            // 
            this.grp_TipoCliente.Controls.Add(this.rdo_PessoaJuridica);
            this.grp_TipoCliente.Controls.Add(this.rdo_PessoaFisica);
            this.grp_TipoCliente.Location = new System.Drawing.Point(14, 4);
            this.grp_TipoCliente.Name = "grp_TipoCliente";
            this.grp_TipoCliente.Size = new System.Drawing.Size(205, 44);
            this.grp_TipoCliente.TabIndex = 0;
            this.grp_TipoCliente.TabStop = false;
            this.grp_TipoCliente.Text = "Tipo de Cliente";
            // 
            // rdo_PessoaJuridica
            // 
            this.rdo_PessoaJuridica.AutoSize = true;
            this.rdo_PessoaJuridica.Location = new System.Drawing.Point(108, 19);
            this.rdo_PessoaJuridica.Name = "rdo_PessoaJuridica";
            this.rdo_PessoaJuridica.Size = new System.Drawing.Size(92, 17);
            this.rdo_PessoaJuridica.TabIndex = 1;
            this.rdo_PessoaJuridica.TabStop = true;
            this.rdo_PessoaJuridica.Text = "Pessoa Física";
            this.rdo_PessoaJuridica.UseVisualStyleBackColor = true;
            this.rdo_PessoaJuridica.CheckedChanged += new System.EventHandler(this.rdo_PessoaJuridica_CheckedChanged);
            // 
            // rdo_PessoaFisica
            // 
            this.rdo_PessoaFisica.AutoSize = true;
            this.rdo_PessoaFisica.Location = new System.Drawing.Point(6, 19);
            this.rdo_PessoaFisica.Name = "rdo_PessoaFisica";
            this.rdo_PessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rdo_PessoaFisica.TabIndex = 0;
            this.rdo_PessoaFisica.TabStop = true;
            this.rdo_PessoaFisica.Text = "Pessoa Física";
            this.rdo_PessoaFisica.UseVisualStyleBackColor = true;
            this.rdo_PessoaFisica.CheckedChanged += new System.EventHandler(this.rdo_PessoaFisica_CheckedChanged);
            // 
            // grp_PessoaJuridica
            // 
            this.grp_PessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_PessoaJuridica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grp_PessoaJuridica.Location = new System.Drawing.Point(14, 54);
            this.grp_PessoaJuridica.Name = "grp_PessoaJuridica";
            this.grp_PessoaJuridica.Size = new System.Drawing.Size(982, 543);
            this.grp_PessoaJuridica.TabIndex = 2;
            this.grp_PessoaJuridica.TabStop = false;
            this.grp_PessoaJuridica.Text = "Pessoa Jurídica";
            this.grp_PessoaJuridica.Visible = false;
            // 
            // frm_Cad_Cliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1034, 624);
            this.Controls.Add(this.pnl_CadCliente);
            this.Name = "frm_Cad_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_CadCliente.ResumeLayout(false);
            this.grp_PessoaFisica.ResumeLayout(false);
            this.grp_PessoaFisica.PerformLayout();
            this.grp_TipoCliente.ResumeLayout(false);
            this.grp_TipoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_CadCliente;
        private System.Windows.Forms.RadioButton rdo_PessoaJuridica;
        private System.Windows.Forms.RadioButton rdo_PessoaFisica;
        private System.Windows.Forms.GroupBox grp_TipoCliente;
        private System.Windows.Forms.GroupBox grp_PessoaFisica;
        private System.Windows.Forms.GroupBox grp_PessoaJuridica;
        private System.Windows.Forms.ComboBox cbo_Sexo;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_DataNasc;
        private System.Windows.Forms.DateTimePicker txt_DataNasc;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.Label lbl_TelCelular;
        private System.Windows.Forms.Label lbl_TelComercial;
        private System.Windows.Forms.Label lbl_TelResidencial;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.MaskedTextBox txt_telResidencial;
        private System.Windows.Forms.MaskedTextBox txt_Cpf;
        private System.Windows.Forms.MaskedTextBox txt_TelCelular;
        private System.Windows.Forms.MaskedTextBox txt_TelComercial;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox txt_Cep;
        private System.Windows.Forms.Label lbl_Cep;
        private System.Windows.Forms.ComboBox cbo_Operadora;
        private System.Windows.Forms.Label lbl_Operadora;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label lbl_Complemento;
        private System.Windows.Forms.TextBox txt_EndComplemento;        
        private System.Windows.Forms.BindingSource tblEstadoBindingSource;
        
    }
}