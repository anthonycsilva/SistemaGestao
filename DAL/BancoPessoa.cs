using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BancoPessoa : Banco
    {
        public void inserePessoa(Pessoa pessoa)
        {
            string instrucaoPessoa = $"INSERT INTO Pessoa (NOME, IDADE, CPF, VENDEDOR) VALUES ('{pessoa.NOME}',{pessoa.IDADE},'{pessoa.CPF}', 0);";
            SqlConnection con = new SqlConnection(this.CONEXAO);

            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(instrucaoPessoa, con);
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
