
namespace LivrariaFive.View
{
    partial class FormRelatorioVendas
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
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.btnItensMaisVendidos = new System.Windows.Forms.Button();
            this.btnRelatorioVendas = new System.Windows.Forms.Button();
            this.txtBuscarAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatusPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarMes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(12, 56);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(776, 382);
            this.dgvVendas.TabIndex = 0;
            // 
            // btnItensMaisVendidos
            // 
            this.btnItensMaisVendidos.Location = new System.Drawing.Point(12, 12);
            this.btnItensMaisVendidos.Name = "btnItensMaisVendidos";
            this.btnItensMaisVendidos.Size = new System.Drawing.Size(155, 23);
            this.btnItensMaisVendidos.TabIndex = 1;
            this.btnItensMaisVendidos.Text = "Livros Mais Vendidos";
            this.btnItensMaisVendidos.UseVisualStyleBackColor = true;
            this.btnItensMaisVendidos.Click += new System.EventHandler(this.btnItensMaisVendidos_Click);
            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.Location = new System.Drawing.Point(173, 12);
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.Size = new System.Drawing.Size(129, 23);
            this.btnRelatorioVendas.TabIndex = 2;
            this.btnRelatorioVendas.Text = "Relatório de Vendas";
            this.btnRelatorioVendas.UseVisualStyleBackColor = true;
            this.btnRelatorioVendas.Click += new System.EventHandler(this.btnRelatorioVendas_Click);
            // 
            // txtBuscarAno
            // 
            this.txtBuscarAno.Location = new System.Drawing.Point(338, 18);
            this.txtBuscarAno.Name = "txtBuscarAno";
            this.txtBuscarAno.Size = new System.Drawing.Size(50, 20);
            this.txtBuscarAno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ano:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(620, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mês:";
            // 
            // txtStatusPedido
            // 
            this.txtStatusPedido.Location = new System.Drawing.Point(488, 18);
            this.txtStatusPedido.Name = "txtStatusPedido";
            this.txtStatusPedido.Size = new System.Drawing.Size(80, 20);
            this.txtStatusPedido.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status do Pedido:";
            // 
            // txtBuscarMes
            // 
            this.txtBuscarMes.Location = new System.Drawing.Point(409, 18);
            this.txtBuscarMes.Name = "txtBuscarMes";
            this.txtBuscarMes.Size = new System.Drawing.Size(50, 20);
            this.txtBuscarMes.TabIndex = 10;
            // 
            // FormRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscarMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatusPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarAno);
            this.Controls.Add(this.btnRelatorioVendas);
            this.Controls.Add(this.btnItensMaisVendidos);
            this.Controls.Add(this.dgvVendas);
            this.Name = "FormRelatorioVendas";
            this.Text = "FormRelatorioVendas";
            this.Load += new System.EventHandler(this.FormRelatorioVendas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Button btnItensMaisVendidos;
        private System.Windows.Forms.Button btnRelatorioVendas;
        private System.Windows.Forms.TextBox txtBuscarAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatusPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarMes;
    }
}