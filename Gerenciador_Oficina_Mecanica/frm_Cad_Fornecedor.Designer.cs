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
            this.lbl_forn_quantcarac = new System.Windows.Forms.Label();
            this.lbl_forn_obs = new System.Windows.Forms.Label();
            this.txt_forn_obs = new System.Windows.Forms.TextBox();
            this.cbo_forn_operadora = new System.Windows.Forms.ComboBox();
            this.tbl_OperadorasTelefoniaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_forn_skype = new System.Windows.Forms.TextBox();
            this.txt_forn_nomevendedor = new System.Windows.Forms.TextBox();
            this.lbl_forn_nomevendedor = new System.Windows.Forms.Label();
            this.lbl_forn_skype = new System.Windows.Forms.Label();
            this.txt_forn_celVendedor = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpo_forn_Segmento = new System.Windows.Forms.GroupBox();
            this.rdo_forn_servicos = new System.Windows.Forms.RadioButton();
            this.rdo_forn_pecas = new System.Windows.Forms.RadioButton();
            this.gpo_forn_tipo = new System.Windows.Forms.GroupBox();
            this.txt_forn_inss = new System.Windows.Forms.MaskedTextBox();
            this.txt_forn_cpf = new System.Windows.Forms.MaskedTextBox();
            this.rdo_forn_juridica = new System.Windows.Forms.RadioButton();
            this.rdo_forn_fisica = new System.Windows.Forms.RadioButton();
            this.txt_forn_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lbl_forn_cnpj = new System.Windows.Forms.Label();
            this.lbl_forn_cpf = new System.Windows.Forms.Label();
            this.lbl_forn_inss = new System.Windows.Forms.Label();
            this.gbo_forn_banco = new System.Windows.Forms.GroupBox();
            this.cbo_forn_bancos = new System.Windows.Forms.ComboBox();
            this.txt_forn_conta = new System.Windows.Forms.TextBox();
            this.txt_forn_agencia = new System.Windows.Forms.TextBox();
            this.lbl_forn_banco = new System.Windows.Forms.Label();
            this.lbl_forn_conta = new System.Windows.Forms.Label();
            this.lbl_forn_agencia = new System.Windows.Forms.Label();
            this.lbl_forn_site = new System.Windows.Forms.Label();
            this.txt_forn_site = new System.Windows.Forms.TextBox();
            this.txt_forn_nomefant = new System.Windows.Forms.TextBox();
            this.btn_forn_Salvar = new System.Windows.Forms.Button();
            this.cbo_forn_cidade = new System.Windows.Forms.ComboBox();
            this.cbo_forn_estado = new System.Windows.Forms.ComboBox();
            this.lbl_forn_Estado = new System.Windows.Forms.Label();
            this.lbl_forn_cidade = new System.Windows.Forms.Label();
            this.lbl_forn_bairro = new System.Windows.Forms.Label();
            this.txt_forn_bairro = new System.Windows.Forms.TextBox();
            this.lbl_forn_complemento = new System.Windows.Forms.Label();
            this.txt_forn_CompEnd = new System.Windows.Forms.TextBox();
            this.lbl_forn_endereco = new System.Windows.Forms.Label();
            this.txt_forn_end = new System.Windows.Forms.TextBox();
            this.txt_forn_cep = new System.Windows.Forms.MaskedTextBox();
            this.lbl_forn_Cep = new System.Windows.Forms.Label();
            this.txt_forn_TelVendedor = new System.Windows.Forms.MaskedTextBox();
            this.txt_forn_telGeral = new System.Windows.Forms.MaskedTextBox();
            this.lbl_TelComercial = new System.Windows.Forms.Label();
            this.lbl_forn_TelGeral = new System.Windows.Forms.Label();
            this.lbl_nomefant = new System.Windows.Forms.Label();
            this.lbl_forn_Email = new System.Windows.Forms.Label();
            this.txt_forn_Email = new System.Windows.Forms.TextBox();
            this.lbl_razsoc = new System.Windows.Forms.Label();
            this.txt_forn_razsoc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ativo = new System.Windows.Forms.RadioButton();
            this.rdo_forn_inativo = new System.Windows.Forms.RadioButton();
            this.lbl_forn_inscestadual = new System.Windows.Forms.Label();
            this.txt_forn_inscestadual = new System.Windows.Forms.MaskedTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.tbl_OperadorasTelefoniaBindingSource1)).BeginInit();
            this.gpo_forn_Segmento.SuspendLayout();
            this.gpo_forn_tipo.SuspendLayout();
            this.gbo_forn_banco.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.grp_PessoaFisica.Controls.Add(this.groupBox1);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_quantcarac);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_obs);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_obs);
            this.grp_PessoaFisica.Controls.Add(this.cbo_forn_operadora);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_skype);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_nomevendedor);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_nomevendedor);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_skype);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_celVendedor);
            this.grp_PessoaFisica.Controls.Add(this.label1);
            this.grp_PessoaFisica.Controls.Add(this.gpo_forn_Segmento);
            this.grp_PessoaFisica.Controls.Add(this.gpo_forn_tipo);
            this.grp_PessoaFisica.Controls.Add(this.gbo_forn_banco);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_site);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_site);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_nomefant);
            this.grp_PessoaFisica.Controls.Add(this.btn_forn_Salvar);
            this.grp_PessoaFisica.Controls.Add(this.cbo_forn_cidade);
            this.grp_PessoaFisica.Controls.Add(this.cbo_forn_estado);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_Estado);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_cidade);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_bairro);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_bairro);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_complemento);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_CompEnd);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_endereco);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_end);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_cep);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_Cep);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_TelVendedor);
            this.grp_PessoaFisica.Controls.Add(this.txt_forn_telGeral);
            this.grp_PessoaFisica.Controls.Add(this.lbl_TelComercial);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_TelGeral);
            this.grp_PessoaFisica.Controls.Add(this.lbl_nomefant);
            this.grp_PessoaFisica.Controls.Add(this.lbl_forn_Email);
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
            // lbl_forn_quantcarac
            // 
            this.lbl_forn_quantcarac.AutoSize = true;
            this.lbl_forn_quantcarac.Location = new System.Drawing.Point(6, 403);
            this.lbl_forn_quantcarac.Name = "lbl_forn_quantcarac";
            this.lbl_forn_quantcarac.Size = new System.Drawing.Size(168, 13);
            this.lbl_forn_quantcarac.TabIndex = 53;
            this.lbl_forn_quantcarac.Text = "Quantidade de caracteres:  0/300";
            // 
            // lbl_forn_obs
            // 
            this.lbl_forn_obs.AutoSize = true;
            this.lbl_forn_obs.Location = new System.Drawing.Point(6, 290);
            this.lbl_forn_obs.Name = "lbl_forn_obs";
            this.lbl_forn_obs.Size = new System.Drawing.Size(70, 13);
            this.lbl_forn_obs.TabIndex = 52;
            this.lbl_forn_obs.Text = "Observações";
            // 
            // txt_forn_obs
            // 
            this.txt_forn_obs.AcceptsReturn = true;
            this.txt_forn_obs.AcceptsTab = true;
            this.txt_forn_obs.Location = new System.Drawing.Point(6, 306);
            this.txt_forn_obs.MaxLength = 300;
            this.txt_forn_obs.Multiline = true;
            this.txt_forn_obs.Name = "txt_forn_obs";
            this.txt_forn_obs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_forn_obs.Size = new System.Drawing.Size(969, 94);
            this.txt_forn_obs.TabIndex = 23;
            this.txt_forn_obs.TextChanged += new System.EventHandler(this.txt_forn_obs_TextChanged);
            // 
            // cbo_forn_operadora
            // 
            this.cbo_forn_operadora.DataSource = this.tbl_OperadorasTelefoniaBindingSource1;
            this.cbo_forn_operadora.DisplayMember = "Nome_Operadora";
            this.cbo_forn_operadora.FormattingEnabled = true;
            this.cbo_forn_operadora.Location = new System.Drawing.Point(484, 70);
            this.cbo_forn_operadora.Name = "cbo_forn_operadora";
            this.cbo_forn_operadora.Size = new System.Drawing.Size(89, 21);
            this.cbo_forn_operadora.TabIndex = 7;
            this.cbo_forn_operadora.ValueMember = "id";
            // 
            // tbl_OperadorasTelefoniaBindingSource1
            // 
            this.tbl_OperadorasTelefoniaBindingSource1.DataMember = "tbl_OperadorasTelefonia";
            this.tbl_OperadorasTelefoniaBindingSource1.DataSource = this.gerenciaOficinaDataSet;
            // 
            // txt_forn_skype
            // 
            this.txt_forn_skype.Location = new System.Drawing.Point(579, 70);
            this.txt_forn_skype.MaxLength = 20;
            this.txt_forn_skype.Multiline = true;
            this.txt_forn_skype.Name = "txt_forn_skype";
            this.txt_forn_skype.Size = new System.Drawing.Size(122, 20);
            this.txt_forn_skype.TabIndex = 8;
            // 
            // txt_forn_nomevendedor
            // 
            this.txt_forn_nomevendedor.Location = new System.Drawing.Point(117, 71);
            this.txt_forn_nomevendedor.MaxLength = 20;
            this.txt_forn_nomevendedor.Multiline = true;
            this.txt_forn_nomevendedor.Name = "txt_forn_nomevendedor";
            this.txt_forn_nomevendedor.Size = new System.Drawing.Size(141, 20);
            this.txt_forn_nomevendedor.TabIndex = 4;
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
            // lbl_forn_skype
            // 
            this.lbl_forn_skype.AutoSize = true;
            this.lbl_forn_skype.Location = new System.Drawing.Point(576, 54);
            this.lbl_forn_skype.Name = "lbl_forn_skype";
            this.lbl_forn_skype.Size = new System.Drawing.Size(89, 13);
            this.lbl_forn_skype.TabIndex = 46;
            this.lbl_forn_skype.Text = "Skype Vendedor:";
            // 
            // txt_forn_celVendedor
            // 
            this.txt_forn_celVendedor.Location = new System.Drawing.Point(374, 71);
            this.txt_forn_celVendedor.Mask = "(99) 00000-0000";
            this.txt_forn_celVendedor.Name = "txt_forn_celVendedor";
            this.txt_forn_celVendedor.Size = new System.Drawing.Size(104, 20);
            this.txt_forn_celVendedor.TabIndex = 6;
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
            this.rdo_forn_servicos.TabIndex = 22;
            this.rdo_forn_servicos.Text = "Serviços";
            this.rdo_forn_servicos.UseVisualStyleBackColor = true;
            // 
            // rdo_forn_pecas
            // 
            this.rdo_forn_pecas.AutoSize = true;
            this.rdo_forn_pecas.Checked = true;
            this.rdo_forn_pecas.Location = new System.Drawing.Point(7, 20);
            this.rdo_forn_pecas.Name = "rdo_forn_pecas";
            this.rdo_forn_pecas.Size = new System.Drawing.Size(55, 17);
            this.rdo_forn_pecas.TabIndex = 21;
            this.rdo_forn_pecas.TabStop = true;
            this.rdo_forn_pecas.Text = "Peças";
            this.rdo_forn_pecas.UseVisualStyleBackColor = true;
            // 
            // gpo_forn_tipo
            // 
            this.gpo_forn_tipo.Controls.Add(this.lbl_forn_inscestadual);
            this.gpo_forn_tipo.Controls.Add(this.rdo_forn_juridica);
            this.gpo_forn_tipo.Controls.Add(this.rdo_forn_fisica);
            this.gpo_forn_tipo.Controls.Add(this.txt_forn_inscestadual);
            this.gpo_forn_tipo.Controls.Add(this.txt_forn_CNPJ);
            this.gpo_forn_tipo.Controls.Add(this.lbl_forn_cnpj);
            this.gpo_forn_tipo.Controls.Add(this.lbl_forn_cpf);
            this.gpo_forn_tipo.Controls.Add(this.lbl_forn_inss);
            this.gpo_forn_tipo.Controls.Add(this.txt_forn_cpf);
            this.gpo_forn_tipo.Controls.Add(this.txt_forn_inss);
            this.gpo_forn_tipo.Location = new System.Drawing.Point(393, 156);
            this.gpo_forn_tipo.Name = "gpo_forn_tipo";
            this.gpo_forn_tipo.Size = new System.Drawing.Size(217, 131);
            this.gpo_forn_tipo.TabIndex = 41;
            this.gpo_forn_tipo.TabStop = false;
            this.gpo_forn_tipo.Text = "Tipo de Fornecedor";
            this.gpo_forn_tipo.UseCompatibleTextRendering = true;
            // 
            // txt_forn_inss
            // 
            this.txt_forn_inss.Location = new System.Drawing.Point(7, 105);
            this.txt_forn_inss.Mask = "000000000000";
            this.txt_forn_inss.Name = "txt_forn_inss";
            this.txt_forn_inss.Size = new System.Drawing.Size(120, 20);
            this.txt_forn_inss.TabIndex = 33;
            this.txt_forn_inss.Visible = false;
            // 
            // txt_forn_cpf
            // 
            this.txt_forn_cpf.Location = new System.Drawing.Point(7, 66);
            this.txt_forn_cpf.Mask = "000.000.000-00";
            this.txt_forn_cpf.Name = "txt_forn_cpf";
            this.txt_forn_cpf.Size = new System.Drawing.Size(120, 20);
            this.txt_forn_cpf.TabIndex = 32;
            this.txt_forn_cpf.Visible = false;
            // 
            // rdo_forn_juridica
            // 
            this.rdo_forn_juridica.AutoSize = true;
            this.rdo_forn_juridica.Checked = true;
            this.rdo_forn_juridica.Location = new System.Drawing.Point(105, 20);
            this.rdo_forn_juridica.Name = "rdo_forn_juridica";
            this.rdo_forn_juridica.Size = new System.Drawing.Size(101, 17);
            this.rdo_forn_juridica.TabIndex = 20;
            this.rdo_forn_juridica.TabStop = true;
            this.rdo_forn_juridica.Text = "Pessoa Jurídica";
            this.rdo_forn_juridica.UseVisualStyleBackColor = true;
            this.rdo_forn_juridica.CheckedChanged += new System.EventHandler(this.rdo_forn_juridica_CheckedChanged);
            // 
            // rdo_forn_fisica
            // 
            this.rdo_forn_fisica.AutoSize = true;
            this.rdo_forn_fisica.Location = new System.Drawing.Point(7, 20);
            this.rdo_forn_fisica.Name = "rdo_forn_fisica";
            this.rdo_forn_fisica.Size = new System.Drawing.Size(92, 17);
            this.rdo_forn_fisica.TabIndex = 19;
            this.rdo_forn_fisica.Text = "Pessoa Física";
            this.rdo_forn_fisica.UseVisualStyleBackColor = true;
            this.rdo_forn_fisica.CheckedChanged += new System.EventHandler(this.rdo_forn_fisica_CheckedChanged);
            // 
            // txt_forn_CNPJ
            // 
            this.txt_forn_CNPJ.Location = new System.Drawing.Point(8, 66);
            this.txt_forn_CNPJ.Mask = "00,000,000/0000-00";
            this.txt_forn_CNPJ.Name = "txt_forn_CNPJ";
            this.txt_forn_CNPJ.Size = new System.Drawing.Size(118, 20);
            this.txt_forn_CNPJ.TabIndex = 5;
            // 
            // lbl_forn_cnpj
            // 
            this.lbl_forn_cnpj.AutoSize = true;
            this.lbl_forn_cnpj.Location = new System.Drawing.Point(7, 50);
            this.lbl_forn_cnpj.Name = "lbl_forn_cnpj";
            this.lbl_forn_cnpj.Size = new System.Drawing.Size(37, 13);
            this.lbl_forn_cnpj.TabIndex = 9;
            this.lbl_forn_cnpj.Text = "CNPJ:";
            // 
            // lbl_forn_cpf
            // 
            this.lbl_forn_cpf.AutoSize = true;
            this.lbl_forn_cpf.Location = new System.Drawing.Point(7, 50);
            this.lbl_forn_cpf.Name = "lbl_forn_cpf";
            this.lbl_forn_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_forn_cpf.TabIndex = 11;
            this.lbl_forn_cpf.Text = "CPF";
            this.lbl_forn_cpf.Visible = false;
            // 
            // lbl_forn_inss
            // 
            this.lbl_forn_inss.AutoSize = true;
            this.lbl_forn_inss.Location = new System.Drawing.Point(4, 89);
            this.lbl_forn_inss.Name = "lbl_forn_inss";
            this.lbl_forn_inss.Size = new System.Drawing.Size(32, 13);
            this.lbl_forn_inss.TabIndex = 29;
            this.lbl_forn_inss.Text = "INSS";
            this.lbl_forn_inss.Visible = false;
            // 
            // gbo_forn_banco
            // 
            this.gbo_forn_banco.Controls.Add(this.cbo_forn_bancos);
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
            // cbo_forn_bancos
            // 
            this.cbo_forn_bancos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_forn_bancos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_forn_bancos.DataSource = this.tblBancosBindingSource;
            this.cbo_forn_bancos.DisplayMember = "Nome_Banco";
            this.cbo_forn_bancos.FormattingEnabled = true;
            this.cbo_forn_bancos.Location = new System.Drawing.Point(7, 42);
            this.cbo_forn_bancos.Name = "cbo_forn_bancos";
            this.cbo_forn_bancos.Size = new System.Drawing.Size(193, 21);
            this.cbo_forn_bancos.TabIndex = 16;
            this.cbo_forn_bancos.ValueMember = "id";
            // 
            // txt_forn_conta
            // 
            this.txt_forn_conta.Location = new System.Drawing.Point(280, 43);
            this.txt_forn_conta.MaxLength = 60;
            this.txt_forn_conta.Name = "txt_forn_conta";
            this.txt_forn_conta.Size = new System.Drawing.Size(92, 20);
            this.txt_forn_conta.TabIndex = 18;
            this.txt_forn_conta.WordWrap = false;
            // 
            // txt_forn_agencia
            // 
            this.txt_forn_agencia.Location = new System.Drawing.Point(206, 43);
            this.txt_forn_agencia.MaxLength = 60;
            this.txt_forn_agencia.Name = "txt_forn_agencia";
            this.txt_forn_agencia.Size = new System.Drawing.Size(68, 20);
            this.txt_forn_agencia.TabIndex = 17;
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
            this.lbl_forn_site.Location = new System.Drawing.Point(731, 16);
            this.lbl_forn_site.Name = "lbl_forn_site";
            this.lbl_forn_site.Size = new System.Drawing.Size(28, 13);
            this.lbl_forn_site.TabIndex = 30;
            this.lbl_forn_site.Text = "Site:";
            // 
            // txt_forn_site
            // 
            this.txt_forn_site.Location = new System.Drawing.Point(732, 32);
            this.txt_forn_site.MaxLength = 60;
            this.txt_forn_site.Name = "txt_forn_site";
            this.txt_forn_site.Size = new System.Drawing.Size(243, 20);
            this.txt_forn_site.TabIndex = 2;
            this.txt_forn_site.WordWrap = false;
            // 
            // txt_forn_nomefant
            // 
            this.txt_forn_nomefant.Location = new System.Drawing.Point(369, 32);
            this.txt_forn_nomefant.MaxLength = 60;
            this.txt_forn_nomefant.Name = "txt_forn_nomefant";
            this.txt_forn_nomefant.Size = new System.Drawing.Size(357, 20);
            this.txt_forn_nomefant.TabIndex = 1;
            this.txt_forn_nomefant.WordWrap = false;
            // 
            // btn_forn_Salvar
            // 
            this.btn_forn_Salvar.Image = global::Gerenciador_Oficina_Mecanica.Properties.Resources.save;
            this.btn_forn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_forn_Salvar.Location = new System.Drawing.Point(840, 422);
            this.btn_forn_Salvar.Name = "btn_forn_Salvar";
            this.btn_forn_Salvar.Size = new System.Drawing.Size(135, 30);
            this.btn_forn_Salvar.TabIndex = 24;
            this.btn_forn_Salvar.Text = "Cadastrar Fornecedor";
            this.btn_forn_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_forn_Salvar.UseVisualStyleBackColor = true;
            this.btn_forn_Salvar.Click += new System.EventHandler(this.btn_forn_Salvar_Click);
            // 
            // cbo_forn_cidade
            // 
            this.cbo_forn_cidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_forn_cidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_forn_cidade.DataSource = this.tbl_CidadeBindingSource;
            this.cbo_forn_cidade.DisplayMember = "Nome_Cidade";
            this.cbo_forn_cidade.FormattingEnabled = true;
            this.cbo_forn_cidade.Location = new System.Drawing.Point(788, 110);
            this.cbo_forn_cidade.Name = "cbo_forn_cidade";
            this.cbo_forn_cidade.Size = new System.Drawing.Size(187, 21);
            this.cbo_forn_cidade.TabIndex = 15;
            this.cbo_forn_cidade.ValueMember = "id";
            // 
            // cbo_forn_estado
            // 
            this.cbo_forn_estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_forn_estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_forn_estado.DataSource = this.tbl_EstadoBindingSource;
            this.cbo_forn_estado.DisplayMember = "Sigla_Estado";
            this.cbo_forn_estado.FormattingEnabled = true;
            this.cbo_forn_estado.Location = new System.Drawing.Point(720, 110);
            this.cbo_forn_estado.Name = "cbo_forn_estado";
            this.cbo_forn_estado.Size = new System.Drawing.Size(62, 21);
            this.cbo_forn_estado.TabIndex = 14;
            this.cbo_forn_estado.ValueMember = "id";
            // 
            // lbl_forn_Estado
            // 
            this.lbl_forn_Estado.AutoSize = true;
            this.lbl_forn_Estado.Location = new System.Drawing.Point(718, 94);
            this.lbl_forn_Estado.Name = "lbl_forn_Estado";
            this.lbl_forn_Estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_forn_Estado.TabIndex = 26;
            this.lbl_forn_Estado.Text = "Estado:";
            // 
            // lbl_forn_cidade
            // 
            this.lbl_forn_cidade.AutoSize = true;
            this.lbl_forn_cidade.Location = new System.Drawing.Point(785, 94);
            this.lbl_forn_cidade.Name = "lbl_forn_cidade";
            this.lbl_forn_cidade.Size = new System.Drawing.Size(43, 13);
            this.lbl_forn_cidade.TabIndex = 25;
            this.lbl_forn_cidade.Text = "Cidade:";
            // 
            // lbl_forn_bairro
            // 
            this.lbl_forn_bairro.AutoSize = true;
            this.lbl_forn_bairro.Location = new System.Drawing.Point(590, 94);
            this.lbl_forn_bairro.Name = "lbl_forn_bairro";
            this.lbl_forn_bairro.Size = new System.Drawing.Size(37, 13);
            this.lbl_forn_bairro.TabIndex = 24;
            this.lbl_forn_bairro.Text = "Bairro:";
            // 
            // txt_forn_bairro
            // 
            this.txt_forn_bairro.Location = new System.Drawing.Point(593, 110);
            this.txt_forn_bairro.MaxLength = 50;
            this.txt_forn_bairro.Multiline = true;
            this.txt_forn_bairro.Name = "txt_forn_bairro";
            this.txt_forn_bairro.Size = new System.Drawing.Size(122, 20);
            this.txt_forn_bairro.TabIndex = 13;
            // 
            // lbl_forn_complemento
            // 
            this.lbl_forn_complemento.AutoSize = true;
            this.lbl_forn_complemento.Location = new System.Drawing.Point(443, 94);
            this.lbl_forn_complemento.Name = "lbl_forn_complemento";
            this.lbl_forn_complemento.Size = new System.Drawing.Size(144, 13);
            this.lbl_forn_complemento.TabIndex = 22;
            this.lbl_forn_complemento.Text = "Complemento (loja, apto ....): ";
            // 
            // txt_forn_CompEnd
            // 
            this.txt_forn_CompEnd.Location = new System.Drawing.Point(446, 110);
            this.txt_forn_CompEnd.Multiline = true;
            this.txt_forn_CompEnd.Name = "txt_forn_CompEnd";
            this.txt_forn_CompEnd.Size = new System.Drawing.Size(141, 20);
            this.txt_forn_CompEnd.TabIndex = 12;
            // 
            // lbl_forn_endereco
            // 
            this.lbl_forn_endereco.AutoSize = true;
            this.lbl_forn_endereco.Location = new System.Drawing.Point(83, 94);
            this.lbl_forn_endereco.Name = "lbl_forn_endereco";
            this.lbl_forn_endereco.Size = new System.Drawing.Size(56, 13);
            this.lbl_forn_endereco.TabIndex = 20;
            this.lbl_forn_endereco.Text = "Endereço:";
            // 
            // txt_forn_end
            // 
            this.txt_forn_end.Location = new System.Drawing.Point(86, 110);
            this.txt_forn_end.Multiline = true;
            this.txt_forn_end.Name = "txt_forn_end";
            this.txt_forn_end.Size = new System.Drawing.Size(354, 20);
            this.txt_forn_end.TabIndex = 11;
            // 
            // txt_forn_cep
            // 
            this.txt_forn_cep.Location = new System.Drawing.Point(9, 110);
            this.txt_forn_cep.Mask = "00,000-000";
            this.txt_forn_cep.Name = "txt_forn_cep";
            this.txt_forn_cep.Size = new System.Drawing.Size(71, 20);
            this.txt_forn_cep.TabIndex = 10;
            // 
            // lbl_forn_Cep
            // 
            this.lbl_forn_Cep.AutoSize = true;
            this.lbl_forn_Cep.Location = new System.Drawing.Point(6, 94);
            this.lbl_forn_Cep.Name = "lbl_forn_Cep";
            this.lbl_forn_Cep.Size = new System.Drawing.Size(31, 13);
            this.lbl_forn_Cep.TabIndex = 19;
            this.lbl_forn_Cep.Text = "CEP:";
            // 
            // txt_forn_TelVendedor
            // 
            this.txt_forn_TelVendedor.Location = new System.Drawing.Point(264, 71);
            this.txt_forn_TelVendedor.Mask = "(99) 0000-0000";
            this.txt_forn_TelVendedor.Name = "txt_forn_TelVendedor";
            this.txt_forn_TelVendedor.Size = new System.Drawing.Size(104, 20);
            this.txt_forn_TelVendedor.TabIndex = 5;
            // 
            // txt_forn_telGeral
            // 
            this.txt_forn_telGeral.Location = new System.Drawing.Point(9, 71);
            this.txt_forn_telGeral.Mask = "(99) 0000-0000";
            this.txt_forn_telGeral.Name = "txt_forn_telGeral";
            this.txt_forn_telGeral.Size = new System.Drawing.Size(104, 20);
            this.txt_forn_telGeral.TabIndex = 3;
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
            // lbl_forn_Email
            // 
            this.lbl_forn_Email.AutoSize = true;
            this.lbl_forn_Email.Location = new System.Drawing.Point(704, 54);
            this.lbl_forn_Email.Name = "lbl_forn_Email";
            this.lbl_forn_Email.Size = new System.Drawing.Size(38, 13);
            this.lbl_forn_Email.TabIndex = 3;
            this.lbl_forn_Email.Text = "E-mail:";
            // 
            // txt_forn_Email
            // 
            this.txt_forn_Email.Location = new System.Drawing.Point(707, 70);
            this.txt_forn_Email.MaxLength = 60;
            this.txt_forn_Email.Name = "txt_forn_Email";
            this.txt_forn_Email.Size = new System.Drawing.Size(268, 20);
            this.txt_forn_Email.TabIndex = 9;
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
            this.txt_forn_razsoc.TabIndex = 0;
            this.txt_forn_razsoc.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_forn_inativo);
            this.groupBox1.Controls.Add(this.Ativo);
            this.groupBox1.Location = new System.Drawing.Point(616, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 131);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status Fornecedor";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // Ativo
            // 
            this.Ativo.AutoSize = true;
            this.Ativo.Checked = true;
            this.Ativo.Location = new System.Drawing.Point(6, 39);
            this.Ativo.Name = "Ativo";
            this.Ativo.Size = new System.Drawing.Size(49, 17);
            this.Ativo.TabIndex = 0;
            this.Ativo.TabStop = true;
            this.Ativo.Text = "Ativo";
            this.Ativo.UseVisualStyleBackColor = true;
            // 
            // rdo_forn_inativo
            // 
            this.rdo_forn_inativo.AutoSize = true;
            this.rdo_forn_inativo.Location = new System.Drawing.Point(6, 83);
            this.rdo_forn_inativo.Name = "rdo_forn_inativo";
            this.rdo_forn_inativo.Size = new System.Drawing.Size(57, 17);
            this.rdo_forn_inativo.TabIndex = 1;
            this.rdo_forn_inativo.Text = "Inativo";
            this.rdo_forn_inativo.UseVisualStyleBackColor = true;
            // 
            // lbl_forn_inscestadual
            // 
            this.lbl_forn_inscestadual.AutoSize = true;
            this.lbl_forn_inscestadual.Location = new System.Drawing.Point(6, 90);
            this.lbl_forn_inscestadual.Name = "lbl_forn_inscestadual";
            this.lbl_forn_inscestadual.Size = new System.Drawing.Size(74, 13);
            this.lbl_forn_inscestadual.TabIndex = 34;
            this.lbl_forn_inscestadual.Text = "Insc. Estadual";
            // 
            // txt_forn_inscestadual
            // 
            this.txt_forn_inscestadual.Location = new System.Drawing.Point(7, 105);
            this.txt_forn_inscestadual.Mask = "000000000000";
            this.txt_forn_inscestadual.Name = "txt_forn_inscestadual";
            this.txt_forn_inscestadual.Size = new System.Drawing.Size(120, 20);
            this.txt_forn_inscestadual.TabIndex = 35;
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
            ((System.ComponentModel.ISupportInitialize)(this.tbl_OperadorasTelefoniaBindingSource1)).EndInit();
            this.gpo_forn_Segmento.ResumeLayout(false);
            this.gpo_forn_Segmento.PerformLayout();
            this.gpo_forn_tipo.ResumeLayout(false);
            this.gpo_forn_tipo.PerformLayout();
            this.gbo_forn_banco.ResumeLayout(false);
            this.gbo_forn_banco.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox txt_forn_celVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpo_forn_Segmento;
        private System.Windows.Forms.RadioButton rdo_forn_servicos;
        private System.Windows.Forms.RadioButton rdo_forn_pecas;
        private System.Windows.Forms.GroupBox gpo_forn_tipo;
        private System.Windows.Forms.RadioButton rdo_forn_juridica;
        private System.Windows.Forms.RadioButton rdo_forn_fisica;
        private System.Windows.Forms.MaskedTextBox txt_forn_CNPJ;
        private System.Windows.Forms.Label lbl_forn_cnpj;
        private System.Windows.Forms.Label lbl_forn_cpf;
        private System.Windows.Forms.Label lbl_forn_inss;
        private System.Windows.Forms.GroupBox gbo_forn_banco;
        private System.Windows.Forms.ComboBox cbo_forn_bancos;
        public System.Windows.Forms.TextBox txt_forn_conta;
        public System.Windows.Forms.TextBox txt_forn_agencia;
        private System.Windows.Forms.Label lbl_forn_banco;
        private System.Windows.Forms.Label lbl_forn_conta;
        private System.Windows.Forms.Label lbl_forn_agencia;
        private System.Windows.Forms.Label lbl_forn_site;
        private System.Windows.Forms.TextBox txt_forn_site;
        public System.Windows.Forms.TextBox txt_forn_nomefant;
        private System.Windows.Forms.Button btn_forn_Salvar;
        private System.Windows.Forms.ComboBox cbo_forn_cidade;
        private System.Windows.Forms.ComboBox cbo_forn_estado;
        private System.Windows.Forms.Label lbl_forn_Estado;
        private System.Windows.Forms.Label lbl_forn_cidade;
        private System.Windows.Forms.Label lbl_forn_bairro;
        private System.Windows.Forms.TextBox txt_forn_bairro;
        private System.Windows.Forms.Label lbl_forn_complemento;
        private System.Windows.Forms.TextBox txt_forn_CompEnd;
        private System.Windows.Forms.Label lbl_forn_endereco;
        private System.Windows.Forms.TextBox txt_forn_end;
        private System.Windows.Forms.MaskedTextBox txt_forn_cep;
        private System.Windows.Forms.Label lbl_forn_Cep;
        private System.Windows.Forms.MaskedTextBox txt_forn_TelVendedor;
        private System.Windows.Forms.MaskedTextBox txt_forn_telGeral;
        private System.Windows.Forms.Label lbl_TelComercial;
        private System.Windows.Forms.Label lbl_forn_TelGeral;
        private System.Windows.Forms.Label lbl_nomefant;
        private System.Windows.Forms.Label lbl_forn_Email;
        private System.Windows.Forms.TextBox txt_forn_Email;
        private System.Windows.Forms.Label lbl_razsoc;
        public System.Windows.Forms.TextBox txt_forn_razsoc;
        private System.Windows.Forms.TextBox txt_forn_skype;
        private System.Windows.Forms.TextBox txt_forn_nomevendedor;
        private System.Windows.Forms.Label lbl_forn_nomevendedor;
        private System.Windows.Forms.ComboBox cbo_forn_operadora;
        private System.Windows.Forms.BindingSource tbl_OperadorasTelefoniaBindingSource1;
        private System.Windows.Forms.Label lbl_forn_obs;
        private System.Windows.Forms.TextBox txt_forn_obs;
        private System.Windows.Forms.MaskedTextBox txt_forn_inss;
        private System.Windows.Forms.MaskedTextBox txt_forn_cpf;
        private System.Windows.Forms.Label lbl_forn_quantcarac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_forn_inativo;
        private System.Windows.Forms.RadioButton Ativo;
        private System.Windows.Forms.Label lbl_forn_inscestadual;
        private System.Windows.Forms.MaskedTextBox txt_forn_inscestadual;
    }
}