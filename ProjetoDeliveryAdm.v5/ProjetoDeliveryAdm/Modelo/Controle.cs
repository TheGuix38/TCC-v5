using ProjetoDeliveryAdm.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeliveryAdm.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDAL loginDAL = new LoginDAL();
            tem = loginDAL.verificarLogin(login, senha);

            //if (!loginDAL.mensagem.Equals(""))
            if (!loginDAL.mensagem.Equals(""))
            {
                this.mensagem = loginDAL.mensagem;
            }
            return tem;
        }

        public String cadastrar(String admNome, String admLogin, String admSenha, String confSenha, String admEmail, String admCpf, String admEndereco, String admEstado, String admCidade, String admBairro, String admCep, String admTelefone, String admCelular)
        {
            LoginDAL loginDAL = new LoginDAL();
            this.mensagem = loginDAL.cadastrar(admNome, admLogin, admSenha, confSenha, admEmail, admCpf, admEndereco, admEstado, admCidade, admBairro, admCep, admTelefone, admCelular);
            if (loginDAL.tem)//a msg que vai vir é de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
