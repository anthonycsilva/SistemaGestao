
namespace PerolaDocesGestao
{
    partial class Frm_FazerPedido
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
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Rua = new System.Windows.Forms.Label();
            this.dateTime_DataEscolhida = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Vendedores = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Clientes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_codigoPedido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_ListaItens = new System.Windows.Forms.DataGridView();
            this.btn_SalvarPedido = new System.Windows.Forms.Button();
            this.btn_AdicionarItem = new System.Windows.Forms.Button();
            this.btn_removerProdutoDaLista = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_totalGeral = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaItens)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cidade.Location = new System.Drawing.Point(123, 220);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(47, 23);
            this.lbl_Cidade.TabIndex = 27;
            this.lbl_Cidade.Text = "Rua:";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bairro.Location = new System.Drawing.Point(118, 186);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(47, 23);
            this.lbl_Bairro.TabIndex = 26;
            this.lbl_Bairro.Text = "Rua:";
            // 
            // lbl_Rua
            // 
            this.lbl_Rua.AutoSize = true;
            this.lbl_Rua.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Rua.Location = new System.Drawing.Point(99, 153);
            this.lbl_Rua.Name = "lbl_Rua";
            this.lbl_Rua.Size = new System.Drawing.Size(47, 23);
            this.lbl_Rua.TabIndex = 25;
            this.lbl_Rua.Text = "Rua:";
            // 
            // dateTime_DataEscolhida
            // 
            this.dateTime_DataEscolhida.Location = new System.Drawing.Point(364, 186);
            this.dateTime_DataEscolhida.Name = "dateTime_DataEscolhida";
            this.dateTime_DataEscolhida.Size = new System.Drawing.Size(200, 23);
            this.dateTime_DataEscolhida.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(363, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Data:";
            // 
            // comboBox_Vendedores
            // 
            this.comboBox_Vendedores.FormattingEnabled = true;
            this.comboBox_Vendedores.Location = new System.Drawing.Point(364, 118);
            this.comboBox_Vendedores.Name = "comboBox_Vendedores";
            this.comboBox_Vendedores.Size = new System.Drawing.Size(199, 23);
            this.comboBox_Vendedores.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(363, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Vendedor:";
            // 
            // comboBox_Clientes
            // 
            this.comboBox_Clientes.FormattingEnabled = true;
            this.comboBox_Clientes.Location = new System.Drawing.Point(46, 118);
            this.comboBox_Clientes.Name = "comboBox_Clientes";
            this.comboBox_Clientes.Size = new System.Drawing.Size(199, 23);
            this.comboBox_Clientes.TabIndex = 20;
            this.comboBox_Clientes.TextChanged += new System.EventHandler(this.comboBox_Clientes_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rua:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cliente:";
            // 
            // lbl_codigoPedido
            // 
            this.lbl_codigoPedido.AutoSize = true;
            this.lbl_codigoPedido.Font = new System.Drawing.Font("Bahnschrift Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_codigoPedido.Location = new System.Drawing.Point(278, 9);
            this.lbl_codigoPedido.Name = "lbl_codigoPedido";
            this.lbl_codigoPedido.Size = new System.Drawing.Size(143, 39);
            this.lbl_codigoPedido.TabIndex = 15;
            this.lbl_codigoPedido.Text = "codigoxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pedido:";
            // 
            // dataGridView_ListaItens
            // 
            this.dataGridView_ListaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListaItens.Location = new System.Drawing.Point(45, 261);
            this.dataGridView_ListaItens.Name = "dataGridView_ListaItens";
            this.dataGridView_ListaItens.RowTemplate.Height = 25;
            this.dataGridView_ListaItens.Size = new System.Drawing.Size(518, 418);
            this.dataGridView_ListaItens.TabIndex = 28;
            this.dataGridView_ListaItens.Click += new System.EventHandler(this.dataGridView_ListaItens_Click);
            // 
            // btn_SalvarPedido
            // 
            this.btn_SalvarPedido.BackColor = System.Drawing.Color.Gray;
            this.btn_SalvarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SalvarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalvarPedido.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SalvarPedido.Location = new System.Drawing.Point(46, 732);
            this.btn_SalvarPedido.Name = "btn_SalvarPedido";
            this.btn_SalvarPedido.Size = new System.Drawing.Size(139, 23);
            this.btn_SalvarPedido.TabIndex = 29;
            this.btn_SalvarPedido.Text = "Salvar";
            this.btn_SalvarPedido.UseVisualStyleBackColor = false;
            this.btn_SalvarPedido.Click += new System.EventHandler(this.btn_SalvarPedido_Click);
            // 
            // btn_AdicionarItem
            // 
            this.btn_AdicionarItem.BackColor = System.Drawing.Color.Gray;
            this.btn_AdicionarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdicionarItem.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AdicionarItem.Location = new System.Drawing.Point(424, 699);
            this.btn_AdicionarItem.Name = "btn_AdicionarItem";
            this.btn_AdicionarItem.Size = new System.Drawing.Size(139, 23);
            this.btn_AdicionarItem.TabIndex = 30;
            this.btn_AdicionarItem.Text = "Adicionar Item";
            this.btn_AdicionarItem.UseVisualStyleBackColor = false;
            this.btn_AdicionarItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_removerProdutoDaLista
            // 
            this.btn_removerProdutoDaLista.BackColor = System.Drawing.Color.Gray;
            this.btn_removerProdutoDaLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_removerProdutoDaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removerProdutoDaLista.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_removerProdutoDaLista.Location = new System.Drawing.Point(424, 738);
            this.btn_removerProdutoDaLista.Name = "btn_removerProdutoDaLista";
            this.btn_removerProdutoDaLista.Size = new System.Drawing.Size(139, 23);
            this.btn_removerProdutoDaLista.TabIndex = 31;
            this.btn_removerProdutoDaLista.Text = "Remover Item";
            this.btn_removerProdutoDaLista.UseVisualStyleBackColor = false;
            this.btn_removerProdutoDaLista.Click += new System.EventHandler(this.btn_removerProdutoDaLista_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(45, 682);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 23);
            this.label11.TabIndex = 32;
            this.label11.Text = "Total Geral:";
            // 
            // lbl_totalGeral
            // 
            this.lbl_totalGeral.AutoSize = true;
            this.lbl_totalGeral.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalGeral.Location = new System.Drawing.Point(156, 682);
            this.lbl_totalGeral.Name = "lbl_totalGeral";
            this.lbl_totalGeral.Size = new System.Drawing.Size(47, 23);
            this.lbl_totalGeral.TabIndex = 33;
            this.lbl_totalGeral.Text = "Rua:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(424, 773);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Alterar Item";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Frm_FazerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(622, 808);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_totalGeral);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_removerProdutoDaLista);
            this.Controls.Add(this.btn_AdicionarItem);
            this.Controls.Add(this.btn_SalvarPedido);
            this.Controls.Add(this.dataGridView_ListaItens);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.lbl_Bairro);
            this.Controls.Add(this.lbl_Rua);
            this.Controls.Add(this.dateTime_DataEscolhida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Vendedores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Clientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_codigoPedido);
            this.Controls.Add(this.label1);
            this.Name = "Frm_FazerPedido";
            this.Text = "Frm_FazerPedido";
            this.Load += new System.EventHandler(this.Frm_FazerPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Label lbl_Rua;
        private System.Windows.Forms.DateTimePicker dateTime_DataEscolhida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Vendedores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Clientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_codigoPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_ListaItens;
        private System.Windows.Forms.Button btn_SalvarPedido;
        private System.Windows.Forms.Button btn_AdicionarItem;
        private System.Windows.Forms.Button btn_removerProdutoDaLista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_totalGeral;
        private System.Windows.Forms.Button button3;
    }
}