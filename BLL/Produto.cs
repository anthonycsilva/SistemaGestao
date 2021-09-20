using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Produto
    {
        public int ID_PRODUTO { get; set; }
        public string NOME_PRODUTO { get; set; }
        public string PRECO { get; set; }


        public DataTable getProdutoQuantidade()
        {
            string instrucao = "SELECT Produto.ID_PRODUTO, Produto.NOME_PRODUTO,Estoque.UNIDADES,Produto.PRECO from Produto inner join Estoque on Produto.ID_PRODUTO = Estoque.ID_PRODUTO;";
            Banco banco = new Banco();
            DataTable dataTable = new DataTable();

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(instrucao, banco.CONEXAO);
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public DataTable getProduto()
        {
            string instrucao = "SELECT * FROM Produto";
            Banco banco = new Banco();
            DataTable dataTable = new DataTable();

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(instrucao, banco.CONEXAO);
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {

                throw e;
            }
            
            
        }
        public DataTable getDadosPesquisaID(string numero)
        {
            Banco banco = new Banco();
            DataTable dataTable = new DataTable();

            string instrucao = $@"SELECT * FROM PRODUTO WHERE NOME_PRODUTO LIKE '%{numero}%'";

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(instrucao, banco.CONEXAO);
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

    }
}
