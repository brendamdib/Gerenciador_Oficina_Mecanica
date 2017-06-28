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

        private void rdo_forn_servicos_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
