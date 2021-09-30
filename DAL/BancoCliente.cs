using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
namespace DAL
{
    public class BancoCliente : Banco
    {
        public void insereCliente(Cliente cliente)
        {
            string instrucaoCliente = $"insert into Cliente (ID_PESSOA, ESTADO, CIDADE, BAIRRO, RUA, NUMERO_RESIDENCIA, CEP) values ({cliente.ID_PESSOA}, '{cliente.ESTADO}', '{cliente.CIDADE}', '{cliente.BAIRRO}' ,'{cliente.RUA}', {cliente.NUMERO_RESIDENCIA}, '{cliente.CEP}');";
            SqlConnection con = new SqlConnection(this.CONEXAO);

            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(instrucaoCliente, con);
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
