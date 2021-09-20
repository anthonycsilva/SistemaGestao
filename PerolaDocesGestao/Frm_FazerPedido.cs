﻿using System;
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
    public partial class Frm_FazerPedido : Form
    {
        public Frm_FazerPedido(int numeroPedido)
        {
            InitializeComponent();
            lbl_codigoPedido.Text = numeroPedido.ToString();


        }

        Pedido pedido = new Pedido();
        OperacoesBanco banco = new OperacoesBanco();
        
        private void button1_Click(object sender, EventArgs e)
        {
 
            Frm_AddItem addItem = new Frm_AddItem();
            MetodosGerais metodosEspeciais = new MetodosGerais();
            int numeroPedido = metodosEspeciais.converteStringInt(lbl_codigoPedido.Text);
            addItem.ShowDialog();
        }

        private void dataGridView_ListaItens_Click(object sender, EventArgs e)
        {
            DataTable dt = pedido.getTemp();
            dataGridView_ListaItens.DataSource = dt;
        }

        private void Frm_FazerPedido_Load(object sender, EventArgs e)
        {
            banco.limpaTemp();
            DataTable dt = pedido.getTemp();
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
    }
}
