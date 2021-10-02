
namespace PerolaDocesGestao
{
    partial class Frm_alteraProduto
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
            this.btn_AddDistribuidora = new System.Windows.Forms.Button();
            this.numeric_QuantidadeProduto = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.comboBox_Distribuidoras = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PrecoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_idProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_QuantidadeProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddDistribuidora
            // 
            this.btn_AddDistribuidora.BackColor = System.Drawing.Color.Gray;
            this.btn_AddDistribuidora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AddDistribuidora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDistribuidora.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddDistribuidora.Location = new System.Drawing.Point(482, 228);
            this.btn_AddDistribuidora.Name = "btn_AddDistribuidora";
            this.btn_AddDistribuidora.Size = new System.Drawing.Size(108, 23);
            this.btn_AddDistribuidora.TabIndex = 34;
            this.btn_AddDistribuidora.Text = "Adicionar Nova";
            this.btn_AddDistribuidora.UseVisualStyleBackColor = false;
            // 
            // numeric_QuantidadeProduto
            // 
            this.numeric_QuantidadeProduto.Location = new System.Drawing.Point(224, 175);
            this.numeric_QuantidadeProduto.Name = "numeric_QuantidadeProduto";
            this.numeric_QuantidadeProduto.Size = new System.Drawing.Size(104, 23);
            this.numeric_QuantidadeProduto.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(109, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Quantidade:";
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.Gray;
            this.Btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sair.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sair.Location = new System.Drawing.Point(451, 354);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(139, 23);
            this.Btn_Sair.TabIndex = 31;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.Gray;
            this.btn_Alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Alterar.Location = new System.Drawing.Point(224, 297);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(139, 23);
            this.btn_Alterar.TabIndex = 30;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            // 
            // comboBox_Distribuidoras
            // 
            this.comboBox_Distribuidoras.FormattingEnabled = true;
            this.comboBox_Distribuidoras.Location = new System.Drawing.Point(224, 228);
            this.comboBox_Distribuidoras.Name = "comboBox_Distribuidoras";
            this.comboBox_Distribuidoras.Size = new System.Drawing.Size(237, 23);
            this.comboBox_Distribuidoras.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(109, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Distribuidora:";
            // 
            // textBox_PrecoProduto
            // 
            this.textBox_PrecoProduto.Location = new System.Drawing.Point(224, 133);
            this.textBox_PrecoProduto.Name = "textBox_PrecoProduto";
            this.textBox_PrecoProduto.Size = new System.Drawing.Size(237, 23);
            this.textBox_PrecoProduto.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(77, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Preço do Produto:";
            // 
            // textBox_NomeProduto
            // 
            this.textBox_NomeProduto.Location = new System.Drawing.Point(224, 96);
            this.textBox_NomeProduto.Name = "textBox_NomeProduto";
            this.textBox_NomeProduto.Size = new System.Drawing.Size(237, 23);
            this.textBox_NomeProduto.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome do Produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(200, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "ID do Produto:";
            // 
            // lbl_idProduto
            // 
            this.lbl_idProduto.AutoSize = true;
            this.lbl_idProduto.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_idProduto.Location = new System.Drawing.Point(318, 33);
            this.lbl_idProduto.Name = "lbl_idProduto";
            this.lbl_idProduto.Size = new System.Drawing.Size(82, 19);
            this.lbl_idProduto.TabIndex = 36;
            this.lbl_idProduto.Text = "iDProduto";
            // 
            // Frm_alteraProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(661, 396);
            this.Controls.Add(this.lbl_idProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_AddDistribuidora);
            this.Controls.Add(this.numeric_QuantidadeProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.comboBox_Distribuidoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_PrecoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NomeProduto);
            this.Controls.Add(this.label1);
            this.Name = "Frm_alteraProduto";
            this.Text = "alteraProduto";
            this.Load += new System.EventHandler(this.Frm_alteraProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_QuantidadeProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddDistribuidora;
        private System.Windows.Forms.NumericUpDown numeric_QuantidadeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.ComboBox comboBox_Distribuidoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PrecoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_idProduto;
    }
}