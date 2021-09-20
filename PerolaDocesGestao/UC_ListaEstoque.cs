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
    public partial class UC_ListaEstoque : UserControl
    {
        public UC_ListaEstoque()
        {
            InitializeComponent();
        }

        private void textBox_PesquisaNomeEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            Estoque estoque = new Estoque();
            dataGridView_Estoque.DataSource = estoque.getDadosPesquisa(textBox_PesquisaNomeEstoque.Text);
        }

        private void textBox_PesquisaIDEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            //int numeroPesqusa = Int32.Parse(textBox_PesquisaIDEstoque.Text);
            Estoque estoque = new Estoque();
            dataGridView_Estoque.DataSource = estoque.getDadosPesquisaID(textBox_PesquisaIDEstoque.Text);
        }

        private void UC_ListaEstoque_Load(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            dataGridView_Estoque.DataSource = estoque.getDadosEstoque();
        }

        private void btn_AtualizarLista_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            dataGridView_Estoque.DataSource = estoque.getDadosEstoque();
        }
    }
}
