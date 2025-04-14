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
    public class VendaDAO
    {
        private MySqlConnection conexao;
        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #region Método cadastra venda
        public void cadastrarvenda(Vendas obj)
        {
            try
            {
                string sql = @"insert into tb_vendas (cliente_id,data_venda,total_venda,observacoes)
                                values(@cliente_id,@data_venda,@total_venda,@obs)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executacmd.Parameters.AddWithValue("@obs", obj.obs);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Venda cadastrada com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Método que retorna o Id da ultima venda
        public int retornaidultimavenda()
        {
            try
            {
                int idvenda = 0;
                string sql = @"select max(id) id from tb_vendas";
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader rs = executacmdsql.ExecuteReader();
                if(rs.Read())
                {
                    idvenda = rs.GetInt32("id");
                }
                conexao.Close();

                return idvenda;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
                return 0;
            }
        }

        #endregion

        #region Método que exibi hitorico de venda
        public DataTable listarvendasporperiodo(DateTime datainicio, DateTime datafim)
        {
            try
            {
                DataTable tabelahitorico = new DataTable();
                string sql = @"SELECT v.id as 'Código',
		                              v.data_venda as 'Data da venda',
                                      c.nome as 'Cliente',
                                      v.total_venda as 'Total',
                                       v.observacoes as 'obs'
	                                   FROM tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)
                                       Where v.data_venda between @datainicio and @datafim";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@datainicio", datainicio);
                executacmd.Parameters.AddWithValue("@datafim", datafim);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelahitorico);

                return tabelahitorico;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion

        #region Listar todas as vendas
        public DataTable listarvendas()
        {
            try 
            { 
                DataTable tabelahistorico = new DataTable();
                string sql = @"SELECT v.id as 'Código',
		                              v.data_venda as 'Data da venda',
                                      c.nome as 'Cliente',
                                      v.total_venda as 'Total',
                                       v.observacoes as 'obs'
	                                   FROM tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelahistorico);

                conexao.Close();

                return tabelahistorico;
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
