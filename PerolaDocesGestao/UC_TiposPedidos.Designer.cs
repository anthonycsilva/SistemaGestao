
namespace PerolaDocesGestao
{
    partial class UC_TiposPedidos
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
            this.btn_PedidosFinalizados = new System.Windows.Forms.Button();
            this.btn_PedidosAbertos = new System.Windows.Forms.Button();
            this.btn_gerarPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_PedidosFinalizados
            // 
            this.btn_PedidosFinalizados.BackColor = System.Drawing.Color.Gray;
            this.btn_PedidosFinalizados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_PedidosFinalizados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PedidosFinalizados.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_PedidosFinalizados.Location = new System.Drawing.Point(204, 251);
            this.btn_PedidosFinalizados.Name = "btn_PedidosFinalizados";
            this.btn_PedidosFinalizados.Size = new System.Drawing.Size(193, 57);
            this.btn_PedidosFinalizados.TabIndex = 23;
            this.btn_PedidosFinalizados.Text = "PEDIDOS FINALIZADOS";
            this.btn_PedidosFinalizados.UseVisualStyleBackColor = false;
            // 
            // btn_PedidosAbertos
            // 
            this.btn_PedidosAbertos.BackColor = System.Drawing.Color.Gray;
            this.btn_PedidosAbertos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_PedidosAbertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PedidosAbertos.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_PedidosAbertos.Location = new System.Drawing.Point(204, 122);
            this.btn_PedidosAbertos.Name = "btn_PedidosAbertos";
            this.btn_PedidosAbertos.Size = new System.Drawing.Size(193, 57);
            this.btn_PedidosAbertos.TabIndex = 22;
            this.btn_PedidosAbertos.Text = "PEDIDOS EM ABERTO";
            this.btn_PedidosAbertos.UseVisualStyleBackColor = false;
            // 
            // btn_gerarPedido
            // 
            this.btn_gerarPedido.BackColor = System.Drawing.Color.Gray;
            this.btn_gerarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_gerarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerarPedido.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_gerarPedido.Location = new System.Drawing.Point(204, 384);
            this.btn_gerarPedido.Name = "btn_gerarPedido";
            this.btn_gerarPedido.Size = new System.Drawing.Size(193, 57);
            this.btn_gerarPedido.TabIndex = 24;
            this.btn_gerarPedido.Text = "GERAR PEDIDO";
            this.btn_gerarPedido.UseVisualStyleBackColor = false;
            this.btn_gerarPedido.Click += new System.EventHandler(this.btn_gerarPedido_Click);
            // 
            // UC_TiposPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btn_gerarPedido);
            this.Controls.Add(this.btn_PedidosFinalizados);
            this.Controls.Add(this.btn_PedidosAbertos);
            this.Name = "UC_TiposPedidos";
            this.Size = new System.Drawing.Size(613, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PedidosFinalizados;
        private System.Windows.Forms.Button btn_PedidosAbertos;
        private System.Windows.Forms.Button btn_gerarPedido;
    }
}
