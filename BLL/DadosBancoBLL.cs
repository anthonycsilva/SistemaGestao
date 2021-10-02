using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DadosBancoBLL
    {
        public string CONEXAO { get; set; } = @"Server=DESKTOP-5P62EHD\SQLEXPRESS;Database=PerolaDocesGestao;Trusted_Connection=True;";


        // ABA DE PROTUDOS
        public DataTable pesquisaBanco(string instrucao)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                SqlDataAdapter resultado = new SqlDataAdapter(instrucao, this.CONEXAO);
                DataTable dt = new DataTable();
                resultado.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
