
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarLivros));
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
            this.txtAutorGerenciarLivros = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoLivroGerenciarLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarLivros
            // 
            this.dgvMostrarLivros.AllowUserToAddRows = false;
            this.dgvMostrarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMostrarLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarLivros.Location = new System.Drawing.Point(432, 0);
            this.dgvMostrarLivros.Name = "dgvMostrarLivros";
            this.dgvMostrarLivros.RowHeadersWidth = 51;
            this.dgvMostrarLivros.Size = new System.Drawing.Size(740, 631);
            this.dgvMostrarLivros.TabIndex = 0;
            this.dgvMostrarLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarLivros_CellClick);
            // 
            // btnCadastrarLivroGerenciarLivros
            // 
            this.btnCadastrarLivroGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarLivroGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarLivroGerenciarLivros.Location = new System.Drawing.Point(50, 22);
            this.btnCadastrarLivroGerenciarLivros.Name = "btnCadastrarLivroGerenciarLivros";
            this.btnCadastrarLivroGerenciarLivros.Size = new System.Drawing.Size(104, 29);
            this.btnCadastrarLivroGerenciarLivros.TabIndex = 1;
            this.btnCadastrarLivroGerenciarLivros.Text = "Cadastrar Livros";
            this.btnCadastrarLivroGerenciarLivros.UseVisualStyleBackColor = true;
            this.btnCadastrarLivroGerenciarLivros.Click += new System.EventHandler(this.btnCadastrarLivroGerenciarLivros_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolta.Location = new System.Drawing.Point(243, 22);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(158, 29);
            this.btnVolta.TabIndex = 2;
            this.btnVolta.Text = "Voltar para página anterior";
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(256, 87);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(143, 26);
            this.txtId.TabIndex = 3;
            // 
            // lblIdGerenciarLivros
            // 
            this.lblIdGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdGerenciarLivros.AutoSize = true;
            this.lblIdGerenciarLivros.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblIdGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdGerenciarLivros.Location = new System.Drawing.Point(254, 68);
            this.lblIdGerenciarLivros.Name = "lblIdGerenciarLivros";
            this.lblIdGerenciarLivros.Size = new System.Drawing.Size(30, 18);
            this.lblIdGerenciarLivros.TabIndex = 4;
            this.lblIdGerenciarLivros.Text = "ID: ";
            // 
            // lblTituloGerenciarLivros
            // 
            this.lblTituloGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloGerenciarLivros.AutoSize = true;
            this.lblTituloGerenciarLivros.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTituloGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGerenciarLivros.Location = new System.Drawing.Point(254, 126);
            this.lblTituloGerenciarLivros.Name = "lblTituloGerenciarLivros";
            this.lblTituloGerenciarLivros.Size = new System.Drawing.Size(48, 18);
            this.lblTituloGerenciarLivros.TabIndex = 5;
            this.lblTituloGerenciarLivros.Text = "Titulo:";
            // 
            // lblIsbnGerenciarLivros
            // 
            this.lblIsbnGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIsbnGerenciarLivros.AutoSize = true;
            this.lblIsbnGerenciarLivros.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblIsbnGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbnGerenciarLivros.Location = new System.Drawing.Point(51, 143);
            this.lblIsbnGerenciarLivros.Name = "lblIsbnGerenciarLivros";
            this.lblIsbnGerenciarLivros.Size = new System.Drawing.Size(46, 18);
            this.lblIsbnGerenciarLivros.TabIndex = 6;
            this.lblIsbnGerenciarLivros.Text = "ISBN:";
            // 
            // lblAnoPublicacaoGerenciarLivros
            // 
            this.lblAnoPublicacaoGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnoPublicacaoGerenciarLivros.AutoSize = true;
            this.lblAnoPublicacaoGerenciarLivros.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblAnoPublicacaoGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoPublicacaoGerenciarLivros.Location = new System.Drawing.Point(255, 250);
            this.lblAnoPublicacaoGerenciarLivros.Name = "lblAnoPublicacaoGerenciarLivros";
            this.lblAnoPublicacaoGerenciarLivros.Size = new System.Drawing.Size(135, 18);
            this.lblAnoPublicacaoGerenciarLivros.TabIndex = 7;
            this.lblAnoPublicacaoGerenciarLivros.Text = "Ano de Publicação:";
            // 
            // lblIdEditora
            // 
            this.lblIdEditora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdEditora.AutoSize = true;
            this.lblIdEditora.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblIdEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEditora.Location = new System.Drawing.Point(254, 357);
            this.lblIdEditora.Name = "lblIdEditora";
            this.lblIdEditora.Size = new System.Drawing.Size(59, 18);
            this.lblIdEditora.TabIndex = 8;
            this.lblIdEditora.Text = "Editora:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descrição:";
            // 
            // lblGeneroGerenciarLivros
            // 
            this.lblGeneroGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGeneroGerenciarLivros.AutoSize = true;
            this.lblGeneroGerenciarLivros.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblGeneroGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroGerenciarLivros.Location = new System.Drawing.Point(50, 337);
            this.lblGeneroGerenciarLivros.Name = "lblGeneroGerenciarLivros";
            this.lblGeneroGerenciarLivros.Size = new System.Drawing.Size(62, 18);
            this.lblGeneroGerenciarLivros.TabIndex = 10;
            this.lblGeneroGerenciarLivros.Text = "Gênero:";
            // 
            // lblPrecoGerenciarLivros
            // 
            this.lblPrecoGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecoGerenciarLivros.AutoSize = true;
            this.lblPrecoGerenciarLivros.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPrecoGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoGerenciarLivros.Location = new System.Drawing.Point(50, 207);
            this.lblPrecoGerenciarLivros.Name = "lblPrecoGerenciarLivros";
            this.lblPrecoGerenciarLivros.Size = new System.Drawing.Size(52, 18);
            this.lblPrecoGerenciarLivros.TabIndex = 11;
            this.lblPrecoGerenciarLivros.Text = "Preço:";
            // 
            // lblEstoqueGerenciarLivros
            // 
            this.lblEstoqueGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstoqueGerenciarLivros.AutoSize = true;
            this.lblEstoqueGerenciarLivros.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblEstoqueGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueGerenciarLivros.Location = new System.Drawing.Point(252, 304);
            this.lblEstoqueGerenciarLivros.Name = "lblEstoqueGerenciarLivros";
            this.lblEstoqueGerenciarLivros.Size = new System.Drawing.Size(71, 18);
            this.lblEstoqueGerenciarLivros.TabIndex = 12;
            this.lblEstoqueGerenciarLivros.Text = "Estoque: ";
            // 
            // lblImagemLivro
            // 
            this.lblImagemLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImagemLivro.AutoSize = true;
            this.lblImagemLivro.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblImagemLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemLivro.Location = new System.Drawing.Point(166, 459);
            this.lblImagemLivro.Name = "lblImagemLivro";
            this.lblImagemLivro.Size = new System.Drawing.Size(122, 18);
            this.lblImagemLivro.TabIndex = 13;
            this.lblImagemLivro.Text = "Imagem do Livro:";
            // 
            // lblIdiomaGerenciarLivros
            // 
            this.lblIdiomaGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdiomaGerenciarLivros.AutoSize = true;
            this.lblIdiomaGerenciarLivros.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblIdiomaGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomaGerenciarLivros.Location = new System.Drawing.Point(50, 267);
            this.lblIdiomaGerenciarLivros.Name = "lblIdiomaGerenciarLivros";
            this.lblIdiomaGerenciarLivros.Size = new System.Drawing.Size(56, 18);
            this.lblIdiomaGerenciarLivros.TabIndex = 14;
            this.lblIdiomaGerenciarLivros.Text = "Idioma:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(256, 147);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(143, 26);
            this.txtTitulo.TabIndex = 15;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(50, 165);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 26);
            this.txtIsbn.TabIndex = 16;
            this.txtIsbn.TextChanged += new System.EventHandler(this.txtIsbn_TextChanged);
            // 
            // txtAnoPublicacao
            // 
            this.txtAnoPublicacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnoPublicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoPublicacao.Location = new System.Drawing.Point(253, 271);
            this.txtAnoPublicacao.Name = "txtAnoPublicacao";
            this.txtAnoPublicacao.Size = new System.Drawing.Size(146, 26);
            this.txtAnoPublicacao.TabIndex = 17;
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(52, 226);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 26);
            this.txtPreco.TabIndex = 18;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Location = new System.Drawing.Point(253, 323);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(146, 26);
            this.txtEstoque.TabIndex = 19;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdioma.Location = new System.Drawing.Point(52, 287);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(100, 26);
            this.txtIdioma.TabIndex = 21;
            this.txtIdioma.TextChanged += new System.EventHandler(this.txtIdioma_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(52, 416);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(347, 26);
            this.txtDescricao.TabIndex = 22;
            // 
            // txtGenero
            // 
            this.txtGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(52, 357);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 26);
            this.txtGenero.TabIndex = 23;
            // 
            // txtEditora
            // 
            this.txtEditora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.Location = new System.Drawing.Point(254, 378);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(145, 26);
            this.txtEditora.TabIndex = 24;
            // 
            // pbFotoLivroGerenciarLivros
            // 
            this.pbFotoLivroGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFotoLivroGerenciarLivros.Location = new System.Drawing.Point(169, 482);
            this.pbFotoLivroGerenciarLivros.Name = "pbFotoLivroGerenciarLivros";
            this.pbFotoLivroGerenciarLivros.Size = new System.Drawing.Size(100, 137);
            this.pbFotoLivroGerenciarLivros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoLivroGerenciarLivros.TabIndex = 25;
            this.pbFotoLivroGerenciarLivros.TabStop = false;
            // 
            // btnEditarFotoGerenciarLivros
            // 
            this.btnEditarFotoGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarFotoGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFotoGerenciarLivros.Location = new System.Drawing.Point(50, 536);
            this.btnEditarFotoGerenciarLivros.Name = "btnEditarFotoGerenciarLivros";
            this.btnEditarFotoGerenciarLivros.Size = new System.Drawing.Size(89, 30);
            this.btnEditarFotoGerenciarLivros.TabIndex = 28;
            this.btnEditarFotoGerenciarLivros.Text = "Editar Foto";
            this.btnEditarFotoGerenciarLivros.UseVisualStyleBackColor = true;
            this.btnEditarFotoGerenciarLivros.Click += new System.EventHandler(this.btnEditarFotoGerenciarLivros_Click);
            // 
            // btnLimparTextBox
            // 
            this.btnLimparTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimparTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTextBox.Location = new System.Drawing.Point(50, 97);
            this.btnLimparTextBox.Name = "btnLimparTextBox";
            this.btnLimparTextBox.Size = new System.Drawing.Size(104, 29);
            this.btnLimparTextBox.TabIndex = 29;
            this.btnLimparTextBox.Text = "Limpar TextBox";
            this.btnLimparTextBox.UseVisualStyleBackColor = true;
            this.btnLimparTextBox.Click += new System.EventHandler(this.btnLimparTextBox_Click);
            // 
            // btnSalvarAlteracoesGerenciarLivros
            // 
            this.btnSalvarAlteracoesGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarAlteracoesGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAlteracoesGerenciarLivros.Location = new System.Drawing.Point(50, 56);
            this.btnSalvarAlteracoesGerenciarLivros.Name = "btnSalvarAlteracoesGerenciarLivros";
            this.btnSalvarAlteracoesGerenciarLivros.Size = new System.Drawing.Size(104, 29);
            this.btnSalvarAlteracoesGerenciarLivros.TabIndex = 30;
            this.btnSalvarAlteracoesGerenciarLivros.Text = "Salvar Alterações";
            this.btnSalvarAlteracoesGerenciarLivros.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracoesGerenciarLivros.Click += new System.EventHandler(this.btnSalvarAlteracoesGerenciarLivros_Click);
            // 
            // txtAutorGerenciarLivros
            // 
            this.txtAutorGerenciarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAutorGerenciarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutorGerenciarLivros.Location = new System.Drawing.Point(253, 206);
            this.txtAutorGerenciarLivros.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAutorGerenciarLivros.Name = "txtAutorGerenciarLivros";
            this.txtAutorGerenciarLivros.Size = new System.Drawing.Size(146, 26);
            this.txtAutorGerenciarLivros.TabIndex = 31;
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(254, 185);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(47, 18);
            this.lblAutor.TabIndex = 32;
            this.lblAutor.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 631);
            this.label1.TabIndex = 33;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmGerenciarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 631);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtAutorGerenciarLivros);
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
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox txtAutorGerenciarLivros;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label label1;
    }
}