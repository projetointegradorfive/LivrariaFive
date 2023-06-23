namespace LivrariaFive.View
{
    partial class FormPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfilUsuario));
            this.maskTxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailGerenciarUsuarios = new System.Windows.Forms.Label();
            this.maskTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascimentoGerenciarUsuarios = new System.Windows.Forms.Label();
            this.lblTelefoneGerenciarUsuarios = new System.Windows.Forms.Label();
            this.lblCpfGerenciarUsuarios = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEnderecoGerenciarUsuarios = new System.Windows.Forms.Label();
            this.btnMeusPedidos = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblWelcomeUsuario = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // maskTxtDataNascimento
            // 
            this.maskTxtDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxtDataNascimento.Enabled = false;
            this.maskTxtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTxtDataNascimento.Location = new System.Drawing.Point(440, 278);
            this.maskTxtDataNascimento.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.maskTxtDataNascimento.Mask = "00/00/0000";
            this.maskTxtDataNascimento.Name = "maskTxtDataNascimento";
            this.maskTxtDataNascimento.Size = new System.Drawing.Size(322, 29);
            this.maskTxtDataNascimento.TabIndex = 40;
            this.maskTxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(71, 397);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(322, 29);
            this.txtEmail.TabIndex = 39;
            // 
            // lblEmailGerenciarUsuarios
            // 
            this.lblEmailGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailGerenciarUsuarios.AutoSize = true;
            this.lblEmailGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailGerenciarUsuarios.Location = new System.Drawing.Point(66, 373);
            this.lblEmailGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailGerenciarUsuarios.Name = "lblEmailGerenciarUsuarios";
            this.lblEmailGerenciarUsuarios.Size = new System.Drawing.Size(73, 24);
            this.lblEmailGerenciarUsuarios.TabIndex = 38;
            this.lblEmailGerenciarUsuarios.Text = "E-mail: ";
            // 
            // maskTxtTelefone
            // 
            this.maskTxtTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTxtTelefone.Location = new System.Drawing.Point(443, 341);
            this.maskTxtTelefone.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.maskTxtTelefone.Mask = "(00) 0 0000-0000 ";
            this.maskTxtTelefone.Name = "maskTxtTelefone";
            this.maskTxtTelefone.Size = new System.Drawing.Size(320, 29);
            this.maskTxtTelefone.TabIndex = 37;
            this.maskTxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskTxtCpf
            // 
            this.maskTxtCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxtCpf.Enabled = false;
            this.maskTxtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTxtCpf.Location = new System.Drawing.Point(72, 462);
            this.maskTxtCpf.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.maskTxtCpf.Mask = "000,000,000-00";
            this.maskTxtCpf.Name = "maskTxtCpf";
            this.maskTxtCpf.Size = new System.Drawing.Size(322, 29);
            this.maskTxtCpf.TabIndex = 36;
            this.maskTxtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblDataNascimentoGerenciarUsuarios
            // 
            this.lblDataNascimentoGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataNascimentoGerenciarUsuarios.AutoSize = true;
            this.lblDataNascimentoGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimentoGerenciarUsuarios.Location = new System.Drawing.Point(435, 254);
            this.lblDataNascimentoGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataNascimentoGerenciarUsuarios.Name = "lblDataNascimentoGerenciarUsuarios";
            this.lblDataNascimentoGerenciarUsuarios.Size = new System.Drawing.Size(184, 24);
            this.lblDataNascimentoGerenciarUsuarios.TabIndex = 35;
            this.lblDataNascimentoGerenciarUsuarios.Text = "Data de Nascimento:";
            // 
            // lblTelefoneGerenciarUsuarios
            // 
            this.lblTelefoneGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefoneGerenciarUsuarios.AutoSize = true;
            this.lblTelefoneGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneGerenciarUsuarios.Location = new System.Drawing.Point(436, 317);
            this.lblTelefoneGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefoneGerenciarUsuarios.Name = "lblTelefoneGerenciarUsuarios";
            this.lblTelefoneGerenciarUsuarios.Size = new System.Drawing.Size(95, 24);
            this.lblTelefoneGerenciarUsuarios.TabIndex = 34;
            this.lblTelefoneGerenciarUsuarios.Text = "Telefone: ";
            // 
            // lblCpfGerenciarUsuarios
            // 
            this.lblCpfGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCpfGerenciarUsuarios.AutoSize = true;
            this.lblCpfGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfGerenciarUsuarios.Location = new System.Drawing.Point(69, 437);
            this.lblCpfGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpfGerenciarUsuarios.Name = "lblCpfGerenciarUsuarios";
            this.lblCpfGerenciarUsuarios.Size = new System.Drawing.Size(57, 24);
            this.lblCpfGerenciarUsuarios.TabIndex = 33;
            this.lblCpfGerenciarUsuarios.Text = "CPF: ";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(71, 338);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(322, 29);
            this.txtSenha.TabIndex = 32;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(72, 278);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(321, 29);
            this.txtNome.TabIndex = 31;
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(68, 314);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(75, 24);
            this.lblSenha.TabIndex = 30;
            this.lblSenha.Text = "Senha: ";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(68, 253);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(72, 24);
            this.lblNome.TabIndex = 29;
            this.lblNome.Text = "Nome: ";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(443, 406);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(320, 29);
            this.txtEndereco.TabIndex = 42;
            // 
            // lblEnderecoGerenciarUsuarios
            // 
            this.lblEnderecoGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnderecoGerenciarUsuarios.AutoSize = true;
            this.lblEnderecoGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoGerenciarUsuarios.Location = new System.Drawing.Point(437, 381);
            this.lblEnderecoGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnderecoGerenciarUsuarios.Name = "lblEnderecoGerenciarUsuarios";
            this.lblEnderecoGerenciarUsuarios.Size = new System.Drawing.Size(104, 24);
            this.lblEnderecoGerenciarUsuarios.TabIndex = 41;
            this.lblEnderecoGerenciarUsuarios.Text = "Endereço: ";
            // 
            // btnMeusPedidos
            // 
            this.btnMeusPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMeusPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeusPedidos.Location = new System.Drawing.Point(679, 12);
            this.btnMeusPedidos.Name = "btnMeusPedidos";
            this.btnMeusPedidos.Size = new System.Drawing.Size(176, 34);
            this.btnMeusPedidos.TabIndex = 44;
            this.btnMeusPedidos.Text = "Meus Pedidos";
            this.btnMeusPedidos.UseVisualStyleBackColor = true;
            this.btnMeusPedidos.Click += new System.EventHandler(this.btnMeusPedidos_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(479, 462);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(204, 34);
            this.btnAtualizar.TabIndex = 45;
            this.btnAtualizar.Text = "Atualizar Meus Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(398, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 34);
            this.button1.TabIndex = 46;
            this.button1.Text = "Voltar para Página Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(289, 126);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(79, 25);
            this.lblNomeUsuario.TabIndex = 48;
            this.lblNomeUsuario.Text = "Cliente";
            // 
            // lblWelcomeUsuario
            // 
            this.lblWelcomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUsuario.Location = new System.Drawing.Point(144, 126);
            this.lblWelcomeUsuario.Name = "lblWelcomeUsuario";
            this.lblWelcomeUsuario.Size = new System.Drawing.Size(149, 32);
            this.lblWelcomeUsuario.TabIndex = 47;
            this.lblWelcomeUsuario.Text = "Bem Vindo(a),";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label15.Font = new System.Drawing.Font("Ink Free", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(66, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 36);
            this.label15.TabIndex = 52;
            this.label15.Text = "Five Books";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label14.Location = new System.Drawing.Point(-5, -5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(912, 82);
            this.label14.TabIndex = 50;
            // 
            // FormPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 574);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.lblWelcomeUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnMeusPedidos);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEnderecoGerenciarUsuarios);
            this.Controls.Add(this.maskTxtDataNascimento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmailGerenciarUsuarios);
            this.Controls.Add(this.maskTxtTelefone);
            this.Controls.Add(this.maskTxtCpf);
            this.Controls.Add(this.lblDataNascimentoGerenciarUsuarios);
            this.Controls.Add(this.lblTelefoneGerenciarUsuarios);
            this.Controls.Add(this.lblCpfGerenciarUsuarios);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label14);
            this.Name = "FormPerfilUsuario";
            this.Text = "FormPerfilUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPerfilUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskTxtDataNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailGerenciarUsuarios;
        private System.Windows.Forms.MaskedTextBox maskTxtTelefone;
        private System.Windows.Forms.MaskedTextBox maskTxtCpf;
        private System.Windows.Forms.Label lblDataNascimentoGerenciarUsuarios;
        private System.Windows.Forms.Label lblTelefoneGerenciarUsuarios;
        private System.Windows.Forms.Label lblCpfGerenciarUsuarios;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEnderecoGerenciarUsuarios;
        private System.Windows.Forms.Button btnMeusPedidos;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblWelcomeUsuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label14;
    }
}