using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidade
{
    public class usuario
    {
        public int cod_usuario { get; set; }
        public string nome_completo { get; set; }
        public string idade { get; set; }
        public string sexo { get; set; }
        public string telefone { get; set; }
        public string nome_usuario { get; set; }
        public string senha { get; set; }
        public string funcao { get; set; }
        public string add_por { get; set; }
        public string data_registro { get; set; }
    }
}
