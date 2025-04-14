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
    public partial class Frmvendas : Form
    {
        Cliente obj = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        Produto p = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        int qtd;
        decimal preco;
        decimal subtotal, total;

        DataTable carrinho = new DataTable();
        public Frmvendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaprodutos.DataSource = carrinho;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                obj = cdao.Retornaclienteporcpf(txtcpf.Text);

                if(obj != null)
                {
                    txtnome.Text = obj.nome;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                    txtcpf.Clear();
                    txtcpf.Focus();
                }
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                p = pdao.Retornaprodutoporcodigo(int.Parse(txtcodigo.Text));

                if(p != null)
                {
                    txtdesc.Text = p.descricao;
                    txtpreco.Text = p.preco.ToString();
                    txtqtd.Focus();
                }
                else
                {
                    txtcodigo.Clear(); 
                    txtcodigo.Focus();
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtqtd.Text);
                preco = decimal.Parse(txtpreco.Text);

                subtotal = qtd * preco;

                total += subtotal;

                carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdesc.Text, qtd, preco, subtotal);

                txttotal.Text = total.ToString();

                txtcodigo.Clear();
                txtdesc.Clear();
                txtqtd.Clear();
                txtpreco.Clear();

                txtcodigo.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite o código do produto!");
            }
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            decimal subproduto = decimal.Parse(tabelaprodutos.CurrentRow.Cells[4].Value.ToString());

            int indice = tabelaprodutos.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;
            txttotal.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dataatual = DateTime.Parse(txtdata.Text);
            Frmpagamentos tela = new Frmpagamentos(obj,carrinho,dataatual);

            tela.txttotal.Text = total.ToString();

            tela.ShowDialog();
        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();
        }
    }
}
