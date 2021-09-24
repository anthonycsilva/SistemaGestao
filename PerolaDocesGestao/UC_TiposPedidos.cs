using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using BLL;
using System.Windows.Forms;

namespace PerolaDocesGestao
{
    public partial class UC_TiposPedidos : UserControl
    {
        public UC_TiposPedidos()
        {
            InitializeComponent();
        }

        private void btn_gerarPedido_Click(object sender, EventArgs e)
        {
            MetodosGerais gerais = new MetodosGerais();
            int codigoPedido = gerais.gerarCodigoPedido();
            Frm_FazerPedido fazerPedido = new Frm_FazerPedido(codigoPedido);
            fazerPedido.ShowDialog();
        }
    }
}
