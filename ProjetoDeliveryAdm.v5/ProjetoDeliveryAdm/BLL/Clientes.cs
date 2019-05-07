using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeliveryAdm.BLL
{
    class Clientes
    {
        private int _CodCliente;
        public int CodCliente
        {
            get { return _CodCliente; }
            set { _CodCliente = value; }
        }
        private string _NomeCliente;
        public string nomec
        {
            get { return _NomeCliente; }
            set { _NomeCliente = value.ToUpper(); }
        }
        private string _CPF;
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value.ToUpper(); }
        }
        private string _Endereco;
        public string Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }
        private string _Telefone;
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }
        private string _Celular;
        public string Celular
        {
            get { return _Celular; }
            set { _Celular = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value.ToLower(); }
        }
        private string _DataNasc;
        public string DataNasc
        {
            get { return _DataNasc; }
            set { _DataNasc = value; }
        }
    }
}
