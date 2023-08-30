
namespace exerciciosAPI.ConnectionStringSingleton
{
    public class ConnectionStringSingleton
    {
        private static ConnectionStringSingleton connectionStringSingleton;
        public static string ConnectionString;

        public ConnectionStringSingleton()
        {}

        public static ConnectionStringSingleton GerarInstancia()
        {
            if (connectionStringSingleton == null)
            {
                connectionStringSingleton = new ConnectionStringSingleton();
                ConnectionString = "Data Source=/Users/mariacarolinaboabaid/Downloads/Senai/GitHub/floripamaistec/Mod_3/semana04/exercicio06/fichaCadastro.db;";
            }
            return connectionStringSingleton;

        }

        public string ReturnConnection()
        {
            return ConnectionString;
        }
    }
}