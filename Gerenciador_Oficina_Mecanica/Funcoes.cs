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
        public string Nome_Cliente;
        public string DataNasc_Cliente { get; set; }
        public string Sexo_Cliente { get; set; }
        public string CPF_Cliente { get; set; }
        public string RG_Cliente { get; set; }
        public string Email_Cliente { get; set; }
        public string TelRes_Cliente { get; set; }
        public string TelCom_Cliente { get; set; }
        public string TelCel_Cliente { get; set; }
        public string OperadoraCel_Cliente { get; set; }
        public string CEP_Cliente { get; set; }
        public string Endereco_Cliente { get; set; }
        public string CompEndereco_Cliente { get; set; }
        public string Bairro_Cliente { get; set; }
        public string Estado_Cliente { get; set; }
        public string Cidade_Cliente { get; set; }

        

        public static SqlConnection GetConnection()
        {
            string str = "Data Source=localhost;Initial Catalog = GerenciaOficina;uid =sa;pwd = f1d500";

            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();                
                return con;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }            
            
        }

        //public static string PesquisaCEP(string CEP)
        //{
        //    try
        //    {
        //        string endereco, bairro, cidade, estado;
        //        endereco = "Teste";
        //        bairro = "Buritis";
        //        cidade = "Belo Horizonte";
        //        estado = "MG";

        //        return (endereco, bairro; cidade, estado);
        //    }
        //    catch (Exception e)
        //    {
        //        System.Windows.Forms.MessageBox.Show(e.Message);                
        //        throw;
        //    }
        //}


          public static string CadastraCliente(string Nome, string DataNasc, int Sexo, string RG, string CPF, string Email, string TelRes, string TelCom, string TelCel, int Operadora, string CEP, string Endereco, string CompEndereco, string Bairro, int UF, int Cidade)
            {            
                try
                {
                    FuncoesSQL.GetConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd = FuncoesSQL.GetConnection().CreateCommand();
                    cmd.CommandText = "stp_Insere_CliPF";
                    cmd.CommandType = CommandType.StoredProcedure;
                
                    cmd.Parameters.AddWithValue("@Nome_Cliente", Nome);
                    cmd.Parameters.AddWithValue("@DataNasc_Cliente", DataNasc);
                    cmd.Parameters.AddWithValue("@Sexo_Cliente", Sexo);
                    cmd.Parameters.AddWithValue("@RG_Cliente", RG);
                    cmd.Parameters.AddWithValue("@CPF_Cliente", CPF);
                    cmd.Parameters.AddWithValue("@Email_Cliente", Email);
                    cmd.Parameters.AddWithValue("@TelRes_Cliente", TelRes);
                    cmd.Parameters.AddWithValue("@TelCom_Cliente", TelCom);
                    cmd.Parameters.AddWithValue("@TelCel_Cliente", TelCel);
                    cmd.Parameters.AddWithValue("@OperadoraCel_Cliente", Operadora);
                    cmd.Parameters.AddWithValue("@CEP_Cliente", CEP);
                    cmd.Parameters.AddWithValue("@Endereco_Cliente", Endereco);
                    cmd.Parameters.AddWithValue("@CompEnd_Cliente", CompEndereco);
                    cmd.Parameters.AddWithValue("@Bairro_Cliente", Bairro);
                    cmd.Parameters.AddWithValue("@Estado_Cliente", UF);
                    cmd.Parameters.AddWithValue("@Cidade_Cliente", Cidade);                    

                    cmd.ExecuteNonQuery();

                    cmd.Connection.Close();

                frm_Cad_Cliente frmCadCli = new frm_Cad_Cliente();
                frmCadCli.grp_PessoaFisica.Enabled = true;



                return "OK";
                }
                catch (Exception e)
                {                    
                    System.Windows.Forms.MessageBox.Show(e.Message);                
                    return "erro";
                    throw;
                }

            }
    }  
}
