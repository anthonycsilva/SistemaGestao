using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Temp : DadosBancoBLL
    {
      public DataTable getTemp2()
        {
            try
            {
                
                string comando = "SELECT Produto.ID_PRODUTO, Produto.NOME_PRODUTO, Produto.PRECO, Temp.QTD_ESCOLHIDA FROM Produto INNER JOIN Temp on Produto.ID_PRODUTO = Temp.ID_PRODUTO;";
                SqlDataAdapter resultado = new SqlDataAdapter(comando, CONEXAO);
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
