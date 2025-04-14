using MySql.Data.MySqlClient;
using projeto__controles_de_venda.br.com.projeto.view;
using projeto_controles_de_vendas.br.com.projeto.conexao;
using projeto_controles_de_vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_controles_de_vendas.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;
        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método Cadastrar funcionario
        public void cadastrarfuncionario(Funcionario obj)
        {
            try
            {
                string sql = "insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)" +
                             "values (@nome,@rg,@cpf,@email,@senha,@cargo,@nivel,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("senha", obj.senha);
                executacmd.Parameters.AddWithValue("cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("nivel", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        #endregion

        #region Método alterar funcionario
        public void alterarfuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"update tb_funcionarios set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,nivel_acesso=@nivel,telefone=@telefone,celular=@celular,cep=@cep,
                                endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                                where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário alterado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }


        #endregion

        #region Método excluir
        public void deletarfuncionario(Funcionario obj)
        {
            try
            {
                string sql = "delete from tb_funcionarios where id = @codigo";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
 
                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluido com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }


        #endregion

        #region Método Listarfuncionarios
        public DataTable listarFuncionarios()
        {
            try
            {
                DataTable tabelafuncionario = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                conexao.Close();

                return tabelafuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }




        #endregion

        #region Método buscafuncionariospornome
        public DataTable buscaFuncionariospornome(string nome)
        {
            try
            {
                DataTable tabelafuncionario = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios where nome = @nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                conexao.Close();

                return tabelafuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }


        #endregion

        #region Método que listafuncionáriospornome
        public DataTable listarFuncionariospornome(string nome)
        {
            try
            {
                DataTable tabelafuncionario = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios where nome like @nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome" , nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                conexao.Close();

                return tabelafuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }


        #endregion

        #region Método que efetua login
        public bool efetutarlogin(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios 
                                        Where email = @email and senha = @senha;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();
                if(reader.Read()) 
                { 
                    string nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome");

                    MessageBox.Show("Seja bem vindo ao sistema, " + nome);
                    Frmmenu telamenu = new Frmmenu();

                    telamenu.txtusuario.Text = nome;

                    if (nivel.Equals("Administrador"))
                    {
                        telamenu.Show();
                    }
                    else if(nivel.Equals("Vendedor"))
                    {
                        telamenu.menuprodutos.Visible = false;
                        telamenu.menuhistorico.Enabled = false;
                        telamenu.Show();  
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("senha ou email incorreto!");
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return false;
            }
        }

        #endregion

    }
}
