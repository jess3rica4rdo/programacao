using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidade
{
    public class detalhe_compra
    {
        public int cod_detalhecompra { get; set; }
        public compra ocompra { get; set; }
        public produto oproduto { get; set; }
        public decimal preco_compra { get; set; }
        public decimal preco_venda { get; set; }
        public int quantidade { get; set; }
        public decimal valor_total { get; set; }
        public string data_registro { get; set; }

    }
}
