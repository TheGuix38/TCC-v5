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

namespace ProjetoDeliveryAdm.UI
{
    public partial class frmCadastroAdm : Form
    {
        public frmCadastroAdm()
        {
            InitializeComponent();
        }

        private void BtnCadastrarAdm_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtNomeAdm.Text, txtLoginAdm.Text, txtSenhaAdm.Text, txtConfSenhaAdm.Text, txtEmailAdm.Text, txtCPFadm.Text, txtEnderecoAdm.Text, cmbEstadoAdm.Text, txtCidadeAdm.Text, txtBairroAdm.Text, txtCepAdm.Text, txtTelAdm.Text, txtCelularAdm.Text);
            if (controle.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);//mensagem de erro
            }
        }
    }
}
