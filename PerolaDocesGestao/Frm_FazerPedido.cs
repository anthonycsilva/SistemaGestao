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
    public partial class Frm_FazerPedido: Form
    {
        MetodosGerais gerais = new MetodosGerais();
        Temp temp = new Temp();
        bancoPedidoItens banco = new bancoPedidoItens();

        public static int numeroPedidoAtual;
        public Frm_FazerPedido(int numeroPedido)
        {
            InitializeComponent();
            lbl_codigoPedido.Text = numeroPedido.ToString();
            numeroPedidoAtual = numeroPedido;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
 
            Frm_AddItem addItem = new Frm_AddItem();
            MetodosGerais metodosEspeciais = new MetodosGerais();
            int numeroPedido = metodosEspeciais.converteStringInt(lbl_codigoPedido.Text);
            addItem.ShowDialog();
        }

        private void dataGridView_ListaItens_Click(object sender, EventArgs e)
        {
            DataTable dt_Pedidos = temp.getTemp2();
            dataGridView_ListaItens.DataSource = dt_Pedidos;

            //DataTable dt_CalculoTotal = temp.getTemp2();

            DataTableReader dtr = new DataTableReader(dt_Pedidos);
            double total;
            double totalFinal = 0;
            while (dtr.Read())
            {
                double preco = Double.Parse(dtr["PRECO"].ToString());
                int qtd = gerais.converteStringInt(dtr["QTD_ESCOLHIDA"].ToString());
                total = preco * qtd;
                totalFinal += total;
            }

            totalFinal = Math.Round(totalFinal, 2);
            lbl_totalGeral.Text = totalFinal.ToString("F2");


        }

        private void Frm_FazerPedido_Load(object sender, EventArgs e)
        {
            banco.limpaTemp();
            Temp temp = new Temp();
            DataTable dt = temp.getTemp2();
            dataGridView_ListaItens.DataSource = dt;

            Cliente clientes = new Cliente();
            var dadosClientes = clientes.getClientes();
            comboBox_Clientes.DataSource = dadosClientes;
            comboBox_Clientes.DisplayMember = "NOME";

            Vendedor vendedores = new Vendedor();
            var dadosVendedores = vendedores.getVendedores();
            comboBox_Vendedores.DataSource = dadosVendedores;
            comboBox_Vendedores.DisplayMember = "NOME";
        }

        private void btn_SalvarPedido_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Clientes_TextChanged(object sender, EventArgs e)
        {
            Cliente clientes = new Cliente();
            DataTable dt = clientes.getCliente(comboBox_Clientes.Text);

            DataTableReader dtr = new DataTableReader(dt);
            while (dtr.Read())
            {
                lbl_Rua.Text = dtr["RUA"].ToString();
                lbl_Cidade.Text = dtr["CIDADE"].ToString();
                lbl_Bairro.Text = dtr["BAIRRO"].ToString();
            }
        }

        private void btn_removerProdutoDaLista_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListaItens.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_ListaItens.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_ListaItens.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["ID_PRODUTO"].Value);
                int id_produtoSelecionado = gerais.converteStringInt(cellValue);
                try
                {
                    banco.deletaItemTemp(id_produtoSelecionado);
                    MessageBox.Show("O Produto selecionado foi deletado com sucesso!");
                    DataTable dt = temp.getTemp2();
                    dataGridView_ListaItens.DataSource = dt;
                }
                catch (Exception k)
                {
                    MessageBox.Show($"Erro!: {k}");
                    throw k;
                }

            }
            else
            {
                return;
            }

        }
    }
}
