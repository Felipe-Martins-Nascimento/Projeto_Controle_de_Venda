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
    public partial class Frmpagamentos : Form
    {
        Cliente obj = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;
        public Frmpagamentos(Cliente obj,DataTable carrinho, DateTime dataatual)
        {
            this.obj = obj;
            this.carrinho = carrinho;
            this.dataatual = dataatual;

            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtpreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmpagamentos_Load(object sender, EventArgs e)
        {
            txttroco.Text = "0,00";
            txtdinheiro.Text = "0,00";
            txtcartao.Text = "0,00";
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_dinheiro, v_cartao, troco, totalpago, total;

                ProdutoDAO dao_produto = new ProdutoDAO();

                int qtd_estoque, qtd_comprada, estoque_atualizado;

                v_dinheiro = decimal.Parse(txtdinheiro.Text);
                v_cartao = decimal.Parse(txtcartao.Text);
                total = decimal.Parse(txttotal.Text);

                totalpago = v_dinheiro + v_cartao;
                if (totalpago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor total da venda");
                }
                else
                {
                    troco = totalpago - total;
                    Vendas vendas = new Vendas();

                    vendas.cliente_id = obj.codigo;
                    vendas.data_venda = dataatual;
                    vendas.total_venda = total;
                    vendas.obs = txtobs.Text;

                    VendaDAO vDAO = new VendaDAO();
                    txttroco.Text = troco.ToString();
                    vDAO.cadastrarvenda(vendas);

                    foreach(DataRow linha in carrinho.Rows)
                    {
                        Itemvenda item = new Itemvenda();
                        item.venda_id = vDAO.retornaidultimavenda();
                        item.produto_id = int. Parse(linha["Código"].ToString());
                        item.qtd = int.Parse(linha["qtd"].ToString());
                        item.subtotal = decimal.Parse(linha["subtotal"].ToString());

                        qtd_estoque = dao_produto.retornaestoqueatual(item.produto_id);
                        qtd_comprada = item.qtd;
                        estoque_atualizado = qtd_estoque - qtd_comprada;

                        dao_produto.baixaestoque(item.produto_id, estoque_atualizado);

                        ItemvendaDAO itemdao = new ItemvendaDAO();
                        itemdao.cadastraritem(item);
                    }

                    MessageBox.Show("Venda finalizada com sucesso!");
                    this.Dispose();

                    new Frmvendas().ShowDialog();
                }    
             }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
