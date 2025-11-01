using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace DAL {
    public class ProdutoDAL {

        public static int Inserir(Produto produto) {
            MySqlConnection conexao = null;

            try {
                conexao = ConexaoBD.ObterConexao();
                conexao.Open();

                string sql = "INSERT INTO produto (nome, quantidade) VALUES (@Nome, @Quantidade); SELECT LAST_INSERT_ID();";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Nome", produto.Nome);
                comando.Parameters.AddWithValue("@Quantidade", produto.Quantidade);

                int produtoId = Convert.ToInt32(comando.ExecuteScalar());

                return produtoId;
            } catch (Exception ex) {
                throw new Exception("Erro ao inserir produto no banco de dados: " + ex.Message);
            } finally {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open) {
                    conexao.Close();
                }
            }
        }


        public static List<Produto> ListarTodos() {
            MySqlConnection conexao = null;
            List<Produto> lista = new List<Produto>();

            try {
                conexao = ConexaoBD.ObterConexao();
                conexao.Open();

                string sql = "SELECT id, nome, quantidade, data_hora FROM produto;";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read()) {
                    Produto p = new Produto();
                    p.Id = leitor.GetInt32("id");
                    p.Nome = leitor.GetString("nome");
                    p.Quantidade = leitor.GetInt32("quantidade");
                    p.DataHora = leitor.GetDateTime("data_hora");

                    lista.Add(p);
                }
                return lista;

            } catch (Exception ex) {
                throw new Exception("Erro ao trazer produtos do banco de dados: " + ex.Message);
            } finally {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open) {
                    conexao.Close();
                }
            }
        }

        /// <summary>
        /// Atualiza um registro de produto existente no banco de dados.
        /// </summary>
        /// <param name="produto">O objeto 'Produto' contendo os dados (Id, Nome, Quantidade) a serem atualizados.</param>
        /// <returns>A quantidade de linhas alteradas em caso de sucesso.</returns>
        /// <exception cref="System.Exception">Lança uma exceção genérica se houver uma falha ao atualizar no banco de dados.</exception>
        public static int Atualizar(Produto produto) {
            MySqlConnection conexao = null;

            try {
                conexao = ConexaoBD.ObterConexao();
                conexao.Open();

                string sql = "UPDATE produto SET nome=@Nome, quantidade=@Quantidade WHERE id=@Id;";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Nome", produto.Nome);
                comando.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                comando.Parameters.AddWithValue("@Id", produto.Id);

                int modificadas=comando.ExecuteNonQuery();

                return modificadas;
            } catch (Exception ex) {
                throw new Exception("Erro ao atualizar produto no banco de dados: " + ex.Message);
            } finally {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open) {
                    conexao.Close();
                }
            }
        }

        /// <summary>
        /// Exclui um registro de produto existente no banco de dados.
        /// </summary>
        /// <param name="produto">O objeto 'Produto' contendo o ID do Produto a ser excluído.</param>
        /// <returns>A quantidade de linhas excluidas em caso de sucesso.</returns>
        /// <exception cref="System.Exception">Lança uma exceção genérica se houver uma falha ao excluir do banco de dados.</exception>
        public static int Excluir(Produto produto) {
            MySqlConnection conexao = null;

            try {
                conexao = ConexaoBD.ObterConexao();
                conexao.Open();

                string sql = "DELETE FROM produto WHERE id=@Id;";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Id", produto.Id);

                int modificadas = comando.ExecuteNonQuery();

                return modificadas;
            } catch (Exception ex) {
                throw new Exception("Erro ao excluir produto do banco de dados: " + ex.Message);
            } finally {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open) {
                    conexao.Close();
                }
            }
        }
    }
}
