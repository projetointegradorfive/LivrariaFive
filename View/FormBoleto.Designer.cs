
namespace LivrariaFive.View
{
    partial class FormBoleto
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
            this.btnGerarBoleto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarBoleto
            // 
            this.btnGerarBoleto.Location = new System.Drawing.Point(46, 72);
            this.btnGerarBoleto.Name = "btnGerarBoleto";
            this.btnGerarBoleto.Size = new System.Drawing.Size(241, 58);
            this.btnGerarBoleto.TabIndex = 4;
            this.btnGerarBoleto.Tag = "GerarBoleto";
            this.btnGerarBoleto.Text = "Gerar Boleto";
            this.btnGerarBoleto.UseVisualStyleBackColor = true;
            this.btnGerarBoleto.Click += new System.EventHandler(this.btnGerarBoleto_Click);
            // 
            // FormBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 196);
            this.Controls.Add(this.btnGerarBoleto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "FormBoleto";
            this.Text = "FormBoleto";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGerarBoleto;
    }
}