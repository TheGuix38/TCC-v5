using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeliveryAdm.BLL
{
    class Produtos
    {
        private int _CodProd;
        public int CodProd
        {
            get { return _CodProd; }
            set { _CodProd = value; }
        }
        private string _MarcaProduto;
        public string MarcaProduto
        {
            get { return _MarcaProduto; }
            set { _MarcaProduto = value.ToUpper(); }
        }
        private string _NomeProduto;
        public string NomeProduto
        {
            get { return _NomeProduto; }
            set { _NomeProduto = value.ToUpper(); }
        }
        private string _Preco;
        public string Preco
        {
            get { return _Preco; }
            set { _Preco = value; }
        }
        private string _Descricao;
        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }
    }
}
