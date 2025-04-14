using MySql.Data.MySqlClient;
using projeto__controles_de_venda.br.com.projeto.model;
using projeto_controles_de_vendas.br.com.projeto.conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto__controles_de_venda.br.com.projeto.dao
{
    public class ItemvendaDAO
    {
        private MySqlConnection conexao;
        public ItemvendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método que cadastra um item de venda
        public void cadastraritem(Itemvenda obj)
        {
            try
            {
                string sql = @"insert into tb_itensvendas (venda_id,produto_id,qtd,subtotal)
                                values(@venda_id,@produto_id,@qtd,@subtotal)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

                conexao.Open();
                executacmd.ExecuteNonQuery();

               // MessageBox.Show("Item cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Método que lista todos os itens por venda
        public DataTable listaritensporvenda(int venda_id)
        {
            try
            {
                DataTable tabeladetalhes = new DataTable();
                string sql = @"select i.id as 'Código',
		                              p.descricao as 'Descrição',
		                              i.qtd as 'Quantidade',
		                              p.preco as 'Preço',
		                              i.subtotal as 'Subtotal' from tb_itensvendas as i
		                              join tb_produtos as p on (i.produto_id = p.id)
                                      Where venda_id = @venda_id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", venda_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabeladetalhes);

                return tabeladetalhes;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion
    }
}
