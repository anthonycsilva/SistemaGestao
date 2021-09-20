
namespace PerolaDocesGestao
{
    partial class UC_ListaPedidos
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
            this.dataGridView_ListaPedidos = new System.Windows.Forms.DataGridView();
            this.btn_AdicionarPedido = new System.Windows.Forms.Button();
            this.btn_GerarRelatório = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ListaPedidos
            // 
            this.dataGridView_ListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListaPedidos.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_ListaPedidos.Name = "dataGridView_ListaPedidos";
            this.dataGridView_ListaPedidos.RowTemplate.Height = 25;
            this.dataGridView_ListaPedidos.Size = new System.Drawing.Size(606, 411);
            this.dataGridView_ListaPedidos.TabIndex = 0;
            // 
            // btn_AdicionarPedido
            // 
            this.btn_AdicionarPedido.BackColor = System.Drawing.Color.Gray;
            this.btn_AdicionarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AdicionarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdicionarPedido.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AdicionarPedido.Location = new System.Drawing.Point(471, 471);
            this.btn_AdicionarPedido.Name = "btn_AdicionarPedido";
            this.btn_AdicionarPedido.Size = new System.Drawing.Size(139, 23);
            this.btn_AdicionarPedido.TabIndex = 10;
            this.btn_AdicionarPedido.Text = "Gerar Pedido";
            this.btn_AdicionarPedido.UseVisualStyleBackColor = false;
            this.btn_AdicionarPedido.Click += new System.EventHandler(this.btn_AdicionarPedido_Click);
            // 
            // btn_GerarRelatório
            // 
            this.btn_GerarRelatório.BackColor = System.Drawing.Color.Gray;
            this.btn_GerarRelatório.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_GerarRelatório.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GerarRelatório.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GerarRelatório.Location = new System.Drawing.Point(471, 500);
            this.btn_GerarRelatório.Name = "btn_GerarRelatório";
            this.btn_GerarRelatório.Size = new System.Drawing.Size(139, 23);
            this.btn_GerarRelatório.TabIndex = 11;
            this.btn_GerarRelatório.Text = "Gerar Relatório";
            this.btn_GerarRelatório.UseVisualStyleBackColor = false;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.Gray;
            this.btn_Atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Atualizar.Location = new System.Drawing.Point(4, 421);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(139, 23);
            this.btn_Atualizar.TabIndex = 12;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            // 
            // UC_ListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_GerarRelatório);
            this.Controls.Add(this.btn_AdicionarPedido);
            this.Controls.Add(this.dataGridView_ListaPedidos);
            this.Name = "UC_ListaPedidos";
            this.Size = new System.Drawing.Size(613, 600);
            this.Load += new System.EventHandler(this.UC_ListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ListaPedidos;
        private System.Windows.Forms.Button btn_AdicionarPedido;
        private System.Windows.Forms.Button btn_GerarRelatório;
        private System.Windows.Forms.Button btn_Atualizar;
    }
}
