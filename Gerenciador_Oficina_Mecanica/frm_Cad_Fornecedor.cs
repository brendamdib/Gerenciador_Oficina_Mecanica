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
        }
    }
}
