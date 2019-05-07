using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Para trabalhar com dados
using System.Data.SqlClient; // Cliente SQL

namespace ProjetoDeliveryAdm.DAL
{
        class Conexao
        {
            // Declarar um objeto para conexão SQL
            SqlConnection con;

            // Declarar um metodo construtor
            //Metodo construtor = é executado sempre que um objeto da classe é instanciado.
            public Conexao()
            {
                //contruçâo do objeto de conexão SQL 
                con = new SqlConnection();

                //configurar objeto de conexão
                con.ConnectionString = @"Data Source = DESKTOP-QBGVP1J\SQLEXPRESS;
                                 Initial Catalog = bd_tcc;
                             Integrated Security = true"; //@ permite string com varias linhas
                                                          //Data Source = Nome do servidor
                                                          //Initial Catalog = Nome do Banco de Dados
                                                          //Integrated Security = Se for a Autenticação do Windows colocar "true"
                                                          //'DESKTOP-QBGVP1J\SQLEXPRESS' to connect in TheGuix house or (local)
        }

        //Método de ação para conectar
        public SqlConnection Conectar()
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }

            //Método de ação para desconectar
            public SqlConnection Desconectar()
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return con;
            }
        }
    }
