
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarLivros
            // 
            this.dgvMostrarLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvMostrarLivros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvMostrarLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarLivros.Location = new System.Drawing.Point(489, 1);
            this.dgvMostrarLivros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMostrarLivros.Name = "dgvMostrarLivros";
            this.dgvMostrarLivros.RowHeadersWidth = 51;
            this.dgvMostrarLivros.Size = new System.Drawing.Size(1076, 715);
            this.dgvMostrarLivros.TabIndex = 0;
            // 
            // btnCadastrarLivroGerenciarLivros
            // 
            this.btnCadastrarLivroGerenciarLivros.Location = new System.Drawing.Point(16, 15);
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
            this.btnVolta.Location = new System.Drawing.Point(372, 15);
            this.btnVolta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(109, 32);
            this.btnVolta.TabIndex = 2;
            this.btnVolta.Text = "Voltar";
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // FrmGerenciarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 720);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnCadastrarLivroGerenciarLivros);
            this.Controls.Add(this.dgvMostrarLivros);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGerenciarLivros";
            this.Text = "FrmGerenciarLivros";
            this.Load += new System.EventHandler(this.FrmGerenciarLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarLivros;
        private System.Windows.Forms.Button btnCadastrarLivroGerenciarLivros;
        private System.Windows.Forms.Button btnVolta;
    }
}