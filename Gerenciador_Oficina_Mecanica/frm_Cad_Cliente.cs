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
    }
}
