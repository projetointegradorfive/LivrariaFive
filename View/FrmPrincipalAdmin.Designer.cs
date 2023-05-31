
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
            this.btnEncerrarSessao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerenciarUsuarios = new System.Windows.Forms.Button();
            this.btnGerenciarLivros = new System.Windows.Forms.Button();
            this.btnRelatórios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncerrarSessao
            // 
            this.btnEncerrarSessao.Location = new System.Drawing.Point(659, 12);
            this.btnEncerrarSessao.Name = "btnEncerrarSessao";
            this.btnEncerrarSessao.Size = new System.Drawing.Size(129, 29);
            this.btnEncerrarSessao.TabIndex = 1;
            this.btnEncerrarSessao.Text = "Encerrar Sessão";
            this.btnEncerrarSessao.UseVisualStyleBackColor = true;
            this.btnEncerrarSessao.Click += new System.EventHandler(this.btnEncerrarSessao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerenciarUsuarios
            // 
            this.btnGerenciarUsuarios.Location = new System.Drawing.Point(236, 269);
            this.btnGerenciarUsuarios.Name = "btnGerenciarUsuarios";
            this.btnGerenciarUsuarios.Size = new System.Drawing.Size(147, 51);
            this.btnGerenciarUsuarios.TabIndex = 3;
            this.btnGerenciarUsuarios.Text = "Gerenciar Usuários";
            this.btnGerenciarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarLivros
            // 
            this.btnGerenciarLivros.Location = new System.Drawing.Point(312, 341);
            this.btnGerenciarLivros.Name = "btnGerenciarLivros";
            this.btnGerenciarLivros.Size = new System.Drawing.Size(147, 51);
            this.btnGerenciarLivros.TabIndex = 4;
            this.btnGerenciarLivros.Text = "Gerenciar Livros";
            this.btnGerenciarLivros.UseVisualStyleBackColor = true;
            // 
            // btnRelatórios
            // 
            this.btnRelatórios.Location = new System.Drawing.Point(399, 269);
            this.btnRelatórios.Name = "btnRelatórios";
            this.btnRelatórios.Size = new System.Drawing.Size(147, 51);
            this.btnRelatórios.TabIndex = 5;
            this.btnRelatórios.Text = "Relatório de vendas";
            this.btnRelatórios.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRelatórios);
            this.Controls.Add(this.btnGerenciarLivros);
            this.Controls.Add(this.btnGerenciarUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEncerrarSessao);
            this.Name = "FrmPrincipalAdmin";
            this.Text = "FrmPrincipalAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEncerrarSessao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGerenciarUsuarios;
        private System.Windows.Forms.Button btnGerenciarLivros;
        private System.Windows.Forms.Button btnRelatórios;
    }
}