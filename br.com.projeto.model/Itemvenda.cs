using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto__controles_de_venda.br.com.projeto.model
{
    public class Itemvenda
    {
        public int id { get; set; }
        public int venda_id { get; set; }
        public int produto_id { get; set; }
        public int qtd { get; set; }
        public decimal subtotal{ get; set; }

    }
}
