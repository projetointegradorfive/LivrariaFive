namespace LivrariaFive.View
{
    partial class FormPagamentoCartao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagamentoCartao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeTitular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxParcelaCartão = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnFazerPagamento = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MskCvv = new System.Windows.Forms.MaskedTextBox();
            this.MskValidade = new System.Windows.Forms.MaskedTextBox();
            this.MskNumCartao = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelarPagamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(747, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do titular:";
            // 
            // TxtNomeTitular
            // 
            this.TxtNomeTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeTitular.Location = new System.Drawing.Point(79, 47);
            this.TxtNomeTitular.Name = "TxtNomeTitular";
            this.TxtNomeTitular.Size = new System.Drawing.Size(278, 29);
            this.TxtNomeTitular.TabIndex = 2;
            this.TxtNomeTitular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeTitular_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número do Cartão:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Validade (MM/AAAA):";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "CVV:";
            // 
            // cboxParcelaCartão
            // 
            this.cboxParcelaCartão.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxParcelaCartão.DropDownWidth = 277;
            this.cboxParcelaCartão.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxParcelaCartão.FormattingEnabled = true;
            this.cboxParcelaCartão.ItemHeight = 24;
            this.cboxParcelaCartão.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x"});
            this.cboxParcelaCartão.Location = new System.Drawing.Point(403, 143);
            this.cboxParcelaCartão.MinimumSize = new System.Drawing.Size(277, 0);
            this.cboxParcelaCartão.Name = "cboxParcelaCartão";
            this.cboxParcelaCartão.Size = new System.Drawing.Size(277, 32);
            this.cboxParcelaCartão.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parcela:";
            // 
            // BtnFazerPagamento
            // 
            this.BtnFazerPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFazerPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFazerPagamento.Location = new System.Drawing.Point(554, 404);
            this.BtnFazerPagamento.Name = "BtnFazerPagamento";
            this.BtnFazerPagamento.Size = new System.Drawing.Size(215, 34);
            this.BtnFazerPagamento.TabIndex = 11;
            this.BtnFazerPagamento.Text = "Fazer Pagamento";
            this.BtnFazerPagamento.UseVisualStyleBackColor = true;
            this.BtnFazerPagamento.Click += new System.EventHandler(this.BtnFazerPagamento_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.MskCvv);
            this.panel1.Controls.Add(this.MskValidade);
            this.panel1.Controls.Add(this.MskNumCartao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboxParcelaCartão);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtNomeTitular);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 275);
            this.panel1.TabIndex = 12;
            // 
            // MskCvv
            // 
            this.MskCvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskCvv.Location = new System.Drawing.Point(403, 53);
            this.MskCvv.Margin = new System.Windows.Forms.Padding(2);
            this.MskCvv.Mask = "000";
            this.MskCvv.Name = "MskCvv";
            this.MskCvv.PromptChar = '0';
            this.MskCvv.Size = new System.Drawing.Size(72, 29);
            this.MskCvv.TabIndex = 15;
            // 
            // MskValidade
            // 
            this.MskValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskValidade.Location = new System.Drawing.Point(79, 244);
            this.MskValidade.Margin = new System.Windows.Forms.Padding(2);
            this.MskValidade.Mask = "00/0000";
            this.MskValidade.Name = "MskValidade";
            this.MskValidade.PromptChar = '0';
            this.MskValidade.Size = new System.Drawing.Size(75, 29);
            this.MskValidade.TabIndex = 14;
            this.MskValidade.ValidatingType = typeof(System.DateTime);
            // 
            // MskNumCartao
            // 
            this.MskNumCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskNumCartao.Location = new System.Drawing.Point(79, 149);
            this.MskNumCartao.Margin = new System.Windows.Forms.Padding(2);
            this.MskNumCartao.Mask = "0000 0000 0000 0000";
            this.MskNumCartao.Name = "MskNumCartao";
            this.MskNumCartao.PromptChar = '0';
            this.MskNumCartao.Size = new System.Drawing.Size(278, 29);
            this.MskNumCartao.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnCancelarPagamento);
            this.panel2.Location = new System.Drawing.Point(22, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 45);
            this.panel2.TabIndex = 13;
            // 
            // btnCancelarPagamento
            // 
            this.btnCancelarPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPagamento.Location = new System.Drawing.Point(3, 3);
            this.btnCancelarPagamento.Name = "btnCancelarPagamento";
            this.btnCancelarPagamento.Size = new System.Drawing.Size(215, 34);
            this.btnCancelarPagamento.TabIndex = 12;
            this.btnCancelarPagamento.Text = "Cancelar Pagamento";
            this.btnCancelarPagamento.UseVisualStyleBackColor = true;
            this.btnCancelarPagamento.Click += new System.EventHandler(this.btnCancelarPagamento_Click);
            // 
            // FormPagamentoCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnFazerPagamento);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "FormPagamentoCartao";
            this.Text = "FormPagamentoCartao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeTitular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxParcelaCartão;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnFazerPagamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox MskNumCartao;
        private System.Windows.Forms.MaskedTextBox MskValidade;
        private System.Windows.Forms.MaskedTextBox MskCvv;
        private System.Windows.Forms.Button btnCancelarPagamento;
    }
}