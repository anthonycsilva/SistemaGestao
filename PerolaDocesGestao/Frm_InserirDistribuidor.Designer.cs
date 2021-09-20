
namespace PerolaDocesGestao
{
    partial class Frm_InserirDistribuidor
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
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.textBox_CNPJDistribuidora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NomeDistribuidora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.Gray;
            this.Btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sair.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sair.Location = new System.Drawing.Point(418, 232);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(139, 23);
            this.Btn_Sair.TabIndex = 31;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.Gray;
            this.btn_Cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrar.Location = new System.Drawing.Point(229, 171);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(139, 23);
            this.btn_Cadastrar.TabIndex = 30;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // textBox_CNPJDistribuidora
            // 
            this.textBox_CNPJDistribuidora.Location = new System.Drawing.Point(191, 95);
            this.textBox_CNPJDistribuidora.Name = "textBox_CNPJDistribuidora";
            this.textBox_CNPJDistribuidora.Size = new System.Drawing.Size(237, 23);
            this.textBox_CNPJDistribuidora.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(134, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "CNPJ:";
            // 
            // textBox_NomeDistribuidora
            // 
            this.textBox_NomeDistribuidora.Location = new System.Drawing.Point(191, 30);
            this.textBox_NomeDistribuidora.Name = "textBox_NomeDistribuidora";
            this.textBox_NomeDistribuidora.Size = new System.Drawing.Size(237, 23);
            this.textBox_NomeDistribuidora.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome:";
            // 
            // Frm_InserirDistribuidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(569, 270);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.textBox_CNPJDistribuidora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NomeDistribuidora);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_InserirDistribuidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_InserirDistribuidor";
            this.Load += new System.EventHandler(this.Frm_InserirDistribuidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox textBox_CNPJDistribuidora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NomeDistribuidora;
        private System.Windows.Forms.Label label1;
    }
}