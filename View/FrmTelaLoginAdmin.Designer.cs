
namespace LivrariaFive.View
{
    partial class FrmTelaLoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaLoginAdmin));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblCpfAdmin = new System.Windows.Forms.Label();
            this.txtCpfAdmin = new System.Windows.Forms.TextBox();
            this.lblSenhaAdmin = new System.Windows.Forms.Label();
            this.txtSenhaAdmin = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(170, 312);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(182, 35);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // lblCpfAdmin
            // 
            this.lblCpfAdmin.AutoSize = true;
            this.lblCpfAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfAdmin.Location = new System.Drawing.Point(84, 171);
            this.lblCpfAdmin.Name = "lblCpfAdmin";
            this.lblCpfAdmin.Size = new System.Drawing.Size(45, 24);
            this.lblCpfAdmin.TabIndex = 1;
            this.lblCpfAdmin.Text = "CPF:";
            // 
            // txtCpfAdmin
            // 
            this.txtCpfAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfAdmin.Location = new System.Drawing.Point(135, 167);
            this.txtCpfAdmin.Name = "txtCpfAdmin";
            this.txtCpfAdmin.Size = new System.Drawing.Size(279, 30);
            this.txtCpfAdmin.TabIndex = 2;
            // 
            // lblSenhaAdmin
            // 
            this.lblSenhaAdmin.AutoSize = true;
            this.lblSenhaAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAdmin.Location = new System.Drawing.Point(63, 251);
            this.lblSenhaAdmin.Name = "lblSenhaAdmin";
            this.lblSenhaAdmin.Size = new System.Drawing.Size(66, 24);
            this.lblSenhaAdmin.TabIndex = 3;
            this.lblSenhaAdmin.Text = "Senha:";
            // 
            // txtSenhaAdmin
            // 
            this.txtSenhaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAdmin.Location = new System.Drawing.Point(135, 247);
            this.txtSenhaAdmin.Name = "txtSenhaAdmin";
            this.txtSenhaAdmin.Size = new System.Drawing.Size(279, 30);
            this.txtSenhaAdmin.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(170, 377);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(182, 32);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTelaLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtSenhaAdmin);
            this.Controls.Add(this.lblSenhaAdmin);
            this.Controls.Add(this.txtCpfAdmin);
            this.Controls.Add(this.lblCpfAdmin);
            this.Controls.Add(this.btnEntrar);
            this.Name = "FrmTelaLoginAdmin";
            this.Text = "FrmTelaLoginAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblCpfAdmin;
        private System.Windows.Forms.TextBox txtCpfAdmin;
        private System.Windows.Forms.Label lblSenhaAdmin;
        private System.Windows.Forms.TextBox txtSenhaAdmin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}