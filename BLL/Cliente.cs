using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Cliente : Pessoa
    {
        public int ID_CLIENTE { get; set; }
        public int ID_PESSOA { get; set; }
        public string ESTADO { get; set; }
        public string CIDADE { get; set; }
        public string RUA { get; set; }
        public int NUMERO_RESIDENCIA { get; set; }
        public string CEP { get; set; }


        public DataTable getClientes()
        {
            try
            {
                Banco banco = new Banco();
                string comando = "SELECT Pessoa.ID_PESSOA, Pessoa.NOME,Pessoa.CPF, Cliente.CIDADE,Cliente.ESTADO FROM Pessoa INNER JOIN Cliente ON Pessoa.ID_PESSOA = Cliente.ID_PESSOA;";
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
