namespace ProjetoDeliveryAdm
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSairAdm = new System.Windows.Forms.Button();
            this.btnCadatreseAdm = new System.Windows.Forms.Button();
            this.btnCadastrarAdm = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSenhaAdm = new System.Windows.Forms.TextBox();
            this.lblSenhaAdm = new System.Windows.Forms.Label();
            this.txtLoginAdm = new System.Windows.Forms.TextBox();
            this.lblLoginAdm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSairAdm
            // 
            this.btnSairAdm.Location = new System.Drawing.Point(446, 293);
            this.btnSairAdm.Name = "btnSairAdm";
            this.btnSairAdm.Size = new System.Drawing.Size(75, 23);
            this.btnSairAdm.TabIndex = 26;
            this.btnSairAdm.Text = "SAIR";
            this.btnSairAdm.UseVisualStyleBackColor = true;
            this.btnSairAdm.Click += new System.EventHandler(this.BtnSairAdm_Click);
            // 
            // btnCadatreseAdm
            // 
            this.btnCadatreseAdm.Location = new System.Drawing.Point(692, 409);
            this.btnCadatreseAdm.Name = "btnCadatreseAdm";
            this.btnCadatreseAdm.Size = new System.Drawing.Size(96, 29);
            this.btnCadatreseAdm.TabIndex = 25;
            this.btnCadatreseAdm.Text = "CADASTRE-SE";
            this.btnCadatreseAdm.UseVisualStyleBackColor = true;
            this.btnCadatreseAdm.Click += new System.EventHandler(this.BtnCadatreseAdm_Click);
            // 
            // btnCadastrarAdm
            // 
            this.btnCadastrarAdm.Location = new System.Drawing.Point(365, 293);
            this.btnCadastrarAdm.Name = "btnCadastrarAdm";
            this.btnCadastrarAdm.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAdm.TabIndex = 24;
            this.btnCadastrarAdm.Text = "ENTRAR";
            this.btnCadastrarAdm.UseVisualStyleBackColor = true;
            this.btnCadastrarAdm.Click += new System.EventHandler(this.BtnCadastrarAdm_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Image = global::ProjetoDeliveryAdm.Properties.Resources.logoprojeto;
            this.pictureBox3.Location = new System.Drawing.Point(270, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 117);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // txtSenhaAdm
            // 
            this.txtSenhaAdm.Location = new System.Drawing.Point(325, 267);
            this.txtSenhaAdm.Name = "txtSenhaAdm";
            this.txtSenhaAdm.PasswordChar = '•';
            this.txtSenhaAdm.Size = new System.Drawing.Size(196, 20);
            this.txtSenhaAdm.TabIndex = 22;
            // 
            // lblSenhaAdm
            // 
            this.lblSenhaAdm.AutoSize = true;
            this.lblSenhaAdm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSenhaAdm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAdm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenhaAdm.Location = new System.Drawing.Point(261, 270);
            this.lblSenhaAdm.Name = "lblSenhaAdm";
            this.lblSenhaAdm.Size = new System.Drawing.Size(58, 16);
            this.lblSenhaAdm.TabIndex = 21;
            this.lblSenhaAdm.Text = "Senha:";
            // 
            // txtLoginAdm
            // 
            this.txtLoginAdm.Location = new System.Drawing.Point(325, 232);
            this.txtLoginAdm.Name = "txtLoginAdm";
            this.txtLoginAdm.Size = new System.Drawing.Size(196, 20);
            this.txtLoginAdm.TabIndex = 20;
            // 
            // lblLoginAdm
            // 
            this.lblLoginAdm.AutoSize = true;
            this.lblLoginAdm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblLoginAdm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAdm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoginAdm.Location = new System.Drawing.Point(267, 233);
            this.lblLoginAdm.Name = "lblLoginAdm";
            this.lblLoginAdm.Size = new System.Drawing.Size(52, 16);
            this.lblLoginAdm.TabIndex = 19;
            this.lblLoginAdm.Text = "Login:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSairAdm);
            this.Controls.Add(this.btnCadatreseAdm);
            this.Controls.Add(this.btnCadastrarAdm);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSenhaAdm);
            this.Controls.Add(this.lblSenhaAdm);
            this.Controls.Add(this.txtLoginAdm);
            this.Controls.Add(this.lblLoginAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairAdm;
        private System.Windows.Forms.Button btnCadatreseAdm;
        private System.Windows.Forms.Button btnCadastrarAdm;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSenhaAdm;
        private System.Windows.Forms.Label lblSenhaAdm;
        private System.Windows.Forms.TextBox txtLoginAdm;
        private System.Windows.Forms.Label lblLoginAdm;
    }
}

