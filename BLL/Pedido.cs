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

        public DataTable getTemp(int id_pedidoItens)
        {
            try
            {
                string comando = $@"SELECT ID_PRODUTO, NOME_PRODUTO, QTD_ESTOQUE AS QTD_ESCOLHIDA, PRECO_UNIDADE AS PRECO FROM PedidoItens WHERE ID_PEDIDOITENS={id_pedidoItens};";


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
