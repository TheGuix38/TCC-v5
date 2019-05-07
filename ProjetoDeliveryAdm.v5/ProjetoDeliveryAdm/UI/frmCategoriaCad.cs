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
    public partial class frmCategoriaCad : Form
    {
        public frmCategoriaCad()
        {
            InitializeComponent();
        }

        private void BtnCadastrarCat_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciar um objeto da camada BLL
                BLL.Categorias cat = new BLL.Categorias();

                //Preencer o objt BLL com o conteúdo da IOnterface
                cat.Nome = txtNomeCat.Text;

                //Instanciar um objeto da camada DAL
                DAL.CategoriaDAL cDAL = new DAL.CategoriaDAL();

                //Enviar para o método (ação) Cadastrar obj BLL
                cDAL.Cadastrar(cat);

                //Limpar a txt
                txtNomeCat.Clear();
                //Retornar cursor para a txt
                txtNomeCat.Focus();
                MessageBox.Show("Categoria Cadastrada!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar! \n\n" + erro.Message);
            }
        }
    }
}
