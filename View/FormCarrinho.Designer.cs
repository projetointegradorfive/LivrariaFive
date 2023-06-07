
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
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.btnRemoverItemCarrinho = new System.Windows.Forms.Button();
            this.btnLimparCarrinho = new System.Windows.Forms.Button();
            this.lblPrecoTotalCarrinho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEfetuarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.AllowUserToAddRows = false;
            this.dgvCarrinho.AllowUserToDeleteRows = false;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Location = new System.Drawing.Point(12, 12);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.Size = new System.Drawing.Size(776, 352);
            this.dgvCarrinho.TabIndex = 0;
            this.dgvCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinho_CellContentClick);
            this.dgvCarrinho.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinho_CellEndEdit);
            // 
            // btnRemoverItemCarrinho
            // 
            this.btnRemoverItemCarrinho.Location = new System.Drawing.Point(26, 394);
            this.btnRemoverItemCarrinho.Name = "btnRemoverItemCarrinho";
            this.btnRemoverItemCarrinho.Size = new System.Drawing.Size(117, 34);
            this.btnRemoverItemCarrinho.TabIndex = 1;
            this.btnRemoverItemCarrinho.Text = "Remover Produto";
            this.btnRemoverItemCarrinho.UseVisualStyleBackColor = true;
            this.btnRemoverItemCarrinho.Click += new System.EventHandler(this.btnRemoverItemCarrinho_Click);
            // 
            // btnLimparCarrinho
            // 
            this.btnLimparCarrinho.Location = new System.Drawing.Point(186, 394);
            this.btnLimparCarrinho.Name = "btnLimparCarrinho";
            this.btnLimparCarrinho.Size = new System.Drawing.Size(117, 34);
            this.btnLimparCarrinho.TabIndex = 2;
            this.btnLimparCarrinho.Text = "Limpar Carrinho";
            this.btnLimparCarrinho.UseVisualStyleBackColor = true;
            this.btnLimparCarrinho.Click += new System.EventHandler(this.btnLimparCarrinho_Click);
            // 
            // lblPrecoTotalCarrinho
            // 
            this.lblPrecoTotalCarrinho.Location = new System.Drawing.Point(422, 394);
            this.lblPrecoTotalCarrinho.Name = "lblPrecoTotalCarrinho";
            this.lblPrecoTotalCarrinho.Size = new System.Drawing.Size(88, 29);
            this.lblPrecoTotalCarrinho.TabIndex = 3;
            this.lblPrecoTotalCarrinho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(363, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total do Carrinho:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEfetuarPedido
            // 
            this.btnEfetuarPedido.Location = new System.Drawing.Point(654, 394);
            this.btnEfetuarPedido.Name = "btnEfetuarPedido";
            this.btnEfetuarPedido.Size = new System.Drawing.Size(134, 34);
            this.btnEfetuarPedido.TabIndex = 5;
            this.btnEfetuarPedido.Text = "Fazer Pedido";
            this.btnEfetuarPedido.UseVisualStyleBackColor = true;
            // 
            // FormCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEfetuarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrecoTotalCarrinho);
            this.Controls.Add(this.btnLimparCarrinho);
            this.Controls.Add(this.btnRemoverItemCarrinho);
            this.Controls.Add(this.dgvCarrinho);
            this.Name = "FormCarrinho";
            this.Text = "FormCarrinho";
            this.Load += new System.EventHandler(this.FormCarrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Button btnRemoverItemCarrinho;
        private System.Windows.Forms.Button btnLimparCarrinho;
        private System.Windows.Forms.Label lblPrecoTotalCarrinho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEfetuarPedido;
    }
}