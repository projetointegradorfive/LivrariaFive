
namespace LivrariaFive.View
{
    partial class FrmGerenciarLivros
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
            this.dgvMostrarLivros = new System.Windows.Forms.DataGridView();
            this.btnCadastrarLivroGerenciarLivros = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIdGerenciarLivros = new System.Windows.Forms.Label();
            this.lblTituloGerenciarLivros = new System.Windows.Forms.Label();
            this.lblIsbnGerenciarLivros = new System.Windows.Forms.Label();
            this.lblAnoPublicacaoGerenciarLivros = new System.Windows.Forms.Label();
            this.lblIdEditora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGeneroGerenciarLivros = new System.Windows.Forms.Label();
            this.lblPrecoGerenciarLivros = new System.Windows.Forms.Label();
            this.lblEstoqueGerenciarLivros = new System.Windows.Forms.Label();
            this.lblImagemLivro = new System.Windows.Forms.Label();
            this.lblIdiomaGerenciarLivros = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtAnoPublicacao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.pbFotoLivroGerenciarLivros = new System.Windows.Forms.PictureBox();
            this.btnEditarFotoGerenciarLivros = new System.Windows.Forms.Button();
            this.btnLimparTextBox = new System.Windows.Forms.Button();
            this.btnSalvarAlteracoesGerenciarLivros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoLivroGerenciarLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarLivros
            // 
            this.dgvMostrarLivros.AllowUserToAddRows = false;
            this.dgvMostrarLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvMostrarLivros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvMostrarLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarLivros.Location = new System.Drawing.Point(489, 1);
            this.dgvMostrarLivros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMostrarLivros.Name = "dgvMostrarLivros";
            this.dgvMostrarLivros.RowHeadersWidth = 51;
            this.dgvMostrarLivros.Size = new System.Drawing.Size(1076, 715);
            this.dgvMostrarLivros.TabIndex = 0;
            this.dgvMostrarLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarLivros_CellClick);
            // 
            // btnCadastrarLivroGerenciarLivros
            // 
            this.btnCadastrarLivroGerenciarLivros.Location = new System.Drawing.Point(13, 13);
            this.btnCadastrarLivroGerenciarLivros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarLivroGerenciarLivros.Name = "btnCadastrarLivroGerenciarLivros";
            this.btnCadastrarLivroGerenciarLivros.Size = new System.Drawing.Size(139, 36);
            this.btnCadastrarLivroGerenciarLivros.TabIndex = 1;
            this.btnCadastrarLivroGerenciarLivros.Text = "Cadastrar Livros";
            this.btnCadastrarLivroGerenciarLivros.UseVisualStyleBackColor = true;
            this.btnCadastrarLivroGerenciarLivros.Click += new System.EventHandler(this.btnCadastrarLivroGerenciarLivros_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.Location = new System.Drawing.Point(271, 15);
            this.btnVolta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(211, 34);
            this.btnVolta.TabIndex = 2;
            this.btnVolta.Text = "Voltar para página anterior";
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(284, 93);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 3;
            // 
            // lblIdGerenciarLivros
            // 
            this.lblIdGerenciarLivros.AutoSize = true;
            this.lblIdGerenciarLivros.Location = new System.Drawing.Point(280, 73);
            this.lblIdGerenciarLivros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdGerenciarLivros.Name = "lblIdGerenciarLivros";
            this.lblIdGerenciarLivros.Size = new System.Drawing.Size(29, 17);
            this.lblIdGerenciarLivros.TabIndex = 4;
            this.lblIdGerenciarLivros.Text = "ID: ";
            // 
            // lblTituloGerenciarLivros
            // 
            this.lblTituloGerenciarLivros.AutoSize = true;
            this.lblTituloGerenciarLivros.Location = new System.Drawing.Point(288, 149);
            this.lblTituloGerenciarLivros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloGerenciarLivros.Name = "lblTituloGerenciarLivros";
            this.lblTituloGerenciarLivros.Size = new System.Drawing.Size(47, 17);
            this.lblTituloGerenciarLivros.TabIndex = 5;
            this.lblTituloGerenciarLivros.Text = "Titulo:";
            // 
            // lblIsbnGerenciarLivros
            // 
            this.lblIsbnGerenciarLivros.AutoSize = true;
            this.lblIsbnGerenciarLivros.Location = new System.Drawing.Point(13, 169);
            this.lblIsbnGerenciarLivros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsbnGerenciarLivros.Name = "lblIsbnGerenciarLivros";
            this.lblIsbnGerenciarLivros.Size = new System.Drawing.Size(42, 17);
            this.lblIsbnGerenciarLivros.TabIndex = 6;
            this.lblIsbnGerenciarLivros.Text = "isbn: ";
            // 
            // lblAnoPublicacaoGerenciarLivros
            // 
            this.lblAnoPublicacaoGerenciarLivros.AutoSize = true;
            this.lblAnoPublicacaoGerenciarLivros.Location = new System.Drawing.Point(284, 224);
            this.lblAnoPublicacaoGerenciarLivros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnoPublicacaoGerenciarLivros.Name = "lblAnoPublicacaoGerenciarLivros";
            this.lblAnoPublicacaoGerenciarLivros.Size = new System.Drawing.Size(130, 17);
            this.lblAnoPublicacaoGerenciarLivros.TabIndex = 7;
            this.lblAnoPublicacaoGerenciarLivros.Text = "Ano de Publicação:";
            // 
            // lblIdEditora
            // 
            this.lblIdEditora.AutoSize = true;
            this.lblIdEditora.Location = new System.Drawing.Point(284, 407);
            this.lblIdEditora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdEditora.Name = "lblIdEditora";
            this.lblIdEditora.Size = new System.Drawing.Size(57, 17);
            this.lblIdEditora.TabIndex = 8;
            this.lblIdEditora.Text = "Editora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 480);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descrição:";
            // 
            // lblGeneroGerenciarLivros
            // 
            this.lblGeneroGerenciarLivros.AutoSize = true;
            this.lblGeneroGerenciarLivros.Location = new System.Drawing.Point(12, 407);
            this.lblGeneroGerenciarLivros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneroGerenciarLivros.Name = "lblGeneroGerenciarLivros";
            this.lblGeneroGerenciarLivros.Size = new System.Drawing.Size(60, 17);
            this.lblGeneroGerenciarLivros.TabIndex = 10;
            this.lblGeneroGerenciarLivros.Text = "Gênero:";
            // 
            // lblPrecoGerenciarLivros
            // 
            this.lblPrecoGerenciarLivros.AutoSize = true;
            this.lblPrecoGerenciarLivros.Location = new System.Drawing.Point(12, 228);
            this.lblPrecoGerenciarLivros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoGerenciarLivros.Name = "lblPrecoGerenciarLivros";
            this.lblPrecoGerenciarLivros.Size = new System.Drawing.Size(49, 17);
            this.lblPrecoGerenciarLivros.TabIndex = 11;
            this.lblPrecoGerenciarLivros.Text = "Preço:";
            // 
            // lblEstoqueGerenciarLivros
            // 
            this.lblEstoqueGerenciarLivros.AutoSize = true;
            this.lblEstoqueGerenciarLivros.Location = new System.Drawing.Point(280, 321);
            this.lblEstoqueGerenciarLivros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstoqueGerenciarLivros.Name = "lblEstoqueGerenciarLivros";
            this.lblEstoqueGerenciarLivros.Size = new System.Drawing.Size(68, 17);
            this.lblEstoqueGerenciarLivros.TabIndex = 12;
            this.lblEstoqueGerenciarLivros.Text = "Estoque: ";
            // 
            // lblImagemLivro
            // 
            this.lblImagemLivro.AutoSize = true;
            this.lblImagemLivro.Location = new System.Drawing.Point(165, 528);
            this.lblImagemLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagemLivro.Name = "lblImagemLivro";
            this.lblImagemLivro.Size = new System.Drawing.Size(116, 17);
            this.lblImagemLivro.TabIndex = 13;
            this.lblImagemLivro.Text = "Imagem do Livro:";
            // 
            // lblIdiomaGerenciarLivros
            // 
            this.lblIdiomaGerenciarLivros.AutoSize = true;
            this.lblIdiomaGerenciarLivros.Location = new System.Drawing.Point(12, 321);
            this.lblIdiomaGerenciarLivros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdiomaGerenciarLivros.Name = "lblIdiomaGerenciarLivros";
            this.lblIdiomaGerenciarLivros.Size = new System.Drawing.Size(53, 17);
            this.lblIdiomaGerenciarLivros.TabIndex = 14;
            this.lblIdiomaGerenciarLivros.Text = "Idioma:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(288, 169);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(132, 22);
            this.txtTitulo.TabIndex = 15;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(13, 189);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(132, 22);
            this.txtIsbn.TabIndex = 16;
            // 
            // txtAnoPublicacao
            // 
            this.txtAnoPublicacao.Location = new System.Drawing.Point(288, 247);
            this.txtAnoPublicacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnoPublicacao.Name = "txtAnoPublicacao";
            this.txtAnoPublicacao.Size = new System.Drawing.Size(132, 22);
            this.txtAnoPublicacao.TabIndex = 17;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(16, 247);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(132, 22);
            this.txtPreco.TabIndex = 18;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(284, 341);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(132, 22);
            this.txtEstoque.TabIndex = 19;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(16, 341);
            this.txtIdioma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(132, 22);
            this.txtIdioma.TabIndex = 21;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(16, 500);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(468, 22);
            this.txtDescricao.TabIndex = 22;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(16, 427);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(132, 22);
            this.txtGenero.TabIndex = 23;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(288, 427);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(132, 22);
            this.txtEditora.TabIndex = 24;
            // 
            // pbFotoLivroGerenciarLivros
            // 
            this.pbFotoLivroGerenciarLivros.Location = new System.Drawing.Point(161, 548);
            this.pbFotoLivroGerenciarLivros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbFotoLivroGerenciarLivros.Name = "pbFotoLivroGerenciarLivros";
            this.pbFotoLivroGerenciarLivros.Size = new System.Drawing.Size(133, 169);
            this.pbFotoLivroGerenciarLivros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoLivroGerenciarLivros.TabIndex = 25;
            this.pbFotoLivroGerenciarLivros.TabStop = false;
            // 
            // btnEditarFotoGerenciarLivros
            // 
            this.btnEditarFotoGerenciarLivros.Location = new System.Drawing.Point(16, 614);
            this.btnEditarFotoGerenciarLivros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarFotoGerenciarLivros.Name = "btnEditarFotoGerenciarLivros";
            this.btnEditarFotoGerenciarLivros.Size = new System.Drawing.Size(119, 44);
            this.btnEditarFotoGerenciarLivros.TabIndex = 28;
            this.btnEditarFotoGerenciarLivros.Text = "Editar Foto";
            this.btnEditarFotoGerenciarLivros.UseVisualStyleBackColor = true;
            this.btnEditarFotoGerenciarLivros.Click += new System.EventHandler(this.btnEditarFotoGerenciarLivros_Click);
            // 
            // btnLimparTextBox
            // 
            this.btnLimparTextBox.Location = new System.Drawing.Point(13, 120);
            this.btnLimparTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparTextBox.Name = "btnLimparTextBox";
            this.btnLimparTextBox.Size = new System.Drawing.Size(139, 36);
            this.btnLimparTextBox.TabIndex = 29;
            this.btnLimparTextBox.Text = "Limpar TextBox";
            this.btnLimparTextBox.UseVisualStyleBackColor = true;
            this.btnLimparTextBox.Click += new System.EventHandler(this.btnLimparTextBox_Click);
            // 
            // btnSalvarAlteracoesGerenciarLivros
            // 
            this.btnSalvarAlteracoesGerenciarLivros.Location = new System.Drawing.Point(13, 63);
            this.btnSalvarAlteracoesGerenciarLivros.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarAlteracoesGerenciarLivros.Name = "btnSalvarAlteracoesGerenciarLivros";
            this.btnSalvarAlteracoesGerenciarLivros.Size = new System.Drawing.Size(139, 36);
            this.btnSalvarAlteracoesGerenciarLivros.TabIndex = 30;
            this.btnSalvarAlteracoesGerenciarLivros.Text = "Salvar Alterações";
            this.btnSalvarAlteracoesGerenciarLivros.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracoesGerenciarLivros.Click += new System.EventHandler(this.btnSalvarAlteracoesGerenciarLivros_Click);
            // 
            // FrmGerenciarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 720);
            this.Controls.Add(this.btnSalvarAlteracoesGerenciarLivros);
            this.Controls.Add(this.btnLimparTextBox);
            this.Controls.Add(this.btnEditarFotoGerenciarLivros);
            this.Controls.Add(this.pbFotoLivroGerenciarLivros);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtAnoPublicacao);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblIdiomaGerenciarLivros);
            this.Controls.Add(this.lblImagemLivro);
            this.Controls.Add(this.lblEstoqueGerenciarLivros);
            this.Controls.Add(this.lblPrecoGerenciarLivros);
            this.Controls.Add(this.lblGeneroGerenciarLivros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblIdEditora);
            this.Controls.Add(this.lblAnoPublicacaoGerenciarLivros);
            this.Controls.Add(this.lblIsbnGerenciarLivros);
            this.Controls.Add(this.lblTituloGerenciarLivros);
            this.Controls.Add(this.lblIdGerenciarLivros);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnCadastrarLivroGerenciarLivros);
            this.Controls.Add(this.dgvMostrarLivros);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGerenciarLivros";
            this.Text = "FrmGerenciarLivros";
            this.Load += new System.EventHandler(this.FrmGerenciarLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoLivroGerenciarLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarLivros;
        private System.Windows.Forms.Button btnCadastrarLivroGerenciarLivros;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdGerenciarLivros;
        private System.Windows.Forms.Label lblTituloGerenciarLivros;
        private System.Windows.Forms.Label lblIsbnGerenciarLivros;
        private System.Windows.Forms.Label lblAnoPublicacaoGerenciarLivros;
        private System.Windows.Forms.Label lblIdEditora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGeneroGerenciarLivros;
        private System.Windows.Forms.Label lblPrecoGerenciarLivros;
        private System.Windows.Forms.Label lblEstoqueGerenciarLivros;
        private System.Windows.Forms.Label lblImagemLivro;
        private System.Windows.Forms.Label lblIdiomaGerenciarLivros;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtAnoPublicacao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.PictureBox pbFotoLivroGerenciarLivros;
        private System.Windows.Forms.Button btnEditarFotoGerenciarLivros;
        private System.Windows.Forms.Button btnLimparTextBox;
        private System.Windows.Forms.Button btnSalvarAlteracoesGerenciarLivros;
    }
}