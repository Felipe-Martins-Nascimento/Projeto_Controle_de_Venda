using projeto__controles_de_venda.br.com.projeto.dao;
using projeto__controles_de_venda.br.com.projeto.model;
using projeto_controles_de_vendas.br.com.projeto.model;
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
    public partial class frmprodutos : Form
    {
        public frmprodutos()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmprodutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();
            cbfornecedor.DataSource = f_dao.listarfornecedor();

            cbfornecedor.DisplayMember = "nome";
            cbfornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaproduto.DataSource = dao.listarproduto();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdestoque = int.Parse(txtqtd.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());
          
            ProdutoDAO dao = new ProdutoDAO();
            dao.cadastraproduto(obj);

            new Helpers().LimparTela(this);

            tabelaproduto.DataSource = dao.listarproduto();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void tabelaproduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaproduto.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = tabelaproduto.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = tabelaproduto.CurrentRow.Cells[2].Value.ToString();
            txtqtd.Text = tabelaproduto.CurrentRow.Cells[3].Value.ToString();
            cbfornecedor.Text = tabelaproduto.CurrentRow.Cells[4].Value.ToString();

            tabprodutos.SelectedTab = tabPage1;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdestoque = int.Parse(txtqtd.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());
            obj.id = int.Parse(txtcodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.alterarproduto(obj);

            new Helpers().LimparTela(this);

            tabelaproduto.DataSource = dao.listarproduto();

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.id = int.Parse(txtcodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.excluirproduto(obj);

            new Helpers().LimparTela(this);

            tabelaproduto.DataSource = dao.listarproduto();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaproduto.DataSource = dao.listarprodutopornome(nome);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;
            ProdutoDAO dao = new ProdutoDAO();
            tabelaproduto.DataSource = dao.buscarprodutopornome(nome);

            if(tabelaproduto.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum fornedor encontrado com esse nome.");
                tabelaproduto.DataSource = dao.listarproduto();
            }
        }
    }
}
