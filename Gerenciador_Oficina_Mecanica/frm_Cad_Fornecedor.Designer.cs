namespace Gerenciador_Oficina_Mecanica
{
    partial class frm_Cad_Fornecedor
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
            this.components = new System.ComponentModel.Container();
            this.tbl_OperadorasTelefoniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerenciaOficinaDataSet = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSet();
            this.tbl_CidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_EstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Clientes_PFTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_Clientes_PFTableAdapter();
            this.tbl_SexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Clientes_PFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_EstadoTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_EstadoTableAdapter();
            this.tableAdapterManager = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.TableAdapterManager();
            this.tbl_CidadeTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_CidadeTableAdapter();
            this.tbl_SexoTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_SexoTableAdapter();
            this.tbl_OperadorasTelefoniaTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_OperadorasTelefoniaTableAdapter();
            this.tbl_Clientes_PJTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_Clientes_PJTableAdapter();
            this.tbl_Clientes_PJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BancosTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_BancosTableAdapter();
            this.pnl_CadCliente = new System.Windows.Forms.Panel();
            this.grp_PessoaFisica = new System.Windows.Forms.GroupBox();
            this.lbl_forn_skype = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpo_forn_Segmento = new System.Windows.Forms.GroupBox();
            this.rdo_forn_servicos = new System.Windows.Forms.RadioButton();
            this.rdo_forn_pecas = new System.Windows.Forms.RadioButton();
            this.gpo_forn_tipo = new System.Windows.Forms.GroupBox();
            this.rdo_forn_juridica = new System.Windows.Forms.RadioButton();
            this.rdo_forn_fisica = new System.Windows.Forms.RadioButton();
            this.txt_forn_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.txt_forn_CPF = new System.Windows.Forms.TextBox();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.lbl_inss = new System.Windows.Forms.Label();
            this.txt_forn_inss = new System.Windows.Forms.TextBox();
            this.gbo_forn_banco = new System.Windows.Forms.GroupBox();
            this.cbo_bancos = new System.Windows.Forms.ComboBox();
            this.txt_forn_conta = new System.Windows.Forms.TextBox();
            this.txt_forn_agencia = new System.Windows.Forms.TextBox();
            this.lbl_forn_banco = new System.Windows.Forms.Label();
            this.lbl_forn_conta = new System.Windows.Forms.Label();
            this.lbl_forn_agencia = new System.Windows.Forms.Label();
            this.lbl_forn_site = new System.Windows.Forms.Label();
            this.txt_forn_site = new System.Windows.Forms.TextBox();
            this.txt_forn_nomefant = new System.Windows.Forms.TextBox();
            this.btn_forn_Salvar = new System.Windows.Forms.Button();
            this.cbo_CliPF_Cidade = new System.Windows.Forms.ComboBox();
            this.cbo_CliPF_Estado = new System.Windows.Forms.ComboBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.txt_CliPF_Bairro = new System.Windows.Forms.TextBox();
            this.lbl_Complemento = new System.Windows.Forms.Label();
            this.txt_CliPF_EndComp = new System.Windows.Forms.TextBox();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.txt_CliPF_End = new System.Windows.Forms.TextBox();
            this.txt_CliPF_Cep = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Cep = new System.Windows.Forms.Label();
            this.txt_forn_TelVendedor = new System.Windows.Forms.MaskedTextBox();
            this.txt_forn_Geral = new System.Windows.Forms.MaskedTextBox();
            this.lbl_TelComercial = new System.Windows.Forms.Label();
            this.lbl_forn_TelGeral = new System.Windows.Forms.Label();
            this.lbl_nomefant = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_forn_Email = new System.Windows.Forms.TextBox();
            this.lbl_razsoc = new System.Windows.Forms.Label();
            this.txt_forn_razsoc = new System.Windows.Forms.TextBox();
            this.lbl_forn_nomevendedor = new System.Windows.Forms.Label();
            this.txt_forn_nomevendedor = new System.Windows.Forms.TextBox();
            this.txt_forn_skype = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_OperadorasTelefoniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaOficinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_EstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Clientes_PFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Clientes_PJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBancosBindingSource)).BeginInit();
            this.pnl_CadCliente.SuspendLayout();
            this.grp_PessoaFisica.SuspendLayout();
            this.gpo_forn_Segmento.SuspendLayout();
            this.gpo_forn_tipo.SuspendLayout();
            this.gbo_forn_banco.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_OperadorasTelefoniaBindingSource
            // 
            this.tbl_OperadorasTelefoniaBindingSource.DataMember = "tbl_OperadorasTelefonia";
            this.tbl_OperadorasTelefoniaBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // gerenciaOficinaDataSet
            // 
            this.gerenciaOficinaDataSet.DataSetName = "GerenciaOficinaDataSet";
            this.gerenciaOficinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_CidadeBindingSource
            // 
            this.tbl_CidadeBindingSource.DataMember = "tbl_Cidade";
            this.tbl_CidadeBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // tbl_EstadoBindingSource
            // 
            this.tbl_EstadoBindingSource.DataMember = "tbl_Estado";
            this.tbl_EstadoBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // tbl_Clientes_PFTableAdapter
            // 
            this.tbl_Clientes_PFTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_SexoBindingSource
            // 
            this.tbl_SexoBindingSource.DataMember = "tbl_Sexo";
            this.tbl_SexoBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // tbl_Clientes_PFBindingSource
            // 
            this.tbl_Clientes_PFBindingSource.DataMember = "tbl_Clientes_PF";
            this.tbl_Clientes_PFBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // tbl_EstadoTableAdapter
            // 
            this.tbl_EstadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_BancosTableAdapter = null;
            this.tableAdapterManager.tbl_CidadeTableAdapter = null;
            this.tableAdapterManager.tbl_Clientes_PFTableAdapter = null;
            this.tableAdapterManager.tbl_Clientes_PJTableAdapter = null;
            this.tableAdapterManager.tbl_EstadoTableAdapter = this.tbl_EstadoTableAdapter;
            this.tableAdapterManager.tbl_FabricantesTableAdapter = null;
            this.tableAdapterManager.tbl_FormaPgtoTableAdapter = null;
            this.tableAdapterManager.tbl_FornecedoresTableAdapter = null;
            this.tableAdapterManager.tbl_ModelosVeiculosTableAdapter = null;
            this.tableAdapterManager.tbl_OperadorasTelefoniaTableAdapter = null;
            this.tableAdapterManager.tbl_OrcamentosTableAdapter = null;
            this.tableAdapterManager.tbl_ServicosTableAdapter = null;
            this.tableAdapterManager.tbl_SexoTableAdapter = null;
            this.tableAdapterManager.tbl_VeiculoClienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_CidadeTableAdapter
            // 
            this.tbl_CidadeTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_SexoTableAdapter
            // 
            this.tbl_SexoTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_OperadorasTelefoniaTableAdapter
            // 
            this.tbl_OperadorasTelefoniaTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Clientes_PJTableAdapter
            // 
            this.tbl_Clientes_PJTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Clientes_PJBindingSource
            // 
            this.tbl_Clientes_PJBindingSource.DataMember = "tbl_Clientes_PJ";
            this.tbl_Clientes_PJBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // tblBancosBindingSource
            // 
            this.tblBancosBindingSource.DataMember = "tbl_Bancos";
            this.tblBancosBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // tbl_BancosTableAdapter
            // 
            this.tbl_BancosTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_CadCliente
            // 
            this.pnl_CadCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_CadCliente.AutoSize = true;
            this.pnl_CadCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_CadCliente.Controls.Add(this.grp_PessoaFisica);
            this.pnl_CadCliente.Location = new System.Drawing.Point(12, 12);
            this.pnl_CadCliente.Name = "pnl_CadCliente";
            this.pnl_CadCliente.Size = new System.Drawing.Size(1212, 659);
            this.pnl_CadCliente.TabIndex = 1;
            // 
            // grp_PessoaFisica
            // 
            this.grp_PessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_PessoaFisica.AutoSize = true;
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_skype);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_nomevendedor);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_nomevendedor);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_skype);
            this.grp_PessoaFisica.Controls.Add(this.maskedTextBox1);
            this.grp_PessoaFisica.Controls.Add(this.label1);
            this.grp_PessoaFisica.Controls.Add(this.gpo_forn_Segmento);
            this.grp_PessoaFisica.Controls.Add(this.gpo_forn_tipo);
            this.grp_PessoaFisica.Controls.Add(this.gbo_forn_banco);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_site);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_site);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_nomefant);
            this.grp_PessoaFisica.Controls.Add(this.btn_forn_Salvar);
            this.grp_PessoaFisica.Controls.Add(this.cbo_CliPF_Cidade);
            this.grp_PessoaFisica.Controls.Add(this.cbo_CliPF_Estado);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Estado);
            this.grp_PessoaFisica.Controls.Add(this.lbl_cidade);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Bairro);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_Bairro);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Complemento);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_EndComp);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Endereco);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_End);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_Cep);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Cep);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_TelVendedor);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_Geral);
            this.grp_PessoaFisica.Controls.Add(this.lbl_TelComercial);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_TelGeral);
            this.grp_PessoaFisica.Controls.Add(this.lbl_nomefant);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Email);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_Email);
            this.grp_PessoaFisica.Controls.Add(this.lbl_razsoc);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_razsoc);
            this.grp_PessoaFisica.Location = new System.Drawing.Point(12, 3);
            this.grp_PessoaFisica.Name = "grp_PessoaFisica";
            this.grp_PessoaFisica.Size = new System.Drawing.Size(1189, 639);
            this.grp_PessoaFisica.TabIndex = 1;
            this.grp_PessoaFisica.TabStop = false;
            this.grp_PessoaFisica.Text = "Fornecedor";
            // 
            // lbl_forn_skype
            // 
            this.lbl_forn_skype.AutoSize = true;
            this.lbl_forn_skype.Location = new System.Drawing.Point(481, 55);
            this.lbl_forn_skype.Name = "lbl_forn_skype";
            this.lbl_forn_skype.Size = new System.Drawing.Size(89, 13);
            this.lbl_forn_skype.TabIndex = 46;
            this.lbl_forn_skype.Text = "Skype Vendedor:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(374, 71);
            this.maskedTextBox1.Mask = "(99) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(104, 20);
            this.maskedTextBox1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Whatsapp Vendedor:";
            // 
            // gpo_forn_Segmento
            // 
            this.gpo_forn_Segmento.Controls.Add(this.rdo_forn_servicos);
            this.gpo_forn_Segmento.Controls.Add(this.rdo_forn_pecas);
            this.gpo_forn_Segmento.Location = new System.Drawing.Point(9, 246);
            this.gpo_forn_Segmento.Name = "gpo_forn_Segmento";
            this.gpo_forn_Segmento.Size = new System.Drawing.Size(378, 41);
            this.gpo_forn_Segmento.TabIndex = 42;
            this.gpo_forn_Segmento.TabStop = false;
            this.gpo_forn_Segmento.Text = "Tipo de Fornecedor";
            this.gpo_forn_Segmento.UseCompatibleTextRendering = true;
            // 
            // rdo_forn_servicos
            // 
            this.rdo_forn_servicos.AutoSize = true;
            this.rdo_forn_servicos.Location = new System.Drawing.Point(123, 19);
            this.rdo_forn_servicos.Name = "rdo_forn_servicos";
            this.rdo_forn_servicos.Size = new System.Drawing.Size(66, 17);
            this.rdo_forn_servicos.TabIndex = 31;
            this.rdo_forn_servicos.TabStop = true;
            this.rdo_forn_servicos.Text = "Serviços";
            this.rdo_forn_servicos.UseVisualStyleBackColor = true;
            this.rdo_forn_servicos.CheckedChanged += new System.EventHandler(this.rdo_forn_servicos_CheckedChanged);
            // 
            // rdo_forn_pecas
            // 
            this.rdo_forn_pecas.AutoSize = true;
            this.rdo_forn_pecas.Location = new System.Drawing.Point(7, 20);
            this.rdo_forn_pecas.Name = "rdo_forn_pecas";
            this.rdo_forn_pecas.Size = new System.Drawing.Size(55, 17);
            this.rdo_forn_pecas.TabIndex = 30;
            this.rdo_forn_pecas.TabStop = true;
            this.rdo_forn_pecas.Text = "Peças";
            this.rdo_forn_pecas.UseVisualStyleBackColor = true;
            // 
            // gpo_forn_tipo
            // 
            this.gpo_forn_tipo.Controls.Add(this.rdo_forn_juridica);
            this.gpo_forn_tipo.Controls.Add(this.rdo_forn_fisica);
            this.gpo_forn_tipo.Controls.Add(this.txt_forn_CNPJ);
            this.gpo_forn_tipo.Controls.Add(this.lbl_Cpf);
            this.gpo_forn_tipo.Controls.Add(this.txt_forn_CPF);
            this.gpo_forn_tipo.Controls.Add(this.lbl_rg);
            this.gpo_forn_tipo.Controls.Add(this.lbl_inss);
            this.gpo_forn_tipo.Controls.Add(this.txt_forn_inss);
            this.gpo_forn_tipo.Location = new System.Drawing.Point(410, 156);
            this.gpo_forn_tipo.Name = "gpo_forn_tipo";
            this.gpo_forn_tipo.Size = new System.Drawing.Size(288, 131);
            this.gpo_forn_tipo.TabIndex = 41;
            this.gpo_forn_tipo.TabStop = false;
            this.gpo_forn_tipo.Text = "Tipo de Fornecedor";
            this.gpo_forn_tipo.UseCompatibleTextRendering = true;
            // 
            // rdo_forn_juridica
            // 
            this.rdo_forn_juridica.AutoSize = true;
            this.rdo_forn_juridica.Location = new System.Drawing.Point(123, 19);
            this.rdo_forn_juridica.Name = "rdo_forn_juridica";
            this.rdo_forn_juridica.Size = new System.Drawing.Size(101, 17);
            this.rdo_forn_juridica.TabIndex = 31;
            this.rdo_forn_juridica.TabStop = true;
            this.rdo_forn_juridica.Text = "Pessoa Jurídica";
            this.rdo_forn_juridica.UseVisualStyleBackColor = true;
            // 
            // rdo_forn_fisica
            // 
            this.rdo_forn_fisica.AutoSize = true;
            this.rdo_forn_fisica.Location = new System.Drawing.Point(7, 20);
            this.rdo_forn_fisica.Name = "rdo_forn_fisica";
            this.rdo_forn_fisica.Size = new System.Drawing.Size(92, 17);
            this.rdo_forn_fisica.TabIndex = 30;
            this.rdo_forn_fisica.TabStop = true;
            this.rdo_forn_fisica.Text = "Pessoa Física";
            this.rdo_forn_fisica.UseVisualStyleBackColor = true;
            // 
            // txt_forn_CNPJ
            // 
            this.txt_forn_CNPJ.Location = new System.Drawing.Point(9, 66);
            this.txt_forn_CNPJ.Mask = "00,000,000/0000-00";
            this.txt_forn_CNPJ.Name = "txt_forn_CNPJ";
            this.txt_forn_CNPJ.Size = new System.Drawing.Size(118, 20);
            this.txt_forn_CNPJ.TabIndex = 5;
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Location = new System.Drawing.Point(7, 50);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(37, 13);
            this.lbl_Cpf.TabIndex = 9;
            this.lbl_Cpf.Text = "CNPJ:";
            // 
            // txt_forn_CPF
            // 
            this.txt_forn_CPF.Location = new System.Drawing.Point(10, 105);
            this.txt_forn_CPF.MaxLength = 15;
            this.txt_forn_CPF.Name = "txt_forn_CPF";
            this.txt_forn_CPF.Size = new System.Drawing.Size(131, 20);
            this.txt_forn_CPF.TabIndex = 6;
            this.txt_forn_CPF.WordWrap = false;
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(6, 89);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(100, 13);
            this.lbl_rg.TabIndex = 11;
            this.lbl_rg.Text = "CPF (Pessoa física)";
            // 
            // lbl_inss
            // 
            this.lbl_inss.AutoSize = true;
            this.lbl_inss.Location = new System.Drawing.Point(143, 89);
            this.lbl_inss.Name = "lbl_inss";
            this.lbl_inss.Size = new System.Drawing.Size(105, 13);
            this.lbl_inss.TabIndex = 29;
            this.lbl_inss.Text = "INSS (Pessoa física)";
            // 
            // txt_forn_inss
            // 
            this.txt_forn_inss.Location = new System.Drawing.Point(147, 105);
            this.txt_forn_inss.MaxLength = 15;
            this.txt_forn_inss.Name = "txt_forn_inss";
            this.txt_forn_inss.Size = new System.Drawing.Size(131, 20);
            this.txt_forn_inss.TabIndex = 28;
            this.txt_forn_inss.WordWrap = false;
            // 
            // gbo_forn_banco
            // 
            this.gbo_forn_banco.Controls.Add(this.cbo_bancos);
            this.gbo_forn_banco.Controls.Add(this.txt_forn_conta);
            this.gbo_forn_banco.Controls.Add(this.txt_forn_agencia);
            this.gbo_forn_banco.Controls.Add(this.lbl_forn_banco);
            this.gbo_forn_banco.Controls.Add(this.lbl_forn_conta);
            this.gbo_forn_banco.Controls.Add(this.lbl_forn_agencia);
            this.gbo_forn_banco.Location = new System.Drawing.Point(9, 156);
            this.gbo_forn_banco.Name = "gbo_forn_banco";
            this.gbo_forn_banco.Size = new System.Drawing.Size(378, 81);
            this.gbo_forn_banco.TabIndex = 33;
            this.gbo_forn_banco.TabStop = false;
            this.gbo_forn_banco.Text = "Dados bancários";
            this.gbo_forn_banco.UseCompatibleTextRendering = true;
            // 
            // cbo_bancos
            // 
            this.cbo_bancos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_bancos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_bancos.DataSource = this.tblBancosBindingSource;
            this.cbo_bancos.DisplayMember = "Nome_Banco";
            this.cbo_bancos.FormattingEnabled = true;
            this.cbo_bancos.Location = new System.Drawing.Point(7, 42);
            this.cbo_bancos.Name = "cbo_bancos";
            this.cbo_bancos.Size = new System.Drawing.Size(193, 21);
            this.cbo_bancos.TabIndex = 41;
            this.cbo_bancos.ValueMember = "id";
            // 
            // txt_forn_conta
            // 
            this.txt_forn_conta.Location = new System.Drawing.Point(280, 43);
            this.txt_forn_conta.MaxLength = 60;
            this.txt_forn_conta.Name = "txt_forn_conta";
            this.txt_forn_conta.Size = new System.Drawing.Size(92, 20);
            this.txt_forn_conta.TabIndex = 40;
            this.txt_forn_conta.WordWrap = false;
            // 
            // txt_forn_agencia
            // 
            this.txt_forn_agencia.Location = new System.Drawing.Point(206, 43);
            this.txt_forn_agencia.MaxLength = 60;
            this.txt_forn_agencia.Name = "txt_forn_agencia";
            this.txt_forn_agencia.Size = new System.Drawing.Size(68, 20);
            this.txt_forn_agencia.TabIndex = 39;
            this.txt_forn_agencia.WordWrap = false;
            // 
            // lbl_forn_banco
            // 
            this.lbl_forn_banco.AutoSize = true;
            this.lbl_forn_banco.Location = new System.Drawing.Point(6, 27);
            this.lbl_forn_banco.Name = "lbl_forn_banco";
            this.lbl_forn_banco.Size = new System.Drawing.Size(38, 13);
            this.lbl_forn_banco.TabIndex = 34;
            this.lbl_forn_banco.Text = "Banco";
            // 
            // lbl_forn_conta
            // 
            this.lbl_forn_conta.AutoSize = true;
            this.lbl_forn_conta.Location = new System.Drawing.Point(278, 27);
            this.lbl_forn_conta.Name = "lbl_forn_conta";
            this.lbl_forn_conta.Size = new System.Drawing.Size(38, 13);
            this.lbl_forn_conta.TabIndex = 38;
            this.lbl_forn_conta.Text = "Conta:";
            // 
            // lbl_forn_agencia
            // 
            this.lbl_forn_agencia.AutoSize = true;
            this.lbl_forn_agencia.Location = new System.Drawing.Point(203, 27);
            this.lbl_forn_agencia.Name = "lbl_forn_agencia";
            this.lbl_forn_agencia.Size = new System.Drawing.Size(46, 13);
            this.lbl_forn_agencia.TabIndex = 37;
            this.lbl_forn_agencia.Text = "Agencia";
            // 
            // lbl_forn_site
            // 
            this.lbl_forn_site.AutoSize = true;
            this.lbl_forn_site.Location = new System.Drawing.Point(586, 16);
            this.lbl_forn_site.Name = "lbl_forn_site";
            this.lbl_forn_site.Size = new System.Drawing.Size(28, 13);
            this.lbl_forn_site.TabIndex = 30;
            this.lbl_forn_site.Text = "Site:";
            // 
            // txt_forn_site
            // 
            this.txt_forn_site.Location = new System.Drawing.Point(589, 32);
            this.txt_forn_site.MaxLength = 60;
            this.txt_forn_site.Name = "txt_forn_site";
            this.txt_forn_site.Size = new System.Drawing.Size(184, 20);
            this.txt_forn_site.TabIndex = 31;
            this.txt_forn_site.WordWrap = false;
            // 
            // txt_forn_nomefant
            // 
            this.txt_forn_nomefant.Location = new System.Drawing.Point(369, 32);
            this.txt_forn_nomefant.MaxLength = 60;
            this.txt_forn_nomefant.Name = "txt_forn_nomefant";
            this.txt_forn_nomefant.Size = new System.Drawing.Size(214, 20);
            this.txt_forn_nomefant.TabIndex = 27;
            this.txt_forn_nomefant.WordWrap = false;
            // 
            // btn_forn_Salvar
            // 
            this.btn_forn_Salvar.Image = global::Gerenciador_Oficina_Mecanica.Properties.Resources.save;
            this.btn_forn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_forn_Salvar.Location = new System.Drawing.Point(840, 261);
            this.btn_forn_Salvar.Name = "btn_forn_Salvar";
            this.btn_forn_Salvar.Size = new System.Drawing.Size(135, 30);
            this.btn_forn_Salvar.TabIndex = 18;
            this.btn_forn_Salvar.Text = "Cadastrar Fornecedor";
            this.btn_forn_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_forn_Salvar.UseVisualStyleBackColor = true;
            // 
            // cbo_CliPF_Cidade
            // 
            this.cbo_CliPF_Cidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_CliPF_Cidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_CliPF_Cidade.DataSource = this.tbl_CidadeBindingSource;
            this.cbo_CliPF_Cidade.DisplayMember = "Nome_Cidade";
            this.cbo_CliPF_Cidade.FormattingEnabled = true;
            this.cbo_CliPF_Cidade.Location = new System.Drawing.Point(788, 110);
            this.cbo_CliPF_Cidade.Name = "cbo_CliPF_Cidade";
            this.cbo_CliPF_Cidade.Size = new System.Drawing.Size(187, 21);
            this.cbo_CliPF_Cidade.TabIndex = 17;
            this.cbo_CliPF_Cidade.ValueMember = "id";
            // 
            // cbo_CliPF_Estado
            // 
            this.cbo_CliPF_Estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_CliPF_Estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_CliPF_Estado.DataSource = this.tbl_EstadoBindingSource;
            this.cbo_CliPF_Estado.DisplayMember = "Sigla_Estado";
            this.cbo_CliPF_Estado.FormattingEnabled = true;
            this.cbo_CliPF_Estado.Location = new System.Drawing.Point(720, 110);
            this.cbo_CliPF_Estado.Name = "cbo_CliPF_Estado";
            this.cbo_CliPF_Estado.Size = new System.Drawing.Size(62, 21);
            this.cbo_CliPF_Estado.TabIndex = 16;
            this.cbo_CliPF_Estado.ValueMember = "id";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(718, 94);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_Estado.TabIndex = 26;
            this.lbl_Estado.Text = "Estado:";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(785, 94);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(43, 13);
            this.lbl_cidade.TabIndex = 25;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Location = new System.Drawing.Point(590, 94);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(37, 13);
            this.lbl_Bairro.TabIndex = 24;
            this.lbl_Bairro.Text = "Bairro:";
            // 
            // txt_CliPF_Bairro
            // 
            this.txt_CliPF_Bairro.Location = new System.Drawing.Point(593, 110);
            this.txt_CliPF_Bairro.MaxLength = 50;
            this.txt_CliPF_Bairro.Multiline = true;
            this.txt_CliPF_Bairro.Name = "txt_CliPF_Bairro";
            this.txt_CliPF_Bairro.Size = new System.Drawing.Size(122, 20);
            this.txt_CliPF_Bairro.TabIndex = 15;
            // 
            // lbl_Complemento
            // 
            this.lbl_Complemento.AutoSize = true;
            this.lbl_Complemento.Location = new System.Drawing.Point(443, 94);
            this.lbl_Complemento.Name = "lbl_Complemento";
            this.lbl_Complemento.Size = new System.Drawing.Size(144, 13);
            this.lbl_Complemento.TabIndex = 22;
            this.lbl_Complemento.Text = "Complemento (loja, apto ....): ";
            // 
            // txt_CliPF_EndComp
            // 
            this.txt_CliPF_EndComp.Location = new System.Drawing.Point(446, 110);
            this.txt_CliPF_EndComp.Multiline = true;
            this.txt_CliPF_EndComp.Name = "txt_CliPF_EndComp";
            this.txt_CliPF_EndComp.Size = new System.Drawing.Size(141, 20);
            this.txt_CliPF_EndComp.TabIndex = 14;
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Location = new System.Drawing.Point(83, 94);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(56, 13);
            this.lbl_Endereco.TabIndex = 20;
            this.lbl_Endereco.Text = "Endereço:";
            // 
            // txt_CliPF_End
            // 
            this.txt_CliPF_End.Location = new System.Drawing.Point(86, 110);
            this.txt_CliPF_End.Multiline = true;
            this.txt_CliPF_End.Name = "txt_CliPF_End";
            this.txt_CliPF_End.Size = new System.Drawing.Size(354, 20);
            this.txt_CliPF_End.TabIndex = 13;
            // 
            // txt_CliPF_Cep
            // 
            this.txt_CliPF_Cep.Location = new System.Drawing.Point(9, 110);
            this.txt_CliPF_Cep.Mask = "00,000-000";
            this.txt_CliPF_Cep.Name = "txt_CliPF_Cep";
            this.txt_CliPF_Cep.Size = new System.Drawing.Size(71, 20);
            this.txt_CliPF_Cep.TabIndex = 12;
            // 
            // lbl_Cep
            // 
            this.lbl_Cep.AutoSize = true;
            this.lbl_Cep.Location = new System.Drawing.Point(6, 94);
            this.lbl_Cep.Name = "lbl_Cep";
            this.lbl_Cep.Size = new System.Drawing.Size(31, 13);
            this.lbl_Cep.TabIndex = 19;
            this.lbl_Cep.Text = "CEP:";
            // 
            // txt_forn_TelVendedor
            // 
            this.txt_forn_TelVendedor.Location = new System.Drawing.Point(264, 71);
            this.txt_forn_TelVendedor.Mask = "(99) 0000-0000";
            this.txt_forn_TelVendedor.Name = "txt_forn_TelVendedor";
            this.txt_forn_TelVendedor.Size = new System.Drawing.Size(104, 20);
            this.txt_forn_TelVendedor.TabIndex = 9;
            // 
            // txt_forn_Geral
            // 
            this.txt_forn_Geral.Location = new System.Drawing.Point(9, 71);
            this.txt_forn_Geral.Mask = "(99) 0000-0000";
            this.txt_forn_Geral.Name = "txt_forn_Geral";
            this.txt_forn_Geral.Size = new System.Drawing.Size(104, 20);
            this.txt_forn_Geral.TabIndex = 8;
            // 
            // lbl_TelComercial
            // 
            this.lbl_TelComercial.AutoSize = true;
            this.lbl_TelComercial.Location = new System.Drawing.Point(261, 55);
            this.lbl_TelComercial.Name = "lbl_TelComercial";
            this.lbl_TelComercial.Size = new System.Drawing.Size(101, 13);
            this.lbl_TelComercial.TabIndex = 14;
            this.lbl_TelComercial.Text = "Telefone Vendedor:";
            // 
            // lbl_forn_TelGeral
            // 
            this.lbl_forn_TelGeral.AutoSize = true;
            this.lbl_forn_TelGeral.Location = new System.Drawing.Point(6, 55);
            this.lbl_forn_TelGeral.Name = "lbl_forn_TelGeral";
            this.lbl_forn_TelGeral.Size = new System.Drawing.Size(77, 13);
            this.lbl_forn_TelGeral.TabIndex = 12;
            this.lbl_forn_TelGeral.Text = "Telefone Geral";
            // 
            // lbl_nomefant
            // 
            this.lbl_nomefant.AutoSize = true;
            this.lbl_nomefant.Location = new System.Drawing.Point(366, 16);
            this.lbl_nomefant.Name = "lbl_nomefant";
            this.lbl_nomefant.Size = new System.Drawing.Size(78, 13);
            this.lbl_nomefant.TabIndex = 5;
            this.lbl_nomefant.Text = "Nome Fantasia";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(609, 55);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(38, 13);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Text = "E-mail:";
            // 
            // txt_forn_Email
            // 
            this.txt_forn_Email.Location = new System.Drawing.Point(612, 71);
            this.txt_forn_Email.MaxLength = 60;
            this.txt_forn_Email.Name = "txt_forn_Email";
            this.txt_forn_Email.Size = new System.Drawing.Size(196, 20);
            this.txt_forn_Email.TabIndex = 7;
            this.txt_forn_Email.WordWrap = false;
            // 
            // lbl_razsoc
            // 
            this.lbl_razsoc.AutoSize = true;
            this.lbl_razsoc.Location = new System.Drawing.Point(6, 16);
            this.lbl_razsoc.Name = "lbl_razsoc";
            this.lbl_razsoc.Size = new System.Drawing.Size(70, 13);
            this.lbl_razsoc.TabIndex = 1;
            this.lbl_razsoc.Text = "Razão Social";
            // 
            // txt_forn_razsoc
            // 
            this.txt_forn_razsoc.Location = new System.Drawing.Point(9, 32);
            this.txt_forn_razsoc.MaxLength = 60;
            this.txt_forn_razsoc.Name = "txt_forn_razsoc";
            this.txt_forn_razsoc.Size = new System.Drawing.Size(354, 20);
            this.txt_forn_razsoc.TabIndex = 2;
            this.txt_forn_razsoc.WordWrap = false;
            // 
            // lbl_forn_nomevendedor
            // 
            this.lbl_forn_nomevendedor.AutoSize = true;
            this.lbl_forn_nomevendedor.Location = new System.Drawing.Point(116, 55);
            this.lbl_forn_nomevendedor.Name = "lbl_forn_nomevendedor";
            this.lbl_forn_nomevendedor.Size = new System.Drawing.Size(87, 13);
            this.lbl_forn_nomevendedor.TabIndex = 48;
            this.lbl_forn_nomevendedor.Text = "Nome Vendedor:";
            // 
            // txt_forn_nomevendedor
            // 
            this.txt_forn_nomevendedor.Location = new System.Drawing.Point(117, 71);
            this.txt_forn_nomevendedor.MaxLength = 20;
            this.txt_forn_nomevendedor.Multiline = true;
            this.txt_forn_nomevendedor.Name = "txt_forn_nomevendedor";
            this.txt_forn_nomevendedor.Size = new System.Drawing.Size(141, 20);
            this.txt_forn_nomevendedor.TabIndex = 49;
            // 
            // txt_forn_skype
            // 
            this.txt_forn_skype.Location = new System.Drawing.Point(484, 71);
            this.txt_forn_skype.MaxLength = 20;
            this.txt_forn_skype.Multiline = true;
            this.txt_forn_skype.Name = "txt_forn_skype";
            this.txt_forn_skype.Size = new System.Drawing.Size(122, 20);
            this.txt_forn_skype.TabIndex = 50;
            // 
            // frm_Cad_Fornecedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1239, 679);
            this.Controls.Add(this.pnl_CadCliente);
            this.Name = "frm_Cad_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Cad_Fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_OperadorasTelefoniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaOficinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_EstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Clientes_PFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Clientes_PJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBancosBindingSource)).EndInit();
            this.pnl_CadCliente.ResumeLayout(false);
            this.pnl_CadCliente.PerformLayout();
            this.grp_PessoaFisica.ResumeLayout(false);
            this.grp_PessoaFisica.PerformLayout();
            this.gpo_forn_Segmento.ResumeLayout(false);
            this.gpo_forn_Segmento.PerformLayout();
            this.gpo_forn_tipo.ResumeLayout(false);
            this.gpo_forn_tipo.PerformLayout();
            this.gbo_forn_banco.ResumeLayout(false);
            this.gbo_forn_banco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tbl_OperadorasTelefoniaBindingSource;
        private GerenciaOficinaDataSet gerenciaOficinaDataSet;
        private System.Windows.Forms.BindingSource tbl_CidadeBindingSource;
        private System.Windows.Forms.BindingSource tbl_EstadoBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_Clientes_PFTableAdapter tbl_Clientes_PFTableAdapter;
        private System.Windows.Forms.BindingSource tbl_SexoBindingSource;
        private System.Windows.Forms.BindingSource tbl_Clientes_PFBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_EstadoTableAdapter tbl_EstadoTableAdapter;
        private GerenciaOficinaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GerenciaOficinaDataSetTableAdapters.tbl_CidadeTableAdapter tbl_CidadeTableAdapter;
        private GerenciaOficinaDataSetTableAdapters.tbl_SexoTableAdapter tbl_SexoTableAdapter;
        private GerenciaOficinaDataSetTableAdapters.tbl_OperadorasTelefoniaTableAdapter tbl_OperadorasTelefoniaTableAdapter;
        private GerenciaOficinaDataSetTableAdapters.tbl_Clientes_PJTableAdapter tbl_Clientes_PJTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Clientes_PJBindingSource;
        private System.Windows.Forms.BindingSource tblBancosBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_BancosTableAdapter tbl_BancosTableAdapter;
        private System.Windows.Forms.Panel pnl_CadCliente;
        public System.Windows.Forms.GroupBox grp_PessoaFisica;
        private System.Windows.Forms.Label lbl_forn_skype;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpo_forn_Segmento;
        private System.Windows.Forms.RadioButton rdo_forn_servicos;
        private System.Windows.Forms.RadioButton rdo_forn_pecas;
        private System.Windows.Forms.GroupBox gpo_forn_tipo;
        private System.Windows.Forms.RadioButton rdo_forn_juridica;
        private System.Windows.Forms.RadioButton rdo_forn_fisica;
        private System.Windows.Forms.MaskedTextBox txt_forn_CNPJ;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.TextBox txt_forn_CPF;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.Label lbl_inss;
        private System.Windows.Forms.TextBox txt_forn_inss;
        private System.Windows.Forms.GroupBox gbo_forn_banco;
        private System.Windows.Forms.ComboBox cbo_bancos;
        public System.Windows.Forms.TextBox txt_forn_conta;
        public System.Windows.Forms.TextBox txt_forn_agencia;
        private System.Windows.Forms.Label lbl_forn_banco;
        private System.Windows.Forms.Label lbl_forn_conta;
        private System.Windows.Forms.Label lbl_forn_agencia;
        private System.Windows.Forms.Label lbl_forn_site;
        private System.Windows.Forms.TextBox txt_forn_site;
        public System.Windows.Forms.TextBox txt_forn_nomefant;
        private System.Windows.Forms.Button btn_forn_Salvar;
        private System.Windows.Forms.ComboBox cbo_CliPF_Cidade;
        private System.Windows.Forms.ComboBox cbo_CliPF_Estado;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.TextBox txt_CliPF_Bairro;
        private System.Windows.Forms.Label lbl_Complemento;
        private System.Windows.Forms.TextBox txt_CliPF_EndComp;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.TextBox txt_CliPF_End;
        private System.Windows.Forms.MaskedTextBox txt_CliPF_Cep;
        private System.Windows.Forms.Label lbl_Cep;
        private System.Windows.Forms.MaskedTextBox txt_forn_TelVendedor;
        private System.Windows.Forms.MaskedTextBox txt_forn_Geral;
        private System.Windows.Forms.Label lbl_TelComercial;
        private System.Windows.Forms.Label lbl_forn_TelGeral;
        private System.Windows.Forms.Label lbl_nomefant;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_forn_Email;
        private System.Windows.Forms.Label lbl_razsoc;
        public System.Windows.Forms.TextBox txt_forn_razsoc;
        private System.Windows.Forms.TextBox txt_forn_skype;
        private System.Windows.Forms.TextBox txt_forn_nomevendedor;
        private System.Windows.Forms.Label lbl_forn_nomevendedor;
    }
}