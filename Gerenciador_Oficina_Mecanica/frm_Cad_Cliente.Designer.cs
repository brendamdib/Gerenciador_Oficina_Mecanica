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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbl_CliPF_Cod;
            System.Windows.Forms.Label lbl_CliPJ_Cod;
            this.pnl_CadCliente = new System.Windows.Forms.Panel();
            this.txt_CliPJ_Cod = new System.Windows.Forms.TextBox();
            this.tbl_Clientes_PJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerenciaOficinaDataSet = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSet();
            this.grp_PessoaFisica = new System.Windows.Forms.GroupBox();
            this.grp_Cli_Veiculos = new System.Windows.Forms.GroupBox();
            this.grd_CliPF_Veiculos = new System.Windows.Forms.DataGridView();
            this.btn_CliPF_addVeiculo = new System.Windows.Forms.Button();
            this.btn_CliPF_editVeiculo = new System.Windows.Forms.Button();
            this.btn_CliPF_delVeiculo = new System.Windows.Forms.Button();
            this.btn_Cli_Salvar = new System.Windows.Forms.Button();
            this.cbo_CliPF_Operadora = new System.Windows.Forms.ComboBox();
            this.tbl_OperadorasTelefoniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_CliPF_Sexo = new System.Windows.Forms.ComboBox();
            this.tbl_SexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_CliPF_Cidade = new System.Windows.Forms.ComboBox();
            this.tbl_CidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_CliPF_Estado = new System.Windows.Forms.ComboBox();
            this.tbl_EstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.lbl_Operadora = new System.Windows.Forms.Label();
            this.txt_CliPF_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_CliPF_TelCel = new System.Windows.Forms.MaskedTextBox();
            this.txt_CliPF_TelCom = new System.Windows.Forms.MaskedTextBox();
            this.txt_CliPF_TelRes = new System.Windows.Forms.MaskedTextBox();
            this.lbl_TelCelular = new System.Windows.Forms.Label();
            this.lbl_TelComercial = new System.Windows.Forms.Label();
            this.lbl_TelResidencial = new System.Windows.Forms.Label();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.txt_CliPF_RG = new System.Windows.Forms.TextBox();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_DataNasc = new System.Windows.Forms.Label();
            this.txt_CliPF_DataNasc = new System.Windows.Forms.DateTimePicker();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_CliPF_Email = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_CliPF_Nome = new System.Windows.Forms.TextBox();
            this.txt_CliPF_Cod = new System.Windows.Forms.TextBox();
            this.tbl_Clientes_PFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grp_TipoCliente = new System.Windows.Forms.GroupBox();
            this.rdo_Cli_PJ = new System.Windows.Forms.RadioButton();
            this.rdo_Cli_PF = new System.Windows.Forms.RadioButton();
            this.grp_PessoaJuridica = new System.Windows.Forms.GroupBox();
            this.tbl_EstadoTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_EstadoTableAdapter();
            this.tableAdapterManager = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.TableAdapterManager();
            this.tbl_CidadeTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_CidadeTableAdapter();
            this.tbl_SexoTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_SexoTableAdapter();
            this.tbl_OperadorasTelefoniaTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_OperadorasTelefoniaTableAdapter();
            this.tbl_Clientes_PFTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_Clientes_PFTableAdapter();
            this.tbl_Clientes_PJTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_Clientes_PJTableAdapter();
            lbl_CliPF_Cod = new System.Windows.Forms.Label();
            lbl_CliPJ_Cod = new System.Windows.Forms.Label();
            this.pnl_CadCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Clientes_PJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaOficinaDataSet)).BeginInit();
            this.grp_PessoaFisica.SuspendLayout();
            this.grp_Cli_Veiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_CliPF_Veiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_OperadorasTelefoniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_EstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Clientes_PFBindingSource)).BeginInit();
            this.grp_TipoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CliPF_Cod
            // 
            lbl_CliPF_Cod.AutoSize = true;
            lbl_CliPF_Cod.Enabled = false;
            lbl_CliPF_Cod.Location = new System.Drawing.Point(258, 7);
            lbl_CliPF_Cod.Name = "lbl_CliPF_Cod";
            lbl_CliPF_Cod.Size = new System.Drawing.Size(91, 13);
            lbl_CliPF_Cod.TabIndex = 37;
            lbl_CliPF_Cod.Text = "Código Cliente PF";
            lbl_CliPF_Cod.Visible = false;
            // 
            // lbl_CliPJ_Cod
            // 
            lbl_CliPJ_Cod.AutoSize = true;
            lbl_CliPJ_Cod.Enabled = false;
            lbl_CliPJ_Cod.Location = new System.Drawing.Point(258, 31);
            lbl_CliPJ_Cod.Name = "lbl_CliPJ_Cod";
            lbl_CliPJ_Cod.Size = new System.Drawing.Size(90, 13);
            lbl_CliPJ_Cod.TabIndex = 38;
            lbl_CliPJ_Cod.Text = "Codigo Cliente PJ";
            lbl_CliPJ_Cod.Visible = false;
            // 
            // pnl_CadCliente
            // 
            this.pnl_CadCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_CadCliente.AutoSize = true;
            this.pnl_CadCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_CadCliente.Controls.Add(lbl_CliPJ_Cod);
            this.pnl_CadCliente.Controls.Add(this.txt_CliPJ_Cod);
            this.pnl_CadCliente.Controls.Add(lbl_CliPF_Cod);
            this.pnl_CadCliente.Controls.Add(this.grp_PessoaFisica);
            this.pnl_CadCliente.Controls.Add(this.txt_CliPF_Cod);
            this.pnl_CadCliente.Controls.Add(this.grp_TipoCliente);
            this.pnl_CadCliente.Controls.Add(this.grp_PessoaJuridica);
            this.pnl_CadCliente.Location = new System.Drawing.Point(13, 13);
            this.pnl_CadCliente.Name = "pnl_CadCliente";
            this.pnl_CadCliente.Size = new System.Drawing.Size(1152, 614);
            this.pnl_CadCliente.TabIndex = 0;
            // 
            // txt_CliPJ_Cod
            // 
            this.txt_CliPJ_Cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_Clientes_PJBindingSource, "id", true));
            this.txt_CliPJ_Cod.Enabled = false;
            this.txt_CliPJ_Cod.Location = new System.Drawing.Point(355, 28);
            this.txt_CliPJ_Cod.Name = "txt_CliPJ_Cod";
            this.txt_CliPJ_Cod.Size = new System.Drawing.Size(100, 20);
            this.txt_CliPJ_Cod.TabIndex = 39;
            this.txt_CliPJ_Cod.Visible = false;
            // 
            // tbl_Clientes_PJBindingSource
            // 
            this.tbl_Clientes_PJBindingSource.DataMember = "tbl_Clientes_PJ";
            this.tbl_Clientes_PJBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // gerenciaOficinaDataSet
            // 
            this.gerenciaOficinaDataSet.DataSetName = "GerenciaOficinaDataSet";
            this.gerenciaOficinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grp_PessoaFisica
            // 
            this.grp_PessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_PessoaFisica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grp_PessoaFisica.Controls.Add(this.grp_Cli_Veiculos);
            this.grp_PessoaFisica.Controls.Add(this.btn_Cli_Salvar);
            this.grp_PessoaFisica.Controls.Add(this.cbo_CliPF_Operadora);
            this.grp_PessoaFisica.Controls.Add(this.cbo_CliPF_Sexo);
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
            this.grp_PessoaFisica.Controls.Add(this.lbl_Operadora);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_Cpf);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_TelCel);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_TelCom);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_TelRes);
            this.grp_PessoaFisica.Controls.Add(this.lbl_TelCelular);
            this.grp_PessoaFisica.Controls.Add(this.lbl_TelComercial);
            this.grp_PessoaFisica.Controls.Add(this.lbl_TelResidencial);
            this.grp_PessoaFisica.Controls.Add(this.lbl_rg);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_RG);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Cpf);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Sexo);
            this.grp_PessoaFisica.Controls.Add(this.lbl_DataNasc);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_DataNasc);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Email);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_Email);
            this.grp_PessoaFisica.Controls.Add(this.lbl_Nome);
            this.grp_PessoaFisica.Controls.Add(this.txt_CliPF_Nome);
            this.grp_PessoaFisica.Location = new System.Drawing.Point(14, 54);
            this.grp_PessoaFisica.Name = "grp_PessoaFisica";
            this.grp_PessoaFisica.Size = new System.Drawing.Size(1120, 549);
            this.grp_PessoaFisica.TabIndex = 1;
            this.grp_PessoaFisica.TabStop = false;
            this.grp_PessoaFisica.Text = "Pessoa Física";
            this.grp_PessoaFisica.Visible = false;
            // 
            // grp_Cli_Veiculos
            // 
            this.grp_Cli_Veiculos.Controls.Add(this.grd_CliPF_Veiculos);
            this.grp_Cli_Veiculos.Controls.Add(this.btn_CliPF_addVeiculo);
            this.grp_Cli_Veiculos.Controls.Add(this.btn_CliPF_editVeiculo);
            this.grp_Cli_Veiculos.Controls.Add(this.btn_CliPF_delVeiculo);
            this.grp_Cli_Veiculos.Location = new System.Drawing.Point(9, 196);
            this.grp_Cli_Veiculos.Name = "grp_Cli_Veiculos";
            this.grp_Cli_Veiculos.Size = new System.Drawing.Size(966, 182);
            this.grp_Cli_Veiculos.TabIndex = 20;
            this.grp_Cli_Veiculos.TabStop = false;
            this.grp_Cli_Veiculos.Text = "Veículos";
            // 
            // grd_CliPF_Veiculos
            // 
            this.grd_CliPF_Veiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_CliPF_Veiculos.Location = new System.Drawing.Point(6, 20);
            this.grd_CliPF_Veiculos.Name = "grd_CliPF_Veiculos";
            this.grd_CliPF_Veiculos.Size = new System.Drawing.Size(829, 148);
            this.grd_CliPF_Veiculos.TabIndex = 32;
            this.grd_CliPF_Veiculos.TabStop = false;
            // 
            // btn_CliPF_addVeiculo
            // 
            this.btn_CliPF_addVeiculo.Image = global::Gerenciador_Oficina_Mecanica.Properties.Resources.add_1_icon;
            this.btn_CliPF_addVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CliPF_addVeiculo.Location = new System.Drawing.Point(841, 20);
            this.btn_CliPF_addVeiculo.Name = "btn_CliPF_addVeiculo";
            this.btn_CliPF_addVeiculo.Size = new System.Drawing.Size(120, 30);
            this.btn_CliPF_addVeiculo.TabIndex = 19;
            this.btn_CliPF_addVeiculo.Text = "Adicionar Veículo";
            this.btn_CliPF_addVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CliPF_addVeiculo.UseVisualStyleBackColor = true;
            this.btn_CliPF_addVeiculo.Click += new System.EventHandler(this.btn_CliPF_addVeiculo_Click);
            // 
            // btn_CliPF_editVeiculo
            // 
            this.btn_CliPF_editVeiculo.Image = global::Gerenciador_Oficina_Mecanica.Properties.Resources.edit_icon;
            this.btn_CliPF_editVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CliPF_editVeiculo.Location = new System.Drawing.Point(841, 79);
            this.btn_CliPF_editVeiculo.Name = "btn_CliPF_editVeiculo";
            this.btn_CliPF_editVeiculo.Size = new System.Drawing.Size(121, 30);
            this.btn_CliPF_editVeiculo.TabIndex = 20;
            this.btn_CliPF_editVeiculo.Text = "Editar Veículo";
            this.btn_CliPF_editVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CliPF_editVeiculo.UseVisualStyleBackColor = true;
            // 
            // btn_CliPF_delVeiculo
            // 
            this.btn_CliPF_delVeiculo.Image = global::Gerenciador_Oficina_Mecanica.Properties.Resources.delete_1_icon;
            this.btn_CliPF_delVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CliPF_delVeiculo.Location = new System.Drawing.Point(841, 138);
            this.btn_CliPF_delVeiculo.Name = "btn_CliPF_delVeiculo";
            this.btn_CliPF_delVeiculo.Size = new System.Drawing.Size(120, 30);
            this.btn_CliPF_delVeiculo.TabIndex = 21;
            this.btn_CliPF_delVeiculo.Text = "Excluir Veículo";
            this.btn_CliPF_delVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CliPF_delVeiculo.UseVisualStyleBackColor = true;
            // 
            // btn_Cli_Salvar
            // 
            this.btn_Cli_Salvar.Image = global::Gerenciador_Oficina_Mecanica.Properties.Resources.save;
            this.btn_Cli_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cli_Salvar.Location = new System.Drawing.Point(854, 155);
            this.btn_Cli_Salvar.Name = "btn_Cli_Salvar";
            this.btn_Cli_Salvar.Size = new System.Drawing.Size(121, 30);
            this.btn_Cli_Salvar.TabIndex = 18;
            this.btn_Cli_Salvar.Text = "Cadastrar Cliente";
            this.btn_Cli_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cli_Salvar.UseVisualStyleBackColor = true;
            this.btn_Cli_Salvar.Click += new System.EventHandler(this.btn_Cli_Salvar_Click);
            // 
            // cbo_CliPF_Operadora
            // 
            this.cbo_CliPF_Operadora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_CliPF_Operadora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_CliPF_Operadora.DataSource = this.tbl_OperadorasTelefoniaBindingSource;
            this.cbo_CliPF_Operadora.DisplayMember = "Nome_Operadora";
            this.cbo_CliPF_Operadora.FormattingEnabled = true;
            this.cbo_CliPF_Operadora.Location = new System.Drawing.Point(699, 70);
            this.cbo_CliPF_Operadora.Name = "cbo_CliPF_Operadora";
            this.cbo_CliPF_Operadora.Size = new System.Drawing.Size(139, 21);
            this.cbo_CliPF_Operadora.TabIndex = 11;
            this.cbo_CliPF_Operadora.ValueMember = "id";
            // 
            // tbl_OperadorasTelefoniaBindingSource
            // 
            this.tbl_OperadorasTelefoniaBindingSource.DataMember = "tbl_OperadorasTelefonia";
            this.tbl_OperadorasTelefoniaBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // cbo_CliPF_Sexo
            // 
            this.cbo_CliPF_Sexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_CliPF_Sexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_CliPF_Sexo.DataSource = this.tbl_SexoBindingSource;
            this.cbo_CliPF_Sexo.DisplayMember = "Descricao_Sexo";
            this.cbo_CliPF_Sexo.FormattingEnabled = true;
            this.cbo_CliPF_Sexo.Location = new System.Drawing.Point(594, 32);
            this.cbo_CliPF_Sexo.Name = "cbo_CliPF_Sexo";
            this.cbo_CliPF_Sexo.Size = new System.Drawing.Size(120, 21);
            this.cbo_CliPF_Sexo.TabIndex = 4;
            this.cbo_CliPF_Sexo.ValueMember = "id";
            // 
            // tbl_SexoBindingSource
            // 
            this.tbl_SexoBindingSource.DataMember = "tbl_Sexo";
            this.tbl_SexoBindingSource.DataSource = this.gerenciaOficinaDataSet;
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
            // tbl_CidadeBindingSource
            // 
            this.tbl_CidadeBindingSource.DataMember = "tbl_Cidade";
            this.tbl_CidadeBindingSource.DataSource = this.gerenciaOficinaDataSet;
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
            this.cbo_CliPF_Estado.SelectedIndexChanged += new System.EventHandler(this.cbo_Estado_SelectedIndexChanged);
            // 
            // tbl_EstadoBindingSource
            // 
            this.tbl_EstadoBindingSource.DataMember = "tbl_Estado";
            this.tbl_EstadoBindingSource.DataSource = this.gerenciaOficinaDataSet;
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
            // lbl_Operadora
            // 
            this.lbl_Operadora.AutoSize = true;
            this.lbl_Operadora.Location = new System.Drawing.Point(696, 55);
            this.lbl_Operadora.Name = "lbl_Operadora";
            this.lbl_Operadora.Size = new System.Drawing.Size(60, 13);
            this.lbl_Operadora.TabIndex = 18;
            this.lbl_Operadora.Text = "Operadora:";
            // 
            // txt_CliPF_Cpf
            // 
            this.txt_CliPF_Cpf.Location = new System.Drawing.Point(720, 32);
            this.txt_CliPF_Cpf.Mask = "000,000,000-00";
            this.txt_CliPF_Cpf.Name = "txt_CliPF_Cpf";
            this.txt_CliPF_Cpf.Size = new System.Drawing.Size(118, 20);
            this.txt_CliPF_Cpf.TabIndex = 5;
            // 
            // txt_CliPF_TelCel
            // 
            this.txt_CliPF_TelCel.Location = new System.Drawing.Point(589, 71);
            this.txt_CliPF_TelCel.Mask = "(99) 00000-0000";
            this.txt_CliPF_TelCel.Name = "txt_CliPF_TelCel";
            this.txt_CliPF_TelCel.Size = new System.Drawing.Size(104, 20);
            this.txt_CliPF_TelCel.TabIndex = 10;
            // 
            // txt_CliPF_TelCom
            // 
            this.txt_CliPF_TelCom.Location = new System.Drawing.Point(479, 71);
            this.txt_CliPF_TelCom.Mask = "(99) 0000-0000";
            this.txt_CliPF_TelCom.Name = "txt_CliPF_TelCom";
            this.txt_CliPF_TelCom.Size = new System.Drawing.Size(104, 20);
            this.txt_CliPF_TelCom.TabIndex = 9;
            // 
            // txt_CliPF_TelRes
            // 
            this.txt_CliPF_TelRes.Location = new System.Drawing.Point(369, 71);
            this.txt_CliPF_TelRes.Mask = "(99) 0000-0000";
            this.txt_CliPF_TelRes.Name = "txt_CliPF_TelRes";
            this.txt_CliPF_TelRes.Size = new System.Drawing.Size(104, 20);
            this.txt_CliPF_TelRes.TabIndex = 8;
            // 
            // lbl_TelCelular
            // 
            this.lbl_TelCelular.AutoSize = true;
            this.lbl_TelCelular.Location = new System.Drawing.Point(586, 55);
            this.lbl_TelCelular.Name = "lbl_TelCelular";
            this.lbl_TelCelular.Size = new System.Drawing.Size(87, 13);
            this.lbl_TelCelular.TabIndex = 16;
            this.lbl_TelCelular.Text = "Telefone Celular:";
            // 
            // lbl_TelComercial
            // 
            this.lbl_TelComercial.AutoSize = true;
            this.lbl_TelComercial.Location = new System.Drawing.Point(476, 55);
            this.lbl_TelComercial.Name = "lbl_TelComercial";
            this.lbl_TelComercial.Size = new System.Drawing.Size(101, 13);
            this.lbl_TelComercial.TabIndex = 14;
            this.lbl_TelComercial.Text = "Telefone Comercial:";
            // 
            // lbl_TelResidencial
            // 
            this.lbl_TelResidencial.AutoSize = true;
            this.lbl_TelResidencial.Location = new System.Drawing.Point(366, 55);
            this.lbl_TelResidencial.Name = "lbl_TelResidencial";
            this.lbl_TelResidencial.Size = new System.Drawing.Size(110, 13);
            this.lbl_TelResidencial.TabIndex = 12;
            this.lbl_TelResidencial.Text = "Telefone Residencial:";
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(840, 16);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(26, 13);
            this.lbl_rg.TabIndex = 11;
            this.lbl_rg.Text = "RG:";
            // 
            // txt_CliPF_RG
            // 
            this.txt_CliPF_RG.Location = new System.Drawing.Point(844, 32);
            this.txt_CliPF_RG.MaxLength = 15;
            this.txt_CliPF_RG.Name = "txt_CliPF_RG";
            this.txt_CliPF_RG.Size = new System.Drawing.Size(131, 20);
            this.txt_CliPF_RG.TabIndex = 6;
            this.txt_CliPF_RG.WordWrap = false;
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Location = new System.Drawing.Point(718, 16);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(30, 13);
            this.lbl_Cpf.TabIndex = 9;
            this.lbl_Cpf.Text = "CPF:";
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Location = new System.Drawing.Point(591, 16);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(34, 13);
            this.lbl_Sexo.TabIndex = 6;
            this.lbl_Sexo.Text = "Sexo:";
            // 
            // lbl_DataNasc
            // 
            this.lbl_DataNasc.AutoSize = true;
            this.lbl_DataNasc.Location = new System.Drawing.Point(366, 16);
            this.lbl_DataNasc.Name = "lbl_DataNasc";
            this.lbl_DataNasc.Size = new System.Drawing.Size(107, 13);
            this.lbl_DataNasc.TabIndex = 5;
            this.lbl_DataNasc.Text = "Data de Nascimento:";
            // 
            // txt_CliPF_DataNasc
            // 
            this.txt_CliPF_DataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_CliPF_DataNasc.Location = new System.Drawing.Point(369, 32);
            this.txt_CliPF_DataNasc.Name = "txt_CliPF_DataNasc";
            this.txt_CliPF_DataNasc.Size = new System.Drawing.Size(219, 20);
            this.txt_CliPF_DataNasc.TabIndex = 3;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(6, 55);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(38, 13);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Text = "E-mail:";
            // 
            // txt_CliPF_Email
            // 
            this.txt_CliPF_Email.Location = new System.Drawing.Point(9, 71);
            this.txt_CliPF_Email.MaxLength = 60;
            this.txt_CliPF_Email.Name = "txt_CliPF_Email";
            this.txt_CliPF_Email.Size = new System.Drawing.Size(354, 20);
            this.txt_CliPF_Email.TabIndex = 7;
            this.txt_CliPF_Email.WordWrap = false;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(6, 16);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome:";
            // 
            // txt_CliPF_Nome
            // 
            this.txt_CliPF_Nome.Location = new System.Drawing.Point(9, 32);
            this.txt_CliPF_Nome.MaxLength = 60;
            this.txt_CliPF_Nome.Name = "txt_CliPF_Nome";
            this.txt_CliPF_Nome.Size = new System.Drawing.Size(354, 20);
            this.txt_CliPF_Nome.TabIndex = 2;
            this.txt_CliPF_Nome.WordWrap = false;
            // 
            // txt_CliPF_Cod
            // 
            this.txt_CliPF_Cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_Clientes_PFBindingSource, "id", true));
            this.txt_CliPF_Cod.Enabled = false;
            this.txt_CliPF_Cod.Location = new System.Drawing.Point(355, 3);
            this.txt_CliPF_Cod.Name = "txt_CliPF_Cod";
            this.txt_CliPF_Cod.Size = new System.Drawing.Size(100, 20);
            this.txt_CliPF_Cod.TabIndex = 38;
            this.txt_CliPF_Cod.Visible = false;
            // 
            // tbl_Clientes_PFBindingSource
            // 
            this.tbl_Clientes_PFBindingSource.DataMember = "tbl_Clientes_PF";
            this.tbl_Clientes_PFBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // grp_TipoCliente
            // 
            this.grp_TipoCliente.Controls.Add(this.rdo_Cli_PJ);
            this.grp_TipoCliente.Controls.Add(this.rdo_Cli_PF);
            this.grp_TipoCliente.Location = new System.Drawing.Point(14, 4);
            this.grp_TipoCliente.Name = "grp_TipoCliente";
            this.grp_TipoCliente.Size = new System.Drawing.Size(211, 44);
            this.grp_TipoCliente.TabIndex = 0;
            this.grp_TipoCliente.TabStop = false;
            this.grp_TipoCliente.Text = "Tipo de Cliente";
            // 
            // rdo_Cli_PJ
            // 
            this.rdo_Cli_PJ.AutoSize = true;
            this.rdo_Cli_PJ.Location = new System.Drawing.Point(108, 19);
            this.rdo_Cli_PJ.Name = "rdo_Cli_PJ";
            this.rdo_Cli_PJ.Size = new System.Drawing.Size(101, 17);
            this.rdo_Cli_PJ.TabIndex = 1;
            this.rdo_Cli_PJ.TabStop = true;
            this.rdo_Cli_PJ.Text = "Pessoa Jurídica";
            this.rdo_Cli_PJ.UseVisualStyleBackColor = true;
            this.rdo_Cli_PJ.CheckedChanged += new System.EventHandler(this.rdo_PessoaJuridica_CheckedChanged);
            // 
            // rdo_Cli_PF
            // 
            this.rdo_Cli_PF.AutoSize = true;
            this.rdo_Cli_PF.Location = new System.Drawing.Point(6, 19);
            this.rdo_Cli_PF.Name = "rdo_Cli_PF";
            this.rdo_Cli_PF.Size = new System.Drawing.Size(92, 17);
            this.rdo_Cli_PF.TabIndex = 0;
            this.rdo_Cli_PF.TabStop = true;
            this.rdo_Cli_PF.Text = "Pessoa Física";
            this.rdo_Cli_PF.UseVisualStyleBackColor = true;
            this.rdo_Cli_PF.CheckedChanged += new System.EventHandler(this.rdo_PessoaFisica_CheckedChanged);
            // 
            // grp_PessoaJuridica
            // 
            this.grp_PessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_PessoaJuridica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grp_PessoaJuridica.Location = new System.Drawing.Point(14, 54);
            this.grp_PessoaJuridica.Name = "grp_PessoaJuridica";
            this.grp_PessoaJuridica.Size = new System.Drawing.Size(1120, 549);
            this.grp_PessoaJuridica.TabIndex = 2;
            this.grp_PessoaJuridica.TabStop = false;
            this.grp_PessoaJuridica.Text = "Pessoa Jurídica";
            this.grp_PessoaJuridica.Visible = false;
            // 
            // tbl_EstadoTableAdapter
            // 
            this.tbl_EstadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            // tbl_Clientes_PFTableAdapter
            // 
            this.tbl_Clientes_PFTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Clientes_PJTableAdapter
            // 
            this.tbl_Clientes_PJTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Cad_Cliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1173, 635);
            this.Controls.Add(this.pnl_CadCliente);
            this.Name = "frm_Cad_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Cad_Cliente_Load);
            this.pnl_CadCliente.ResumeLayout(false);
            this.pnl_CadCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Clientes_PJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaOficinaDataSet)).EndInit();
            this.grp_PessoaFisica.ResumeLayout(false);
            this.grp_PessoaFisica.PerformLayout();
            this.grp_Cli_Veiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_CliPF_Veiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_OperadorasTelefoniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_EstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Clientes_PFBindingSource)).EndInit();
            this.grp_TipoCliente.ResumeLayout(false);
            this.grp_TipoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_CadCliente;
        private System.Windows.Forms.RadioButton rdo_Cli_PJ;
        private System.Windows.Forms.RadioButton rdo_Cli_PF;
        private System.Windows.Forms.GroupBox grp_TipoCliente;
        private System.Windows.Forms.GroupBox grp_PessoaJuridica;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_DataNasc;
        private System.Windows.Forms.DateTimePicker txt_CliPF_DataNasc;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.Label lbl_TelCelular;
        private System.Windows.Forms.Label lbl_TelComercial;
        private System.Windows.Forms.Label lbl_TelResidencial;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.TextBox txt_CliPF_RG;
        private System.Windows.Forms.MaskedTextBox txt_CliPF_TelRes;
        private System.Windows.Forms.MaskedTextBox txt_CliPF_Cpf;
        private System.Windows.Forms.MaskedTextBox txt_CliPF_TelCel;
        private System.Windows.Forms.MaskedTextBox txt_CliPF_TelCom;
        private System.Windows.Forms.TextBox txt_CliPF_Email;
        private System.Windows.Forms.MaskedTextBox txt_CliPF_Cep;
        private System.Windows.Forms.Label lbl_Cep;
        private System.Windows.Forms.Label lbl_Operadora;
        private System.Windows.Forms.TextBox txt_CliPF_End;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.TextBox txt_CliPF_Bairro;
        private System.Windows.Forms.Label lbl_Complemento;
        private System.Windows.Forms.TextBox txt_CliPF_EndComp;        
        private System.Windows.Forms.BindingSource tblEstadoBindingSource;
        private GerenciaOficinaDataSet gerenciaOficinaDataSet;
        private System.Windows.Forms.BindingSource tbl_EstadoBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_EstadoTableAdapter tbl_EstadoTableAdapter;
        private GerenciaOficinaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbo_CliPF_Estado;
        private System.Windows.Forms.BindingSource tbl_CidadeBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_CidadeTableAdapter tbl_CidadeTableAdapter;
        private System.Windows.Forms.ComboBox cbo_CliPF_Cidade;
        private System.Windows.Forms.DataGridView grd_CliPF_Veiculos;
        private System.Windows.Forms.Button btn_CliPF_delVeiculo;
        private System.Windows.Forms.Button btn_CliPF_addVeiculo;
        private System.Windows.Forms.BindingSource tbl_SexoBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_SexoTableAdapter tbl_SexoTableAdapter;
        private System.Windows.Forms.ComboBox cbo_CliPF_Sexo;
        private System.Windows.Forms.Button btn_CliPF_editVeiculo;
        private System.Windows.Forms.BindingSource tbl_OperadorasTelefoniaBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_OperadorasTelefoniaTableAdapter tbl_OperadorasTelefoniaTableAdapter;
        private System.Windows.Forms.ComboBox cbo_CliPF_Operadora;
        private System.Windows.Forms.Button btn_Cli_Salvar;
        private System.Windows.Forms.GroupBox grp_Cli_Veiculos;
        private System.Windows.Forms.BindingSource tbl_Clientes_PFBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_Clientes_PFTableAdapter tbl_Clientes_PFTableAdapter;
        private System.Windows.Forms.TextBox txt_CliPF_Cod;
        private System.Windows.Forms.BindingSource tbl_Clientes_PJBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_Clientes_PJTableAdapter tbl_Clientes_PJTableAdapter;
        private System.Windows.Forms.TextBox txt_CliPJ_Cod;
        public System.Windows.Forms.TextBox txt_CliPF_Nome;
        public System.Windows.Forms.GroupBox grp_PessoaFisica;
    }
}