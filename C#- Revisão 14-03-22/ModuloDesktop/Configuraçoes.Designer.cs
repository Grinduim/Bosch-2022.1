
namespace ModuloDesktop
{
    partial class Configuraçoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimparSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configurações";
            // 
            // BtnLimparSenha
            // 
            this.BtnLimparSenha.Location = new System.Drawing.Point(101, 79);
            this.BtnLimparSenha.Name = "BtnLimparSenha";
            this.BtnLimparSenha.Size = new System.Drawing.Size(179, 53);
            this.BtnLimparSenha.TabIndex = 1;
            this.BtnLimparSenha.Text = "Limpar Senha Gravada";
            this.BtnLimparSenha.UseVisualStyleBackColor = true;
            this.BtnLimparSenha.Click += new System.EventHandler(this.BtnLimparSenha_Click);
            // 
            // Configuraçoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 242);
            this.Controls.Add(this.BtnLimparSenha);
            this.Controls.Add(this.label1);
            this.Name = "Configuraçoes";
            this.Text = "Configuraçoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLimparSenha;
    }
}