using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    internal class ConexaoBD {
        // Coloque a sua string de conexão aqui
        private static readonly string connectionString = "Server=localhost;Database=estoque;Uid=root;Pwd=dd8893;";

        public static MySqlConnection ObterConexao() {
            return new MySqlConnection(connectionString);
        }
    }
}
