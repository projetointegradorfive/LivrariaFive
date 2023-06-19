
namespace LivrariaFive.View
{
    partial class FormLoginUser
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnLogarUser = new System.Windows.Forms.Button();
            this.btnLoginAdminRestrito = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.maskTxtTelefoneCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskTxtCpfCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailCadastro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDataNascimentoCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtEnderecoCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastrarUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DetalhesEndereco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(125, 228);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaLogin.Location = new System.Drawing.Point(125, 280);
            this.txtSenhaLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(215, 23);
            this.txtSenhaLogin.TabIndex = 3;
            // 
            // btnLogarUser
            // 
            this.btnLogarUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogarUser.Location = new System.Drawing.Point(164, 359);
            this.btnLogarUser.Name = "btnLogarUser";
            this.btnLogarUser.Size = new System.Drawing.Size(76, 32);
            this.btnLogarUser.TabIndex = 2;
            this.btnLogarUser.Text = "Logar";
            this.btnLogarUser.UseVisualStyleBackColor = false;
            this.btnLogarUser.Click += new System.EventHandler(this.btnLogarUser_Click);
            // 
            // btnLoginAdminRestrito
            // 
            this.btnLoginAdminRestrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoginAdminRestrito.Location = new System.Drawing.Point(9, 9);
            this.btnLoginAdminRestrito.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoginAdminRestrito.Name = "btnLoginAdminRestrito";
            this.btnLoginAdminRestrito.Size = new System.Drawing.Size(124, 23);
            this.btnLoginAdminRestrito.TabIndex = 5;
            this.btnLoginAdminRestrito.Text = "Login Restrito";
            this.btnLoginAdminRestrito.UseVisualStyleBackColor = true;
            this.btnLoginAdminRestrito.Click += new System.EventHandler(this.btnLoginAdminRestrito_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskTxtTelefoneCadastro
            // 
            this.maskTxtTelefoneCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxtTelefoneCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTxtTelefoneCadastro.Location = new System.Drawing.Point(782, 259);
            this.maskTxtTelefoneCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.maskTxtTelefoneCadastro.Mask = "(00) 0 0000-0000 ";
            this.maskTxtTelefoneCadastro.Name = "maskTxtTelefoneCadastro";
            this.maskTxtTelefoneCadastro.Size = new System.Drawing.Size(104, 23);
            this.maskTxtTelefoneCadastro.TabIndex = 12;
            this.maskTxtTelefoneCadastro.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(698, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Telefone:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCadastro.Location = new System.Drawing.Point(525, 211);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(126, 23);
            this.txtNomeCadastro.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "CPF:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskTxtCpfCadastro
            // 
            this.maskTxtCpfCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxtCpfCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTxtCpfCadastro.Location = new System.Drawing.Point(524, 249);
            this.maskTxtCpfCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.maskTxtCpfCadastro.Mask = "000,000,000-00";
            this.maskTxtCpfCadastro.Name = "maskTxtCpfCadastro";
            this.maskTxtCpfCadastro.Size = new System.Drawing.Size(112, 23);
            this.maskTxtCpfCadastro.TabIndex = 11;
            this.maskTxtCpfCadastro.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmailCadastro
            // 
            this.txtEmailCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCadastro.Location = new System.Drawing.Point(524, 333);
            this.txtEmailCadastro.Name = "txtEmailCadastro";
            this.txtEmailCadastro.Size = new System.Drawing.Size(361, 23);
            this.txtEmailCadastro.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "E-mail:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(456, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Senha:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCadastro.Location = new System.Drawing.Point(524, 292);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(111, 23);
            this.txtSenhaCadastro.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(689, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 46);
            this.label10.TabIndex = 0;
            this.label10.Text = "Data de\r\nnascimento:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(447, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Endereço:";
            // 
            // dtpDataNascimentoCadastro
            // 
            this.dtpDataNascimentoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDataNascimentoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimentoCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimentoCadastro.Location = new System.Drawing.Point(784, 226);
            this.dtpDataNascimentoCadastro.Name = "dtpDataNascimentoCadastro";
            this.dtpDataNascimentoCadastro.Size = new System.Drawing.Size(102, 23);
            this.dtpDataNascimentoCadastro.TabIndex = 1;
            // 
            // txtEnderecoCadastro
            // 
            this.txtEnderecoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnderecoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoCadastro.Location = new System.Drawing.Point(524, 368);
            this.txtEnderecoCadastro.Name = "txtEnderecoCadastro";
            this.txtEnderecoCadastro.Size = new System.Drawing.Size(361, 23);
            this.txtEnderecoCadastro.TabIndex = 1;
            // 
            // btnCadastrarUser
            // 
            this.btnCadastrarUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUser.Location = new System.Drawing.Point(629, 431);
            this.btnCadastrarUser.Name = "btnCadastrarUser";
            this.btnCadastrarUser.Size = new System.Drawing.Size(87, 30);
            this.btnCadastrarUser.TabIndex = 5;
            this.btnCadastrarUser.Text = "Cadastrar";
            this.btnCadastrarUser.UseVisualStyleBackColor = true;
            this.btnCadastrarUser.Click += new System.EventHandler(this.btnCadastrarUser_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "LOGIN USUÁRIO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "CADASTRO USUÁRIO";
            // 
            // DetalhesEndereco
            // 
            this.DetalhesEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetalhesEndereco.AutoSize = true;
            this.DetalhesEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalhesEndereco.Location = new System.Drawing.Point(681, 392);
            this.DetalhesEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DetalhesEndereco.Name = "DetalhesEndereco";
            this.DetalhesEndereco.Size = new System.Drawing.Size(181, 13);
            this.DetalhesEndereco.TabIndex = 15;
            this.DetalhesEndereco.Text = "Cidade, Bairro, Logradouro e Número";
            // 
            // FormLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 511);
            this.Controls.Add(this.DetalhesEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarUser);
            this.Controls.Add(this.txtEnderecoCadastro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDataNascimentoCadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSenhaCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskTxtCpfCadastro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmailCadastro);
            this.Controls.Add(this.txtNomeCadastro);
            this.Controls.Add(this.maskTxtTelefoneCadastro);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogarUser);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLoginAdminRestrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLoginUser";
            this.Text = "FormLoginUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrarUser;
        private System.Windows.Forms.TextBox txtEnderecoCadastro;
        private System.Windows.Forms.DateTimePicker dtpDataNascimentoCadastro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailCadastro;
        private System.Windows.Forms.MaskedTextBox maskTxtCpfCadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskTxtTelefoneCadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoginAdminRestrito;
        private System.Windows.Forms.Button btnLogarUser;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DetalhesEndereco;
    }
}