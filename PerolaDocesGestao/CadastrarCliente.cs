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
    public partial class CadastrarCliente : Form
    {
        OperacoesBanco banco = new OperacoesBanco();
        Cliente cliente = new Cliente();
        Vendedor vendedor = new Vendedor();
        
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            MetodosGerais metodosGerais = new MetodosGerais();
            if (metodosGerais.verificaCPF(textBox_CPF.Text) == true)
            {
                string nomePessoa = textBox_Nome.Text;
                string idadePessoaString = textBox_Idade.Text;
                int idade = Int32.Parse(idadePessoaString);
                string cpf = textBox_CPF.Text;

                string estado = textBox_Estado.Text.ToUpper();
                string cidade = textBox_Cidade.Text.ToUpper();
                string residenciaString = textBox_NumeroResidencia.Text;
                int numero_residencia = Int32.Parse(residenciaString);
                string rua = textBox_Rua.Text.ToUpper();
                string cep = textBox_CEP.Text.ToUpper();

                Pessoa pessoa = vendedor.CadastraPessoa(nomePessoa,idade,cpf);
               
                try
                {
                    banco.inserePessoa(pessoa);
                    int x = banco.VerificaExistenciaPessoa();
                    pessoa.ID_PESSOA = x;
                    Cliente cliente = vendedor.cadastrarCliente(pessoa, estado, cidade, rua, numero_residencia, cep);
                    banco.insereCliente(cliente);
                    MessageBox.Show("Sucesso!", "Cliente cadastrado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception k)
                {
                    MessageBox.Show($"Erro Ao cadastrar o cliente: {k.Message}","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

            }
            else
            {
                MessageBox.Show("CPF Inválido, verifique o que foi digitado","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
