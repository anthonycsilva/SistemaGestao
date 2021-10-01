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
           var i =  produto.ID_PRODUTO; // FAZER AQUI AONDE SERÁ SELECIONADO O ID DO PRODUTO PARA SER ALTERADO
        }

        public int VerificaExistencia()
        {
            Banco banco = new Banco();
            string pesquisaProduto = "SELECT TOP 1 * FROM [Produto] ORDER BY ID_PRODUTO DESC";
            SqlDataAdapter resultados = new SqlDataAdapter(pesquisaProduto, banco.CONEXAO);
            DataTable ultimoSelecioando = new DataTable();
            resultados.Fill(ultimoSelecioando);
            DataTableReader dt = new DataTableReader(ultimoSelecioando);
            int idInteiro = 0;
            while (dt.Read())
            {
                string idString = dt["ID_PRODUTO"].ToString();
                idInteiro = Int32.Parse(idString);
            }
            return idInteiro;


        }


        public void inserePedidoItens(PedidoItens item, int id_pedidoItens)
        {
            string instrucao = $"insert into PedidoItens (ID_PEDIDOITENS, ID_PRODUTO, NOME_PRODUTO,PRECO_UNIDADE, QTD_ESTOQUE) VALUES ({id_pedidoItens}, {item.ID_PRODUTO},'{item.NOME_PRODUTO}','{item.PRECO_UNIDADE}',{item.QUANTIDADE_PEDIDA})";
            SqlConnection con = new SqlConnection(this.CONEXAO);
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(instrucao, con);
                comando.ExecuteScalar();
                InsereTemp(item, id_pedidoItens);
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();
            }
        }

        public void limpaTemp()
        {
            string instrucao = $"delete from Temp";
            SqlConnection con = new SqlConnection(this.CONEXAO);
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(instrucao, con);
                comando.ExecuteScalar();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();
            }
        }

        public void InsereTemp(PedidoItens itens, int pedidoitem_ID)
        {
            string instrucao = $"insert into Temp (ID_PRODUTO, QTD_ESCOLHIDA) values ({pedidoitem_ID}, {itens.QUANTIDADE_PEDIDA})";
            SqlConnection con = new SqlConnection(this.CONEXAO);
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(instrucao, con);
                comando.ExecuteScalar();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();
            }
        }

        public void cadastraPedido(Pedido pedido)
        {
            string instrucao = $"insert into Pedido (ID_PEDIDOITENS, ID_CLIENTE,DATA_PEDIDO,ID_VENDEDOR, PRECO_TOTAL) values ({pedido.ID_PEDIDOITENS}, {pedido.ID_CLIENTE},'{pedido.DATA_PEDIDO}',{pedido.ID_VENDEDOR},'{pedido.PRECO_TOTAL}');";
            SqlConnection con = new SqlConnection(this.CONEXAO);
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(instrucao, con);
                comando.ExecuteScalar();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();
            }
        }




        public int recuperaID_PedidoItens()
        {
            Banco banco = new Banco();
            string pesquisaProduto = "SELECT TOP 1 * FROM [PedidoItens] ORDER BY ID_PEDIDOITENS DESC";
            SqlDataAdapter resultados = new SqlDataAdapter(pesquisaProduto, banco.CONEXAO);
            DataTable ultimoSelecioando = new DataTable();
            resultados.Fill(ultimoSelecioando);
            DataTableReader dt = new DataTableReader(ultimoSelecioando);
            int idInteiro = 0;
            while (dt.Read())
            {
                string idString = dt["ID_PEDIDOITENS"].ToString();
                idInteiro = Int32.Parse(idString);
            }
            return idInteiro + 1;


        }

    }

}

