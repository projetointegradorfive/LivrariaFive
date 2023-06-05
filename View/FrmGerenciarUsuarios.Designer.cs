
namespace LivrariaFive.View
{
    partial class FrmGerenciarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarUsuarios));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNomeGerenciarUsuarios = new System.Windows.Forms.TextBox();
            this.txtSenhaGerenciarUsuarios = new System.Windows.Forms.TextBox();
            this.txtIdGerenciarUsuarios = new System.Windows.Forms.TextBox();
            this.lblCpfGerenciarUsuarios = new System.Windows.Forms.Label();
            this.txtEnderecoGerenciarUsuarios = new System.Windows.Forms.TextBox();
            this.lblEnderecoGerenciarUsuarios = new System.Windows.Forms.Label();
            this.lblTelefoneGerenciarUsuarios = new System.Windows.Forms.Label();
            this.lblDataNascimentoGerenciarUsuarios = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimparTextBox = new System.Windows.Forms.Button();
            this.btnExcluirUsuarioGerenciarUsuarios = new System.Windows.Forms.Button();
            this.btnSalvarAlteracoesGerenciarUsuarios = new System.Windows.Forms.Button();
            this.btnNovoUsuarioGerenciarUsuarios = new System.Windows.Forms.Button();
            this.dgvUsuariosGerenciarUsuarios = new System.Windows.Forms.DataGridView();
            this.maskTxtCpfGerenciarUsuarios = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtTelefoneGerenciarUsuarios = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailGerenciarUsuarios = new System.Windows.Forms.TextBox();
            this.lblEmailGerenciarUsuarios = new System.Windows.Forms.Label();
            this.maskTxtDataNascimentoGerenciarUsuarios = new System.Windows.Forms.MaskedTextBox();
            this.lblPesquisaUsuarios = new System.Windows.Forms.Label();
            this.txtPesquisaUsuarios = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosGerenciarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(671, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 50);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome: ";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(9, 100);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 7);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID: ";
            // 
            // txtNomeGerenciarUsuarios
            // 
            this.txtNomeGerenciarUsuarios.Location = new System.Drawing.Point(10, 67);
            this.txtNomeGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeGerenciarUsuarios.Name = "txtNomeGerenciarUsuarios";
            this.txtNomeGerenciarUsuarios.Size = new System.Drawing.Size(181, 20);
            this.txtNomeGerenciarUsuarios.TabIndex = 11;
            // 
            // txtSenhaGerenciarUsuarios
            // 
            this.txtSenhaGerenciarUsuarios.Location = new System.Drawing.Point(9, 116);
            this.txtSenhaGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenhaGerenciarUsuarios.Name = "txtSenhaGerenciarUsuarios";
            this.txtSenhaGerenciarUsuarios.Size = new System.Drawing.Size(182, 20);
            this.txtSenhaGerenciarUsuarios.TabIndex = 12;
            // 
            // txtIdGerenciarUsuarios
            // 
            this.txtIdGerenciarUsuarios.Location = new System.Drawing.Point(11, 24);
            this.txtIdGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdGerenciarUsuarios.Name = "txtIdGerenciarUsuarios";
            this.txtIdGerenciarUsuarios.ReadOnly = true;
            this.txtIdGerenciarUsuarios.Size = new System.Drawing.Size(180, 20);
            this.txtIdGerenciarUsuarios.TabIndex = 13;
            // 
            // lblCpfGerenciarUsuarios
            // 
            this.lblCpfGerenciarUsuarios.AutoSize = true;
            this.lblCpfGerenciarUsuarios.Location = new System.Drawing.Point(9, 158);
            this.lblCpfGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpfGerenciarUsuarios.Name = "lblCpfGerenciarUsuarios";
            this.lblCpfGerenciarUsuarios.Size = new System.Drawing.Size(33, 13);
            this.lblCpfGerenciarUsuarios.TabIndex = 14;
            this.lblCpfGerenciarUsuarios.Text = "CPF: ";
            // 
            // txtEnderecoGerenciarUsuarios
            // 
            this.txtEnderecoGerenciarUsuarios.Location = new System.Drawing.Point(205, 320);
            this.txtEnderecoGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnderecoGerenciarUsuarios.Name = "txtEnderecoGerenciarUsuarios";
            this.txtEnderecoGerenciarUsuarios.Size = new System.Drawing.Size(518, 20);
            this.txtEnderecoGerenciarUsuarios.TabIndex = 17;
            // 
            // lblEnderecoGerenciarUsuarios
            // 
            this.lblEnderecoGerenciarUsuarios.AutoSize = true;
            this.lblEnderecoGerenciarUsuarios.Location = new System.Drawing.Point(202, 303);
            this.lblEnderecoGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnderecoGerenciarUsuarios.Name = "lblEnderecoGerenciarUsuarios";
            this.lblEnderecoGerenciarUsuarios.Size = new System.Drawing.Size(59, 13);
            this.lblEnderecoGerenciarUsuarios.TabIndex = 16;
            this.lblEnderecoGerenciarUsuarios.Text = "Endereço: ";
            // 
            // lblTelefoneGerenciarUsuarios
            // 
            this.lblTelefoneGerenciarUsuarios.AutoSize = true;
            this.lblTelefoneGerenciarUsuarios.Location = new System.Drawing.Point(7, 260);
            this.lblTelefoneGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefoneGerenciarUsuarios.Name = "lblTelefoneGerenciarUsuarios";
            this.lblTelefoneGerenciarUsuarios.Size = new System.Drawing.Size(55, 13);
            this.lblTelefoneGerenciarUsuarios.TabIndex = 18;
            this.lblTelefoneGerenciarUsuarios.Text = "Telefone: ";
            // 
            // lblDataNascimentoGerenciarUsuarios
            // 
            this.lblDataNascimentoGerenciarUsuarios.AutoSize = true;
            this.lblDataNascimentoGerenciarUsuarios.Location = new System.Drawing.Point(7, 217);
            this.lblDataNascimentoGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataNascimentoGerenciarUsuarios.Name = "lblDataNascimentoGerenciarUsuarios";
            this.lblDataNascimentoGerenciarUsuarios.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimentoGerenciarUsuarios.TabIndex = 20;
            this.lblDataNascimentoGerenciarUsuarios.Text = "Data de Nascimento:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimparTextBox);
            this.panel1.Controls.Add(this.btnExcluirUsuarioGerenciarUsuarios);
            this.panel1.Controls.Add(this.btnSalvarAlteracoesGerenciarUsuarios);
            this.panel1.Controls.Add(this.btnNovoUsuarioGerenciarUsuarios);
            this.panel1.Location = new System.Drawing.Point(1, 344);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 71);
            this.panel1.TabIndex = 22;
            // 
            // btnLimparTextBox
            // 
            this.btnLimparTextBox.Location = new System.Drawing.Point(72, 23);
            this.btnLimparTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimparTextBox.Name = "btnLimparTextBox";
            this.btnLimparTextBox.Size = new System.Drawing.Size(95, 26);
            this.btnLimparTextBox.TabIndex = 3;
            this.btnLimparTextBox.Text = "Limpar TextBox";
            this.btnLimparTextBox.UseVisualStyleBackColor = true;
            this.btnLimparTextBox.Click += new System.EventHandler(this.btnLimparTextBox_Click);
            // 
            // btnExcluirUsuarioGerenciarUsuarios
            // 
            this.btnExcluirUsuarioGerenciarUsuarios.Location = new System.Drawing.Point(514, 23);
            this.btnExcluirUsuarioGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluirUsuarioGerenciarUsuarios.Name = "btnExcluirUsuarioGerenciarUsuarios";
            this.btnExcluirUsuarioGerenciarUsuarios.Size = new System.Drawing.Size(117, 26);
            this.btnExcluirUsuarioGerenciarUsuarios.TabIndex = 2;
            this.btnExcluirUsuarioGerenciarUsuarios.Text = "Excluir Usuário";
            this.btnExcluirUsuarioGerenciarUsuarios.UseVisualStyleBackColor = true;
            this.btnExcluirUsuarioGerenciarUsuarios.Click += new System.EventHandler(this.btnExcluirUsuarioGerenciarUsuarios_Click);
            // 
            // btnSalvarAlteracoesGerenciarUsuarios
            // 
            this.btnSalvarAlteracoesGerenciarUsuarios.Location = new System.Drawing.Point(358, 23);
            this.btnSalvarAlteracoesGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvarAlteracoesGerenciarUsuarios.Name = "btnSalvarAlteracoesGerenciarUsuarios";
            this.btnSalvarAlteracoesGerenciarUsuarios.Size = new System.Drawing.Size(117, 26);
            this.btnSalvarAlteracoesGerenciarUsuarios.TabIndex = 1;
            this.btnSalvarAlteracoesGerenciarUsuarios.Text = "Salvar Alterações";
            this.btnSalvarAlteracoesGerenciarUsuarios.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracoesGerenciarUsuarios.Click += new System.EventHandler(this.btnSalvarAlteracoesGerenciarUsuarios_Click);
            // 
            // btnNovoUsuarioGerenciarUsuarios
            // 
            this.btnNovoUsuarioGerenciarUsuarios.Location = new System.Drawing.Point(204, 23);
            this.btnNovoUsuarioGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNovoUsuarioGerenciarUsuarios.Name = "btnNovoUsuarioGerenciarUsuarios";
            this.btnNovoUsuarioGerenciarUsuarios.Size = new System.Drawing.Size(117, 26);
            this.btnNovoUsuarioGerenciarUsuarios.TabIndex = 0;
            this.btnNovoUsuarioGerenciarUsuarios.Text = "Novo Usuário";
            this.btnNovoUsuarioGerenciarUsuarios.UseVisualStyleBackColor = true;
            this.btnNovoUsuarioGerenciarUsuarios.Click += new System.EventHandler(this.btnNovoUsuarioGerenciarUsuarios_Click);
            // 
            // dgvUsuariosGerenciarUsuarios
            // 
            this.dgvUsuariosGerenciarUsuarios.AllowUserToAddRows = false;
            this.dgvUsuariosGerenciarUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuariosGerenciarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosGerenciarUsuarios.Location = new System.Drawing.Point(205, 46);
            this.dgvUsuariosGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsuariosGerenciarUsuarios.Name = "dgvUsuariosGerenciarUsuarios";
            this.dgvUsuariosGerenciarUsuarios.ReadOnly = true;
            this.dgvUsuariosGerenciarUsuarios.RowHeadersWidth = 51;
            this.dgvUsuariosGerenciarUsuarios.RowTemplate.Height = 24;
            this.dgvUsuariosGerenciarUsuarios.Size = new System.Drawing.Size(518, 255);
            this.dgvUsuariosGerenciarUsuarios.TabIndex = 23;
            this.dgvUsuariosGerenciarUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosGerenciarUsuarios_CellClick);
            this.dgvUsuariosGerenciarUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuariosGerenciarUsuarios_SelectionChanged);
            // 
            // maskTxtCpfGerenciarUsuarios
            // 
            this.maskTxtCpfGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskTxtCpfGerenciarUsuarios.Location = new System.Drawing.Point(9, 175);
            this.maskTxtCpfGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskTxtCpfGerenciarUsuarios.Mask = "000,000,000-00";
            this.maskTxtCpfGerenciarUsuarios.Name = "maskTxtCpfGerenciarUsuarios";
            this.maskTxtCpfGerenciarUsuarios.Size = new System.Drawing.Size(182, 26);
            this.maskTxtCpfGerenciarUsuarios.TabIndex = 24;
            this.maskTxtCpfGerenciarUsuarios.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskTxtTelefoneGerenciarUsuarios
            // 
            this.maskTxtTelefoneGerenciarUsuarios.Location = new System.Drawing.Point(11, 276);
            this.maskTxtTelefoneGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskTxtTelefoneGerenciarUsuarios.Mask = "(00) 0 0000-0000 ";
            this.maskTxtTelefoneGerenciarUsuarios.Name = "maskTxtTelefoneGerenciarUsuarios";
            this.maskTxtTelefoneGerenciarUsuarios.Size = new System.Drawing.Size(180, 20);
            this.maskTxtTelefoneGerenciarUsuarios.TabIndex = 25;
            this.maskTxtTelefoneGerenciarUsuarios.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmailGerenciarUsuarios
            // 
            this.txtEmailGerenciarUsuarios.Location = new System.Drawing.Point(11, 322);
            this.txtEmailGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailGerenciarUsuarios.Name = "txtEmailGerenciarUsuarios";
            this.txtEmailGerenciarUsuarios.Size = new System.Drawing.Size(182, 20);
            this.txtEmailGerenciarUsuarios.TabIndex = 27;
            // 
            // lblEmailGerenciarUsuarios
            // 
            this.lblEmailGerenciarUsuarios.AutoSize = true;
            this.lblEmailGerenciarUsuarios.Location = new System.Drawing.Point(9, 306);
            this.lblEmailGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailGerenciarUsuarios.Name = "lblEmailGerenciarUsuarios";
            this.lblEmailGerenciarUsuarios.Size = new System.Drawing.Size(41, 13);
            this.lblEmailGerenciarUsuarios.TabIndex = 26;
            this.lblEmailGerenciarUsuarios.Text = "E-mail: ";
            // 
            // maskTxtDataNascimentoGerenciarUsuarios
            // 
            this.maskTxtDataNascimentoGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskTxtDataNascimentoGerenciarUsuarios.Location = new System.Drawing.Point(9, 233);
            this.maskTxtDataNascimentoGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskTxtDataNascimentoGerenciarUsuarios.Mask = "00/00/0000";
            this.maskTxtDataNascimentoGerenciarUsuarios.Name = "maskTxtDataNascimentoGerenciarUsuarios";
            this.maskTxtDataNascimentoGerenciarUsuarios.Size = new System.Drawing.Size(182, 26);
            this.maskTxtDataNascimentoGerenciarUsuarios.TabIndex = 28;
            this.maskTxtDataNascimentoGerenciarUsuarios.ValidatingType = typeof(System.DateTime);
            // 
            // lblPesquisaUsuarios
            // 
            this.lblPesquisaUsuarios.AutoSize = true;
            this.lblPesquisaUsuarios.Location = new System.Drawing.Point(202, 7);
            this.lblPesquisaUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisaUsuarios.Name = "lblPesquisaUsuarios";
            this.lblPesquisaUsuarios.Size = new System.Drawing.Size(103, 13);
            this.lblPesquisaUsuarios.TabIndex = 29;
            this.lblPesquisaUsuarios.Text = "Pesquisar Usuários: ";
            // 
            // txtPesquisaUsuarios
            // 
            this.txtPesquisaUsuarios.Location = new System.Drawing.Point(205, 24);
            this.txtPesquisaUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPesquisaUsuarios.Name = "txtPesquisaUsuarios";
            this.txtPesquisaUsuarios.Size = new System.Drawing.Size(462, 20);
            this.txtPesquisaUsuarios.TabIndex = 30;
            this.txtPesquisaUsuarios.TextChanged += new System.EventHandler(this.txtPesquisaUsuarios_TextChanged);
            // 
            // FrmGerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 413);
            this.Controls.Add(this.txtPesquisaUsuarios);
            this.Controls.Add(this.lblPesquisaUsuarios);
            this.Controls.Add(this.maskTxtDataNascimentoGerenciarUsuarios);
            this.Controls.Add(this.txtEmailGerenciarUsuarios);
            this.Controls.Add(this.lblEmailGerenciarUsuarios);
            this.Controls.Add(this.maskTxtTelefoneGerenciarUsuarios);
            this.Controls.Add(this.maskTxtCpfGerenciarUsuarios);
            this.Controls.Add(this.dgvUsuariosGerenciarUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDataNascimentoGerenciarUsuarios);
            this.Controls.Add(this.lblTelefoneGerenciarUsuarios);
            this.Controls.Add(this.txtEnderecoGerenciarUsuarios);
            this.Controls.Add(this.lblEnderecoGerenciarUsuarios);
            this.Controls.Add(this.lblCpfGerenciarUsuarios);
            this.Controls.Add(this.txtIdGerenciarUsuarios);
            this.Controls.Add(this.txtSenhaGerenciarUsuarios);
            this.Controls.Add(this.txtNomeGerenciarUsuarios);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGerenciarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGerenciarUsuarios";
            this.Load += new System.EventHandler(this.FrmGerenciarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosGerenciarUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNomeGerenciarUsuarios;
        private System.Windows.Forms.TextBox txtSenhaGerenciarUsuarios;
        private System.Windows.Forms.TextBox txtIdGerenciarUsuarios;
        private System.Windows.Forms.Label lblCpfGerenciarUsuarios;
        private System.Windows.Forms.TextBox txtEnderecoGerenciarUsuarios;
        private System.Windows.Forms.Label lblEnderecoGerenciarUsuarios;
        private System.Windows.Forms.Label lblTelefoneGerenciarUsuarios;
        private System.Windows.Forms.Label lblDataNascimentoGerenciarUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluirUsuarioGerenciarUsuarios;
        private System.Windows.Forms.Button btnSalvarAlteracoesGerenciarUsuarios;
        private System.Windows.Forms.Button btnNovoUsuarioGerenciarUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuariosGerenciarUsuarios;
        private System.Windows.Forms.MaskedTextBox maskTxtCpfGerenciarUsuarios;
        private System.Windows.Forms.MaskedTextBox maskTxtTelefoneGerenciarUsuarios;
        private System.Windows.Forms.TextBox txtEmailGerenciarUsuarios;
        private System.Windows.Forms.Label lblEmailGerenciarUsuarios;
        private System.Windows.Forms.MaskedTextBox maskTxtDataNascimentoGerenciarUsuarios;
        private System.Windows.Forms.Button btnLimparTextBox;
        private System.Windows.Forms.Label lblPesquisaUsuarios;
        private System.Windows.Forms.TextBox txtPesquisaUsuarios;
    }
}