using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;


namespace DAL
{
    public class BancoProdutoEstoque : Banco
    {
        public void insereProduto(string nome, string preco, int unidade, int id_distribuidora)
        {
            string instrucaoProduto = $"insert into Produto (NOME_PRODUTO, PRECO) values ('{nome}', {preco});";
            SqlConnection con = new SqlConnection(this.CONEXAO);
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(instrucaoProduto, con);
                comando.ExecuteScalar();

                int enderecoProduto = VerificaExistencia();
                DateTime dateTime = DateTime.Now;
                insereEstoque(enderecoProduto, dateTime.ToString(), unidade, id_distribuidora, con);

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


        public void insereEstoque(int id_produto, string data_entrada, int unidade, int id_distribuidora, SqlConnection con)
        {
            string instrucaoProduto = $"insert into Estoque (ID_PRODUTO, DATA_ENTRADA, UNIDADES, ID_DISTRIBUIDORA) values ({id_produto},'{data_entrada}', {unidade},{id_distribuidora});";
            try
            {
                SqlCommand comando = new SqlCommand(instrucaoProduto, con);
                comando.ExecuteScalar();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int VerificaExistencia()
        {
            Banco banco = new Banco();
            string pesquisaProduto = "SELECT TOP 1 * FROM [Produto] ORDER BY ID_PRODUTO DESC";
            SqlDataAdapter resultados = new SqlDataAdapter(pesquisaProduto, banco.CONEXAO);
            DataTable ultimoSelecioando = new DataTable();
            resultados.Fill(ultimoSelecioando);
            DataTableReader dt = new DataTableReader(ultimoSelecioando);
            int idInteiro = 0;
            while (dt.Read())
            {
                string idString = dt["ID_PRODUTO"].ToString();
                idInteiro = Int32.Parse(idString);
            }
            return idInteiro;


        }
    }
}
