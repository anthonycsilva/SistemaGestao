using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PerolaDocesGestao
{
    public partial class Frm_InserirDistribuidor : Form
    {
        public Frm_InserirDistribuidor()
        {
            InitializeComponent();
        }

        private void Frm_InserirDistribuidor_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string cnpjDistro = textBox_CNPJDistribuidora.Text;
            string nomeDistro = textBox_NomeDistribuidora.Text.ToUpper();
            if (string.IsNullOrEmpty(nomeDistro) || string.IsNullOrEmpty(cnpjDistro))
            {
                MessageBox.Show("Erro!, Nome e o CNPJ não podem ser nulos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Banco banco = new Banco();
                    banco.insereDistribuidora(nomeDistro, cnpjDistro);
                    MessageBox.Show($"Distribuidora, {nomeDistro}, cadastrada com sucesso!");
                }
                catch (Exception k)
                {
                    MessageBox.Show($"Erro! {k}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw k;
                }
            }
            
            
        }
    }
}
