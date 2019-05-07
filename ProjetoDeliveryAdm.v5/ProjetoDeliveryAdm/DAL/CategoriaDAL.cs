using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDeliveryAdm.BLL;

namespace ProjetoDeliveryAdm.DAL
{
    class CategoriaDAL
    {
        //Ações = Métodos (Cadastrar/Consultar/Excluir/Atualizar)
        //Instanciar GLOBAL o obj de conexao
        Conexao con = new Conexao();

        //Cadastrar "Insert"
        public void Cadastrar(BLL.Categorias c)
        {
            //Declarar o objeto de comando de SQL
            SqlCommand cmd = new SqlCommand();
            //CLASSE OBJ = NEW CLASSE

            //Configurar a conexão que o comando irá utilizar
            cmd.Connection = con.Conectar();

            //Configurar o COMANDO "Insert" no objeto cmd
            cmd.CommandText = @"INSERT INTO TBCategoria(NomeCategoria)
                                VALUES(@nomeCategoria)";

            //Passar Valores por parametro
            //cmd.Parameters.Add("@nomeFab", SqlDbType.VarChar).Value = f.Nome;
            //Forma Abreviada
            cmd.Parameters.AddWithValue("@nomeCategoria", c.Nome);

            //Executar o comando no SQL
            cmd.ExecuteNonQuery();

            //Desconectar do banco
            con.Desconectar();
        }

        public void Excluir(BLL.Categorias c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE FROM TBCategoria 
                                WHERE CodCat = @CodCat";
            cmd.Parameters.AddWithValue("@CodCat", c.CodCat);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Atualizar(BLL.Categorias c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE TBCategoria 
                                SET NomeCategoria = @NomeCategoria 
                                WHERE CodCat = @CodCat";
            cmd.Parameters.AddWithValue("@CodCat", c.CodCat);
            cmd.Parameters.AddWithValue("@NomeCategoria", c.Nome);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Consultar() //Não é void por que precisa retornar dados
        {
            //Tabel de Dados no padrão C# (int, double, string, ...)
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT CodCat, NomeCategoria
                              FROM TBCategoria";

            //Instanciar um adaptador de dados SQL
            SqlDataAdapter da = new SqlDataAdapter();

            //Informar o local que está programada a query SQL
            da.SelectCommand = cmd;

            //Preencher o meu DataTable com os dados adaptados do SQL
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        //Sobrecarga = metodo com mesmo nome, mas com assinaturas diferentes
        public DataTable Consultar(BLL.Categorias c) //Não é void por que precisa retornar dados
        {
            //Tabel de Dados no padrão C# (int, double, string, ...)
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT CodCat, NomeCategoria
                              FROM TBCategoria
                              WHERE NomeCategoria LIKE @NomeCategoria";
            cmd.Parameters.AddWithValue("@NomeCategoria", "%" + c.Nome + "%");
            //Instanciar um adaptador de dados SQL - Ex: Transformar VARCHAR em String
            SqlDataAdapter da = new SqlDataAdapter();

            //Informar o local que está programada a query SQL
            da.SelectCommand = cmd;

            //Preencher o meu DataTable com os dados adaptados do SQL
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }
    }
}
