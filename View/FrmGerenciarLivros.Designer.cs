
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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.pbFotoLivroGerenciarLivros = new System.Windows.Forms.PictureBox();
            this.btnAdicionarFotoGerenciarLivros = new System.Windows.Forms.Button();
            this.btnEditarFotoGerenciarLivros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoLivroGerenciarLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarLivros
            // 
            this.dgvMostrarLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvMostrarLivros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvMostrarLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarLivros.Location = new System.Drawing.Point(367, 1);
            this.dgvMostrarLivros.Name = "dgvMostrarLivros";
            this.dgvMostrarLivros.RowHeadersWidth = 51;
            this.dgvMostrarLivros.Size = new System.Drawing.Size(807, 581);
            this.dgvMostrarLivros.TabIndex = 0;
            // 
            // btnCadastrarLivroGerenciarLivros
            // 
            this.btnCadastrarLivroGerenciarLivros.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarLivroGerenciarLivros.Name = "btnCadastrarLivroGerenciarLivros";
            this.btnCadastrarLivroGerenciarLivros.Size = new System.Drawing.Size(104, 29);
            this.btnCadastrarLivroGerenciarLivros.TabIndex = 1;
            this.btnCadastrarLivroGerenciarLivros.Text = "Cadastrar Livros";
            this.btnCadastrarLivroGerenciarLivros.UseVisualStyleBackColor = true;
            this.btnCadastrarLivroGerenciarLivros.Click += new System.EventHandler(this.btnCadastrarLivroGerenciarLivros_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.Location = new System.Drawing.Point(203, 12);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(158, 28);
            this.btnVolta.TabIndex = 2;
            this.btnVolta.Text = "Voltar para página anterior";
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblIdGerenciarLivros
            // 
            this.lblIdGerenciarLivros.AutoSize = true;
            this.lblIdGerenciarLivros.Location = new System.Drawing.Point(109, 56);
            this.lblIdGerenciarLivros.Name = "lblIdGerenciarLivros";
            this.lblIdGerenciarLivros.Size = new System.Drawing.Size(24, 13);
            this.lblIdGerenciarLivros.TabIndex = 4;
            this.lblIdGerenciarLivros.Text = "ID: ";
            // 
            // lblTituloGerenciarLivros
            // 
            this.lblTituloGerenciarLivros.AutoSize = true;
            this.lblTituloGerenciarLivros.Location = new System.Drawing.Point(216, 121);
            this.lblTituloGerenciarLivros.Name = "lblTituloGerenciarLivros";
            this.lblTituloGerenciarLivros.Size = new System.Drawing.Size(36, 13);
            this.lblTituloGerenciarLivros.TabIndex = 5;
            this.lblTituloGerenciarLivros.Text = "Titulo:";
            // 
            // lblIsbnGerenciarLivros
            // 
            this.lblIsbnGerenciarLivros.AutoSize = true;
            this.lblIsbnGerenciarLivros.Location = new System.Drawing.Point(12, 121);
            this.lblIsbnGerenciarLivros.Name = "lblIsbnGerenciarLivros";
            this.lblIsbnGerenciarLivros.Size = new System.Drawing.Size(32, 13);
            this.lblIsbnGerenciarLivros.TabIndex = 6;
            this.lblIsbnGerenciarLivros.Text = "isbn: ";
            // 
            // lblAnoPublicacaoGerenciarLivros
            // 
            this.lblAnoPublicacaoGerenciarLivros.AutoSize = true;
            this.lblAnoPublicacaoGerenciarLivros.Location = new System.Drawing.Point(213, 182);
            this.lblAnoPublicacaoGerenciarLivros.Name = "lblAnoPublicacaoGerenciarLivros";
            this.lblAnoPublicacaoGerenciarLivros.Size = new System.Drawing.Size(100, 13);
            this.lblAnoPublicacaoGerenciarLivros.TabIndex = 7;
            this.lblAnoPublicacaoGerenciarLivros.Text = "Ano de Publicação:";
            // 
            // lblIdEditora
            // 
            this.lblIdEditora.AutoSize = true;
            this.lblIdEditora.Location = new System.Drawing.Point(213, 331);
            this.lblIdEditora.Name = "lblIdEditora";
            this.lblIdEditora.Size = new System.Drawing.Size(43, 13);
            this.lblIdEditora.TabIndex = 8;
            this.lblIdEditora.Text = "Editora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descrição:";
            // 
            // lblGeneroGerenciarLivros
            // 
            this.lblGeneroGerenciarLivros.AutoSize = true;
            this.lblGeneroGerenciarLivros.Location = new System.Drawing.Point(9, 331);
            this.lblGeneroGerenciarLivros.Name = "lblGeneroGerenciarLivros";
            this.lblGeneroGerenciarLivros.Size = new System.Drawing.Size(45, 13);
            this.lblGeneroGerenciarLivros.TabIndex = 10;
            this.lblGeneroGerenciarLivros.Text = "Gênero:";
            // 
            // lblPrecoGerenciarLivros
            // 
            this.lblPrecoGerenciarLivros.AutoSize = true;
            this.lblPrecoGerenciarLivros.Location = new System.Drawing.Point(9, 185);
            this.lblPrecoGerenciarLivros.Name = "lblPrecoGerenciarLivros";
            this.lblPrecoGerenciarLivros.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoGerenciarLivros.TabIndex = 11;
            this.lblPrecoGerenciarLivros.Text = "Preço:";
            // 
            // lblEstoqueGerenciarLivros
            // 
            this.lblEstoqueGerenciarLivros.AutoSize = true;
            this.lblEstoqueGerenciarLivros.Location = new System.Drawing.Point(210, 261);
            this.lblEstoqueGerenciarLivros.Name = "lblEstoqueGerenciarLivros";
            this.lblEstoqueGerenciarLivros.Size = new System.Drawing.Size(52, 13);
            this.lblEstoqueGerenciarLivros.TabIndex = 12;
            this.lblEstoqueGerenciarLivros.Text = "Estoque: ";
            // 
            // lblImagemLivro
            // 
            this.lblImagemLivro.AutoSize = true;
            this.lblImagemLivro.Location = new System.Drawing.Point(124, 429);
            this.lblImagemLivro.Name = "lblImagemLivro";
            this.lblImagemLivro.Size = new System.Drawing.Size(88, 13);
            this.lblImagemLivro.TabIndex = 13;
            this.lblImagemLivro.Text = "Imagem do Livro:";
            // 
            // lblIdiomaGerenciarLivros
            // 
            this.lblIdiomaGerenciarLivros.AutoSize = true;
            this.lblIdiomaGerenciarLivros.Location = new System.Drawing.Point(9, 261);
            this.lblIdiomaGerenciarLivros.Name = "lblIdiomaGerenciarLivros";
            this.lblIdiomaGerenciarLivros.Size = new System.Drawing.Size(41, 13);
            this.lblIdiomaGerenciarLivros.TabIndex = 14;
            this.lblIdiomaGerenciarLivros.Text = "Idioma:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(216, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 201);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(213, 277);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 277);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 21;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(12, 406);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(352, 20);
            this.textBox9.TabIndex = 22;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 347);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 23;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(216, 347);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 24;
            // 
            // pbFotoLivroGerenciarLivros
            // 
            this.pbFotoLivroGerenciarLivros.Location = new System.Drawing.Point(121, 445);
            this.pbFotoLivroGerenciarLivros.Name = "pbFotoLivroGerenciarLivros";
            this.pbFotoLivroGerenciarLivros.Size = new System.Drawing.Size(100, 137);
            this.pbFotoLivroGerenciarLivros.TabIndex = 25;
            this.pbFotoLivroGerenciarLivros.TabStop = false;
            // 
            // btnAdicionarFotoGerenciarLivros
            // 
            this.btnAdicionarFotoGerenciarLivros.Location = new System.Drawing.Point(227, 499);
            this.btnAdicionarFotoGerenciarLivros.Name = "btnAdicionarFotoGerenciarLivros";
            this.btnAdicionarFotoGerenciarLivros.Size = new System.Drawing.Size(89, 36);
            this.btnAdicionarFotoGerenciarLivros.TabIndex = 26;
            this.btnAdicionarFotoGerenciarLivros.Text = "Add Foto";
            this.btnAdicionarFotoGerenciarLivros.UseVisualStyleBackColor = true;
            // 
            // btnEditarFotoGerenciarLivros
            // 
            this.btnEditarFotoGerenciarLivros.Location = new System.Drawing.Point(12, 499);
            this.btnEditarFotoGerenciarLivros.Name = "btnEditarFotoGerenciarLivros";
            this.btnEditarFotoGerenciarLivros.Size = new System.Drawing.Size(89, 36);
            this.btnEditarFotoGerenciarLivros.TabIndex = 28;
            this.btnEditarFotoGerenciarLivros.Text = "Editar Foto";
            this.btnEditarFotoGerenciarLivros.UseVisualStyleBackColor = true;
            // 
            // FrmGerenciarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 585);
            this.Controls.Add(this.btnEditarFotoGerenciarLivros);
            this.Controls.Add(this.btnAdicionarFotoGerenciarLivros);
            this.Controls.Add(this.pbFotoLivroGerenciarLivros);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnCadastrarLivroGerenciarLivros);
            this.Controls.Add(this.dgvMostrarLivros);
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
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.PictureBox pbFotoLivroGerenciarLivros;
        private System.Windows.Forms.Button btnAdicionarFotoGerenciarLivros;
        private System.Windows.Forms.Button btnEditarFotoGerenciarLivros;
    }
}