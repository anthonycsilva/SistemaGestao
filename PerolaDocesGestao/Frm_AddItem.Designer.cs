
namespace PerolaDocesGestao
{
    partial class Frm_AddItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Produtos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_InserirItemPedido = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_produtoNome = new System.Windows.Forms.Label();
            this.Lbl_codigoProduto = new System.Windows.Forms.Label();
            this.numeric_QtdProduto = new System.Windows.Forms.NumericUpDown();
            this.Lbl_precoUnitario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_QtdProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adicione um Item!";
            // 
            // dataGridView_Produtos
            // 
            this.dataGridView_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Produtos.Location = new System.Drawing.Point(12, 88);
            this.dataGridView_Produtos.Name = "dataGridView_Produtos";
            this.dataGridView_Produtos.RowTemplate.Height = 25;
            this.dataGridView_Produtos.Size = new System.Drawing.Size(571, 181);
            this.dataGridView_Produtos.TabIndex = 16;
            this.dataGridView_Produtos.SelectionChanged += new System.EventHandler(this.dataGridView_Produtos_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Produto:";
            // 
            // btn_InserirItemPedido
            // 
            this.btn_InserirItemPedido.BackColor = System.Drawing.Color.Gray;
            this.btn_InserirItemPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_InserirItemPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InserirItemPedido.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InserirItemPedido.Location = new System.Drawing.Point(186, 470);
            this.btn_InserirItemPedido.Name = "btn_InserirItemPedido";
            this.btn_InserirItemPedido.Size = new System.Drawing.Size(203, 33);
            this.btn_InserirItemPedido.TabIndex = 30;
            this.btn_InserirItemPedido.Text = "Inserir No Pedido";
            this.btn_InserirItemPedido.UseVisualStyleBackColor = false;
            this.btn_InserirItemPedido.Click += new System.EventHandler(this.btn_InserirItemPedido_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Quantidade Desejada:";
            // 
            // Lbl_produtoNome
            // 
            this.Lbl_produtoNome.AutoSize = true;
            this.Lbl_produtoNome.BackColor = System.Drawing.Color.White;
            this.Lbl_produtoNome.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_produtoNome.Location = new System.Drawing.Point(99, 307);
            this.Lbl_produtoNome.Name = "Lbl_produtoNome";
            this.Lbl_produtoNome.Size = new System.Drawing.Size(0, 23);
            this.Lbl_produtoNome.TabIndex = 33;
            // 
            // Lbl_codigoProduto
            // 
            this.Lbl_codigoProduto.AutoSize = true;
            this.Lbl_codigoProduto.BackColor = System.Drawing.Color.White;
            this.Lbl_codigoProduto.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_codigoProduto.Location = new System.Drawing.Point(89, 346);
            this.Lbl_codigoProduto.Name = "Lbl_codigoProduto";
            this.Lbl_codigoProduto.Size = new System.Drawing.Size(0, 23);
            this.Lbl_codigoProduto.TabIndex = 34;
            // 
            // numeric_QtdProduto
            // 
            this.numeric_QtdProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_QtdProduto.Location = new System.Drawing.Point(209, 385);
            this.numeric_QtdProduto.Name = "numeric_QtdProduto";
            this.numeric_QtdProduto.Size = new System.Drawing.Size(85, 23);
            this.numeric_QtdProduto.TabIndex = 36;
            this.numeric_QtdProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lbl_precoUnitario
            // 
            this.Lbl_precoUnitario.AutoSize = true;
            this.Lbl_precoUnitario.BackColor = System.Drawing.Color.White;
            this.Lbl_precoUnitario.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_precoUnitario.Location = new System.Drawing.Point(146, 425);
            this.Lbl_precoUnitario.Name = "Lbl_precoUnitario";
            this.Lbl_precoUnitario.Size = new System.Drawing.Size(0, 23);
            this.Lbl_precoUnitario.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Preço Unitario:";
            // 
            // Frm_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(595, 525);
            this.Controls.Add(this.Lbl_precoUnitario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeric_QtdProduto);
            this.Controls.Add(this.Lbl_codigoProduto);
            this.Controls.Add(this.Lbl_produtoNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_InserirItemPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_Produtos);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AddItem";
            this.Text = "Frm_AddItem";
            this.Load += new System.EventHandler(this.Frm_AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_QtdProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Produtos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_InserirItemPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_produtoNome;
        private System.Windows.Forms.Label Lbl_codigoProduto;
        private System.Windows.Forms.NumericUpDown numeric_QtdProduto;
        private System.Windows.Forms.Label Lbl_precoUnitario;
        private System.Windows.Forms.Label label6;
    }
}