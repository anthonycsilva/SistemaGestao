
namespace PerolaDocesGestao
{
    partial class UC_ListaProduto
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AtualizarLista = new System.Windows.Forms.Button();
            this.btn_GerarRelatório = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PesquisaIDProduto = new System.Windows.Forms.TextBox();
            this.textBox_PesquisaNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Produto = new System.Windows.Forms.DataGridView();
            this.btn_InserirProduto = new System.Windows.Forms.Button();
            this.btn_AlterarProduto = new System.Windows.Forms.Button();
            this.btn_ExcluirProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AtualizarLista
            // 
            this.btn_AtualizarLista.BackColor = System.Drawing.Color.Gray;
            this.btn_AtualizarLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AtualizarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtualizarLista.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AtualizarLista.Location = new System.Drawing.Point(457, 211);
            this.btn_AtualizarLista.Name = "btn_AtualizarLista";
            this.btn_AtualizarLista.Size = new System.Drawing.Size(139, 23);
            this.btn_AtualizarLista.TabIndex = 19;
            this.btn_AtualizarLista.Text = "Atualizar Lista";
            this.btn_AtualizarLista.UseVisualStyleBackColor = false;
            // 
            // btn_GerarRelatório
            // 
            this.btn_GerarRelatório.BackColor = System.Drawing.Color.Gray;
            this.btn_GerarRelatório.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_GerarRelatório.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GerarRelatório.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GerarRelatório.Location = new System.Drawing.Point(31, 211);
            this.btn_GerarRelatório.Name = "btn_GerarRelatório";
            this.btn_GerarRelatório.Size = new System.Drawing.Size(139, 23);
            this.btn_GerarRelatório.TabIndex = 18;
            this.btn_GerarRelatório.Text = "Gerar Relatório";
            this.btn_GerarRelatório.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pesquisar ID :";
            // 
            // textBox_PesquisaIDProduto
            // 
            this.textBox_PesquisaIDProduto.Location = new System.Drawing.Point(145, 36);
            this.textBox_PesquisaIDProduto.Name = "textBox_PesquisaIDProduto";
            this.textBox_PesquisaIDProduto.Size = new System.Drawing.Size(234, 23);
            this.textBox_PesquisaIDProduto.TabIndex = 14;
            this.textBox_PesquisaIDProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PesquisaIDProduto_KeyPress);
            // 
            // textBox_PesquisaNomeProduto
            // 
            this.textBox_PesquisaNomeProduto.Location = new System.Drawing.Point(145, 7);
            this.textBox_PesquisaNomeProduto.Name = "textBox_PesquisaNomeProduto";
            this.textBox_PesquisaNomeProduto.Size = new System.Drawing.Size(234, 23);
            this.textBox_PesquisaNomeProduto.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pesquisar Nome :";
            // 
            // dataGridView_Produto
            // 
            this.dataGridView_Produto.AllowUserToAddRows = false;
            this.dataGridView_Produto.AllowUserToDeleteRows = false;
            this.dataGridView_Produto.AllowUserToOrderColumns = true;
            this.dataGridView_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Produto.Location = new System.Drawing.Point(3, 258);
            this.dataGridView_Produto.Name = "dataGridView_Produto";
            this.dataGridView_Produto.ReadOnly = true;
            this.dataGridView_Produto.RowTemplate.Height = 25;
            this.dataGridView_Produto.Size = new System.Drawing.Size(606, 336);
            this.dataGridView_Produto.TabIndex = 11;
            // 
            // btn_InserirProduto
            // 
            this.btn_InserirProduto.BackColor = System.Drawing.Color.Gray;
            this.btn_InserirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_InserirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InserirProduto.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InserirProduto.Location = new System.Drawing.Point(457, 7);
            this.btn_InserirProduto.Name = "btn_InserirProduto";
            this.btn_InserirProduto.Size = new System.Drawing.Size(139, 23);
            this.btn_InserirProduto.TabIndex = 20;
            this.btn_InserirProduto.Text = "Incluir Produto";
            this.btn_InserirProduto.UseVisualStyleBackColor = false;
            this.btn_InserirProduto.Click += new System.EventHandler(this.btn_InserirProduto_Click);
            // 
            // btn_AlterarProduto
            // 
            this.btn_AlterarProduto.BackColor = System.Drawing.Color.Gray;
            this.btn_AlterarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AlterarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlterarProduto.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AlterarProduto.Location = new System.Drawing.Point(457, 45);
            this.btn_AlterarProduto.Name = "btn_AlterarProduto";
            this.btn_AlterarProduto.Size = new System.Drawing.Size(139, 23);
            this.btn_AlterarProduto.TabIndex = 21;
            this.btn_AlterarProduto.Text = "Alterar Produto";
            this.btn_AlterarProduto.UseVisualStyleBackColor = false;
            // 
            // btn_ExcluirProduto
            // 
            this.btn_ExcluirProduto.BackColor = System.Drawing.Color.Gray;
            this.btn_ExcluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluirProduto.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ExcluirProduto.Location = new System.Drawing.Point(457, 86);
            this.btn_ExcluirProduto.Name = "btn_ExcluirProduto";
            this.btn_ExcluirProduto.Size = new System.Drawing.Size(139, 23);
            this.btn_ExcluirProduto.TabIndex = 22;
            this.btn_ExcluirProduto.Text = "Excluir Produto";
            this.btn_ExcluirProduto.UseVisualStyleBackColor = false;
            // 
            // UC_ListaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btn_ExcluirProduto);
            this.Controls.Add(this.btn_AlterarProduto);
            this.Controls.Add(this.btn_InserirProduto);
            this.Controls.Add(this.btn_AtualizarLista);
            this.Controls.Add(this.btn_GerarRelatório);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_PesquisaIDProduto);
            this.Controls.Add(this.textBox_PesquisaNomeProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Produto);
            this.Name = "UC_ListaProduto";
            this.Size = new System.Drawing.Size(613, 600);
            this.Load += new System.EventHandler(this.UC_ListaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AtualizarLista;
        private System.Windows.Forms.Button btn_GerarRelatório;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PesquisaIDProduto;
        private System.Windows.Forms.TextBox textBox_PesquisaNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Produto;
        private System.Windows.Forms.Button btn_InserirProduto;
        private System.Windows.Forms.Button btn_AlterarProduto;
        private System.Windows.Forms.Button btn_ExcluirProduto;
    }
}
