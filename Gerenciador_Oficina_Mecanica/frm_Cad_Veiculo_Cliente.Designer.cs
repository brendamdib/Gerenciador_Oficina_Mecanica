namespace Gerenciador_Oficina_Mecanica
{
    partial class frm_Cad_Veiculo_Cliente
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
            System.Windows.Forms.Label id_Proprietario_VeiculoCliLabel;
            System.Windows.Forms.Label lbl_PlacaVeiculo;
            System.Windows.Forms.Label lbl_Fabricante;
            System.Windows.Forms.Label nome_ModeloLabel;
            System.Windows.Forms.Label lbl_Chassis;
            this.gerenciaOficinaDataSet = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSet();
            this.tbl_VeiculoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_VeiculoClienteTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_VeiculoClienteTableAdapter();
            this.tableAdapterManager = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.TableAdapterManager();
            this.id_Proprietario_VeiculoCliTextBox = new System.Windows.Forms.TextBox();
            this.txt_PlacaVeiculo = new System.Windows.Forms.TextBox();
            this.cbo_Fabricante = new System.Windows.Forms.ComboBox();
            this.tblFabricantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nome_ModeloComboBox = new System.Windows.Forms.ComboBox();
            this.tblModelosVeiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_SalvarVeiculo = new System.Windows.Forms.Button();
            this.tbl_FabricantesTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_FabricantesTableAdapter();
            this.tbl_ModelosVeiculosTableAdapter = new Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.tbl_ModelosVeiculosTableAdapter();
            id_Proprietario_VeiculoCliLabel = new System.Windows.Forms.Label();
            lbl_PlacaVeiculo = new System.Windows.Forms.Label();
            lbl_Fabricante = new System.Windows.Forms.Label();
            nome_ModeloLabel = new System.Windows.Forms.Label();
            lbl_Chassis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaOficinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VeiculoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFabricantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblModelosVeiculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_Proprietario_VeiculoCliLabel
            // 
            id_Proprietario_VeiculoCliLabel.AutoSize = true;
            id_Proprietario_VeiculoCliLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_Proprietario_VeiculoCliLabel.Location = new System.Drawing.Point(12, 18);
            id_Proprietario_VeiculoCliLabel.Name = "id_Proprietario_VeiculoCliLabel";
            id_Proprietario_VeiculoCliLabel.Size = new System.Drawing.Size(67, 13);
            id_Proprietario_VeiculoCliLabel.TabIndex = 0;
            id_Proprietario_VeiculoCliLabel.Text = "Cod. Cliente:";
            // 
            // lbl_PlacaVeiculo
            // 
            lbl_PlacaVeiculo.AutoSize = true;
            lbl_PlacaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_PlacaVeiculo.Location = new System.Drawing.Point(12, 71);
            lbl_PlacaVeiculo.Name = "lbl_PlacaVeiculo";
            lbl_PlacaVeiculo.Size = new System.Drawing.Size(37, 13);
            lbl_PlacaVeiculo.TabIndex = 2;
            lbl_PlacaVeiculo.Text = "Placa:";
            // 
            // lbl_Fabricante
            // 
            lbl_Fabricante.AutoSize = true;
            lbl_Fabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Fabricante.Location = new System.Drawing.Point(12, 44);
            lbl_Fabricante.Name = "lbl_Fabricante";
            lbl_Fabricante.Size = new System.Drawing.Size(60, 13);
            lbl_Fabricante.TabIndex = 4;
            lbl_Fabricante.Text = "Fabricante:";
            // 
            // nome_ModeloLabel
            // 
            nome_ModeloLabel.AutoSize = true;
            nome_ModeloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_ModeloLabel.Location = new System.Drawing.Point(241, 44);
            nome_ModeloLabel.Name = "nome_ModeloLabel";
            nome_ModeloLabel.Size = new System.Drawing.Size(45, 13);
            nome_ModeloLabel.TabIndex = 6;
            nome_ModeloLabel.Text = "Modelo:";
            // 
            // lbl_Chassis
            // 
            lbl_Chassis.AutoSize = true;
            lbl_Chassis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Chassis.Location = new System.Drawing.Point(241, 71);
            lbl_Chassis.Name = "lbl_Chassis";
            lbl_Chassis.Size = new System.Drawing.Size(46, 13);
            lbl_Chassis.TabIndex = 8;
            lbl_Chassis.Text = "Chassis:";
            // 
            // gerenciaOficinaDataSet
            // 
            this.gerenciaOficinaDataSet.DataSetName = "GerenciaOficinaDataSet";
            this.gerenciaOficinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_VeiculoClienteBindingSource
            // 
            this.tbl_VeiculoClienteBindingSource.DataMember = "tbl_VeiculoCliente";
            this.tbl_VeiculoClienteBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // tbl_VeiculoClienteTableAdapter
            // 
            this.tbl_VeiculoClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_CidadeTableAdapter = null;
            this.tableAdapterManager.tbl_Clientes_PFTableAdapter = null;
            this.tableAdapterManager.tbl_Clientes_PJTableAdapter = null;
            this.tableAdapterManager.tbl_EstadoTableAdapter = null;
            this.tableAdapterManager.tbl_FabricantesTableAdapter = null;
            this.tableAdapterManager.tbl_FormaPgtoTableAdapter = null;
            this.tableAdapterManager.tbl_FornecedoresTableAdapter = null;
            this.tableAdapterManager.tbl_ModelosVeiculosTableAdapter = null;
            this.tableAdapterManager.tbl_OperadorasTelefoniaTableAdapter = null;
            this.tableAdapterManager.tbl_OrcamentosTableAdapter = null;
            this.tableAdapterManager.tbl_ServicosTableAdapter = null;
            this.tableAdapterManager.tbl_SexoTableAdapter = null;            
            this.tableAdapterManager.tbl_VeiculoClienteTableAdapter = this.tbl_VeiculoClienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gerenciador_Oficina_Mecanica.GerenciaOficinaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // id_Proprietario_VeiculoCliTextBox
            // 
            this.id_Proprietario_VeiculoCliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_VeiculoClienteBindingSource, "id_Proprietario_VeiculoCli", true));
            this.id_Proprietario_VeiculoCliTextBox.Enabled = false;
            this.id_Proprietario_VeiculoCliTextBox.Location = new System.Drawing.Point(85, 15);
            this.id_Proprietario_VeiculoCliTextBox.Name = "id_Proprietario_VeiculoCliTextBox";
            this.id_Proprietario_VeiculoCliTextBox.Size = new System.Drawing.Size(77, 20);
            this.id_Proprietario_VeiculoCliTextBox.TabIndex = 1;
            // 
            // txt_PlacaVeiculo
            // 
            this.txt_PlacaVeiculo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_VeiculoClienteBindingSource, "Placa_VeiculoCli", true));
            this.txt_PlacaVeiculo.Location = new System.Drawing.Point(85, 68);
            this.txt_PlacaVeiculo.Name = "txt_PlacaVeiculo";
            this.txt_PlacaVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txt_PlacaVeiculo.TabIndex = 4;
            // 
            // cbo_Fabricante
            // 
            this.cbo_Fabricante.DataSource = this.tblFabricantesBindingSource;
            this.cbo_Fabricante.DisplayMember = "Nome_Fabricante";
            this.cbo_Fabricante.FormattingEnabled = true;
            this.cbo_Fabricante.Location = new System.Drawing.Point(85, 41);
            this.cbo_Fabricante.Name = "cbo_Fabricante";
            this.cbo_Fabricante.Size = new System.Drawing.Size(137, 21);
            this.cbo_Fabricante.TabIndex = 2;
            this.cbo_Fabricante.ValueMember = "id";
            this.cbo_Fabricante.SelectedIndexChanged += new System.EventHandler(this.cbo_Fabricante_SelectedIndexChanged);
            // 
            // tblFabricantesBindingSource
            // 
            this.tblFabricantesBindingSource.DataMember = "tbl_Fabricantes";
            this.tblFabricantesBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // nome_ModeloComboBox
            // 
            this.nome_ModeloComboBox.DataSource = this.tblModelosVeiculosBindingSource;
            this.nome_ModeloComboBox.DisplayMember = "Nome_Modelo";
            this.nome_ModeloComboBox.FormattingEnabled = true;
            this.nome_ModeloComboBox.Location = new System.Drawing.Point(292, 41);
            this.nome_ModeloComboBox.Name = "nome_ModeloComboBox";
            this.nome_ModeloComboBox.Size = new System.Drawing.Size(143, 21);
            this.nome_ModeloComboBox.TabIndex = 3;
            this.nome_ModeloComboBox.ValueMember = "id";
            // 
            // tblModelosVeiculosBindingSource
            // 
            this.tblModelosVeiculosBindingSource.DataMember = "tbl_ModelosVeiculos";
            this.tblModelosVeiculosBindingSource.DataSource = this.gerenciaOficinaDataSet;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_VeiculoClienteBindingSource, "Placa_VeiculoCli", true));
            this.textBox1.Location = new System.Drawing.Point(292, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btn_SalvarVeiculo
            // 
            this.btn_SalvarVeiculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SalvarVeiculo.Image = global::Gerenciador_Oficina_Mecanica.Properties.Resources.save;
            this.btn_SalvarVeiculo.Location = new System.Drawing.Point(15, 106);
            this.btn_SalvarVeiculo.Name = "btn_SalvarVeiculo";
            this.btn_SalvarVeiculo.Size = new System.Drawing.Size(160, 35);
            this.btn_SalvarVeiculo.TabIndex = 6;
            this.btn_SalvarVeiculo.Text = "Salvar";
            this.btn_SalvarVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SalvarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalvarVeiculo.UseVisualStyleBackColor = true;
            this.btn_SalvarVeiculo.Click += new System.EventHandler(this.btn_SalvarVeiculo_Click);
            // 
            // tbl_FabricantesTableAdapter
            // 
            this.tbl_FabricantesTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ModelosVeiculosTableAdapter
            // 
            this.tbl_ModelosVeiculosTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Cad_Veiculo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 161);
            this.Controls.Add(this.btn_SalvarVeiculo);
            this.Controls.Add(lbl_Chassis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(nome_ModeloLabel);
            this.Controls.Add(this.nome_ModeloComboBox);
            this.Controls.Add(lbl_Fabricante);
            this.Controls.Add(this.cbo_Fabricante);
            this.Controls.Add(lbl_PlacaVeiculo);
            this.Controls.Add(this.txt_PlacaVeiculo);
            this.Controls.Add(id_Proprietario_VeiculoCliLabel);
            this.Controls.Add(this.id_Proprietario_VeiculoCliTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Cad_Veiculo_Cliente";
            this.Text = "Cadastro de Veículos de Clientes";
            this.Load += new System.EventHandler(this.frm_Cad_Veiculo_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaOficinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VeiculoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFabricantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblModelosVeiculosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GerenciaOficinaDataSet gerenciaOficinaDataSet;
        private System.Windows.Forms.BindingSource tbl_VeiculoClienteBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_VeiculoClienteTableAdapter tbl_VeiculoClienteTableAdapter;
        private GerenciaOficinaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_Proprietario_VeiculoCliTextBox;
        private System.Windows.Forms.TextBox txt_PlacaVeiculo;
        private System.Windows.Forms.ComboBox cbo_Fabricante;
        private System.Windows.Forms.ComboBox nome_ModeloComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_SalvarVeiculo;
        private System.Windows.Forms.BindingSource tblFabricantesBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_FabricantesTableAdapter tbl_FabricantesTableAdapter;
        private System.Windows.Forms.BindingSource tblModelosVeiculosBindingSource;
        private GerenciaOficinaDataSetTableAdapters.tbl_ModelosVeiculosTableAdapter tbl_ModelosVeiculosTableAdapter;
    }
}