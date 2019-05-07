using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeliveryAdm.BLL
{
    class Categorias
    {
        private int _CodCat;
        public int CodCat
        {
            get { return _CodCat; }
            set { _CodCat = value; }
        }
        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value.ToUpper(); }
        }

        internal SqlConnection Conectar()
        {
            throw new NotImplementedException();
        }
    }
}
