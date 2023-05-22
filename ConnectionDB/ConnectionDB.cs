namespace TiendaApi.ConnectionDB
{
    public class ConnectionsDB
    {
        private string connectionString = string.Empty;
        public ConnectionsDB()
        {
            //Constructor de la conections
            var constructor = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            connectionString = constructor.GetSection("ConnectionStrings:conexionmaestra").Value;
        }
        public string cadenaSQL()
        {
            return connectionString;
        }
    }
}
