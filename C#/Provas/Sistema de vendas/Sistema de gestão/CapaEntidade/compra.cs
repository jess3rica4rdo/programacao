using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidade
{
    public class compra
    {
        public int cod_compra { get; set; }
        public usuario ousuario { get; set; }
        public fornecedor ofornecedor { get; set; }
        public string tipo_documento { get; set; }
        public int numero_documento { get; set; }
        public decimal valor_total { get; set; }
        public string data_registro { get; set; }
    }
}
