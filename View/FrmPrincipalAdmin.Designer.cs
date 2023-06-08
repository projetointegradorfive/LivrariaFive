
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerenciarUsuarios
            // 
            this.btnGerenciarUsuarios.Location = new System.Drawing.Point(177, 219);
            this.btnGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerenciarUsuarios.Name = "btnGerenciarUsuarios";
            this.btnGerenciarUsuarios.Size = new System.Drawing.Size(110, 41);
            this.btnGerenciarUsuarios.TabIndex = 3;
            this.btnGerenciarUsuarios.Text = "Gerenciar Usuários";
            this.btnGerenciarUsuarios.UseVisualStyleBackColor = true;
            this.btnGerenciarUsuarios.Click += new System.EventHandler(this.btnGerenciarUsuarios_Click);
            // 
            // btnGerenciarLivros
            // 
            this.btnGerenciarLivros.Location = new System.Drawing.Point(234, 277);
            this.btnGerenciarLivros.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerenciarLivros.Name = "btnGerenciarLivros";
            this.btnGerenciarLivros.Size = new System.Drawing.Size(110, 41);
            this.btnGerenciarLivros.TabIndex = 4;
            this.btnGerenciarLivros.Text = "Gerenciar Livros";
            this.btnGerenciarLivros.UseVisualStyleBackColor = true;
            this.btnGerenciarLivros.Click += new System.EventHandler(this.btnGerenciarLivros_Click);
            // 
            // btnRelatórios
            // 
            this.btnRelatórios.Location = new System.Drawing.Point(299, 219);
            this.btnRelatórios.Margin = new System.Windows.Forms.Padding(2);
            this.btnRelatórios.Name = "btnRelatórios";
            this.btnRelatórios.Size = new System.Drawing.Size(110, 41);
            this.btnRelatórios.TabIndex = 5;
            this.btnRelatórios.Text = "Relatório de vendas";
            this.btnRelatórios.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(553, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRelatórios);
            this.Controls.Add(this.btnGerenciarLivros);
            this.Controls.Add(this.btnGerenciarUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipalAdmin";
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
    }
}