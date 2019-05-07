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
    public partial class frmMenuAdm : Form
    {
        public frmMenuAdm()
        {
            InitializeComponent();
        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCategoriaCad"] == null)
            {
                // Instanciar um objeto da tela do formulário
                UI.frmCategoriaCad tela = new UI.frmCategoriaCad();
                //"Amarrar" esta tela dentro do frmMenuAdm (MDI Container)
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar um objeto da tela do formulário
            UI.frmCategoriaCon tela = new UI.frmCategoriaCon();
            //"Amarrar" esta tela dentro do frmMenuAdm (MDI Container)
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
