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
            if (rdo_PessoaFisica.Checked == true)
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
            if (rdo_PessoaJuridica.Checked == true)
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
            if (cbo_Estado.SelectedValue != null )
            {
                this.tbl_CidadeTableAdapter.FillBy(this.gerenciaOficinaDataSet.tbl_Cidade, ((int)(System.Convert.ChangeType(cbo_Estado.SelectedValue, typeof(int)))));
            }
        }
       
    }
}
