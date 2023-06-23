
namespace LivrariaFive.View
{
    partial class FrmPrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerenciarUsuarios = new System.Windows.Forms.Button();
            this.btnGerenciarLivros = new System.Windows.Forms.Button();
            this.btnRelatórios = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRelatorioClientes = new System.Windows.Forms.Button();
            this.btnRelatorioEstoque = new System.Windows.Forms.Button();
            this.btnRelatorioProdutos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerenciarUsuarios
            // 
            this.btnGerenciarUsuarios.Location = new System.Drawing.Point(236, 270);
            this.btnGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerenciarUsuarios.Name = "btnGerenciarUsuarios";
            this.btnGerenciarUsuarios.Size = new System.Drawing.Size(147, 50);
            this.btnGerenciarUsuarios.TabIndex = 3;
            this.btnGerenciarUsuarios.Text = "Gerenciar Usuários";
            this.btnGerenciarUsuarios.UseVisualStyleBackColor = true;
            this.btnGerenciarUsuarios.Click += new System.EventHandler(this.btnGerenciarUsuarios_Click);
            // 
            // btnGerenciarLivros
            // 
            this.btnGerenciarLivros.Location = new System.Drawing.Point(399, 270);
            this.btnGerenciarLivros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerenciarLivros.Name = "btnGerenciarLivros";
            this.btnGerenciarLivros.Size = new System.Drawing.Size(147, 50);
            this.btnGerenciarLivros.TabIndex = 4;
            this.btnGerenciarLivros.Text = "Gerenciar Livros";
            this.btnGerenciarLivros.UseVisualStyleBackColor = true;
            this.btnGerenciarLivros.Click += new System.EventHandler(this.btnGerenciarLivros_Click);
            // 
            // btnRelatórios
            // 
            this.btnRelatórios.Location = new System.Drawing.Point(236, 343);
            this.btnRelatórios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelatórios.Name = "btnRelatórios";
            this.btnRelatórios.Size = new System.Drawing.Size(147, 50);
            this.btnRelatórios.TabIndex = 5;
            this.btnRelatórios.Text = "Relatório de vendas";
            this.btnRelatórios.UseVisualStyleBackColor = true;
            this.btnRelatórios.Click += new System.EventHandler(this.btnRelatórios_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(723, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnRelatorioClientes
            // 
            this.btnRelatorioClientes.Location = new System.Drawing.Point(87, 343);
            this.btnRelatorioClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelatorioClientes.Name = "btnRelatorioClientes";
            this.btnRelatorioClientes.Size = new System.Drawing.Size(144, 50);
            this.btnRelatorioClientes.TabIndex = 7;
            this.btnRelatorioClientes.Text = "Relatório de Clientes";
            this.btnRelatorioClientes.UseVisualStyleBackColor = true;
            this.btnRelatorioClientes.Click += new System.EventHandler(this.btnRelatorioClientes_Click);
            // 
            // btnRelatorioEstoque
            // 
            this.btnRelatorioEstoque.Location = new System.Drawing.Point(388, 343);
            this.btnRelatorioEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelatorioEstoque.Name = "btnRelatorioEstoque";
            this.btnRelatorioEstoque.Size = new System.Drawing.Size(147, 50);
            this.btnRelatorioEstoque.TabIndex = 8;
            this.btnRelatorioEstoque.Text = "Relatório Faturamento";
            this.btnRelatorioEstoque.UseVisualStyleBackColor = true;
            this.btnRelatorioEstoque.Click += new System.EventHandler(this.btnRelatorioEstoque_Click);
            // 
            // btnRelatorioProdutos
            // 
            this.btnRelatorioProdutos.Location = new System.Drawing.Point(540, 343);
            this.btnRelatorioProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelatorioProdutos.Name = "btnRelatorioProdutos";
            this.btnRelatorioProdutos.Size = new System.Drawing.Size(147, 50);
            this.btnRelatorioProdutos.TabIndex = 9;
            this.btnRelatorioProdutos.Text = "Relatório de Produtos";
            this.btnRelatorioProdutos.UseVisualStyleBackColor = true;
            this.btnRelatorioProdutos.Click += new System.EventHandler(this.btnRelatorioProdutos_Click);
            // 
            // FrmPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRelatorioProdutos);
            this.Controls.Add(this.btnRelatorioEstoque);
            this.Controls.Add(this.btnRelatorioClientes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRelatórios);
            this.Controls.Add(this.btnGerenciarLivros);
            this.Controls.Add(this.btnGerenciarUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal do Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGerenciarUsuarios;
        private System.Windows.Forms.Button btnGerenciarLivros;
        private System.Windows.Forms.Button btnRelatórios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRelatorioClientes;
        private System.Windows.Forms.Button btnRelatorioEstoque;
        private System.Windows.Forms.Button btnRelatorioProdutos;
    }
}