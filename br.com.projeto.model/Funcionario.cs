using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_controles_de_vendas.br.com.projeto.model
{
    public class Funcionario : Cliente
    {    
        public string senha { get; set; }
        public string cargo { get; set; }
        public string nivel_acesso{ get; set; }
    }
}
