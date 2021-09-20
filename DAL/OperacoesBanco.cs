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
    public class OperacoesBanco
    {
        public string CONEXAO { get; set; } = @"Server=DESKTOP-5P62EHD\SQLEXPRESS;Database=PerolaDocesGestao;Trusted_Connection=True;";

        public void inserePessoa(Pessoa pessoa)
        {
            string instrucaoPessoa = $"INSERT INTO Pessoa (NOME, IDADE, CPF, VENDEDOR) VALUES ('{pessoa.NOME}',{pessoa.IDADE},'{pessoa.CPF}', 0);";
            SqlConnection con = new SqlConnection(this.CONEXAO);

            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(instrucaoPessoa,con);
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

        public void insereCliente(Cliente cliente)
        {
            string instrucaoCliente = $"insert into Cliente (ID_PESSOA, ESTADO, CIDADE, RUA, NUMERO_RESIDENCIA, CEP) values ({cliente.ID_PESSOA}, '{cliente.ESTADO}', '{cliente.CIDADE}', '{cliente.RUA}', {cliente.NUMERO_RESIDENCIA}, '{cliente.CEP}');";
            SqlConnection con = new SqlConnection(this.CONEXAO);

            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(instrucaoCliente, con);
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

        public void insereProduto(string nome, string preco, int unidade, int id_distribuidora)
        {
            string instrucaoProduto = $"insert into Produto (NOME_PRODUTO, PRECO) values ('{nome}', {preco});";
            SqlConnection con = new SqlConnection(this.CONEXAO);
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(instrucaoProduto, con);
                comando.ExecuteScalar();

                int enderecoProduto = VerificaExistencia();
                DateTime dateTime = DateTime.Now;
                insereEstoque(enderecoProduto, dateTime.ToString(),unidade, id_distribuidora, con);

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

        public void insereEstoque(int id_produto, string data_entrada, int unidade, int id_distribuidora, SqlConnection con)
        {
            string instrucaoProduto = $"insert into Estoque (ID_PRODUTO, DATA_ENTRADA, UNIDADES, ID_DISTRIBUIDORA) values ({id_produto},'{data_entrada}', {unidade},{id_distribuidora});";
            try
            {
                SqlCommand comando = new SqlCommand(instrucaoProduto, con);
                comando.ExecuteScalar();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void deletaEstoque(int id_produto, int quantidade)
        {
           
        }

        public void insereDistribuidora(string nome, string cnpj)
        {
            OperacoesBanco banco = new OperacoesBanco();
            string instrucao = $"insert into Distribuidora (NOME_DISTRIBUIDORA, CNPJ_DISTRIBUIDORA) values ('{nome}', '{cnpj}')";
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

        public int VerificaExistencia()
        {
            OperacoesBanco banco = new OperacoesBanco();
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

        public int VerificaExistenciaPessoa()
        {
            OperacoesBanco banco = new OperacoesBanco();
            string pesquisaProduto = "SELECT TOP 1 * FROM [Pessoa] ORDER BY ID_PESSOA DESC";
            SqlDataAdapter resultados = new SqlDataAdapter(pesquisaProduto, banco.CONEXAO);
            DataTable ultimoSelecioando = new DataTable();
            resultados.Fill(ultimoSelecioando);
            DataTableReader dt = new DataTableReader(ultimoSelecioando);
            int idInteiro = 0;
            while (dt.Read())
            {
                string idString = dt["ID_PESSOA"].ToString();
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
            OperacoesBanco banco = new OperacoesBanco();
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

