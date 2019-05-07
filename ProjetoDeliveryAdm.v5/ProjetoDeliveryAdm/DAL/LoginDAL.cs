using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDeliveryAdm.DAL
{
    class LoginDAL
    {

        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String loginAdm, String senhaAdm)
        {
            //comando sql para verificar se tem no banco
            cmd.CommandText = "select * from TBCadastroAdm where LoginAdm = @login and SenhaAdm = @senha";
            cmd.Parameters.AddWithValue("@login", loginAdm);
            cmd.Parameters.AddWithValue("@senha", senhaAdm);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//se foi encontrado
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }
            return tem;
        }

        public String cadastrar(String admNome, String admLogin, String admSenha, String confSenha, String admEmail, String admCpf, String admEndereco, String admEstado, String admCidade, String admBairro, String admCep, String admTelefone, String admCelular)
        {
            tem = false;
            //comandos para inserir no banco
            if (admSenha.Equals(confSenha))
            {
                cmd.CommandText = @"insert into TBCadastroAdm(NomeAdm, LoginAdm, SenhaAdm, EmailAdm, CpfAdm, EnderecoAdm, EstadoAdm, CidadeAdm, BairroAdm, CepAdm, TelefoneAdm, CelularAdm) 
                                                       values(@NomeAdm,@LoginAdm,@SenhaAdm,@EmailAdm,@CpfAdm,@EnderecoAdm,@EstadoAdm,@CidadeAdm,@BairroAdm,@CepAdm,@TelefoneAdm,@CelularAdm);";

                cmd.Parameters.AddWithValue("@NomeAdm", admNome);
                cmd.Parameters.AddWithValue("@LoginAdm", admLogin);
                cmd.Parameters.AddWithValue("@SenhaAdm", admSenha);
                cmd.Parameters.AddWithValue("@EmailAdm", admEmail);
                cmd.Parameters.AddWithValue("@CpfAdm", admCpf);
                cmd.Parameters.AddWithValue("@EnderecoAdm", admEndereco);
                cmd.Parameters.AddWithValue("@EstadoAdm", admEstado);
                cmd.Parameters.AddWithValue("@CidadeAdm", admCidade);
                cmd.Parameters.AddWithValue("@BairroAdm", admBairro);
                cmd.Parameters.AddWithValue("@CepAdm", admCep);
                cmd.Parameters.AddWithValue("@TelefoneAdm", admTelefone);
                cmd.Parameters.AddWithValue("@CelularAdm", admCelular);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Cadastrado com Sucesso";
                    tem = true;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro com Banco de Dados \n\n" + erro.Message);
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
           
            return mensagem;
        }
    }
}
