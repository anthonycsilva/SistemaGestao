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
    public partial class Frm_InserirProduto : Form
    {
        //instanciando objetos

        Distribuidora distribuidora = new Distribuidora();
        BancoProdutoEstoque banco = new BancoProdutoEstoque();
        public Frm_InserirProduto()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeProduto = textBox_NomeProduto.Text;
            string precoProduto = textBox_PrecoProduto.Text;
            var unidadesProdutoDecimal = numeric_QuantidadeProduto.Value.ToString();
            int unidadesProduto = Int32.Parse(unidadesProdutoDecimal);
            int distroID = distribuidora.getDistribuidorasID(comboBox_Distribuidoras.Text);
            if (unidadesProduto <= 0)
            {
                MessageBox.Show("Erro!, Não pode adicionar 0 produtos ou valores negativos!");
                return;
            }
            else
            {
                try
                {
                    banco.insereProduto(nomeProduto, precoProduto, unidadesProduto, distroID);
                    MessageBox.Show($"Sucesso!, o produto {nomeProduto} foi adicionado com sucesso!","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception k)
                {
                    MessageBox.Show($"Ocorreu um erro {k}, verifique o que foi digitado", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw k;
                }
                
            }
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Frm_InserirDistribuidor distro = new Frm_InserirDistribuidor();
            distro.Show();
        }

        private void comboBox_Distribuidoras_Click(object sender, EventArgs e)
        {
            var dados = distribuidora.getDistribuidoras();
            comboBox_Distribuidoras.DataSource = dados;
            comboBox_Distribuidoras.DisplayMember = "NOME_DISTRIBUIDORA";
            comboBox_Distribuidoras.ValueMember = "ID_DISTRIBUIDORA";
        }
    }
}
