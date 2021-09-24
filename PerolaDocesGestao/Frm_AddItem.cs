using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PerolaDocesGestao
{
    public partial class Frm_AddItem : Form
    {
        OperacoesBanco banco = new OperacoesBanco();
        MetodosGerais metodosAnthony = new MetodosGerais();
        public Frm_AddItem()
        {
            InitializeComponent();
        }

        private void Frm_AddItem_Load(object sender, EventArgs e)
        {
            Produto produtos = new Produto();
            DataTable produtosTabela = produtos.getProdutoQuantidade();
            dataGridView_Produtos.DataSource = produtosTabela;

        }

        private void btn_InserirItemPedido_Click(object sender, EventArgs e)
        {
            PedidoItens item = new PedidoItens();
            if (Lbl_produtoNome.Text != null)
            {
                int codigoProduto = metodosAnthony.converteStringInt(Lbl_codigoProduto.Text);
                item.ID_PRODUTO = codigoProduto;

                item.NOME_PRODUTO = Lbl_produtoNome.Text;
                item.PRECO_UNIDADE = Lbl_precoUnitario.Text;

                int quantidadePedida = Int32.Parse(numeric_QtdProduto.Value.ToString());
                item.QUANTIDADE_PEDIDA = quantidadePedida;
                int numeroPedido = Frm_FazerPedido.numeroPedidoAtual;
                try
                {
                    banco.inserePedidoItens(item, numeroPedido);
                    MessageBox.Show($"O Produto {item.NOME_PRODUTO}, com {quantidadePedida} unidades, foi adicionado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception k)
                {

                    MessageBox.Show($"Erro! {k}","Aconteceu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
               
              
            
        }

        private void dataGridView_Produtos_SelectionChanged(object sender, EventArgs e)
        {

            var indexGrid = dataGridView_Produtos.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView_Produtos.Rows[indexGrid];
            string nomeProdutoSelecionado = row.Cells[1].Value.ToString();

            string idProdutoSelecionadoString = row.Cells[0].Value.ToString();
            int idProdutoSelecionado = Int32.Parse(idProdutoSelecionadoString);

            string unidadesProdutoSelecionadoString = row.Cells[2].Value.ToString();
            int unidadesProdutoSelecionado = Int32.Parse(unidadesProdutoSelecionadoString);

            string PUnitProdutoSelecionadoString = row.Cells[3].Value.ToString();

            Lbl_produtoNome.Text = nomeProdutoSelecionado;
            Lbl_codigoProduto.Text = idProdutoSelecionadoString;
            Lbl_precoUnitario.Text = PUnitProdutoSelecionadoString;
        }
    }
}
