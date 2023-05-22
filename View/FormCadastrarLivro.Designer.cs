
namespace LivrariaFive.View
{
    partial class FormCadastrarLivro
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
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtGeneroLivro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutorLivro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxAutor = new System.Windows.Forms.ComboBox();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnoPublicacao = new System.Windows.Forms.TextBox();
            this.lblisbn = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblpreco = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Livro:";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(162, 65);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(179, 20);
            this.txtNomeLivro.TabIndex = 1;
            // 
            // txtGeneroLivro
            // 
            this.txtGeneroLivro.Location = new System.Drawing.Point(162, 284);
            this.txtGeneroLivro.Name = "txtGeneroLivro";
            this.txtGeneroLivro.Size = new System.Drawing.Size(124, 20);
            this.txtGeneroLivro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genero:";
            // 
            // txtAutorLivro
            // 
            this.txtAutorLivro.Location = new System.Drawing.Point(162, 311);
            this.txtAutorLivro.Name = "txtAutorLivro";
            this.txtAutorLivro.Size = new System.Drawing.Size(124, 20);
            this.txtAutorLivro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(317, 283);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(166, 21);
            this.comboBoxGenero.TabIndex = 6;
            // 
            // comboBoxAutor
            // 
            this.comboBoxAutor.FormattingEnabled = true;
            this.comboBoxAutor.Location = new System.Drawing.Point(317, 310);
            this.comboBoxAutor.Name = "comboBoxAutor";
            this.comboBoxAutor.Size = new System.Drawing.Size(166, 21);
            this.comboBoxAutor.TabIndex = 7;
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(657, 391);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(131, 47);
            this.btnCadastrarLivro.TabIndex = 10;
            this.btnCadastrarLivro.Text = "Cadastrar Livro";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ano de Publicação:";
            // 
            // txtAnoPublicacao
            // 
            this.txtAnoPublicacao.Location = new System.Drawing.Point(162, 149);
            this.txtAnoPublicacao.Name = "txtAnoPublicacao";
            this.txtAnoPublicacao.Size = new System.Drawing.Size(179, 20);
            this.txtAnoPublicacao.TabIndex = 12;
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.Location = new System.Drawing.Point(121, 110);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(35, 13);
            this.lblisbn.TabIndex = 13;
            this.lblisbn.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(162, 107);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(179, 20);
            this.txtISBN.TabIndex = 14;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(162, 190);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(179, 20);
            this.txtPreco.TabIndex = 15;
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(118, 193);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(38, 13);
            this.lblpreco.TabIndex = 16;
            this.lblpreco.Text = "Preço:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(162, 231);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(179, 20);
            this.txtEstoque.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Estoque:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(507, 65);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(255, 55);
            this.txtDescricao.TabIndex = 19;
            this.txtDescricao.Text = "";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(443, 87);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(58, 13);
            this.lbl8.TabIndex = 20;
            this.lbl8.Text = "Descrição:";
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(507, 152);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(255, 20);
            this.txtIdioma.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Idioma:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "ou";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "ou";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(507, 206);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(124, 20);
            this.txtEditora.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Editora:";
            // 
            // FormCadastrarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblisbn);
            this.Controls.Add(this.txtAnoPublicacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadastrarLivro);
            this.Controls.Add(this.comboBoxAutor);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.txtAutorLivro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGeneroLivro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastrarLivro";
            this.Text = "FormCadastrarLivro";
            this.Load += new System.EventHandler(this.FormCadastrarLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.TextBox txtGeneroLivro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutorLivro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxAutor;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnoPublicacao;
        private System.Windows.Forms.Label lblisbn;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label4;
    }
}