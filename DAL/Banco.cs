using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace DAL
{
    public class Banco
    {
        public string CONEXAO { get; set; } = @"Server=DESKTOP-5P62EHD\SQLEXPRESS;Database=PerolaDocesGestao;Trusted_Connection=True;";


        // ABA DE PROTUDOS

        public void alteraProduto(Produto produto)
        {
            var i = produto.ID_PRODUTO; // FAZER AQUI AONDE SERÁ SELECIONADO O ID DO PRODUTO PARA SER ALTERADO
        }

    }
}

