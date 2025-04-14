using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelafuncionario.DataSource = dao.buscaFuncionariospornome(nome);

            if(tabelafuncionario.Rows.Count == 0 || txtpesquisa.Text == string.Empty)
            {
                MessageBox.Show("Funcionário não encotrado!");
                tabelafuncionario.DataSource = dao.listarFuncionarios();
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cbcargo.SelectedItem.ToString();
            obj.nivel_acesso = cbnivelacesso.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereço.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarfuncionario(obj);

            tabelafuncionario.DataSource = dao.listarFuncionarios();
        }

        private void tabelafuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelafuncionario.DataSource = dao.listarFuncionarios();
        }

        private void tabelafuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelafuncionario.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelafuncionario.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelafuncionario.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelafuncionario.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelafuncionario.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = tabelafuncionario.CurrentRow.Cells[5].Value.ToString();
            cbcargo.Text = tabelafuncionario.CurrentRow.Cells[6].Value.ToString();
            cbnivelacesso.Text = tabelafuncionario.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = tabelafuncionario.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = tabelafuncionario.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = tabelafuncionario.CurrentRow.Cells[10].Value.ToString();
            txtendereço.Text = tabelafuncionario.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = tabelafuncionario.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = tabelafuncionario.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = tabelafuncionario.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = tabelafuncionario.CurrentRow.Cells[15].Value.ToString();
            cbuf.Text = tabelafuncionario.CurrentRow.Cells[16].Value.ToString();

            tabfuncionario.SelectedTab = tabPage1;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.codigo = int.Parse(txtcodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.deletarfuncionario(obj);

            tabelafuncionario.DataSource = dao.listarFuncionarios();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cbcargo.SelectedItem.ToString();
            obj.nivel_acesso = cbnivelacesso.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereço.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();
            obj.codigo = int.Parse(txtcodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarfuncionario(obj);

            tabelafuncionario.DataSource = dao.listarFuncionarios();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelafuncionario.DataSource = dao.listarFuncionariospornome(nome); 
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
