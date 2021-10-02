using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Distribuidora : DadosBancoBLL
    {
        public int ID_DISTRIBUIDORA { get; set; }
        public string NOME_DISTRIBUIDORA { get; set; }
        public string CNPJ { get; set; }

        public DataTable getDistribuidoras()
        {
            string instrucao = "SELECT * FROM Distribuidora;";
            
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(instrucao, CONEXAO);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public int getDistribuidorasID(string nome)
        {
            string instrucao =$"SELECT ID_DISTRIBUIDORA FROM Distribuidora WHERE NOME_DISTRIBUIDORA = '{nome}';";
            
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(instrucao, CONEXAO);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                DataTableReader dtReader = new DataTableReader(dataTable);
                while (dtReader.Read())
                {
                    return Int32.Parse(dtReader["ID_DISTRIBUIDORA"].ToString());
                }
                return Int32.Parse(dtReader["ID_DISTRIBUIDORA"].ToString());
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
