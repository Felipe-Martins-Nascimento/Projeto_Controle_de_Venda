using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto__controles_de_venda.br.com.projeto.model
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao{ get; set; }
        public decimal preco { get; set; }
        public int qtdestoque { get; set; }
        public int for_id { get; set; }

    }
}
