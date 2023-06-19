using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidade
{
    public class produto
    {
        public int cod_produto { get; set; }
        public string nome_produto { get; set; }
        public string categoria { get; set; }
        public string descricao { get; set; }
        public string estado { get; set; }
        public string stock { get; set; }
        public string preco_compra { get; set; }
        public string preco_venda { get; set; }
        public string add_por { get; set; }
        public string data_registro { get; set; }
    }
}
