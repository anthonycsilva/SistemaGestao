using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerolaDocesGestao
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_Pedidos_Principal_Click(object sender, EventArgs e)
        {
           
            Btn_Pedidos_Principal.BackColor = Color.Silver;
            Btn_Clientes_Principal.BackColor = Color.Gray;
            Btn_Estoque_Principal.BackColor = Color.Gray;
            Btn_Produtos_Principal.BackColor = Color.Gray;

            UC_TiposPedidos tiposPedidos = new UC_TiposPedidos();

            Panel_Principal.Controls.Clear();
            Panel_Principal.Controls.Add(tiposPedidos); 
        }

        private void Btn_Clientes_Principal_Click(object sender, EventArgs e)
        {
            Btn_Pedidos_Principal.BackColor = Color.Gray;
            Btn_Clientes_Principal.BackColor = Color.Silver;
            Btn_Estoque_Principal.BackColor = Color.Gray;
            Btn_Produtos_Principal.BackColor = Color.Gray;

            UC_ClienteLista clienteLista = new UC_ClienteLista();
            Panel_Principal.Controls.Clear();
            Panel_Principal.Controls.Add(clienteLista);

        }

        private void Btn_Estoque_Principal_Click(object sender, EventArgs e)
        {
            Btn_Pedidos_Principal.BackColor = Color.Gray;
            Btn_Clientes_Principal.BackColor = Color.Gray;
            Btn_Estoque_Principal.BackColor = Color.Silver;
            Btn_Produtos_Principal.BackColor = Color.Gray;

            UC_ListaEstoque listaEstoque = new UC_ListaEstoque();
            Panel_Principal.Controls.Clear();
            Panel_Principal.Controls.Add(listaEstoque);
        }

        private void Btn_Produtos_Principal_Click(object sender, EventArgs e)
        {
            
            Btn_Pedidos_Principal.BackColor = Color.Gray;
            Btn_Clientes_Principal.BackColor = Color.Gray;
            Btn_Estoque_Principal.BackColor = Color.Gray;
            Btn_Produtos_Principal.BackColor = Color.Silver;

            UC_ListaProduto listaProduto = new UC_ListaProduto();
            Panel_Principal.Controls.Clear();
            Panel_Principal.Controls.Add(listaProduto);
        }

        private void Btn_Sair_Principal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
