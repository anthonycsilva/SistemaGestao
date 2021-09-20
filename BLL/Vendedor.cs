using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class Vendedor
    {
        protected int ID_VENDEDOR { get; set; }



        private Pedido gerarPedido(Cliente cliente, string data_pedido, int id_vendedor,int id_pedidoItens, int id_produto, int qtd_produto, string preco_total)
        {
            Pedido pedido = new Pedido();
            pedido.ID_CLIENTE = cliente.ID_CLIENTE;
            pedido.DATA_PEDIDO = data_pedido;
            pedido.ID_VENDEDOR = id_vendedor;
            pedido.ID_PEDIDOITENS = id_pedidoItens;
            pedido.PRECO_TOTAL = preco_total;

            return pedido;
        }

        public Pessoa CadastraPessoa (string nome, int idade, string cpf)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.NOME = nome;
            pessoa.IDADE = idade;
            pessoa.CPF = cpf;

            return pessoa;
        }

        public Cliente cadastrarCliente(Pessoa pessoa, string estado, string cidade, string rua, int numero_residencia, string cep)
        {
            Cliente cliente = new Cliente();
            cliente.ID_PESSOA = pessoa.ID_PESSOA;
            cliente.ESTADO = estado;
            cliente.CIDADE = cidade;
            cliente.RUA = rua;
            cliente.NUMERO_RESIDENCIA = numero_residencia;
            cliente.CEP = cep;

            return cliente;
        }

        public DataTable getVendedores()
        {
            try
            {
                Banco banco = new Banco();
                string instrucao = @"select Vendedor.ID_VENDEDOR, Pessoa.NOME, Pessoa.CPF, Pessoa.IDADE FROM Vendedor
                                 INNER JOIN Pessoa on Vendedor.ID_PESSOA = Pessoa.ID_PESSOA
                                 where Pessoa.VENDEDOR = 1;";
                SqlDataAdapter resultado = new SqlDataAdapter(instrucao, banco.CONEXAO);
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
