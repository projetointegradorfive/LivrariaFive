
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginUser));
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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(121, 295);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaLogin.Location = new System.Drawing.Point(121, 364);
            this.txtSenhaLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(215, 23);
            this.txtSenhaLogin.TabIndex = 3;
            this.txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // btnLogarUser
            // 
            this.btnLogarUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogarUser.Location = new System.Drawing.Point(184, 476);
            this.btnLogarUser.Name = "btnLogarUser";
            this.btnLogarUser.Size = new System.Drawing.Size(76, 32);
            this.btnLogarUser.TabIndex = 2;
            this.btnLogarUser.Text = "Logar";
            this.btnLogarUser.UseVisualStyleBackColor = false;
            this.btnLogarUser.Click += new System.EventHandler(this.btnLogarUser_Click);
            // 
            // btnLoginAdminRestrito
            // 
            this.btnLoginAdminRestrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoginAdminRestrito.Location = new System.Drawing.Point(9, 98);
            this.btnLoginAdminRestrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoginAdminRestrito.Name = "btnLoginAdminRestrito";
            this.btnLoginAdminRestrito.Size = new System.Drawing.Size(124, 23);
            this.btnLoginAdminRestrito.TabIndex = 5;
            this.btnLoginAdminRestrito.Text = "Login Restrito";
            this.btnLoginAdminRestrito.UseVisualStyleBackColor = true;
            this.btnLoginAdminRestrito.Click += new System.EventHandler(this.btnLoginAdminRestrito_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // maskTxtTelefoneCadastro
            // 
            this.maskTxtTelefoneCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxtTelefoneCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTxtTelefoneCadastro.Location = new System.Drawing.Point(769, 311);
            this.maskTxtTelefoneCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskTxtTelefoneCadastro.Mask = "(00) 0 0000-0000 ";
            this.maskTxtTelefoneCadastro.Name = "maskTxtTelefoneCadastro";
            this.maskTxtTelefoneCadastro.Size = new System.Drawing.Size(104, 23);
            this.maskTxtTelefoneCadastro.TabIndex = 12;
            this.maskTxtTelefoneCadastro.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(660, 311);
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
            this.txtNomeCadastro.Location = new System.Drawing.Point(517, 254);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(126, 23);
            this.txtNomeCadastro.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 293);
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
            this.maskTxtCpfCadastro.Location = new System.Drawing.Point(517, 292);
            this.maskTxtCpfCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtEmailCadastro.Location = new System.Drawing.Point(517, 376);
            this.txtEmailCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailCadastro.Name = "txtEmailCadastro";
            this.txtEmailCadastro.Size = new System.Drawing.Size(356, 23);
            this.txtEmailCadastro.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "E-mail:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(434, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Senha:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCadastro.Location = new System.Drawing.Point(517, 335);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(111, 23);
            this.txtSenhaCadastro.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(660, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 46);
            this.label10.TabIndex = 0;
            this.label10.Text = "Data de\r\nnascimento:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(434, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Endereço:";
            // 
            // dtpDataNascimentoCadastro
            // 
            this.dtpDataNascimentoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDataNascimentoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimentoCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimentoCadastro.Location = new System.Drawing.Point(769, 268);
            this.dtpDataNascimentoCadastro.Name = "dtpDataNascimentoCadastro";
            this.dtpDataNascimentoCadastro.Size = new System.Drawing.Size(104, 23);
            this.dtpDataNascimentoCadastro.TabIndex = 1;
            // 
            // txtEnderecoCadastro
            // 
            this.txtEnderecoCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEnderecoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoCadastro.Location = new System.Drawing.Point(517, 411);
            this.txtEnderecoCadastro.Name = "txtEnderecoCadastro";
            this.txtEnderecoCadastro.Size = new System.Drawing.Size(356, 23);
            this.txtEnderecoCadastro.TabIndex = 1;
            // 
            // btnCadastrarUser
            // 
            this.btnCadastrarUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastrarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUser.Location = new System.Drawing.Point(627, 478);
            this.btnCadastrarUser.Name = "btnCadastrarUser";
            this.btnCadastrarUser.Size = new System.Drawing.Size(85, 30);
            this.btnCadastrarUser.TabIndex = 5;
            this.btnCadastrarUser.Text = "Cadastrar";
            this.btnCadastrarUser.UseVisualStyleBackColor = true;
            this.btnCadastrarUser.Click += new System.EventHandler(this.btnCadastrarUser_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Login Usuário";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cadastrar Usuário";
            // 
            // DetalhesEndereco
            // 
            this.DetalhesEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetalhesEndereco.AutoSize = true;
            this.DetalhesEndereco.BackColor = System.Drawing.SystemColors.Control;
            this.DetalhesEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalhesEndereco.Location = new System.Drawing.Point(689, 437);
            this.DetalhesEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DetalhesEndereco.Name = "DetalhesEndereco";
            this.DetalhesEndereco.Size = new System.Drawing.Size(181, 13);
            this.DetalhesEndereco.TabIndex = 15;
            this.DetalhesEndereco.Text = "Cidade, Bairro, Logradouro e Número";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label12.Location = new System.Drawing.Point(25, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(393, 400);
            this.label12.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(23, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(865, 402);
            this.label13.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label14.Location = new System.Drawing.Point(0, -1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(912, 82);
            this.label14.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label15.Font = new System.Drawing.Font("Ink Free", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(71, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 36);
            this.label15.TabIndex = 20;
            this.label15.Text = "Five Books";
            // 
            // FormLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 572);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
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
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLoginUser";
            this.Text = "FormLoginUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
    }
}