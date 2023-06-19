using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidade
{
    public class fornecedor
    {
        public int cod_fornecedor { get; set; }
        public string nif { get; set; }
        public string razao_social { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string add_por { get; set; }
        public string data_registro { get; set; }
    }
}
