
namespace LivrariaFive.View
{
    partial class LivroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivroForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewLivros = new System.Windows.Forms.DataGridView();
            this.btnAdicionarCarrinho = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAbrirCarrinho = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscarGenero = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtulizarPágina = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.btnBuscarNome = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewLivros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionarCarrinho, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 674);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewLivros
            // 
            this.dataGridViewLivros.AllowUserToAddRows = false;
            this.dataGridViewLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivros.Location = new System.Drawing.Point(3, 205);
            this.dataGridViewLivros.Name = "dataGridViewLivros";
            this.dataGridViewLivros.Size = new System.Drawing.Size(794, 421);
            this.dataGridViewLivros.TabIndex = 0;
            this.dataGridViewLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLivros_CellContentClick);
            this.dataGridViewLivros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLivros_CellDoubleClick);
            // 
            // btnAdicionarCarrinho
            // 
            this.btnAdicionarCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCarrinho.Location = new System.Drawing.Point(3, 632);
            this.btnAdicionarCarrinho.Name = "btnAdicionarCarrinho";
            this.btnAdicionarCarrinho.Size = new System.Drawing.Size(185, 39);
            this.btnAdicionarCarrinho.TabIndex = 0;
            this.btnAdicionarCarrinho.Text = "Adicionar Ao Carrinho";
            this.btnAdicionarCarrinho.UseVisualStyleBackColor = true;
            this.btnAdicionarCarrinho.Click += new System.EventHandler(this.btnAdicionarCarrinho_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarNome, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBuscarNome, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBuscarGenero, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscar, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSair, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAtulizarPágina, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.07407F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.92593F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 196);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genero:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(262, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(28, 19);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarGenero_Click);
            // 
            // btnAbrirCarrinho
            // 
            this.btnAbrirCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCarrinho.Location = new System.Drawing.Point(3, 3);
            this.btnAbrirCarrinho.Name = "btnAbrirCarrinho";
            this.btnAbrirCarrinho.Size = new System.Drawing.Size(122, 39);
            this.btnAbrirCarrinho.TabIndex = 7;
            this.btnAbrirCarrinho.Text = "Carrinho";
            this.btnAbrirCarrinho.UseVisualStyleBackColor = true;
            this.btnAbrirCarrinho.Click += new System.EventHandler(this.btnAbrirCarrinho_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnAbrirCarrinho, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(643, 91);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(128, 46);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // txtBuscarGenero
            // 
            this.txtBuscarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarGenero.Location = new System.Drawing.Point(80, 91);
            this.txtBuscarGenero.MaxLength = 70;
            this.txtBuscarGenero.Name = "txtBuscarGenero";
            this.txtBuscarGenero.Size = new System.Drawing.Size(176, 26);
            this.txtBuscarGenero.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 88);
            this.label3.TabIndex = 9;
            this.label3.Text = "FiveBooks";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtulizarPágina
            // 
            this.btnAtulizarPágina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtulizarPágina.Location = new System.Drawing.Point(643, 3);
            this.btnAtulizarPágina.Name = "btnAtulizarPágina";
            this.btnAtulizarPágina.Size = new System.Drawing.Size(128, 24);
            this.btnAtulizarPágina.TabIndex = 10;
            this.btnAtulizarPágina.Text = "Atualizar Página";
            this.btnAtulizarPágina.UseVisualStyleBackColor = true;
            this.btnAtulizarPágina.Click += new System.EventHandler(this.btnAtulizarPágina_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(646, 143);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 43);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sign out";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNome.Location = new System.Drawing.Point(80, 143);
            this.txtBuscarNome.MaxLength = 70;
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(176, 26);
            this.txtBuscarNome.TabIndex = 4;
            // 
            // btnBuscarNome
            // 
            this.btnBuscarNome.FlatAppearance.BorderSize = 0;
            this.btnBuscarNome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnBuscarNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNome.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNome.Image")));
            this.btnBuscarNome.Location = new System.Drawing.Point(262, 143);
            this.btnBuscarNome.Name = "btnBuscarNome";
            this.btnBuscarNome.Size = new System.Drawing.Size(28, 21);
            this.btnBuscarNome.TabIndex = 5;
            this.btnBuscarNome.UseVisualStyleBackColor = true;
            this.btnBuscarNome.Click += new System.EventHandler(this.btnBuscarNome_Click);
            // 
            // LivroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LivroForm";
            this.Text = "LivroForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.LivroForm_Activated);
            this.Load += new System.EventHandler(this.LivroForm_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdicionarCarrinho;
        private System.Windows.Forms.DataGridView dataGridViewLivros;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarGenero;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnAbrirCarrinho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarNome;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtulizarPágina;
    }
}