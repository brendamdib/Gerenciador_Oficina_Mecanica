using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_Oficina_Mecanica
{
    public partial class frm_Cad_Fornecedor : Form
    {
        public frm_Cad_Fornecedor()
        {
            InitializeComponent();
        }

        private void frm_Cad_Fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gerenciaOficinaDataSet.tbl_Bancos' table. You can move, or remove it, as needed.
            this.tbl_BancosTableAdapter.Fill(this.gerenciaOficinaDataSet.tbl_Bancos);

        }

        private void txt_forn_obs_TextChanged(object sender, EventArgs e)
        {
            lbl_forn_quantcarac.Text = "Quantidade de caracteres: " + txt_forn_obs.TextLength + "/300";
        }

        private void rdo_forn_fisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_forn_fisica.Checked == true)
            {
                txt_forn_cpf.Visible = true;
                lbl_forn_cpf.Visible = true;
                txt_forn_inss.Visible = true;
                lbl_forn_inss.Visible = true;
                txt_forn_CNPJ.Visible = false;
                lbl_forn_cnpj.Visible = false;
                lbl_forn_inscestadual.Visible = false;
                txt_forn_inscestadual.Visible = false;
            }
        }

        private void rdo_forn_juridica_CheckedChanged(object sender, EventArgs e)
        {
            txt_forn_cpf.Visible = false;
            lbl_forn_cpf.Visible = false;
            txt_forn_inss.Visible = false;
            lbl_forn_inss.Visible = false;
            txt_forn_CNPJ.Visible = true;
            lbl_forn_cnpj.Visible = true;
            lbl_forn_inscestadual.Visible = true;
            txt_forn_inscestadual.Visible = true;
        }

        private void btn_forn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                int status, tipo, segmento;
                status = 0;
                tipo = 0;
                segmento = 0;
                
                //Verifica se o fornecedor está ativo ou não
                switch (rdo_forn_inativo.Checked)
                {
                    case true:
                        status = 1;
                        break;
                    case false:
                        status = 0;
                        break;
                }

                //Verifica se é prestador de serviço ou autopeças
                switch (rdo_forn_pecas.Checked)
                {
                    case true:
                        segmento = 1;
                        break;
                    case false:
                        segmento = 0;
                        break;
                }

                //Verifica se é pessoa física ou jurídica
                switch (rdo_forn_juridica.Checked)
                {
                    case true:
                        tipo = 1;
                        break;
                    case false:
                        tipo = 0;
                        break;
                }

                FuncoesSQL.CadastraFornecedor(txt_forn_nomefant.Text, txt_forn_razsoc.Text, txt_forn_CNPJ.Text, txt_forn_inscestadual.Text, txt_forn_Email.Text,
                    txt_forn_telGeral.Text, txt_forn_TelVendedor.Text, txt_forn_celVendedor.Text, Convert.ToInt32(cbo_forn_operadora.SelectedValue), 
                    txt_forn_nomevendedor.Text, txt_forn_cep.Text, txt_forn_end.Text, txt_forn_CompEnd.Text, txt_forn_bairro.Text, 
                    Convert.ToInt32(cbo_forn_estado.SelectedValue), Convert.ToInt32(cbo_forn_cidade.SelectedValue), status, txt_forn_obs.Text,
                    txt_forn_site.Text, txt_forn_skype.Text, Convert.ToInt32(cbo_forn_bancos.SelectedValue), Convert.ToInt32(txt_forn_agencia.Text),
                    txt_forn_conta.Text, txt_forn_cpf.Text, txt_forn_inss.Text, tipo, segmento);                
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                throw;
            }
        }
    }
}
