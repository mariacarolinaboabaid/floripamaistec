
namespace exerciciosAPI.ConnectionStringSingleton
{
    public class ConnectionStringSingleton
    {
        private static ConnectionStringSingleton connectionStringSingleton;
        private static string ConnectionString;


        public ConnectionStringSingleton()
        {}

        public static ConnectionStringSingleton GerarInstancia()
        {
            if (connectionStringSingleton == null)
            {
                connectionStringSingleton = new ConnectionStringSingleton();
                ConnectionString = "Data Source=/Users/mariacarolinaboabaid/Downloads/Senai/GitHub/floripamaistec/Mod_3/semana02/fichaCadastro.db;";
            
            }

            return connectionStringSingleton;

        }

    }
}