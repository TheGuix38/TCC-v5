using ProjetoDeliveryAdm.BLL;
using ProjetoDeliveryAdm.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDeliveryAdm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnCadastrarAdm_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLoginAdm.Text, txtSenhaAdm.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UI.frmMenuAdm frm = new UI.frmMenuAdm();
                    frm.ShowDialog();
                    frm.Dispose();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
            
        }

        private void BtnSairAdm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCadatreseAdm_Click(object sender, EventArgs e)
        {
            UI.frmCadastroAdm frm = new UI.frmCadastroAdm();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
