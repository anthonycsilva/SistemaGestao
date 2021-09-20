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
    public partial class UC_ClienteLista : UserControl
    {
        public UC_ClienteLista()
        {
            InitializeComponent();
        }

        private void Btn_Sair_ListaCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UC_ClienteLista_Load(object sender, EventArgs e)
        {
            try
            {
                Cliente c1 = new Cliente();
                dataGridView_ListaCliente.DataSource = c1.getClientes();
            }
            catch (Exception k)
            {
                MessageBox.Show($"Erro {k.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;

            }
    
        }

        private void btn_CadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.ShowDialog();
        }
    }
}
