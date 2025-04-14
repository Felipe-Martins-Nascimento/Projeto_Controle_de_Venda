using projeto__controles_de_venda.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto__controles_de_venda.br.com.projeto.view
{
    public partial class Frmhistorico : Form
    {
        public Frmhistorico()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            DateTime datainicio, datafim;
            datainicio = Convert.ToDateTime(dtinicio.Value.ToString("yyy-MM-dd"));
            datafim = Convert.ToDateTime(dtfim.Value.ToString("yyy-MM-dd"));

            VendaDAO dao = new VendaDAO();
            tabelahistorico.DataSource = dao.listarvendasporperiodo(datainicio, datafim);
        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            VendaDAO dao = new VendaDAO();
            tabelahistorico.DataSource = dao.listarvendas();

            tabelahistorico.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void tabelahistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idvenda = int.Parse(tabelahistorico.CurrentRow.Cells[0].Value.ToString());
            Frmdetalhes tela = new Frmdetalhes(idvenda);

            DateTime datavenda = Convert.ToDateTime(tabelahistorico.CurrentRow.Cells[1].Value.ToString());

            tela.txtdata.Text = datavenda.ToString("dd/MM/yyyy");
            tela.txtcliente.Text = tabelahistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txttotal.Text = tabelahistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtobs.Text = tabelahistorico.CurrentRow.Cells[4].Value.ToString();

            tela.ShowDialog();
        }
    }
}
