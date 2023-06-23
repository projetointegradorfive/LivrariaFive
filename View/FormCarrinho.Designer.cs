
namespace LivrariaFive.View
{
    partial class FormCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarrinho));
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.btnRemoverItemCarrinho = new System.Windows.Forms.Button();
            this.btnLimparCarrinho = new System.Windows.Forms.Button();
            this.lblPrecoTotalCarrinho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEfetuarPedido = new System.Windows.Forms.Button();
            this.btnSelecionarTudo = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.AllowUserToAddRows = false;
            this.dgvCarrinho.AllowUserToDeleteRows = false;
            this.dgvCarrinho.AllowUserToResizeColumns = false;
            this.dgvCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvCarrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Location = new System.Drawing.Point(16, 119);
            this.dgvCarrinho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.RowHeadersWidth = 51;
            this.dgvCarrinho.Size = new System.Drawing.Size(1035, 444);
            this.dgvCarrinho.TabIndex = 0;
            this.dgvCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinho_CellContentClick);
            this.dgvCarrinho.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinho_CellEndEdit);
            // 
            // btnRemoverItemCarrinho
            // 
            this.btnRemoverItemCarrinho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoverItemCarrinho.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItemCarrinho.Location = new System.Drawing.Point(16, 601);
            this.btnRemoverItemCarrinho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoverItemCarrinho.Name = "btnRemoverItemCarrinho";
            this.btnRemoverItemCarrinho.Size = new System.Drawing.Size(156, 42);
            this.btnRemoverItemCarrinho.TabIndex = 1;
            this.btnRemoverItemCarrinho.Text = "Remover Produto";
            this.btnRemoverItemCarrinho.UseVisualStyleBackColor = true;
            this.btnRemoverItemCarrinho.Click += new System.EventHandler(this.btnRemoverItemCarrinho_Click);
            // 
            // btnLimparCarrinho
            // 
            this.btnLimparCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimparCarrinho.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCarrinho.Location = new System.Drawing.Point(180, 601);
            this.btnLimparCarrinho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparCarrinho.Name = "btnLimparCarrinho";
            this.btnLimparCarrinho.Size = new System.Drawing.Size(156, 42);
            this.btnLimparCarrinho.TabIndex = 2;
            this.btnLimparCarrinho.Text = "Limpar Carrinho";
            this.btnLimparCarrinho.UseVisualStyleBackColor = true;
            this.btnLimparCarrinho.Click += new System.EventHandler(this.btnLimparCarrinho_Click);
            // 
            // lblPrecoTotalCarrinho
            // 
            this.lblPrecoTotalCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrecoTotalCarrinho.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTotalCarrinho.Location = new System.Drawing.Point(703, 601);
            this.lblPrecoTotalCarrinho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoTotalCarrinho.Name = "lblPrecoTotalCarrinho";
            this.lblPrecoTotalCarrinho.Size = new System.Drawing.Size(148, 36);
            this.lblPrecoTotalCarrinho.TabIndex = 3;
            this.lblPrecoTotalCarrinho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 593);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total do Carrinho:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEfetuarPedido
            // 
            this.btnEfetuarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEfetuarPedido.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfetuarPedido.Location = new System.Drawing.Point(872, 601);
            this.btnEfetuarPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEfetuarPedido.Name = "btnEfetuarPedido";
            this.btnEfetuarPedido.Size = new System.Drawing.Size(179, 42);
            this.btnEfetuarPedido.TabIndex = 5;
            this.btnEfetuarPedido.Text = "Fazer Pedido";
            this.btnEfetuarPedido.UseVisualStyleBackColor = true;
            this.btnEfetuarPedido.Click += new System.EventHandler(this.btnEfetuarPedido_Click);
            // 
            // btnSelecionarTudo
            // 
            this.btnSelecionarTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelecionarTudo.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarTudo.Location = new System.Drawing.Point(344, 601);
            this.btnSelecionarTudo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelecionarTudo.Name = "btnSelecionarTudo";
            this.btnSelecionarTudo.Size = new System.Drawing.Size(156, 42);
            this.btnSelecionarTudo.TabIndex = 6;
            this.btnSelecionarTudo.Text = "Selecionar Tudo";
            this.btnSelecionarTudo.UseVisualStyleBackColor = true;
            this.btnSelecionarTudo.Click += new System.EventHandler(this.btnSelecionarTudo_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label15.Font = new System.Drawing.Font("Ink Free", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(92, 47);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 46);
            this.label15.TabIndex = 26;
            this.label15.Text = "Five Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label14.Location = new System.Drawing.Point(-3, -1);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1076, 101);
            this.label14.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(989, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(876, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Carrinho";
            // 
            // FormCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 670);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSelecionarTudo);
            this.Controls.Add(this.btnEfetuarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrecoTotalCarrinho);
            this.Controls.Add(this.btnLimparCarrinho);
            this.Controls.Add(this.btnRemoverItemCarrinho);
            this.Controls.Add(this.dgvCarrinho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormCarrinho";
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.FormCarrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Button btnRemoverItemCarrinho;
        private System.Windows.Forms.Button btnLimparCarrinho;
        private System.Windows.Forms.Label lblPrecoTotalCarrinho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEfetuarPedido;
        private System.Windows.Forms.Button btnSelecionarTudo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}