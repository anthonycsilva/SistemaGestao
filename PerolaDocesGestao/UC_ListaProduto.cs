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
    public partial class UC_ListaProduto : UserControl
    {
        Produto produto = new Produto();
        MetodosGerais gerais = new MetodosGerais();
        BancoProdutoEstoque banco = new BancoProdutoEstoque();
        public UC_ListaProduto()
        {
            InitializeComponent();
        }

        private void textBox_PesquisaIDProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView_Produto.DataSource = produto.getDadosPesquisaID(textBox_PesquisaIDProduto.Text);
        }

        private void textBox_PesquisaNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView_Produto.DataSource = produto.getDadosPesquisaNome(textBox_PesquisaNomeProduto.Text);
        }

        private void btn_InserirProduto_Click(object sender, EventArgs e)
        {
            Frm_InserirProduto inserirProduto = new Frm_InserirProduto();
            inserirProduto.Show();
        }

        private void btn_AtualizarLista_Click(object sender, EventArgs e)
        {
            dataGridView_Produto.DataSource = produto.getProduto();
        }


        private void btn_AlterarProduto_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_Produto.SelectedRows)
            {
                string id_produtoString = row.Cells[0].Value.ToString();
                Frm_alteraProduto alteraProduto = new Frm_alteraProduto(id_produtoString);
                alteraProduto.ShowDialog();
                
               
            }
        }
    }
}
