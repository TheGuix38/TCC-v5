namespace ProjetoDeliveryAdm.UI
{
    partial class frmCategoriaCad
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
            this.lblNomeCat = new System.Windows.Forms.Label();
            this.txtNomeCat = new System.Windows.Forms.TextBox();
            this.btnCadastrarCat = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomeCat
            // 
            this.lblNomeCat.AutoSize = true;
            this.lblNomeCat.Location = new System.Drawing.Point(9, 63);
            this.lblNomeCat.Name = "lblNomeCat";
            this.lblNomeCat.Size = new System.Drawing.Size(101, 13);
            this.lblNomeCat.TabIndex = 0;
            this.lblNomeCat.Text = "Nome da Categoria:";
            // 
            // txtNomeCat
            // 
            this.txtNomeCat.Location = new System.Drawing.Point(12, 79);
            this.txtNomeCat.Name = "txtNomeCat";
            this.txtNomeCat.Size = new System.Drawing.Size(229, 20);
            this.txtNomeCat.TabIndex = 1;
            // 
            // btnCadastrarCat
            // 
            this.btnCadastrarCat.Location = new System.Drawing.Point(167, 117);
            this.btnCadastrarCat.Name = "btnCadastrarCat";
            this.btnCadastrarCat.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCat.TabIndex = 2;
            this.btnCadastrarCat.Text = "Cadastrar";
            this.btnCadastrarCat.UseVisualStyleBackColor = true;
            this.btnCadastrarCat.Click += new System.EventHandler(this.BtnCadastrarCat_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(10, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(13, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "(Automático)";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCategoriaCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 159);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCadastrarCat);
            this.Controls.Add(this.txtNomeCat);
            this.Controls.Add(this.lblNomeCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCategoriaCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCat;
        private System.Windows.Forms.TextBox txtNomeCat;
        private System.Windows.Forms.Button btnCadastrarCat;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox textBox1;
    }
}