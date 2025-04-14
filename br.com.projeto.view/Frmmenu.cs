using projeto_controles_de_vendas.br.com.projeto.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto__controles_de_venda.br.com.projeto.view
{
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel6_Click(object sender, EventArgs e)
        {

        }

        private void Frmmenu_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txthora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmclientes tela = new Frmclientes();
            tela.ShowDialog();
        }

        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmclientes tela = new Frmclientes();
            tela.tabClientes.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfuncionarios tela = new Frmfuncionarios();
            tela.ShowDialog();
        }

        private void consultaDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfuncionarios tela = new Frmfuncionarios();
            tela.tabfuncionario.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfornecedor tela = new Frmfornecedor();
            tela.ShowDialog();
        }

        private void consultaDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfornecedor tela = new Frmfornecedor();
            tela.tabfornecedor.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menucadastroprodutos_Click(object sender, EventArgs e)
        {
            frmprodutos tela = new frmprodutos();
            tela.ShowDialog();
        }

        private void consultaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmprodutos tela = new frmprodutos();
            tela.tabprodutos.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmvendas tela = new Frmvendas();
            tela.ShowDialog();
        }

        private void menuhistorico_Click(object sender, EventArgs e)
        {
            Frmhistorico tela = new Frmhistorico();
            tela.ShowDialog();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja sair?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void trocarDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja trocar de usuário?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Frmlogin tela = new Frmlogin();
                tela.ShowDialog();
            }
        }
    }
}
