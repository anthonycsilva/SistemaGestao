using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Pedido
    {
        public int ID_PEDIDOITENS { get; set; }
        public int ID_PEDIDO { get; set; }
        public int ID_CLIENTE { get; set; }
        public string DATA_PEDIDO { get; set; }
        public int ID_VENDEDOR { get; set; }
        public string PRECO_TOTAL { get; set; }


        Banco banco = new Banco();

        public DataTable getTemp()
        {
            try
            {
                string comando = @"SELECT PedidoItens.ID_PRODUTO, PedidoItens.NOME_PRODUTO, PedidoItens.QTD_ESTOQUE as QTD_ESCOLHIDA, Produto.PRECO FROM PedidoItens
                                   INNER JOIN Temp on PedidoItens.ID_PEDIDOITENS = Temp.ID_PRODUTO
                                   INNER JOIN Produto on PedidoItens.ID_PRODUTO = Produto.ID_PRODUTO;";


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
