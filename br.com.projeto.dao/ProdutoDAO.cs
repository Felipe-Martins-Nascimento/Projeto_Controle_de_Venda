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
    public class ProdutoDAO
    {
        private MySqlConnection conexao;
        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #region Método cadastrar produto
        public void cadastraproduto(Produto obj)
        {
            try
            {
                string sql = @"insert into tb_produtos (descricao,preco,qtd_estoque,for_id)
                                values(@descricao,@preco,@qtd,@for_id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Método listarprodutos
        public DataTable listarproduto()
        {
            try
            {
                DataTable tabelaproduto = new DataTable();
                string sql = @"select p.id as 'Código',
		                                p.descricao as 'Descrição',
		                                p.preco as 'Preço', 
		                                p.qtd_estoque as 'Quantidade no estoque',
		                                f.nome as 'Fornecedor' from tb_produtos as p
		                                join tb_fornecedores as f on (p.for_id = f.id);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaproduto);

                conexao.Close();

                return tabelaproduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }


        #endregion

        #region Alterar produto
        public void alterarproduto(Produto obj)
        {
            try
            {
                string sql = @"update tb_produtos set descricao=@descricao,preco=@preco,qtd_estoque=@qtd,for_id=@for_id where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            { 
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Excluir produto
        public void excluirproduto(Produto obj)
        {
            try
            {
                string sql = @"delete from tb_produtos where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Método listarprodutospornome
        public DataTable listarprodutopornome(string nome)
        {
            try
            {
                DataTable tabelaproduto = new DataTable();
                string sql = @"select p.id as 'Código',
		                                p.descricao as 'Descrição',
		                                p.preco as 'Preço', 
		                                p.qtd_estoque as 'Quantidade no estoque',
		                                f.nome as 'Fornecedor' from tb_produtos as p
		                                join tb_fornecedores as f on (p.for_id = f.id) where p.descricao like @nome;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaproduto);

                conexao.Close();

                return tabelaproduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }


        #endregion

        #region Método buscarprodutospornome
        public DataTable buscarprodutopornome(string nome)
        {
            try
            {
                DataTable tabelaproduto = new DataTable();
                string sql = @"select p.id as 'Código',
		                                p.descricao as 'Descrição',
		                                p.preco as 'Preço', 
		                                p.qtd_estoque as 'Quantidade no estoque',
		                                f.nome as 'Fornecedor' from tb_produtos as p
		                                join tb_fornecedores as f on (p.for_id = f.id) where p.descricao = @nome;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaproduto);

                conexao.Close();

                return tabelaproduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }




        #endregion

        #region Método que retorna um produto por codigo
        public Produto Retornaprodutoporcodigo(int id)
        {
            try
            {
                string sql = @"select * from tb_produtos where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("id", id);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();
                if (rs.Read())
                {
                    Produto p = new Produto();

                    p.id = rs.GetInt32("id");
                    p.descricao = rs.GetString("descricao");
                    p.preco = rs.GetDecimal("preco");
                    conexao.Close();
                    return p;
                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado!");
                    conexao.Close();
                    return null;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que baixa o estoque
        public void baixaestoque(int idproduto, int qtdestoque)
        {
            try
            {
                string sql = @"update tb_produtos set qtd_estoque= @qtd where id= @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@qtd", qtdestoque);
                executacmd.Parameters.AddWithValue("@id", idproduto);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                conexao.Close();
            }
        }



        #endregion

        #region Método que retorna o estoque atual de um produto
        public int retornaestoqueatual(int idproduto)
        {
            try
            {
                string sql = @" select qtd_estoque from tb_produtos where id = @id";

                int qtd_estoque = 0;

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", idproduto);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();
                if (rs.Read())
                {
                    qtd_estoque = rs.GetInt32("qtd_estoque");
                    conexao.Close();
                }
                return qtd_estoque;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                return 0;
            }
        }

        #endregion

    }
}
