
namespace PerolaDocesGestao
{
    partial class Frm_InserirProduto
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
            this.textBox_NomeProduto = new System.Windows.Forms.TextBox();
            this.textBox_PrecoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Distribuidoras = new System.Windows.Forms.ComboBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numeric_QuantidadeProduto = new System.Windows.Forms.NumericUpDown();
            this.btn_AddDistribuidora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_QuantidadeProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Produto:";
            // 
            // textBox_NomeProduto
            // 
            this.textBox_NomeProduto.Location = new System.Drawing.Point(223, 48);
            this.textBox_NomeProduto.Name = "textBox_NomeProduto";
            this.textBox_NomeProduto.Size = new System.Drawing.Size(237, 23);
            this.textBox_NomeProduto.TabIndex = 1;
            // 
            // textBox_PrecoProduto
            // 
            this.textBox_PrecoProduto.Location = new System.Drawing.Point(223, 85);
            this.textBox_PrecoProduto.Name = "textBox_PrecoProduto";
            this.textBox_PrecoProduto.Size = new System.Drawing.Size(237, 23);
            this.textBox_PrecoProduto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço do Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(108, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distribuidora:";
            // 
            // comboBox_Distribuidoras
            // 
            this.comboBox_Distribuidoras.FormattingEnabled = true;
            this.comboBox_Distribuidoras.Location = new System.Drawing.Point(223, 180);
            this.comboBox_Distribuidoras.Name = "comboBox_Distribuidoras";
            this.comboBox_Distribuidoras.Size = new System.Drawing.Size(237, 23);
            this.comboBox_Distribuidoras.TabIndex = 5;
            this.comboBox_Distribuidoras.Click += new System.EventHandler(this.comboBox_Distribuidoras_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.Gray;
            this.btn_Cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrar.Location = new System.Drawing.Point(223, 249);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(139, 23);
            this.btn_Cadastrar.TabIndex = 19;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.Gray;
            this.Btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sair.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sair.Location = new System.Drawing.Point(450, 306);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(139, 23);
            this.Btn_Sair.TabIndex = 20;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(108, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantidade:";
            // 
            // numeric_QuantidadeProduto
            // 
            this.numeric_QuantidadeProduto.Location = new System.Drawing.Point(223, 127);
            this.numeric_QuantidadeProduto.Name = "numeric_QuantidadeProduto";
            this.numeric_QuantidadeProduto.Size = new System.Drawing.Size(104, 23);
            this.numeric_QuantidadeProduto.TabIndex = 22;
            // 
            // btn_AddDistribuidora
            // 
            this.btn_AddDistribuidora.BackColor = System.Drawing.Color.Gray;
            this.btn_AddDistribuidora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AddDistribuidora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDistribuidora.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddDistribuidora.Location = new System.Drawing.Point(481, 180);
            this.btn_AddDistribuidora.Name = "btn_AddDistribuidora";
            this.btn_AddDistribuidora.Size = new System.Drawing.Size(108, 23);
            this.btn_AddDistribuidora.TabIndex = 23;
            this.btn_AddDistribuidora.Text = "Adicionar Nova";
            this.btn_AddDistribuidora.UseVisualStyleBackColor = false;
            this.btn_AddDistribuidora.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_InserirProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(601, 341);
            this.Controls.Add(this.btn_AddDistribuidora);
            this.Controls.Add(this.numeric_QuantidadeProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.comboBox_Distribuidoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_PrecoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NomeProduto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_InserirProduto";
            this.Text = "Frm_InserirProduto";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_QuantidadeProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NomeProduto;
        private System.Windows.Forms.TextBox textBox_PrecoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Distribuidoras;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeric_QuantidadeProduto;
        private System.Windows.Forms.Button btn_AddDistribuidora;
    }
}