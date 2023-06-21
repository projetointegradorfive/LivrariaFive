namespace LivrariaFive.View
{
    partial class FormPedido
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
            this.dgvpedido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnderecoCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.btnFazerPagamento = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalComFrete = new System.Windows.Forms.Label();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpedido
            // 
            this.dgvpedido.AllowUserToAddRows = false;
            this.dgvpedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpedido.Location = new System.Drawing.Point(44, 132);
            this.dgvpedido.Name = "dgvpedido";
            this.dgvpedido.Size = new System.Drawing.Size(699, 149);
            this.dgvpedido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resumo do Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço:\r\n";
            // 
            // lblEnderecoCliente
            // 
            this.lblEnderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoCliente.ForeColor = System.Drawing.Color.Red;
            this.lblEnderecoCliente.Location = new System.Drawing.Point(134, 39);
            this.lblEnderecoCliente.Name = "lblEnderecoCliente";
            this.lblEnderecoCliente.Size = new System.Drawing.Size(265, 37);
            this.lblEnderecoCliente.TabIndex = 3;
            this.lblEnderecoCliente.Text = "null";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total do Pedido:\r\n";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(621, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Frete:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(669, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "R$ 15,00";
            // 
            // cbxFormaPagamento
            // 
            this.cbxFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaPagamento.FormattingEnabled = true;
            this.cbxFormaPagamento.Location = new System.Drawing.Point(44, 346);
            this.cbxFormaPagamento.Name = "cbxFormaPagamento";
            this.cbxFormaPagamento.Size = new System.Drawing.Size(190, 32);
            this.cbxFormaPagamento.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Forma de Pagamento";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedido.Location = new System.Drawing.Point(669, 327);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(18, 20);
            this.lblTotalPedido.TabIndex = 11;
            this.lblTotalPedido.Text = "0";
            // 
            // btnFazerPagamento
            // 
            this.btnFazerPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFazerPagamento.Location = new System.Drawing.Point(604, 407);
            this.btnFazerPagamento.Name = "btnFazerPagamento";
            this.btnFazerPagamento.Size = new System.Drawing.Size(144, 30);
            this.btnFazerPagamento.TabIndex = 12;
            this.btnFazerPagamento.Text = "Ir para Pagamento";
            this.btnFazerPagamento.UseVisualStyleBackColor = true;
            this.btnFazerPagamento.Click += new System.EventHandler(this.btnFazerPagamento_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(549, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total + Frete:\r\n";
            // 
            // lblTotalComFrete
            // 
            this.lblTotalComFrete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalComFrete.AutoSize = true;
            this.lblTotalComFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComFrete.Location = new System.Drawing.Point(658, 361);
            this.lblTotalComFrete.Name = "lblTotalComFrete";
            this.lblTotalComFrete.Size = new System.Drawing.Size(18, 20);
            this.lblTotalComFrete.TabIndex = 14;
            this.lblTotalComFrete.Text = "0";
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarPedido.Location = new System.Drawing.Point(462, 407);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(127, 31);
            this.btnCancelarPedido.TabIndex = 15;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Location = new System.Drawing.Point(35, 406);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(127, 31);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.lblTotalComFrete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFazerPagamento);
            this.Controls.Add(this.lblTotalPedido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxFormaPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEnderecoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvpedido);
            this.Name = "FormPedido";
            this.Text = "Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnderecoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxFormaPagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Button btnFazerPagamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalComFrete;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnVoltar;
    }
}