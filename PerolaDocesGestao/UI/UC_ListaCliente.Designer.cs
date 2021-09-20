
namespace PerolaDocesGestao
{
    partial class UC_ClienteLista
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
            this.dataGridView_ListaCliente = new System.Windows.Forms.DataGridView();
            this.btn_CadastrarCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ListaCliente
            // 
            this.dataGridView_ListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListaCliente.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_ListaCliente.Name = "dataGridView_ListaCliente";
            this.dataGridView_ListaCliente.RowTemplate.Height = 25;
            this.dataGridView_ListaCliente.Size = new System.Drawing.Size(606, 436);
            this.dataGridView_ListaCliente.TabIndex = 0;
            // 
            // btn_CadastrarCliente
            // 
            this.btn_CadastrarCliente.BackColor = System.Drawing.Color.Gray;
            this.btn_CadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastrarCliente.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CadastrarCliente.Location = new System.Drawing.Point(4, 446);
            this.btn_CadastrarCliente.Name = "btn_CadastrarCliente";
            this.btn_CadastrarCliente.Size = new System.Drawing.Size(137, 28);
            this.btn_CadastrarCliente.TabIndex = 26;
            this.btn_CadastrarCliente.Text = "Cadastrar";
            this.btn_CadastrarCliente.UseVisualStyleBackColor = false;
            this.btn_CadastrarCliente.Click += new System.EventHandler(this.btn_CadastrarCliente_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(464, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // UC_ClienteLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_CadastrarCliente);
            this.Controls.Add(this.dataGridView_ListaCliente);
            this.Name = "UC_ClienteLista";
            this.Size = new System.Drawing.Size(613, 600);
            this.Load += new System.EventHandler(this.UC_ClienteLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ListaCliente;
        private System.Windows.Forms.Button btn_CadastrarCliente;
        private System.Windows.Forms.Button button2;
    }
}
