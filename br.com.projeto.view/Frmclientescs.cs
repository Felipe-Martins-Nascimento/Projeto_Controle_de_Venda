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

namespace projeto_controles_de_vendas.br.com.projeto.view
{
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void Frmclientescs_Load(object sender, EventArgs e)
        {
            tabelaclientes.DefaultCellStyle.ForeColor = Color.Black;

            ClienteDAO dao = new ClienteDAO();
            tabelaclientes.DataSource = dao.listarClientes();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
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

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarcliente(obj);

            tabelaclientes.DataSource = dao.listarClientes();
        }

        private void tabelaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaclientes.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaclientes.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaclientes.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaclientes.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaclientes.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = tabelaclientes.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = tabelaclientes.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = tabelaclientes.CurrentRow.Cells[7].Value.ToString();
            txtendereço.Text = tabelaclientes.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = tabelaclientes.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text = tabelaclientes.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = tabelaclientes.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = tabelaclientes.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text = tabelaclientes.CurrentRow.Cells[13].Value.ToString();

            tabClientes.SelectedTab = tabPage1;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(obj);

            tabelaclientes.DataSource = dao.listarClientes();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
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

            ClienteDAO dao = new ClienteDAO();
            dao.AlterarCliente(obj);

            tabelaclientes.DataSource = dao.listarClientes();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;

            ClienteDAO dao = new ClienteDAO();
            tabelaclientes.DataSource = dao.BuscarClientePorNome(nome);

            if(tabelaclientes.Rows.Count == 0)
            {
                tabelaclientes.DataSource = dao.listarClientes();
            } 
        }

        private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO();
            tabelaclientes.DataSource = dao.ListarClientePorNome(nome);
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

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
    }
}
