using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class BancoDistribuidora : Banco
    {
        public void insereDistribuidora(Distribuidora distro)
        {
            Banco banco = new Banco();
            string instrucao = $"insert into Distribuidora (NOME_DISTRIBUIDORA, CNPJ_DISTRIBUIDORA) values ('{distro.NOME_DISTRIBUIDORA}', '{distro.CNPJ}')";
            SqlConnection con = new SqlConnection(this.CONEXAO);
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(instrucao, con);
                comando.ExecuteScalar();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
