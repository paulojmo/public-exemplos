using Npgsql;

namespace SistemaDados
{

    public class Conexao
    {
        // retorna o ultimo id que foi usado na tabela.
        //************************************************
        protected static string ReturnId = " RETURNING id;";

        // recebe a string de conexão com o banco.
        //************************************************
        protected static string conexaoString = null;

        public NpgsqlConnection GetConexao()
        {
            // conexão com o postgres 
            //************************************************
            return new NpgsqlConnection(conexaoString);
        }
    }
}
