
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
            this.dataGridViewItensCarrinho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewItensCarrinho
            // 
            this.dataGridViewItensCarrinho.AllowUserToAddRows = false;
            this.dataGridViewItensCarrinho.AllowUserToDeleteRows = false;
            this.dataGridViewItensCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItensCarrinho.Location = new System.Drawing.Point(16, 62);
            this.dataGridViewItensCarrinho.Name = "dataGridViewItensCarrinho";
            this.dataGridViewItensCarrinho.Size = new System.Drawing.Size(776, 352);
            this.dataGridViewItensCarrinho.TabIndex = 0;
            // 
            // FormCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewItensCarrinho);
            this.Name = "FormCarrinho";
            this.Text = "FormCarrinho";
            this.Load += new System.EventHandler(this.FormCarrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensCarrinho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItensCarrinho;
    }
}