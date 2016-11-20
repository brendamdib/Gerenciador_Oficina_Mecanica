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
    public partial class frm_Index : Form
    {
        public frm_Index()
        {
            InitializeComponent();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cad_Cliente frmCadCliente = new frm_Cad_Cliente();
            frmCadCliente.MdiParent = this;            
            frmCadCliente.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
