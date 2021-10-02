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
    public partial class Frm_alteraProduto : Form
    {
        public Frm_alteraProduto(string idProdutoString)
        {
            
            InitializeComponent();
            lbl_idProduto.Text = idProdutoString;
        }

        private void Frm_alteraProduto_Load(object sender, EventArgs e)
        {
            
            String instrucao = @$"SELECT PRODUTO.ID_PRODUTO, PRODUTO.NOME_PRODUTO, PRODUTO.PRECO, ESTOQUE.UNIDADES, DISTRIBUIDORA.NOME_DISTRIBUIDORA 
                                  FROM PRODUTO INNER JOIN ESTOQUE 
                                  ON PRODUTO.ID_PRODUTO = Estoque.ID_PRODUTO
                                  INNER JOIN DISTRIBUIDORA 
                                  ON ESTOQUE.ID_DISTRIBUIDORA = DISTRIBUIDORA.ID_DISTRIBUIDORA
                                  WHERE PRODUTO.ID_PRODUTO = {lbl_idProduto.Text};";




            DadosBancoBLL banco = new DadosBancoBLL();
            DataTable resultado = banco.pesquisaBanco(instrucao);
            MetodosGerais gerais = new MetodosGerais();
            DataTableReader dt = new DataTableReader(resultado);
            while (dt.Read())
            {
                textBox_NomeProduto.Text = dt["NOME_PRODUTO"].ToString();
                textBox_PrecoProduto.Text = dt["PRECO"].ToString();
                numeric_QuantidadeProduto.Value = gerais.converteStringInt(dt["UNIDADES"].ToString());
                Distribuidora distro = new Distribuidora();
                comboBox_Distribuidoras.DataSource = distro.getDistribuidoras();
                comboBox_Distribuidoras.DisplayMember = "NOME_DISTRIBUIDORA";
                comboBox_Distribuidoras.ValueMember = "ID_DISTRIBUIDORA";

            }

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
