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
    public partial class frm_Cad_Veiculo_Cliente : Form
    {
        public frm_Cad_Veiculo_Cliente()
        {
            InitializeComponent();
        }

        private void tbl_VeiculoClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_VeiculoClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gerenciaOficinaDataSet);
        }      

        private void frm_Cad_Veiculo_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gerenciaOficinaDataSet.tbl_Fabricantes' table. You can move, or remove it, as needed.
            this.tbl_FabricantesTableAdapter.Fill(this.gerenciaOficinaDataSet.tbl_Fabricantes);
            // TODO: This line of code loads data into the 'gerenciaOficinaDataSet.tbl_VeiculoCliente' table. You can move, or remove it, as needed.
            this.tbl_VeiculoClienteTableAdapter.Fill(this.gerenciaOficinaDataSet.tbl_VeiculoCliente);

            // TODO: This line of code loads data into the 'gerenciaOficinaDataSet.tbl_ModelosVeiculos' table. You can move, or remove it, as needed.            
            this.tbl_ModelosVeiculosTableAdapter.Fill(this.gerenciaOficinaDataSet.tbl_ModelosVeiculos, ((int)(System.Convert.ChangeType(cbo_Fabricante.SelectedValue, typeof(int)))));
        }

        private void cbo_Fabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Fabricante.SelectedValue != null)
                {
                    // TODO: This line of code loads data into the 'gerenciaOficinaDataSet.tbl_ModelosVeiculos' table. You can move, or remove it, as needed.            
                    this.tbl_ModelosVeiculosTableAdapter.Fill(this.gerenciaOficinaDataSet.tbl_ModelosVeiculos, ((int)(System.Convert.ChangeType(cbo_Fabricante.SelectedValue, typeof(int)))));
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                throw;
            }            
        }

        private void btn_SalvarVeiculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
