using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeliveryAdm.BLL
{
    class CadastroAdm
    {
        private int _CodAdm;
        public int CodAdm
        {
            get { return _CodAdm; }
            set { _CodAdm = value; }
        }

        private string _NomeAdm;
        public string Nome
        {
            get { return _NomeAdm; }
            set { _NomeAdm = value.ToUpper(); }
        }

        private string _LoginAdm;
        public string LoginAdm
        {
            get { return _LoginAdm; }
            set { _LoginAdm = value.ToUpper(); }
        }

        private string _SenhaAdm;
        public string SenhaAdm
        {
            get { return _SenhaAdm; }
            set { _SenhaAdm = value; }
        }

        private string _CpfAdm;
        public string CpfAdm
        {
            get { return _CpfAdm; }
            set { _CpfAdm = value; }
        }

        private string _EnderecoAdm;
        public string EnderecoAdm
        {
            get { return _EnderecoAdm; }
            set { _EnderecoAdm = value.ToUpper(); }
        }

        private string _EstadoAdm;
        public string EstadoAdm
        {
            get { return _EstadoAdm; }
            set { _EstadoAdm = value.ToUpper(); }
        }

        private string _CidadeAdm;
        public string CidadeAdm
        {
            get { return _CidadeAdm; }
            set { _CidadeAdm = value.ToUpper(); }
        }

        private string _BairroAdm;
        public string BairroAdm
        {
            get { return _BairroAdm; }
            set { _BairroAdm = value.ToUpper(); }
        }

        private string _CepAdm;
        public string CepAdm
        {
            get { return _CepAdm; }
            set { _CepAdm = value; }
        }

        private string _TelefoneAdm;
        public string TelefoneAdm
        {
            get { return _TelefoneAdm; }
            set { _TelefoneAdm = value; }
        }

        private string _CelularAdm;
        public string CelularAdm
        {
            get { return _CelularAdm; }
            set { _CelularAdm = value; }
        }

        private string _EmailAdm;
        public string EmailAdm
        {
            get { return _EmailAdm; }
            set { _EmailAdm = value; }
        }

        private string _DataNascAdm;
        public string DataNascAdm
        {
            get { return _DataNascAdm; }
            set { _DataNascAdm = value; }
        }
    }
}
