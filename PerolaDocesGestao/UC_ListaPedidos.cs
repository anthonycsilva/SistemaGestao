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
    public partial class UC_ListaPedidos : UserControl
    {
        public UC_ListaPedidos()
        {
            InitializeComponent();
        }

        private void UC_ListaPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btn_AdicionarPedido_Click(object sender, EventArgs e)
        {
            MetodosGerais gerais = new MetodosGerais();
            int codigoPedido = gerais.gerarCodigoPedido();
            Frm_FazerPedido fazerPedido = new Frm_FazerPedido(codigoPedido);
            fazerPedido.ShowDialog();

        }
    }
}
