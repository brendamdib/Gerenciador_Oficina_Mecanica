using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gerenciador_Oficina_Mecanica
{
    class Funcoes
    {
    }

    public class FuncoesSQL {
        public string   Nome_Cliente        {get; set;}        
        public string   DataNasc_Cliente    { get; set; }
        public int      Sexo_Cliente        { get; set; }
        public string   CPF_Cliente         { get; set; }
        public string   RG_Cliente          { get; set; }
        public string   Email_Cliente       { get; set; }
        public string   TelRes_Cliente      { get; set; }
        public string   TelCom_Cliente      { get; set; }
        public string   TelCel_Cliente      { get; set; }
        public int      OperadoraCel_Cliente{ get; set; }
        public string   CEP_Cliente         { get; set; }
        public string   Endereco_Cliente    { get; set; }
        public string   CompEndereco_Cliente{ get; set; }
        public string   Bairro_Cliente      { get; set; }
        public int      Estado_Cliente      { get; set; }
        public int      Cidade_Cliente      { get; set; }
        public int      Status_Cliente      { get; set; }
        
        public static SqlConnection GetConnection()
        {
            string str = "Data Source=localhost;Initial Catalog = GerenciaOficina;uid =sa;pwd = f1d500";

            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                System.Windows.Forms.MessageBox.Show("Banco de Dados Conectado");
                return con;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }            
            
        }

        public static SqlCommand CadastraCliente()
        {
            try
            {
                FuncoesSQL.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Nome_Cliente", Nome_Cliente);


                
                @DataNasc_Cliente,
                @Sexo_Cliente,
                @CPF_Cliente,
                @RG_Cliente,
                @Email_Cliente,
                @TelRes_Cliente,
                @TelCom_Cliente,
                @TelCel_Cliente,
                @OperadoraCel_Cliente,
				@CEP_Cliente,
                @Endereco_Cliente,
                @CompEnd_Cliente,
                @Bairro_Cliente,
                @Estado_Cliente,
                @Cidade_Cliente


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);

                lblmsg.Text = "Contatos com idade superior a " + Convert.ToInt32(txtIdade.Text);

                GridView1.DataSource = ds;

                GridView1.DataBind();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }
            
        } 
    }  
}
