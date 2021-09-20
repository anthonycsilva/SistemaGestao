﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BLL
{
    public class Estoque
    {
     public DataTable getDadosEstoque()
        {
            string instrucao = "SELECT Produto.ID_PRODUTO, Produto.NOME_PRODUTO,Estoque.DATA_ENTRADA,Estoque.UNIDADES,Produto.PRECO from Produto inner join Estoque on Produto.ID_PRODUTO = Estoque.ID_PRODUTO;";
            Banco banco = new Banco();

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(instrucao, banco.CONEXAO);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
     public DataTable getDadosPesquisa(string texto )
        {
            string instrucao = $@"SELECT Produto.ID_PRODUTO,
                                Produto.NOME_PRODUTO,
                                Estoque.DATA_ENTRADA,
                                Estoque.UNIDADES,
                                Produto.PRECO

                                FROM Produto INNER JOIN Estoque

                                ON Produto.ID_PRODUTO = Estoque.ID_PRODUTO

                                AND NOME_PRODUTO like '%{texto}%'; ";

            Banco banco = new Banco();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(instrucao, banco.CONEXAO);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    public DataTable getDadosPesquisaID (string numero)
        {
            Banco banco = new Banco();
            DataTable dataTable = new DataTable();

            string instrucao = $@"SELECT Produto.ID_PRODUTO,
                                Produto.NOME_PRODUTO,
                                Estoque.DATA_ENTRADA,
                                Estoque.UNIDADES,
                                Produto.PRECO 

                                FROM Produto INNER JOIN Estoque 

                                ON Produto.ID_PRODUTO = Estoque.ID_PRODUTO

                                AND Produto.ID_PRODUTO like '%{numero}%';";

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
