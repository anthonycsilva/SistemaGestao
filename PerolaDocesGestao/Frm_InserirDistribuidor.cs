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
            try
            {
                OperacoesBanco banco = new OperacoesBanco();
                banco.insereDistribuidora(nomeDistro, cnpjDistro);
            }
            catch (Exception k)
            {
                MessageBox.Show($"Erro! {k}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw k;
            }
            
        }
    }
}
