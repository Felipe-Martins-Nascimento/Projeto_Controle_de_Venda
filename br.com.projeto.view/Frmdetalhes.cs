using projeto__controles_de_venda.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto__controles_de_venda.br.com.projeto.view
{
    public partial class Frmdetalhes : Form
    {
        int venda_id;
        public Frmdetalhes(int idvenda)
        {
            venda_id = idvenda;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmdetalhes_Load(object sender, EventArgs e)
        {
            ItemvendaDAO dao = new ItemvendaDAO();
            tabeladetalhes.DataSource = dao.listaritensporvenda(venda_id);
        }
    }
}
