
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
            this.dgvUsuariosGerenciarUsuarios = new System.Windows.Forms.DataGridView();
            this.maskTxtCpfGerenciarUsuarios = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtTelefoneGerenciarUsuarios = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailGerenciarUsuarios = new System.Windows.Forms.TextBox();
            this.lblEmailGerenciarUsuarios = new System.Windows.Forms.Label();
            this.maskTxtDataNascimentoGerenciarUsuarios = new System.Windows.Forms.MaskedTextBox();
            this.lblPesquisaUsuarios = new System.Windows.Forms.Label();
            this.txtPesquisaUsuarios = new System.Windows.Forms.TextBox();
            this.btnNovoUsuarioGerenciarUsuarios = new System.Windows.Forms.Button();
            this.btnSalvarAlteracoesGerenciarUsuarios = new System.Windows.Forms.Button();
            this.btnExcluirUsuarioGerenciarUsuarios = new System.Windows.Forms.Button();
            this.btnLimparTextBox = new System.Windows.Forms.Button();
            this.btnAtivarConta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosGerenciarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1324, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(32, 206);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 25);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome: ";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(35, 273);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(80, 25);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha: ";
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(33, 135);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 25);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID: ";
            // 
            // txtNomeGerenciarUsuarios
            // 
            this.txtNomeGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeGerenciarUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGerenciarUsuarios.Location = new System.Drawing.Point(33, 226);
            this.txtNomeGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtNomeGerenciarUsuarios.Name = "txtNomeGerenciarUsuarios";
            this.txtNomeGerenciarUsuarios.Size = new System.Drawing.Size(240, 30);
            this.txtNomeGerenciarUsuarios.TabIndex = 11;
            // 
            // txtSenhaGerenciarUsuarios
            // 
            this.txtSenhaGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaGerenciarUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaGerenciarUsuarios.Location = new System.Drawing.Point(35, 293);
            this.txtSenhaGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtSenhaGerenciarUsuarios.Name = "txtSenhaGerenciarUsuarios";
            this.txtSenhaGerenciarUsuarios.Size = new System.Drawing.Size(241, 30);
            this.txtSenhaGerenciarUsuarios.TabIndex = 12;
            // 
            // txtIdGerenciarUsuarios
            // 
            this.txtIdGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdGerenciarUsuarios.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdGerenciarUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGerenciarUsuarios.Location = new System.Drawing.Point(36, 156);
            this.txtIdGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtIdGerenciarUsuarios.Name = "txtIdGerenciarUsuarios";
            this.txtIdGerenciarUsuarios.ReadOnly = true;
            this.txtIdGerenciarUsuarios.Size = new System.Drawing.Size(239, 30);
            this.txtIdGerenciarUsuarios.TabIndex = 13;
            // 
            // lblCpfGerenciarUsuarios
            // 
            this.lblCpfGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCpfGerenciarUsuarios.AutoSize = true;
            this.lblCpfGerenciarUsuarios.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfGerenciarUsuarios.Location = new System.Drawing.Point(32, 335);
            this.lblCpfGerenciarUsuarios.Name = "lblCpfGerenciarUsuarios";
            this.lblCpfGerenciarUsuarios.Size = new System.Drawing.Size(61, 25);
            this.lblCpfGerenciarUsuarios.TabIndex = 14;
            this.lblCpfGerenciarUsuarios.Text = "CPF: ";
            // 
            // txtEnderecoGerenciarUsuarios
            // 
            this.txtEnderecoGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnderecoGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoGerenciarUsuarios.Location = new System.Drawing.Point(337, 640);
            this.txtEnderecoGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnderecoGerenciarUsuarios.Name = "txtEnderecoGerenciarUsuarios";
            this.txtEnderecoGerenciarUsuarios.Size = new System.Drawing.Size(689, 29);
            this.txtEnderecoGerenciarUsuarios.TabIndex = 17;
            // 
            // lblEnderecoGerenciarUsuarios
            // 
            this.lblEnderecoGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnderecoGerenciarUsuarios.AutoSize = true;
            this.lblEnderecoGerenciarUsuarios.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblEnderecoGerenciarUsuarios.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoGerenciarUsuarios.Location = new System.Drawing.Point(333, 618);
            this.lblEnderecoGerenciarUsuarios.Name = "lblEnderecoGerenciarUsuarios";
            this.lblEnderecoGerenciarUsuarios.Size = new System.Drawing.Size(105, 25);
            this.lblEnderecoGerenciarUsuarios.TabIndex = 16;
            this.lblEnderecoGerenciarUsuarios.Text = "Endereço: ";
            // 
            // lblTelefoneGerenciarUsuarios
            // 
            this.lblTelefoneGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefoneGerenciarUsuarios.AutoSize = true;
            this.lblTelefoneGerenciarUsuarios.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneGerenciarUsuarios.Location = new System.Drawing.Point(28, 468);
            this.lblTelefoneGerenciarUsuarios.Name = "lblTelefoneGerenciarUsuarios";
            this.lblTelefoneGerenciarUsuarios.Size = new System.Drawing.Size(103, 25);
            this.lblTelefoneGerenciarUsuarios.TabIndex = 18;
            this.lblTelefoneGerenciarUsuarios.Text = "Telefone: ";
            // 
            // lblDataNascimentoGerenciarUsuarios
            // 
            this.lblDataNascimentoGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataNascimentoGerenciarUsuarios.AutoSize = true;
            this.lblDataNascimentoGerenciarUsuarios.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimentoGerenciarUsuarios.Location = new System.Drawing.Point(29, 400);
            this.lblDataNascimentoGerenciarUsuarios.Name = "lblDataNascimentoGerenciarUsuarios";
            this.lblDataNascimentoGerenciarUsuarios.Size = new System.Drawing.Size(208, 25);
            this.lblDataNascimentoGerenciarUsuarios.TabIndex = 20;
            this.lblDataNascimentoGerenciarUsuarios.Text = "Data de Nascimento:";
            // 
            // dgvUsuariosGerenciarUsuarios
            // 
            this.dgvUsuariosGerenciarUsuarios.AllowUserToAddRows = false;
            this.dgvUsuariosGerenciarUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuariosGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsuariosGerenciarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosGerenciarUsuarios.Location = new System.Drawing.Point(337, 92);
            this.dgvUsuariosGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuariosGerenciarUsuarios.Name = "dgvUsuariosGerenciarUsuarios";
            this.dgvUsuariosGerenciarUsuarios.ReadOnly = true;
            this.dgvUsuariosGerenciarUsuarios.RowHeadersWidth = 51;
            this.dgvUsuariosGerenciarUsuarios.RowTemplate.Height = 24;
            this.dgvUsuariosGerenciarUsuarios.Size = new System.Drawing.Size(1049, 511);
            this.dgvUsuariosGerenciarUsuarios.TabIndex = 23;
            this.dgvUsuariosGerenciarUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosGerenciarUsuarios_CellClick);
            this.dgvUsuariosGerenciarUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuariosGerenciarUsuarios_SelectionChanged);
            // 
            // maskTxtCpfGerenciarUsuarios
            // 
            this.maskTxtCpfGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxtCpfGerenciarUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTxtCpfGerenciarUsuarios.Location = new System.Drawing.Point(32, 356);
            this.maskTxtCpfGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.maskTxtCpfGerenciarUsuarios.Mask = "000,000,000-00";
            this.maskTxtCpfGerenciarUsuarios.Name = "maskTxtCpfGerenciarUsuarios";
            this.maskTxtCpfGerenciarUsuarios.Size = new System.Drawing.Size(241, 30);
            this.maskTxtCpfGerenciarUsuarios.TabIndex = 24;
            this.maskTxtCpfGerenciarUsuarios.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskTxtTelefoneGerenciarUsuarios
            // 
            this.maskTxtTelefoneGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxtTelefoneGerenciarUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTxtTelefoneGerenciarUsuarios.Location = new System.Drawing.Point(33, 489);
            this.maskTxtTelefoneGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.maskTxtTelefoneGerenciarUsuarios.Mask = "(00) 0 0000-0000 ";
            this.maskTxtTelefoneGerenciarUsuarios.Name = "maskTxtTelefoneGerenciarUsuarios";
            this.maskTxtTelefoneGerenciarUsuarios.Size = new System.Drawing.Size(239, 30);
            this.maskTxtTelefoneGerenciarUsuarios.TabIndex = 25;
            this.maskTxtTelefoneGerenciarUsuarios.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmailGerenciarUsuarios
            // 
            this.txtEmailGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailGerenciarUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailGerenciarUsuarios.Location = new System.Drawing.Point(32, 558);
            this.txtEmailGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtEmailGerenciarUsuarios.Name = "txtEmailGerenciarUsuarios";
            this.txtEmailGerenciarUsuarios.Size = new System.Drawing.Size(241, 30);
            this.txtEmailGerenciarUsuarios.TabIndex = 27;
            // 
            // lblEmailGerenciarUsuarios
            // 
            this.lblEmailGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailGerenciarUsuarios.AutoSize = true;
            this.lblEmailGerenciarUsuarios.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailGerenciarUsuarios.Location = new System.Drawing.Point(29, 535);
            this.lblEmailGerenciarUsuarios.Name = "lblEmailGerenciarUsuarios";
            this.lblEmailGerenciarUsuarios.Size = new System.Drawing.Size(83, 25);
            this.lblEmailGerenciarUsuarios.TabIndex = 26;
            this.lblEmailGerenciarUsuarios.Text = "E-mail: ";
            // 
            // maskTxtDataNascimentoGerenciarUsuarios
            // 
            this.maskTxtDataNascimentoGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxtDataNascimentoGerenciarUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTxtDataNascimentoGerenciarUsuarios.Location = new System.Drawing.Point(32, 422);
            this.maskTxtDataNascimentoGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.maskTxtDataNascimentoGerenciarUsuarios.Mask = "00/00/0000";
            this.maskTxtDataNascimentoGerenciarUsuarios.Name = "maskTxtDataNascimentoGerenciarUsuarios";
            this.maskTxtDataNascimentoGerenciarUsuarios.Size = new System.Drawing.Size(241, 30);
            this.maskTxtDataNascimentoGerenciarUsuarios.TabIndex = 28;
            this.maskTxtDataNascimentoGerenciarUsuarios.ValidatingType = typeof(System.DateTime);
            // 
            // lblPesquisaUsuarios
            // 
            this.lblPesquisaUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesquisaUsuarios.AutoSize = true;
            this.lblPesquisaUsuarios.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPesquisaUsuarios.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaUsuarios.Location = new System.Drawing.Point(333, 33);
            this.lblPesquisaUsuarios.Name = "lblPesquisaUsuarios";
            this.lblPesquisaUsuarios.Size = new System.Drawing.Size(202, 25);
            this.lblPesquisaUsuarios.TabIndex = 29;
            this.lblPesquisaUsuarios.Text = "Pesquisar Usuários: ";
            // 
            // txtPesquisaUsuarios
            // 
            this.txtPesquisaUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaUsuarios.Location = new System.Drawing.Point(337, 55);
            this.txtPesquisaUsuarios.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtPesquisaUsuarios.Name = "txtPesquisaUsuarios";
            this.txtPesquisaUsuarios.Size = new System.Drawing.Size(661, 29);
            this.txtPesquisaUsuarios.TabIndex = 30;
            this.txtPesquisaUsuarios.TextChanged += new System.EventHandler(this.txtPesquisaUsuarios_TextChanged);
            // 
            // btnNovoUsuarioGerenciarUsuarios
            // 
            this.btnNovoUsuarioGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovoUsuarioGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoUsuarioGerenciarUsuarios.Location = new System.Drawing.Point(556, 706);
            this.btnNovoUsuarioGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnNovoUsuarioGerenciarUsuarios.Name = "btnNovoUsuarioGerenciarUsuarios";
            this.btnNovoUsuarioGerenciarUsuarios.Size = new System.Drawing.Size(156, 32);
            this.btnNovoUsuarioGerenciarUsuarios.TabIndex = 0;
            this.btnNovoUsuarioGerenciarUsuarios.Text = "Novo Usuário";
            this.btnNovoUsuarioGerenciarUsuarios.UseVisualStyleBackColor = true;
            this.btnNovoUsuarioGerenciarUsuarios.Click += new System.EventHandler(this.btnNovoUsuarioGerenciarUsuarios_Click);
            // 
            // btnSalvarAlteracoesGerenciarUsuarios
            // 
            this.btnSalvarAlteracoesGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarAlteracoesGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAlteracoesGerenciarUsuarios.Location = new System.Drawing.Point(752, 706);
            this.btnSalvarAlteracoesGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSalvarAlteracoesGerenciarUsuarios.Name = "btnSalvarAlteracoesGerenciarUsuarios";
            this.btnSalvarAlteracoesGerenciarUsuarios.Size = new System.Drawing.Size(156, 32);
            this.btnSalvarAlteracoesGerenciarUsuarios.TabIndex = 1;
            this.btnSalvarAlteracoesGerenciarUsuarios.Text = "Salvar Alterações";
            this.btnSalvarAlteracoesGerenciarUsuarios.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracoesGerenciarUsuarios.Click += new System.EventHandler(this.btnSalvarAlteracoesGerenciarUsuarios_Click);
            // 
            // btnExcluirUsuarioGerenciarUsuarios
            // 
            this.btnExcluirUsuarioGerenciarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirUsuarioGerenciarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUsuarioGerenciarUsuarios.Location = new System.Drawing.Point(945, 706);
            this.btnExcluirUsuarioGerenciarUsuarios.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnExcluirUsuarioGerenciarUsuarios.Name = "btnExcluirUsuarioGerenciarUsuarios";
            this.btnExcluirUsuarioGerenciarUsuarios.Size = new System.Drawing.Size(156, 32);
            this.btnExcluirUsuarioGerenciarUsuarios.TabIndex = 2;
            this.btnExcluirUsuarioGerenciarUsuarios.Text = "Excluir Usuário";
            this.btnExcluirUsuarioGerenciarUsuarios.UseVisualStyleBackColor = true;
            this.btnExcluirUsuarioGerenciarUsuarios.Click += new System.EventHandler(this.btnExcluirUsuarioGerenciarUsuarios_Click);
            // 
            // btnLimparTextBox
            // 
            this.btnLimparTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimparTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTextBox.Location = new System.Drawing.Point(389, 706);
            this.btnLimparTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnLimparTextBox.Name = "btnLimparTextBox";
            this.btnLimparTextBox.Size = new System.Drawing.Size(127, 32);
            this.btnLimparTextBox.TabIndex = 3;
            this.btnLimparTextBox.Text = "Limpar TextBox";
            this.btnLimparTextBox.UseVisualStyleBackColor = true;
            this.btnLimparTextBox.Click += new System.EventHandler(this.btnLimparTextBox_Click);
            // 
            // btnAtivarConta
            // 
            this.btnAtivarConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtivarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivarConta.Location = new System.Drawing.Point(1140, 706);
            this.btnAtivarConta.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAtivarConta.Name = "btnAtivarConta";
            this.btnAtivarConta.Size = new System.Drawing.Size(209, 32);
            this.btnAtivarConta.TabIndex = 31;
            this.btnAtivarConta.Text = "Ativar Conta do Usuário";
            this.btnAtivarConta.UseVisualStyleBackColor = true;
            this.btnAtivarConta.Click += new System.EventHandler(this.btnAtivarConta_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(307, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1100, 784);
            this.label1.TabIndex = 32;
            // 
            // FrmGerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 777);
            this.Controls.Add(this.btnAtivarConta);
            this.Controls.Add(this.btnExcluirUsuarioGerenciarUsuarios);
            this.Controls.Add(this.btnLimparTextBox);
            this.Controls.Add(this.btnSalvarAlteracoesGerenciarUsuarios);
            this.Controls.Add(this.txtPesquisaUsuarios);
            this.Controls.Add(this.btnNovoUsuarioGerenciarUsuarios);
            this.Controls.Add(this.lblPesquisaUsuarios);
            this.Controls.Add(this.maskTxtDataNascimentoGerenciarUsuarios);
            this.Controls.Add(this.txtEmailGerenciarUsuarios);
            this.Controls.Add(this.lblEmailGerenciarUsuarios);
            this.Controls.Add(this.maskTxtTelefoneGerenciarUsuarios);
            this.Controls.Add(this.maskTxtCpfGerenciarUsuarios);
            this.Controls.Add(this.dgvUsuariosGerenciarUsuarios);
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
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGerenciarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Usuários";
            this.Load += new System.EventHandler(this.FrmGerenciarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvUsuariosGerenciarUsuarios;
        private System.Windows.Forms.MaskedTextBox maskTxtCpfGerenciarUsuarios;
        private System.Windows.Forms.MaskedTextBox maskTxtTelefoneGerenciarUsuarios;
        private System.Windows.Forms.TextBox txtEmailGerenciarUsuarios;
        private System.Windows.Forms.Label lblEmailGerenciarUsuarios;
        private System.Windows.Forms.MaskedTextBox maskTxtDataNascimentoGerenciarUsuarios;
        private System.Windows.Forms.Label lblPesquisaUsuarios;
        private System.Windows.Forms.TextBox txtPesquisaUsuarios;
        private System.Windows.Forms.Button btnNovoUsuarioGerenciarUsuarios;
        private System.Windows.Forms.Button btnSalvarAlteracoesGerenciarUsuarios;
        private System.Windows.Forms.Button btnExcluirUsuarioGerenciarUsuarios;
        private System.Windows.Forms.Button btnLimparTextBox;
        private System.Windows.Forms.Button btnAtivarConta;
        private System.Windows.Forms.Label label1;
    }
}