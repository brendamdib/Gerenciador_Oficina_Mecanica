using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Windows;


namespace Gerenciador_Oficina_Mecanica
{
    public partial class frm_Cad_Cliente : Form
    {
        

        public frm_Cad_Cliente()
        {
            InitializeComponent();
        }

        private void rdo_PessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Cli_PF.Checked == true)
            {
                grp_PessoaFisica.Visible = true;
                grp_PessoaJuridica.Visible = false;
            }
            else
            {
                grp_PessoaFisica.Visible = false;
            }
        }

        private void rdo_PessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Cli_PJ.Checked == true)
            {
                grp_PessoaJuridica.Visible = true;
                grp_PessoaFisica.Visible = false;
            }
            else
            {
                grp_PessoaJuridica.Visible = false;
            }
        }

        private void tbl_EstadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_EstadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gerenciaOficinaDataSet);
        }

        private void frm_Cad_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gerenciaOficinaDataSet.tbl_Clientes_PJ' table. You can move, or remove it, as needed.
            this.tbl_Clientes_PJTableAdapter.Fill(this.gerenciaOficinaDataSet.tbl_Clientes_PJ);
            // TODO: This line of code loads data into the 'gerenciaOficinaDataSet.tbl_Clientes_PF' table. You can move, or remove it, as needed.
            this.tbl_Clientes_PFTableAdapter.Fill(this.gerenciaOficinaDataSet.tbl_Clientes_PF);
            // TODO: This line of code loads data into the 'gerenciaOficinaDataSet.tbl_OperadorasTelefonia' table. You can move, or remove it, as needed.
            this.tbl_OperadorasTelefoniaTableAdapter.Fill(this.gerenciaOficinaDataSet.tbl_OperadorasTelefonia);
            // TODO: This line of code loads data into the 'gerenciaOficinaDataSet.tbl_Sexo' table. You can move, or remove it, as needed.
            this.tbl_SexoTableAdapter.Fill(this.gerenciaOficinaDataSet.tbl_Sexo);
            // TODO: This line of code loads data into the 'gerenciaOficinaDataSet.tbl_Cidade' table. You can move, or remove it, as needed.
            //this.tbl_CidadeTableAdapter.Fill(this.gerenciaOficinaDataSet.tbl_Cidade);
            this.tbl_CidadeTableAdapter.FillBy(this.gerenciaOficinaDataSet.tbl_Cidade, ((int)(System.Convert.ChangeType(1, typeof(int)))));
            // TODO: This line of code loads data into the 'gerenciaOficinaDataSet.tbl_Estado' table. You can move, or remove it, as needed.
            this.tbl_EstadoTableAdapter.Fill(this.gerenciaOficinaDataSet.tbl_Estado);

           
        }

        private void cbo_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_CliPF_Estado.SelectedValue != null)
            {
                this.tbl_CidadeTableAdapter.FillBy(this.gerenciaOficinaDataSet.tbl_Cidade, ((int)(System.Convert.ChangeType(cbo_CliPF_Estado.SelectedValue, typeof(int)))));
            }
        }

        private void btn_Cli_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncoesSQL.CadastraCliente(txt_CliPF_Nome.Text, txt_CliPF_DataNasc.Text, Int32.Parse(cbo_CliPF_Sexo.SelectedValue.ToString()), txt_CliPF_RG.Text, txt_CliPF_Cpf.Text, txt_CliPF_Email.Text, txt_CliPF_TelRes.Text, txt_CliPF_TelCom.Text, txt_CliPF_TelCel.Text, Int32.Parse(cbo_CliPF_Operadora.SelectedValue.ToString()), txt_CliPF_Cep.Text, txt_CliPF_End.Text, txt_CliPF_EndComp.Text, txt_CliPF_Bairro.Text, Int32.Parse(cbo_CliPF_Estado.SelectedValue.ToString()), Int32.Parse(cbo_CliPF_Cidade.SelectedValue.ToString()));
                
                grp_Cli_Veiculos.Visible = true;
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                throw;
            }
        }

        private void btn_CliPF_addVeiculo_Click(object sender, EventArgs e)
        {
            frm_Cad_Veiculo_Cliente frmCadVeicCliente = new frm_Cad_Veiculo_Cliente();            
            frmCadVeicCliente.Show();
        }

        private void btn_CliPF_addVeiculo_Click(object sender, EventArgs e)
        {
            frm_Cad_Veiculo_Cliente_PF CadVeiculoPF = new frm_Cad_Veiculo_Cliente_PF();
            CadVeiculoPF.Show();
        }
    }
}