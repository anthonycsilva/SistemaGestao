using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class PedidoItens
    {
        public int ID_PEDIDOITENS { get; set; }

        public int ID_PRODUTO { get; set; }
        public string NOME_PRODUTO { get; set; }
        public string PRECO_UNIDADE { get; set; }
        public int QUANTIDADE_PEDIDA { get; set; }


        public DataTable getItens(int id_pedidoItens)
        {
            try
            {
                Banco banco = new Banco();
                string comando = $"SELECT * FROM PedidoItens WHERE ID_PEDIDOITENS = {id_pedidoItens}";
                SqlDataAdapter resultado = new SqlDataAdapter(comando, banco.CONEXAO);
                DataTable dataTable = new DataTable();
                resultado.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
