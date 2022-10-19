using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Models
{
    public class Produto
    {
        public string Id_Produto { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public float Quantidade { get; set; }
        public DateTime Vencimento{ get; set; }
        public string Fornecedor{ get; set; }

    }
}
