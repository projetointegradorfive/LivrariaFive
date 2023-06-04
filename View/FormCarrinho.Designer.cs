
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
            // FormCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}