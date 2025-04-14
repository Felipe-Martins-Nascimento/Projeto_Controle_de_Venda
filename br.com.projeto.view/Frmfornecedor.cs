using projeto__controles_de_venda.br.com.projeto.dao;
using projeto__controles_de_venda.br.com.projeto.model;
using projeto_controles_de_vendas.br.com.projeto.dao;
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
    public partial class Frmfornecedor : Form
    {
        public Frmfornecedor()
        {
            InitializeComponent();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtcep.Text;
                string xml = "http://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                txtendereço.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado,por favor digite manualmente.");
            }
        }

        private void btnnovo_Click_1(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnsalvar_Click_1(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereço.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;

            FornecedorDAO dao = new FornecedorDAO();
            dao.cadastrarfornecedor(obj);

            tabelafornecedores.DataSource = dao.listarfornecedor();

            new Helpers().LimparTela(this);
        }

        private void Frmfornecedor_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            tabelafornecedores.DataSource = dao.listarfornecedor();
        }

        private void tabelafornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelafornecedores.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelafornecedores.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = tabelafornecedores.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = tabelafornecedores.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = tabelafornecedores.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = tabelafornecedores.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = tabelafornecedores.CurrentRow.Cells[6].Value.ToString();
            txtendereço.Text = tabelafornecedores.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = tabelafornecedores.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = tabelafornecedores.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = tabelafornecedores.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = tabelafornecedores.CurrentRow.Cells[11].Value.ToString();
            cbuf.Text = tabelafornecedores.CurrentRow.Cells[12].Value.ToString();

            tabfornecedor.SelectedTab = tabPage1;
        }

        private void btneditar_Click_1(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereço.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;
            obj.codigo = int.Parse(txtcodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.alterarfornecedor(obj);

            tabelafornecedores.DataSource = dao.listarfornecedor();

            new Helpers().LimparTela(this);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj.codigo = int.Parse(txtcodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.excluirfornecedor(obj);

            tabelafornecedores.DataSource = dao.listarfornecedor();

            new Helpers().LimparTela(this);
        }

        private void tabelafornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;

            FornecedorDAO dao = new FornecedorDAO();
            tabelafornecedores.DataSource = dao.buscafornecedorprnome(nome);

            if (tabelafornecedores.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum fornedor encontrado com esse nome.");
                tabelafornecedores.DataSource = dao.listarfornecedor();
            }
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();
            tabelafornecedores.DataSource = dao.listarfornecedorprnome(nome);
        }
    }
}
