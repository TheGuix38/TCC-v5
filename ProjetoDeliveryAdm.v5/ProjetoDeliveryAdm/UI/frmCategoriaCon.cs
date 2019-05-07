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
    public partial class frmCategoriaCon : Form
    {
        public frmCategoriaCon()
        {
            InitializeComponent();
        }


        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Categorias cons = new BLL.Categorias();
                cons.Nome = txtFiltro.Text;

                DAL.CategoriaDAL cDAL = new DAL.CategoriaDAL();
                dgvResultado.DataSource = cDAL.Consultar(cons);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar! \n\n " + erro.Message);
            }
        }
    }
}
