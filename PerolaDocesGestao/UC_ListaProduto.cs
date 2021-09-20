using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace PerolaDocesGestao
{
    public partial class UC_ListaProduto : UserControl
    {
        public UC_ListaProduto()
        {
            InitializeComponent();
        }

        private void UC_ListaProduto_Load(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            dataGridView_Produto.DataSource = produto.getProduto();
        }

        private void textBox_PesquisaIDProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Produto produto = new Produto();
            dataGridView_Produto.DataSource = produto.getDadosPesquisaID(textBox_PesquisaIDProduto.Text);
        }

        private void btn_InserirProduto_Click(object sender, EventArgs e)
        {
            Frm_InserirProduto inserirProduto = new Frm_InserirProduto();
            inserirProduto.Show();
        }
    }
}
