﻿
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
            this.txtDataNascimentoGerenciarUsuarios = new System.Windows.Forms.TextBox();
            this.lblDataNascimentoGerenciarUsuarios = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluirUsuarioGerenciarUsuarios = new System.Windows.Forms.Button();
            this.btnSalvarAlteracoesGerenciarUsuarios = new System.Windows.Forms.Button();
            this.btnNovoUsuarioGerenciarUsuarios = new System.Windows.Forms.Button();
            this.dgvUsuariosGerenciarUsuarios = new System.Windows.Forms.DataGridView();
            this.maskTxtCpfGerenciarUsuarios = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtTelefoneGerenciarUsuarios = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailGerenciarUsuarios = new System.Windows.Forms.TextBox();
            this.lblEmailGerenciarUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosGerenciarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(895, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 17);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome: ";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 123);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 17);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 17);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID: ";
            // 
            // txtNomeGerenciarUsuarios
            // 
            this.txtNomeGerenciarUsuarios.Location = new System.Drawing.Point(13, 82);
            this.txtNomeGerenciarUsuarios.Name = "txtNomeGerenciarUsuarios";
            this.txtNomeGerenciarUsuarios.Size = new System.Drawing.Size(240, 22);
            this.txtNomeGerenciarUsuarios.TabIndex = 11;
            // 
            // txtSenhaGerenciarUsuarios
            // 
            this.txtSenhaGerenciarUsuarios.Location = new System.Drawing.Point(12, 143);
            this.txtSenhaGerenciarUsuarios.Name = "txtSenhaGerenciarUsuarios";
            this.txtSenhaGerenciarUsuarios.Size = new System.Drawing.Size(241, 22);
            this.txtSenhaGerenciarUsuarios.TabIndex = 12;
            // 
            // txtIdGerenciarUsuarios
            // 
            this.txtIdGerenciarUsuarios.Location = new System.Drawing.Point(15, 29);
            this.txtIdGerenciarUsuarios.Name = "txtIdGerenciarUsuarios";
            this.txtIdGerenciarUsuarios.ReadOnly = true;
            this.txtIdGerenciarUsuarios.Size = new System.Drawing.Size(238, 22);
            this.txtIdGerenciarUsuarios.TabIndex = 13;
            // 
            // lblCpfGerenciarUsuarios
            // 
            this.lblCpfGerenciarUsuarios.AutoSize = true;
            this.lblCpfGerenciarUsuarios.Location = new System.Drawing.Point(12, 195);
            this.lblCpfGerenciarUsuarios.Name = "lblCpfGerenciarUsuarios";
            this.lblCpfGerenciarUsuarios.Size = new System.Drawing.Size(42, 17);
            this.lblCpfGerenciarUsuarios.TabIndex = 14;
            this.lblCpfGerenciarUsuarios.Text = "CPF: ";
            // 
            // txtEnderecoGerenciarUsuarios
            // 
            this.txtEnderecoGerenciarUsuarios.Location = new System.Drawing.Point(273, 29);
            this.txtEnderecoGerenciarUsuarios.Name = "txtEnderecoGerenciarUsuarios";
            this.txtEnderecoGerenciarUsuarios.Size = new System.Drawing.Size(516, 22);
            this.txtEnderecoGerenciarUsuarios.TabIndex = 17;
            // 
            // lblEnderecoGerenciarUsuarios
            // 
            this.lblEnderecoGerenciarUsuarios.AutoSize = true;
            this.lblEnderecoGerenciarUsuarios.Location = new System.Drawing.Point(273, 9);
            this.lblEnderecoGerenciarUsuarios.Name = "lblEnderecoGerenciarUsuarios";
            this.lblEnderecoGerenciarUsuarios.Size = new System.Drawing.Size(77, 17);
            this.lblEnderecoGerenciarUsuarios.TabIndex = 16;
            this.lblEnderecoGerenciarUsuarios.Text = "Endereço: ";
            // 
            // lblTelefoneGerenciarUsuarios
            // 
            this.lblTelefoneGerenciarUsuarios.AutoSize = true;
            this.lblTelefoneGerenciarUsuarios.Location = new System.Drawing.Point(9, 320);
            this.lblTelefoneGerenciarUsuarios.Name = "lblTelefoneGerenciarUsuarios";
            this.lblTelefoneGerenciarUsuarios.Size = new System.Drawing.Size(72, 17);
            this.lblTelefoneGerenciarUsuarios.TabIndex = 18;
            this.lblTelefoneGerenciarUsuarios.Text = "Telefone: ";
            // 
            // txtDataNascimentoGerenciarUsuarios
            // 
            this.txtDataNascimentoGerenciarUsuarios.Location = new System.Drawing.Point(12, 287);
            this.txtDataNascimentoGerenciarUsuarios.Name = "txtDataNascimentoGerenciarUsuarios";
            this.txtDataNascimentoGerenciarUsuarios.Size = new System.Drawing.Size(241, 22);
            this.txtDataNascimentoGerenciarUsuarios.TabIndex = 21;
            // 
            // lblDataNascimentoGerenciarUsuarios
            // 
            this.lblDataNascimentoGerenciarUsuarios.AutoSize = true;
            this.lblDataNascimentoGerenciarUsuarios.Location = new System.Drawing.Point(9, 267);
            this.lblDataNascimentoGerenciarUsuarios.Name = "lblDataNascimentoGerenciarUsuarios";
            this.lblDataNascimentoGerenciarUsuarios.Size = new System.Drawing.Size(140, 17);
            this.lblDataNascimentoGerenciarUsuarios.TabIndex = 20;
            this.lblDataNascimentoGerenciarUsuarios.Text = "Data de Nascimento:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluirUsuarioGerenciarUsuarios);
            this.panel1.Controls.Add(this.btnSalvarAlteracoesGerenciarUsuarios);
            this.panel1.Controls.Add(this.btnNovoUsuarioGerenciarUsuarios);
            this.panel1.Location = new System.Drawing.Point(1, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 87);
            this.panel1.TabIndex = 22;
            // 
            // btnExcluirUsuarioGerenciarUsuarios
            // 
            this.btnExcluirUsuarioGerenciarUsuarios.Location = new System.Drawing.Point(632, 30);
            this.btnExcluirUsuarioGerenciarUsuarios.Name = "btnExcluirUsuarioGerenciarUsuarios";
            this.btnExcluirUsuarioGerenciarUsuarios.Size = new System.Drawing.Size(156, 32);
            this.btnExcluirUsuarioGerenciarUsuarios.TabIndex = 2;
            this.btnExcluirUsuarioGerenciarUsuarios.Text = "Excluir Usuário";
            this.btnExcluirUsuarioGerenciarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnSalvarAlteracoesGerenciarUsuarios
            // 
            this.btnSalvarAlteracoesGerenciarUsuarios.Location = new System.Drawing.Point(407, 30);
            this.btnSalvarAlteracoesGerenciarUsuarios.Name = "btnSalvarAlteracoesGerenciarUsuarios";
            this.btnSalvarAlteracoesGerenciarUsuarios.Size = new System.Drawing.Size(156, 32);
            this.btnSalvarAlteracoesGerenciarUsuarios.TabIndex = 1;
            this.btnSalvarAlteracoesGerenciarUsuarios.Text = "Salvar Alterações";
            this.btnSalvarAlteracoesGerenciarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnNovoUsuarioGerenciarUsuarios
            // 
            this.btnNovoUsuarioGerenciarUsuarios.Location = new System.Drawing.Point(193, 30);
            this.btnNovoUsuarioGerenciarUsuarios.Name = "btnNovoUsuarioGerenciarUsuarios";
            this.btnNovoUsuarioGerenciarUsuarios.Size = new System.Drawing.Size(156, 32);
            this.btnNovoUsuarioGerenciarUsuarios.TabIndex = 0;
            this.btnNovoUsuarioGerenciarUsuarios.Text = "Novo Usuário";
            this.btnNovoUsuarioGerenciarUsuarios.UseVisualStyleBackColor = true;
            // 
            // dgvUsuariosGerenciarUsuarios
            // 
            this.dgvUsuariosGerenciarUsuarios.AllowUserToAddRows = false;
            this.dgvUsuariosGerenciarUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuariosGerenciarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosGerenciarUsuarios.Location = new System.Drawing.Point(273, 57);
            this.dgvUsuariosGerenciarUsuarios.Name = "dgvUsuariosGerenciarUsuarios";
            this.dgvUsuariosGerenciarUsuarios.ReadOnly = true;
            this.dgvUsuariosGerenciarUsuarios.RowHeadersWidth = 51;
            this.dgvUsuariosGerenciarUsuarios.RowTemplate.Height = 24;
            this.dgvUsuariosGerenciarUsuarios.Size = new System.Drawing.Size(691, 314);
            this.dgvUsuariosGerenciarUsuarios.TabIndex = 23;
            this.dgvUsuariosGerenciarUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuariosGerenciarUsuarios_SelectionChanged);
            // 
            // maskTxtCpfGerenciarUsuarios
            // 
            this.maskTxtCpfGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskTxtCpfGerenciarUsuarios.Location = new System.Drawing.Point(12, 215);
            this.maskTxtCpfGerenciarUsuarios.Mask = "000,000,000-00";
            this.maskTxtCpfGerenciarUsuarios.Name = "maskTxtCpfGerenciarUsuarios";
            this.maskTxtCpfGerenciarUsuarios.Size = new System.Drawing.Size(241, 30);
            this.maskTxtCpfGerenciarUsuarios.TabIndex = 24;
            this.maskTxtCpfGerenciarUsuarios.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskTxtTelefoneGerenciarUsuarios
            // 
            this.maskTxtTelefoneGerenciarUsuarios.Location = new System.Drawing.Point(15, 340);
            this.maskTxtTelefoneGerenciarUsuarios.Mask = "(00) 0 0000-0000 ";
            this.maskTxtTelefoneGerenciarUsuarios.Name = "maskTxtTelefoneGerenciarUsuarios";
            this.maskTxtTelefoneGerenciarUsuarios.Size = new System.Drawing.Size(238, 22);
            this.maskTxtTelefoneGerenciarUsuarios.TabIndex = 25;
            this.maskTxtTelefoneGerenciarUsuarios.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmailGerenciarUsuarios
            // 
            this.txtEmailGerenciarUsuarios.Location = new System.Drawing.Point(15, 396);
            this.txtEmailGerenciarUsuarios.Name = "txtEmailGerenciarUsuarios";
            this.txtEmailGerenciarUsuarios.Size = new System.Drawing.Size(241, 22);
            this.txtEmailGerenciarUsuarios.TabIndex = 27;
            // 
            // lblEmailGerenciarUsuarios
            // 
            this.lblEmailGerenciarUsuarios.AutoSize = true;
            this.lblEmailGerenciarUsuarios.Location = new System.Drawing.Point(12, 376);
            this.lblEmailGerenciarUsuarios.Name = "lblEmailGerenciarUsuarios";
            this.lblEmailGerenciarUsuarios.Size = new System.Drawing.Size(55, 17);
            this.lblEmailGerenciarUsuarios.TabIndex = 26;
            this.lblEmailGerenciarUsuarios.Text = "E-mail: ";
            // 
            // FrmGerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 508);
            this.Controls.Add(this.txtEmailGerenciarUsuarios);
            this.Controls.Add(this.lblEmailGerenciarUsuarios);
            this.Controls.Add(this.maskTxtTelefoneGerenciarUsuarios);
            this.Controls.Add(this.maskTxtCpfGerenciarUsuarios);
            this.Controls.Add(this.dgvUsuariosGerenciarUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDataNascimentoGerenciarUsuarios);
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
        private System.Windows.Forms.TextBox txtDataNascimentoGerenciarUsuarios;
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
    }
}