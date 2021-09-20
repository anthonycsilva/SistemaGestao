
namespace PerolaDocesGestao
{
    partial class UC_ListaEstoque
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
            this.dataGridView_Estoque = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PesquisaNomeEstoque = new System.Windows.Forms.TextBox();
            this.textBox_PesquisaIDEstoque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_SomaTotalEstoque = new System.Windows.Forms.Label();
            this.btn_GerarRelatório = new System.Windows.Forms.Button();
            this.btn_AtualizarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Estoque
            // 
            this.dataGridView_Estoque.AllowUserToAddRows = false;
            this.dataGridView_Estoque.AllowUserToDeleteRows = false;
            this.dataGridView_Estoque.AllowUserToOrderColumns = true;
            this.dataGridView_Estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Estoque.Location = new System.Drawing.Point(3, 261);
            this.dataGridView_Estoque.Name = "dataGridView_Estoque";
            this.dataGridView_Estoque.ReadOnly = true;
            this.dataGridView_Estoque.RowTemplate.Height = 25;
            this.dataGridView_Estoque.Size = new System.Drawing.Size(606, 336);
            this.dataGridView_Estoque.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar Nome :";
            // 
            // textBox_PesquisaNomeEstoque
            // 
            this.textBox_PesquisaNomeEstoque.Location = new System.Drawing.Point(145, 10);
            this.textBox_PesquisaNomeEstoque.Name = "textBox_PesquisaNomeEstoque";
            this.textBox_PesquisaNomeEstoque.Size = new System.Drawing.Size(234, 23);
            this.textBox_PesquisaNomeEstoque.TabIndex = 2;
            this.textBox_PesquisaNomeEstoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PesquisaNomeEstoque_KeyDown);
            // 
            // textBox_PesquisaIDEstoque
            // 
            this.textBox_PesquisaIDEstoque.Location = new System.Drawing.Point(145, 39);
            this.textBox_PesquisaIDEstoque.Name = "textBox_PesquisaIDEstoque";
            this.textBox_PesquisaIDEstoque.Size = new System.Drawing.Size(234, 23);
            this.textBox_PesquisaIDEstoque.TabIndex = 3;
            this.textBox_PesquisaIDEstoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PesquisaIDEstoque_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesquisar ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo em R$: ";
            // 
            // lbl_SomaTotalEstoque
            // 
            this.lbl_SomaTotalEstoque.AutoSize = true;
            this.lbl_SomaTotalEstoque.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_SomaTotalEstoque.Location = new System.Drawing.Point(145, 124);
            this.lbl_SomaTotalEstoque.Name = "lbl_SomaTotalEstoque";
            this.lbl_SomaTotalEstoque.Size = new System.Drawing.Size(108, 19);
            this.lbl_SomaTotalEstoque.TabIndex = 7;
            this.lbl_SomaTotalEstoque.Text = "Pesquisar ID :";
            // 
            // btn_GerarRelatório
            // 
            this.btn_GerarRelatório.BackColor = System.Drawing.Color.Gray;
            this.btn_GerarRelatório.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_GerarRelatório.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GerarRelatório.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GerarRelatório.Location = new System.Drawing.Point(31, 214);
            this.btn_GerarRelatório.Name = "btn_GerarRelatório";
            this.btn_GerarRelatório.Size = new System.Drawing.Size(139, 23);
            this.btn_GerarRelatório.TabIndex = 9;
            this.btn_GerarRelatório.Text = "Gerar Relatório";
            this.btn_GerarRelatório.UseVisualStyleBackColor = false;
            // 
            // btn_AtualizarLista
            // 
            this.btn_AtualizarLista.BackColor = System.Drawing.Color.Gray;
            this.btn_AtualizarLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AtualizarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtualizarLista.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AtualizarLista.Location = new System.Drawing.Point(457, 214);
            this.btn_AtualizarLista.Name = "btn_AtualizarLista";
            this.btn_AtualizarLista.Size = new System.Drawing.Size(139, 23);
            this.btn_AtualizarLista.TabIndex = 10;
            this.btn_AtualizarLista.Text = "Atualizar Lista";
            this.btn_AtualizarLista.UseVisualStyleBackColor = false;
            this.btn_AtualizarLista.Click += new System.EventHandler(this.btn_AtualizarLista_Click);
            // 
            // UC_ListaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btn_AtualizarLista);
            this.Controls.Add(this.btn_GerarRelatório);
            this.Controls.Add(this.lbl_SomaTotalEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_PesquisaIDEstoque);
            this.Controls.Add(this.textBox_PesquisaNomeEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Estoque);
            this.Name = "UC_ListaEstoque";
            this.Size = new System.Drawing.Size(613, 600);
            this.Load += new System.EventHandler(this.UC_ListaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Estoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PesquisaNomeEstoque;
        private System.Windows.Forms.TextBox textBox_PesquisaIDEstoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_SomaTotalEstoque;
        private System.Windows.Forms.Button btn_GerarRelatório;
        private System.Windows.Forms.Button btn_AtualizarLista;
    }
}
