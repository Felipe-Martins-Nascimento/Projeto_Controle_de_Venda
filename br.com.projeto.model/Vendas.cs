using projeto_controles_de_vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto__controles_de_venda.br.com.projeto.model
{
    public class Vendas
    {
        public int id { get; set; }
        public int cliente_id { get; set; }
        public DateTime data_venda { get; set; }
        public decimal total_venda { get; set; }
        public string obs { get; set; }

    }
}
